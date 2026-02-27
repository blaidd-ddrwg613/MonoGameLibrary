using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary.Graphics;

namespace MonoGameLibrary;

public class Actor
{
    public AnimatedSprite Sprite { get; set; }
    
    public Vector2 Positon { get; set; }
    
    public float MovementSpeed { get; set; }

    public Rectangle BoundRect { get; set; }
    
    public Actor(Vector2 positon)
    {
        TextureAtlas atlas = TextureAtlas.FromFile(Core.Content,"idle.xml");
        Sprite = atlas.CreateAnimatedSprite("idle_front");
        
        Positon = positon;
        MovementSpeed = 10;
        BoundRect = new Rectangle(new Point((int)Positon.X, (int)Positon.Y), new Point((int)Sprite.Width, (int)Sprite.Height));
    }
    
    public void Update(GameTime gameTime)
    {
        var deltaTime = gameTime.ElapsedGameTime.Milliseconds;
        
        Sprite.Update(gameTime);
        
        if (Core.Input.Keyboard.IsKeyDown(Keys.W))
        {
            Positon -= Vector2.UnitY * MovementSpeed * deltaTime;
        }

        if (Core.Input.Keyboard.IsKeyDown(Keys.S))
        {
            Positon += Vector2.UnitY * MovementSpeed * deltaTime;
        }
        if (Core.Input.Keyboard.IsKeyDown(Keys.A))
        {
            Positon -= Vector2.UnitX * MovementSpeed * deltaTime;
        }

        if (Core.Input.Keyboard.IsKeyDown(Keys.D))
        {
            Positon += Vector2.UnitX * MovementSpeed * deltaTime;
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Sprite.Draw(spriteBatch, Positon);
    }
}