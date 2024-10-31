# P_prod-FNA
## Dario Chasi - Nima Zarrabi

# Installation du FNA
> Nous avons déjà éffectué l'installation de FNA dans notre projet mais si vous voulez créer un projet dès 0, on vous laisse les instructions pour le faire correctement.

## Première étape
> Application utilisé: "Visual Studio 2022".

Vous devez créer un projet "Empty project (NET.FRAMEWORK)"
## Explication du programme:

Cette application Windows Forms utilise la biblioteque FNA afin de crée une interface graphique permettant à un utilisateur de crée son propre jeu video 2d en toute simplicité.


```c#
    public class Game1: Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
```

## Mise en place


###  Mise en place - Pull depuis github

Ouverz un git bash dans votre répértoir, puis executez la command 

```command
git pull https://github.com/darchasi/P_prod-FNA
```

###  Mise en place - Lancement du programme

// A VOIR SI ON PUBLIE

###  Mise en place - Pull depuis github