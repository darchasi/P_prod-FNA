# Form procédural du code

## FireCharacter

### Initialize

```C#
    for (int i = 0; i < numOfProjectiles; i++)
    {
        projectiles.Add(new Projectile());
    }
```

### Fire

```C#
    for (int i = 0; i < numOfProjectiles; i++)
    {
        projectiles.Add(new Projectile());
    }
```

### Load

```C#
    for (int i = 0; i < numOfProjectiles; i++)
    {
        projectiles[i].Load(content);
    }
```

### Update

```C#
    for (int i = 0; i < numOfProjectiles; i++)
    {
        projectiles[i].Update(objects, map);
    }
```

### Draw

```C#
    for (int i = 0; i < numOfProjectiles; i++)
    {
        projectiles[i].Draw(spriteBatch);
    }
```

## Game1

### LoadObjects

```C#
    for (int i = 0; i < objects.Count; i++)
    {
        objects[i].Update(objects, map);
        if (objects[i].equipements.Count() > 0)
        {
            objects[i].equipements.ForEach(equipement => equipement.Update(objects, map));
        }
    }
```

### UpdateObjects

```C#
for (int i = 0; i < objects.Count; i++)
    {
        objects[i].Update(objects, map);
    }
```

### DrawObjects

```C#
    for (int i = 0; i < objects.Count; i++)
    {
        objects[i].Draw(spriteBatch);
    }
    for (int i = 0; i < map.decor.Count; i++)
    {
        map.decor[i].Draw(spriteBatch);
    }
```

## Map

### LoadMap

```C#
    public void LoadMap(ContentManager content)
    {
        for (int i = 0; i < decor.Count; i++)
        {
            decor[i].Load(content, decor[i].imagePath);
        }
    }
```

### Update

```C#
    public void Update(List<GameObject> gameObjects)
    {
        for (int i = 0;i < decor.Count;i++)
        {
            decor[i].Update(gameObjects, this);
        }
    }
```

### Rectangle

```C#
    public Rectangle CheckCollision(Rectangle input)
    {
        for (int i = 0; i < walls.Count; i++)
        {
            if (walls[i] != null && walls[i].wall.Intersects(input) == true && walls[i].active == true)
            {
                return walls[i].wall;
            }
        }
        return Rectangle.Empty;
    }
```

### DrawWalls

```C#
    public void DrawWalls(SpriteBatch spriteBatch)
    {
        for (int i = 0; i < walls.Count; i++)
        {
            if (walls[i] != null && walls[i].active== true)
            {
                spriteBatch.Draw(wallImage, new Vector2(walls[i].wall.X, walls[i].wall.Y), walls[i].wall, walls[i].defaultColor, walls[i].defaultRotation, Vector2.Zero, walls[i].defaultScale, SpriteEffects.None, walls[i].defaultLayerDepth);
            }
        }
    }
```

## Pickableitem.cs

## Player.cs

## Projectile.cs

### checkCollision

```C#
    for (int i = 0 ; i < objects.Count; i++)
    {
        if (objects[i].active && objects[i] != owner && objects[i].projectileCollidable && objects[i].CheckCollision(boundingBox))
        {
            Destroy();
            objects[i].ProjectileResponse();
            return;
        }
    }
```
