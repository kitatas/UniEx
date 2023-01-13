using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class RendererTest
    {
        private const float TOLERANCE = 0.0036f;

        #region spriteRenderer

        [Test]
        public void SetSpriteColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.SetColorR(value);
                Assert.AreApproximatelyEqual(value, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // G
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.SetColorG(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(value, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // B
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.SetColorB(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(value, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // A
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.SetColorA(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(value, sprite.color.a);
            }
        }

        [Test]
        public void AddSpriteColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.AddColorR(value);
                Assert.AreApproximatelyEqual(r + value, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // G
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.AddColorG(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g + value, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // B
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.AddColorB(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b + value, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // A
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.AddColorA(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a + value, sprite.color.a);
            }
        }

        [Test]
        public void MultiplySpriteColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.MultiplyColorR(value);
                Assert.AreApproximatelyEqual(r * value, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // G
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.MultiplyColorG(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g * value, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // B
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.MultiplyColorB(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b * value, sprite.color.b);
                Assert.AreApproximatelyEqual(a, sprite.color.a);
            }

            // A
            {
                var gameObject = new GameObject();
                var sprite = gameObject.AddComponent<SpriteRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                sprite.color = color;

                var value = 0.5f;
                sprite.MultiplyColorA(value);
                Assert.AreApproximatelyEqual(r, sprite.color.r);
                Assert.AreApproximatelyEqual(g, sprite.color.g);
                Assert.AreApproximatelyEqual(b, sprite.color.b);
                Assert.AreApproximatelyEqual(a * value, sprite.color.a);
            }
        }

        #endregion

        #region lineRenderer

        [Test]
        public void SetLine()
        {
            // Color
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                line.startColor = color;
                line.endColor = color;

                var value = new Color(0.1f, 0.2f, 0.3f, 0.4f);
                var (r, g, b, a) = value.ToTuple();
                line.SetColor(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // Width
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var (start, end) = (0.1f, 0.2f);
                line.startWidth = start;
                line.endWidth = end;
                Assert.AreApproximatelyEqual(start, line.startWidth);
                Assert.AreApproximatelyEqual(end, line.endWidth);

                var value = 0.3f;
                line.SetWidth(value);
                Assert.AreApproximatelyEqual(value, line.startWidth);
                Assert.AreApproximatelyEqual(value, line.endWidth);
            }

            // NumVertices
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var (start, end) = (1, 2);
                line.numCapVertices = start;
                line.numCornerVertices = end;
                Assert.AreApproximatelyEqual(start, line.numCapVertices);
                Assert.AreApproximatelyEqual(end, line.numCornerVertices);

                var value = 3;
                line.SetNumVertices(value);
                Assert.AreApproximatelyEqual(value, line.numCapVertices);
                Assert.AreApproximatelyEqual(value, line.numCornerVertices);
            }
        }

        [Test]
        public void SetLineStartColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetStartColorR(value);
                Assert.AreApproximatelyEqual(value, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // G
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetStartColorG(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // B
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetStartColorB(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // A
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetStartColorA(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }
        }

        [Test]
        public void AddLineStartColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddStartColorR(value);
                Assert.AreApproximatelyEqual(r + value, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // G
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddStartColorG(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g + value, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // B
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddStartColorB(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b + value, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // A
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddStartColorA(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a + value, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }
        }

        [Test]
        public void MultiplyLineStartColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyStartColorR(value);
                Assert.AreApproximatelyEqual(r * value, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // G
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyStartColorG(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g * value, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // B
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyStartColorB(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b * value, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // A
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyStartColorA(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a * value, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }
        }

        [Test]
        public void SetLineEndColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetEndColorR(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // G
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetEndColorG(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // B
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetEndColorB(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // A
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.SetEndColorA(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(value, line.endColor.a, TOLERANCE);
            }
        }

        [Test]
        public void AddLineEndColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddEndColorR(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r + value, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // G
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddEndColorG(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g + value, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // B
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddEndColorB(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b + value, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // A
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.AddEndColorA(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a + value, line.endColor.a, TOLERANCE);
            }
        }

        [Test]
        public void MultiplyLineEndColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyEndColorR(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r * value, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // G
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyEndColorG(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g * value, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // B
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyEndColorB(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b * value, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.endColor.a, TOLERANCE);
            }

            // A
            {
                var gameObject = new GameObject();
                var line = gameObject.AddComponent<LineRenderer>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                line.startColor = color;
                line.endColor = color;

                var value = 0.5f;
                line.MultiplyEndColorA(value);
                Assert.AreApproximatelyEqual(r, line.startColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.startColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.startColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a, line.startColor.a, TOLERANCE);
                Assert.AreApproximatelyEqual(r, line.endColor.r, TOLERANCE);
                Assert.AreApproximatelyEqual(g, line.endColor.g, TOLERANCE);
                Assert.AreApproximatelyEqual(b, line.endColor.b, TOLERANCE);
                Assert.AreApproximatelyEqual(a * value, line.endColor.a, TOLERANCE);
            }
        }

        #endregion
    }
}