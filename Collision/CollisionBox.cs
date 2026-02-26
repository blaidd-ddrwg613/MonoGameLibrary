using Microsoft.Xna.Framework;
using MonoGameLibrary.Debug;

namespace MonoGameLibrary.Collision;

public class CollisionBox
{
    public Rectangle BoundingBox { get; set; }

    public Color OutlineColor { get; set; }

    public CollisionBox(Rectangle boundingBox)
    {
        BoundingBox = boundingBox;
        OutlineColor = Color.Black;
    }

    public CollisionBox(Rectangle boundingBox, Color outlineColor)
    {
        OutlineColor = outlineColor;
    }

    public void Update(GameTime gameTime)
    {
        
    }

    public void Draw(DebugDraw debugDraw)
    {
        debugDraw.DrawRectangle(BoundingBox, OutlineColor);
    }
}