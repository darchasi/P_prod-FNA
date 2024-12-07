using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using Color = Microsoft.Xna.Framework.Color;

namespace FNA_game_engine
{
    //TO ADD NEW GAME OBJECTS TO THE EDITOR FOLLOW THESE INSTRUCTIONS:
    //1. Add the name of the object to the enum ObjectType (make sure it's spelled exactly the same). Make sure you add it BEFORE NumOfObjects.
    //2. Make sure objectsNamespace is correctly set. This should be the namespace that all your classes are under. Go to Player.cs and copy the namespace that's there, it's likely the one you need.

    public partial class GameInterface : Form
    {
        public Game1 game;
        public Character selectedChar;
        public Enemy selectedEnemy;
        public GameObject selectedGameObj;


        string fullPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
        private bool isDragging;
        private System.Drawing.Point dragStartPoint;
        public GameInterface(Game1 gameInput)
        {
            game = gameInput;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            game.objects.Where(obj => obj is Character).ToList().ForEach(character => LstCharacter.Items.Add((Character)character));
            selectedChar = (Character)LstCharacter.Items[0];
            game.objects.ForEach(gameobj => LstGameObject.Items.Add((GameObject)gameobj));
            selectedGameObj = (GameObject)LstCharacter.Items[0];
            TopPanel.MouseDown += PanelTitleBar_MouseDown;
            TopPanel.MouseMove += PanelTitleBar_MouseMove;
            TopPanel.MouseUp += PanelTitleBar_MouseUp;
        }


        private void GameInterface_Load(object sender, EventArgs e)
        {

        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = e.Location;
        }

