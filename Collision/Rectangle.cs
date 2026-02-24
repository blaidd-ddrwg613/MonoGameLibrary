using Microsoft.Xna.Framework;

namespace MonoGameLibrary.Collision;

public class Rectangle
{
    public Vector2 Position { get; private set; }

    public float Width { get; private set; }
    
    public float Height { get; private set; }
    
    private Rectangle()
    {
        Position = Vector2.Zero;
        Width = 1;
        Height = 1;
    }
    
    public Rectangle(Vector2 position, float width, float height)
    {
        Position = position;
        Width = width;
        Height = height;
    }

    public void Draw()
    {
        
    }

    public float GetLeft()
    {
        return this.Position.X;
    }

    public float GetRight()
    {
        return this.GetLeft() + Width;
    }

    public float GetTop()
    {
        return this.Position.Y;
    }

    public float GetBottom()
    {
        return this.GetTop() + Height;
    }
}