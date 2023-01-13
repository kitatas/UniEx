using UnityEngine;

namespace UniEx
{
    public static class RendererExtension
    {
        #region spriteRenderer

        /// <summary>
        /// Set base color r of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="r">Set value.</param>
        /// <returns>Set result.</returns>
        public static SpriteRenderer SetColorR(this SpriteRenderer self, float r)
        {
            var color = self.color;
            self.color = color.SetR(r);
            return self;
        }

        /// <summary>
        /// Set base color g of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="g">Set value.</param>
        /// <returns>Set result.</returns>
        public static SpriteRenderer SetColorG(this SpriteRenderer self, float g)
        {
            var color = self.color;
            self.color = color.SetG(g);
            return self;
        }

        /// <summary>
        /// Set base color b of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="b">Set value.</param>
        /// <returns>Set result.</returns>
        public static SpriteRenderer SetColorB(this SpriteRenderer self, float b)
        {
            var color = self.color;
            self.color = color.SetB(b);
            return self;
        }

        /// <summary>
        /// Set base color a of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="a">Set value.</param>
        /// <returns>Set result.</returns>
        public static SpriteRenderer SetColorA(this SpriteRenderer self, float a)
        {
            var color = self.color;
            self.color = color.SetA(a);
            return self;
        }

        /// <summary>
        /// Add base color r of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="r">Add value.</param>
        /// <returns>Add result.</returns>
        public static SpriteRenderer AddColorR(this SpriteRenderer self, float r)
        {
            var color = self.color;
            self.color = color.AddR(r);
            return self;
        }

        /// <summary>
        /// Add base color g of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="g">Add value.</param>
        /// <returns>Add result.</returns>
        public static SpriteRenderer AddColorG(this SpriteRenderer self, float g)
        {
            var color = self.color;
            self.color = color.AddG(g);
            return self;
        }

        /// <summary>
        /// Add base color b of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="b">Add value.</param>
        /// <returns>Add result.</returns>
        public static SpriteRenderer AddColorB(this SpriteRenderer self, float b)
        {
            var color = self.color;
            self.color = color.AddB(b);
            return self;
        }

        /// <summary>
        /// Add base color a of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="a">Add value.</param>
        /// <returns>Add result.</returns>
        public static SpriteRenderer AddColorA(this SpriteRenderer self, float a)
        {
            var color = self.color;
            self.color = color.AddA(a);
            return self;
        }

        /// <summary>
        /// Multiply base color r of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="r">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static SpriteRenderer MultiplyColorR(this SpriteRenderer self, float r)
        {
            var color = self.color;
            self.color = color.MultiplyR(r);
            return self;
        }

        /// <summary>
        /// Multiply base color g of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="g">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static SpriteRenderer MultiplyColorG(this SpriteRenderer self, float g)
        {
            var color = self.color;
            self.color = color.MultiplyG(g);
            return self;
        }

        /// <summary>
        /// Multiply base color b of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="b">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static SpriteRenderer MultiplyColorB(this SpriteRenderer self, float b)
        {
            var color = self.color;
            self.color = color.MultiplyB(b);
            return self;
        }

        /// <summary>
        /// Multiply base color a of the SpriteRenderer.
        /// </summary>
        /// <param name="self">Self spriteRenderer.</param>
        /// <param name="a">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static SpriteRenderer MultiplyColorA(this SpriteRenderer self, float a)
        {
            var color = self.color;
            self.color = color.MultiplyA(a);
            return self;
        }

        #endregion

        #region lineRenderer

        /// <summary>
        /// Set start and end color of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="color">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetColor(this LineRenderer self, Color color)
        {
            self.startColor = color;
            self.endColor = color;
            return self;
        }

        /// <summary>
        /// Set start color r of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="r">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetStartColorR(this LineRenderer self, float r)
        {
            var color = self.startColor;
            self.startColor = color.SetR(r);
            return self;
        }

        /// <summary>
        /// Set start color g of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="g">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetStartColorG(this LineRenderer self, float g)
        {
            var color = self.startColor;
            self.startColor = color.SetG(g);
            return self;
        }

        /// <summary>
        /// Set start color b of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="b">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetStartColorB(this LineRenderer self, float b)
        {
            var color = self.startColor;
            self.startColor = color.SetB(b);
            return self;
        }

        /// <summary>
        /// Set start color a of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="a">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetStartColorA(this LineRenderer self, float a)
        {
            var color = self.startColor;
            self.startColor = color.SetA(a);
            return self;
        }

