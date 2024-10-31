# P_prod-FNA
### Dario Chasi - Nima Zarrabi


#  Mise en place

### Le code présent dans le branch "main" sur github contient le code en son ensemble et dernière version
Ouverz un [git bash](https://git-scm.com/downloads) dans votre répértoire, puis executez la command 

```command
git pull https://github.com/darchasi/P_prod-FNA
```

Voici la strucutre que vous deviez avoir:

```
├── Code
│   ├── FNA
│   ├── FNA-game-engine
│   │   ├── .vs
│   │   ├── bin
│   │   ├── Content
│   │   ├── fnalibs
│   │   ├── Utilities
│   │   ├── .gitignore
│   │   ├── App.config
│   │   ├── FNA-game-engine.csproj
│   │   ├── FNA-game-engine.sln
│   │   ├── Game1.cs
│   │   ├── GameObject.cs
│   │   ├── Player.cs
│   │   └── Program.cs
└── README.md
```

Le dossier "FNA"

Le dossier "FNA-game-engine" contient le projet en lui-même
Dossiers important à connaître:
**Content**
Contient tout les média utilisé dans le jeu, comme des images ou fichiers audio.

**fnalibs**
Contient les library FNA nécessaire pour le projet.

**Utilities**
Contient des classes C# qui vont être utiliser pour ce projet, ces classes proviennent 

# Developpement
Nous utilisant Visual Studio 2022 pour le developpement de ce projet, c'est un projet fait avec Windows Forms.

afin d'accèder à l'interface de developpement, il vous suffit d'ouvrir le fichier "FNA-game-engine.sln" avec Visual Studio 2022

L'application utilise la biblioteque FNA, nécessaire au fonctionnement du projet.

## Explication des classes

### Game1.cs

Classe de type Microsoft.Xna.Framework.Game , déclaration du GraphicsDeviceManager `graphics`, le SpriteBatch `spriteBatch` et de la liste de GameObject `objects`

### GameObject.cs

Classe pour les objets du jeu

### Player.cs

class pour le joueur, classe enfant de GameObject

### Program.cs

Lancement de la classe Game