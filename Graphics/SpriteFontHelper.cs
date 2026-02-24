using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Graphics;

public static class SpriteFontHelper
{
    /// <summary>
    /// Submit a text string of sprites for drawing in the current batch, The color of the string will be black.
    /// </summary>
    /// <param name="spriteBatch">The SpriteBatch to submit drawing to</param>
    /// <param name="font">A font</param>
    /// <param name="text">The text to be drawn</param>
    /// <param name="position">Where to draw the text to on the screen</param>
    /// <param name="scale">The scale to apply to the text</param>
    public static void DrawScaledText(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, float scale)
    {
        spriteBatch.DrawString(font, text, position, Color.Black, 0.0f, Vector2.Zero, scale, 
            SpriteEffects.None, 1.0f);
    }
    
    /// <summary>
    /// Submit a text string of sprites for drawing in the current batch, The color of the string will be black.
    /// </summary>
    /// <param name="spriteBatch">The SpriteBatch to submit drawing to</param>
    /// <param name="font">A font</param>
    /// <param name="text">The text to be drawn</param>
    /// <param name="position">Where to draw the text to on the screen</param>
    /// <param name="scale">The scale to apply to the text</param>
    /// <param name="color">The color applied to the drawn text</param>>
    public static void DrawScaledText(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, 
        float scale, Color color)
    {
        spriteBatch.DrawString(font, text, position, color, 0.0f, Vector2.Zero, scale, 
            SpriteEffects.None, 1.0f);
    }
}