        /// <summary>
        /// Add start color r of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="r">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddStartColorR(this LineRenderer self, float r)
        {
            return self.SetStartColorR(self.startColor.r + r);
        }

        /// <summary>
        /// Add start color g of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="g">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddStartColorG(this LineRenderer self, float g)
        {
            return self.SetStartColorG(self.startColor.g + g);
        }

        /// <summary>
        /// Add start color b of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="b">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddStartColorB(this LineRenderer self, float b)
        {
            return self.SetStartColorB(self.startColor.b + b);
        }

        /// <summary>
        /// Add start color a of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="a">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddStartColorA(this LineRenderer self, float a)
        {
            return self.SetStartColorA(self.startColor.a + a);
        }

        /// <summary>
        /// Multiply start color r of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="r">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyStartColorR(this LineRenderer self, float r)
        {
            return self.SetStartColorR(self.startColor.r * r);
        }

        /// <summary>
        /// Multiply start color g of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="g">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyStartColorG(this LineRenderer self, float g)
        {
            return self.SetStartColorG(self.startColor.g * g);
        }

        /// <summary>
        /// Multiply start color b of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="b">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyStartColorB(this LineRenderer self, float b)
        {
            return self.SetStartColorB(self.startColor.b * b);
        }

        /// <summary>
        /// Multiply start color a of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="a">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyStartColorA(this LineRenderer self, float a)
        {
            return self.SetStartColorA(self.startColor.a * a);
        }

        /// <summary>
        /// Set end color r of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="r">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetEndColorR(this LineRenderer self, float r)
        {
            var color = self.endColor;
            self.endColor = color.SetR(r);
            return self;
        }

        /// <summary>
        /// Set end color g of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="g">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetEndColorG(this LineRenderer self, float g)
        {
            var color = self.endColor;
            self.endColor = color.SetG(g);
            return self;
        }

        /// <summary>
        /// Set end color b of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="b">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetEndColorB(this LineRenderer self, float b)
        {
            var color = self.endColor;
            self.endColor = color.SetB(b);
            return self;
        }

        /// <summary>
        /// Set end color a of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="a">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetEndColorA(this LineRenderer self, float a)
        {
            var color = self.endColor;
            self.endColor = color.SetA(a);
            return self;
        }

        /// <summary>
        /// Add end color r of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="r">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddEndColorR(this LineRenderer self, float r)
        {
            return self.SetEndColorR(self.startColor.r + r);
        }

        /// <summary>
        /// Add end color g of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="g">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddEndColorG(this LineRenderer self, float g)
        {
            return self.SetEndColorG(self.startColor.g + g);
        }

        /// <summary>
        /// Add end color b of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="b">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddEndColorB(this LineRenderer self, float b)
        {
            return self.SetEndColorB(self.startColor.b + b);
        }

        /// <summary>
        /// Add end color a of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="a">Add value.</param>
        /// <returns>Add result.</returns>
        public static LineRenderer AddEndColorA(this LineRenderer self, float a)
        {
            return self.SetEndColorA(self.startColor.a + a);
        }

        /// <summary>
        /// Multiply end color r of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="r">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyEndColorR(this LineRenderer self, float r)
        {
            return self.SetEndColorR(self.startColor.r * r);
        }

        /// <summary>
        /// Multiply end color g of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="g">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyEndColorG(this LineRenderer self, float g)
        {
            return self.SetEndColorG(self.startColor.g * g);
        }

        /// <summary>
        /// Multiply end color b of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="b">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyEndColorB(this LineRenderer self, float b)
        {
            return self.SetEndColorB(self.startColor.b * b);
        }

        /// <summary>
        /// Multiply end color a of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="a">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static LineRenderer MultiplyEndColorA(this LineRenderer self, float a)
        {
            return self.SetEndColorA(self.startColor.a * a);
        }

        /// <summary>
        /// Set start and end width of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="width">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetWidth(this LineRenderer self, float width)
        {
            self.startWidth = width;
            self.endWidth = width;
            return self;
        }

        /// <summary>
        /// Set cap and corner vertices of the LineRenderer.
        /// </summary>
        /// <param name="self">Self lineRenderer.</param>
        /// <param name="numVertices">Set value.</param>
        /// <returns>Set result.</returns>
        public static LineRenderer SetNumVertices(this LineRenderer self, int numVertices)
        {
            self.numCapVertices = numVertices;
            self.numCornerVertices = numVertices;
            return self;
        }

        #endregion
    }
}