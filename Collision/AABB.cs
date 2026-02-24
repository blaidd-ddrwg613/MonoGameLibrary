using Microsoft.Xna.Framework;

namespace MonoGameLibrary.Collision;

public class AABB
{
    public static bool CheckForCollision(Rectangle a, Rectangle b)
    {
        var ALeftOfB = a.Right < b.Left;
        var ARightOfB = a.Left > b.Right;
        var AAboveB = a.Bottom < b.Top;
        var ABelowB = a.Top > b.Bottom;

        return !(ALeftOfB || ARightOfB || AAboveB || ABelowB);
    }
}