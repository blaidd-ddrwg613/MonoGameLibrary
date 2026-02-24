namespace MonoGameLibrary.Collision;

public class AABB
{
    public static bool CheckForCollision(Rectangle a, Rectangle b)
    {
        var ALeftOfB = a.GetRight() <= b.GetLeft();
        var ARightOfB = a.GetLeft() >= b.GetRight();
        var AAboveB = a.GetBottom() <= b.GetTop();
        var ABelowB = a.GetTop() >= b.GetBottom();

        return !(ALeftOfB || ARightOfB || AAboveB || ABelowB);
    }
}