        private void PanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                System.Drawing.Point currentPoint = PointToScreen(e.Location);
                this.Location = new System.Drawing.Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }
        private void PanelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("êtes-vous sûr de vouloir fermer le programme ?", "fermer le programme", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                 Application.Exit();
            }*/
            Application.Exit();
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PicBoxIcon_Click(object sender, EventArgs e)
        {

        }

        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
                WindowState = FormWindowState.Maximized;
        }

        private void TBGravityValueInput_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void TBGravityValueInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBGravityValueInput_Leave(object sender, EventArgs e)
        {
            if (TBGravityValueInput.Text.Last() != '.' && TBGravityValueInput.Text.Last() != '-')
            {
                selectedChar.gravity = (float)Convert.ToDecimal(TBGravityValueInput.Text);
                selectedChar.maxFallVelocity = 24f + 8f * selectedChar.gravity;
            }
        }

        private void BtnSwitchGravity_Click(object sender, EventArgs e)
        {
            
            if (Character.applyGravity)
            {
                Character.applyGravity = false;
                BtnSwitchGravity.Text = "Off";
            }
            else
            {
                Character.applyGravity = true;
                BtnSwitchGravity.Text = "On";
            }

            selectedChar = (Character)LstCharacter.Items[LstCharacter.Items.Count - 1];
        }

        private void TBJumpVelocityInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void TBJumpVelocityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBJumpVelocityInput_Leave(object sender, EventArgs e)
        {
            if (TBJumpVelocityInput.Text.Last() != '.' && TBJumpVelocityInput.Text.Last() != '-')
            {
                selectedChar.jumpVelocity = (float)Convert.ToDecimal(TBJumpVelocityInput.Text);
            }
        }

        private void TBAccelInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBAccelInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBAccelInput_Leave(object sender, EventArgs e)
        {
            if (TBAccelInput.Text.Last() != '.' && TBAccelInput.Text.Last() != '-')
            {
                selectedChar.accel = (float)Convert.ToDecimal(TBAccelInput.Text);
            }
        }

        private void LblDecelValue_Click(object sender, EventArgs e)
        {

        }

        private void TBDecelInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBDecelInput_Leave(object sender, EventArgs e)
        {
            if (TBDecelInput.Text.Last() != '.' && TBDecelInput.Text.Last() != '-')
            {
                selectedChar.decel = (float)Convert.ToDecimal(TBDecelInput.Text);
            }
        }

        private void TBDecelInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBHitBoxOffSetX_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBZoomInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCamRotInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBEnMinRespawnInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBEnMaxRespawnInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void LblVisual_Click(object sender, EventArgs e)
        {

        }

        private void LblRotationValue_Click(object sender, EventArgs e)
        {

        }

        private void LblScaleValue_Click(object sender, EventArgs e)
        {

        }

        private void TBScaleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblLayerDepthValue_Click(object sender, EventArgs e)
        {

        }

        private void TBLayerDepthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBRotationInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void PanMaximise_Paint(object sender, PaintEventArgs e)
        {

        }


        private void TBHitBoxOffSetX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBHitBoxOffSetX_Leave(object sender, EventArgs e)
        {
            if (TBHitBoxOffSetX.Text.Last() != '.' && TBHitBoxOffSetX.Text.Last() != '-')
            {
                selectedGameObj.boundingBoxOffset.X = Convert.ToInt16(TBHitBoxOffSetX.Text);
            }
        }

        private void TBHitBoxOffSetY_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBHitBoxOffSetY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBHitBoxOffSetY_Leave(object sender, EventArgs e)
        {
            if (TBHitBoxOffSetY.Text.Last() != '-')
            {
                selectedGameObj.boundingBoxOffset.Y = Convert.ToInt16(TBHitBoxOffSetY.Text);
            }
        }

        private void TBRotationInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBRotationInput_Leave(object sender, EventArgs e)
        {
            if (TBRotationInput.Text.Last() != '.' && TBRotationInput.Text.Last() != '-')
            {
                selectedGameObj.rotation = (float)Convert.ToDecimal(TBRotationInput.Text);
            }
        }

        private void TBScaleInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBScaleInput_Leave(object sender, EventArgs e)
        {
            if (TBScaleInput.Text.Last() != '.' && TBScaleInput.Text.Last() != '-')
            {
                selectedGameObj.scale = (float)Convert.ToDecimal(TBScaleInput.Text);
            }
        }

        private void TBLayerDepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBLayerDepthInput_Leave(object sender, EventArgs e)
        {
            if (TBLayerDepthInput.Text.Last() != '.' && TBLayerDepthInput.Text.Last() != '-')
            {
                selectedGameObj.layerDepth = (float)Convert.ToDecimal(TBLayerDepthInput.Text);
            }
        }

        private void TBZoomInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBZoomInput_Leave(object sender, EventArgs e)
        {
            if (TBZoomInput.Text.Last() != '.' && (float)(Convert.ToDecimal(TBZoomInput.Text)) > 0)
            {
                Camera.zoom = (float)Convert.ToDecimal(TBZoomInput.Text);
            }
        }
        private void TBCamRotInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBCamRotInput_Leave(object sender, EventArgs e)
        {
            if (TBCamRotInput.Text.Last() != '.' && (float)(Convert.ToDecimal(TBCamRotInput.Text)) > 0)
            {
                Camera.rotation = (float)Convert.ToDecimal(TBCamRotInput.Text);
            }
        }

        private void TBEnMinRespawnInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBEnMinRespawnInput_Leave(object sender, EventArgs e)
        {
            if (TBEnMinRespawnInput.Text.Last() != '.' && (float)(Convert.ToDecimal(TBEnMinRespawnInput.Text)) > 0)
            {
                selectedEnemy = (Enemy)game.objects.Where(selectedobj => selectedobj.name == "Enemy1").ToList().Last();
                selectedEnemy.minRespawnTimer = (int)Convert.ToDecimal(TBEnMinRespawnInput.Text);
            }
        }

        private void TBEnMaxRespawnInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBEnMaxRespawnInput_Leave(object sender, EventArgs e)
        {
            if (TBEnMaxRespawnInput.Text.Last() != '.' && (float)(Convert.ToDecimal(TBEnMaxRespawnInput.Text)) > 0)
            {
                selectedEnemy = (Enemy)game.objects.Where(selectedobj => selectedobj.name == "Enemy1").ToList().Last();
                selectedEnemy.maxRespawnTimer = (int)Convert.ToDecimal(TBEnMaxRespawnInput.Text);
            }
        }

        private void TBArrowVelInput_Leave(object sender, EventArgs e)
        {
            if (TBArrowVelInput.Text.Last() != '.' && (float)(Convert.ToDecimal(TBArrowVelInput.Text)) > 0)
            {
                Projectile.baseXvelocity = (float)Convert.ToDecimal(TBArrowVelInput.Text);
            }
        }
        private void TBArrowVelInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void LstCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedChar = (Character)LstCharacter.SelectedItem;
        }

        private void LstGameObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGameObj = (GameObject)LstGameObject.SelectedItem;
        }

        private void LblZoomValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (btnFullScreen.Text == "On")
            {
                game.IsFullScreen= false;
                btnFullScreen.Text = "Off";
            }
            else
            {
                game.IsFullScreen = true;
                btnFullScreen.Text = "On";
            }

            Resolution.SetResolution(Game1.SCREENWIDTH, Game1.SCREENHEIGHT, game.IsFullScreen);
        }
        private void TBArrowVelInput_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // RoundButton class because Windows Forms does not have one by default
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grPath);
            base.OnPaint(e);
        }
    }
}
