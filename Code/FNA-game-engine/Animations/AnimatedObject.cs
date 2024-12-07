using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace FNA_game_engine
{
    public class AnimatedObject : GameObject
    {
        protected int currentAnimationFrame;
        protected float animationTimer;
        protected int currentAnimationX = -1, currentAnimationY = -1;
        public AnimationSet animationSet = new AnimationSet();
        public Animation currentAnimation;

        public bool syncingAnimation;
        protected bool flipRightFrames = false;
        protected bool flipLeftFrames = true;
        protected SpriteEffects spriteEffects = SpriteEffects.None;

        protected void LoadAnimation(string path, ContentManager content)
        {
            AnimationData animationData = AnimationLoader.Load(path);
            animationSet = animationData.animation;

            // Inital values setup
            center.X = animationSet.width / 2;
            center.Y = animationSet.height / 2;

            // Defualts to the first thing in the list
            if (animationSet.animationList.Count > 0)
            {
                currentAnimation = animationSet.animationList[0];

                currentAnimationFrame = 0;
                animationTimer = 0f;
                CalculateFramePosition();
            }
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            base.Update(objects, map);
            if (currentAnimation != null)
            {
                UpdateAnimations();
            }
        }

        public virtual void ChangeAnimation(string newAnimation)
        {
            var newAnim = GetAnimation(newAnimation);
            if (newAnim == null || currentAnimation == newAnim)
            {
                return;
            }

            currentAnimation = newAnim;

            currentAnimationFrame = 0;
            animationTimer = currentAnimation.speed;

            CalculateFramePosition();

            // Check if this is an animation that we want to flip
            spriteEffects = DetermineSpriteEffects(newAnimation);

            // Sync effects
            if (equipements.Count() > 0 && !syncingAnimation)
            {
                SyncEquipmentAnimation(newAnimation);
            }
        }

        private SpriteEffects DetermineSpriteEffects(string animationName)
        {
            if ((flipRightFrames && animationName.Contains("Right")) ||
                (flipLeftFrames && animationName.Contains("Left")))
            {
                return SpriteEffects.FlipHorizontally;
            }
            return SpriteEffects.None;
        }


        public void SyncEquipmentAnimation(string newAnimation)
        {
            syncingAnimation = true;

            foreach (Equipement equipement in equipements)
            {
                if (equipement.animationSet?.animationList.Count > 0 && equipement.name != "crossbow-spritesheet.png")
                {
                    var matchingAnimation = GetMatchingAnimation(equipement, newAnimation);
                    if (matchingAnimation != null && equipement.currentAnimation != matchingAnimation)
                    {
                        equipement.ChangeAnimation(matchingAnimation.name);
                    }
                }
            }

            syncingAnimation = false;
        }

        private Animation GetMatchingAnimation(Equipement equipement, string baseAnimationName)
        {
            // Match name
            var exactMatch = equipement.animationSet.animationList
                .FirstOrDefault(animation => animation.name == baseAnimationName);
            if (exactMatch != null)
                return exactMatch;


            if (baseAnimationName.Contains("Run"))
            {
                return equipement.animationSet.animationList
                    .FirstOrDefault(animation => animation.name.Contains("Run"));
            }
            if (baseAnimationName.Contains("Idle"))
            {
                return equipement.animationSet.animationList
                    .FirstOrDefault(animation => animation.name.Contains("Idle"));
            }

            // return first animation
            return equipement.animationSet.animationList.FirstOrDefault();
        }

        //equipements.Where(eqipement => eqipement.animationSet.animationList.Count() > 0).Last().ChangeAnimation(equipements.Select(equip => equip.animationSet.animationList.Where(animation => animation.name == currentAnimation.name).Last()).Last().name.ToString());
        private Animation GetAnimation(string animation)
        {
            string name = GetAnimationName(animation);

            for (int i = 0; i < animationSet.animationList.Count; i++)
            {
                if (animationSet.animationList[i].name == name)
                {
                    return animationSet.animationList[i];
                }
            }
            return null;
        }

        protected virtual void UpdateAnimations()
        {
            if (currentAnimation.animationOrder.Count < 1)
            {
                return;
            }

            animationTimer -= 1;

            if (animationTimer <= 0)
            {
                animationTimer = currentAnimation.speed;

                if (AnimationComplete())
                {
                    currentAnimationFrame = 0;
                    if (currentAnimation.name == "Fire Left" && this is Equipement)
                    {
                        ChangeAnimation("Idle Left");
                    }
                    else if (currentAnimation.name == "Fire Right" && this is Equipement)
                    {
                        ChangeAnimation("Idle Right");
                    }
                }
                else
                {
                    currentAnimationFrame++;
                }
                CalculateFramePosition();
            }
        }

        protected void CalculateFramePosition()
        {
            int coordonate = currentAnimation.animationOrder[currentAnimationFrame];

            currentAnimationX = (coordonate % animationSet.gridX) * animationSet.width;

            currentAnimationY = (coordonate / animationSet.gridX) * animationSet.height;
        }

        public bool AnimationComplete()
        {
            return currentAnimationFrame >= currentAnimation.animationOrder.Count - 1;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!active)
            {
                return;
            }
            if (currentAnimationY == -1 || currentAnimationX == -1)
            {
                base.Draw(spriteBatch);
            }
            else
            {
                spriteBatch.Draw(image, position, new Rectangle(currentAnimationX, currentAnimationY, animationSet.width, animationSet.height), drawColor, rotation, Vector2.Zero, scale, spriteEffects, layerDepth);
            }
        }
        protected string GetAnimationName(string animation)
        {
            //Make an accurately spaced string. Example: "RunLeft" will now be "Run Left":
            return AddSpacesToSentence(animation.ToString(), false);
        }

        protected bool AnimationIsNot(string input)
        {
            //Used to check if our currentAnimation isn't set to the one passed in:
            return currentAnimation != null && GetAnimationName(input) != currentAnimation.name;
        }

        public string AddSpacesToSentence(string text, bool preserveAcronyms) //IfThisWasPassedIn... "If This Was Passed In" would be returned
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }
    }
}
