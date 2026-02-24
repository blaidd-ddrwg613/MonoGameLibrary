using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Debug;

public class DebugDraw
{
    private readonly GraphicsDevice _graphicsDevice;
    private BasicEffect _effect;

    public DebugDraw(GraphicsDevice graphicsDevice)
    {
        _graphicsDevice = graphicsDevice;
    }

    private void EnsureEffect()
    {
        if (_effect != null)
            return;

        _effect = new BasicEffect(_graphicsDevice)
        {
            VertexColorEnabled = true,
            Projection = Matrix.CreateOrthographicOffCenter(
                0,
                _graphicsDevice.Viewport.Width,
                _graphicsDevice.Viewport.Height,
                0,
                0,
                1
            ),
            View = Matrix.Identity,
            World = Matrix.Identity
        };
    }

    private void ApplyEffect()
    {
        EnsureEffect();

        foreach (var pass in _effect.CurrentTechnique.Passes)
            pass.Apply();
    }

    public void DrawLine(Vector2 start, Vector2 end, Color color)
    {
        var vertices = new[]
        {
            new VertexPositionColor(new Vector3(start, 0), color),
            new VertexPositionColor(new Vector3(end, 0), color)
        };

        ApplyEffect();
        _graphicsDevice.DrawUserPrimitives(PrimitiveType.LineList, vertices, 0, 1);
    }


    public void DrawRectangle(Rectangle rect, Color color)
    {
        Vector2 tl = new(rect.Left, rect.Top);
        Vector2 tr = new(rect.Right, rect.Top);
        Vector2 br = new(rect.Right, rect.Bottom);
        Vector2 bl = new(rect.Left, rect.Bottom);

        DrawLine(tl, tr, color);
        DrawLine(tr, br, color);
        DrawLine(br, bl, color);
        DrawLine(bl, tl, color);
    }

    public void DrawCircle(Vector2 center, float radius, Color color, int segments = 32)
    {
        float increment = MathF.Tau / segments;
        float angle = 0f;

        Vector2 prev = center + new Vector2(MathF.Cos(0), MathF.Sin(0)) * radius;

        for (int i = 1; i <= segments; i++)
        {
            angle += increment;
            Vector2 next = center + new Vector2(MathF.Cos(angle), MathF.Sin(angle)) * radius;

            DrawLine(prev, next, color);
            prev = next;
        }
    }

    public void DrawRay(Vector2 origin, Vector2 direction, float length, Color color)
    {
        Vector2 end = origin + Vector2.Normalize(direction) * length;
        DrawLine(origin, end, color);
    }

    public void DrawPolygon(IReadOnlyList<Vector2> points, Color color)
    {
        for (int i = 0; i < points.Count; i++)
        {
            Vector2 a = points[i];
            Vector2 b = points[(i + 1) % points.Count];
            DrawLine(a, b, color);
        }
    }


}