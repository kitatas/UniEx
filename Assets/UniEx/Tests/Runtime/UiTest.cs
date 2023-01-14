using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class UiTest
    {
        #region graphic.color

        [Test]
        public void SetGraphicColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.SetColorR(value);
                Assert.AreApproximatelyEqual(value, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // G
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.SetColorG(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(value, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // B
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.SetColorB(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(value, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // A
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.SetColorA(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(value, image.color.a);
            }
        }

        [Test]
        public void AddGraphicColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.AddColorR(value);
                Assert.AreApproximatelyEqual(r + value, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // G
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.AddColorG(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g + value, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // B
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.AddColorB(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b + value, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // A
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.AddColorA(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a + value, image.color.a);
            }
        }

        [Test]
        public void MultiplyGraphicColor()
        {
            // R
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.MultiplyColorR(value);
                Assert.AreApproximatelyEqual(r * value, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // G
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.MultiplyColorG(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g * value, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // B
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.MultiplyColorB(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b * value, image.color.b);
                Assert.AreApproximatelyEqual(a, image.color.a);
            }

            // A
            {
                var gameObject = new GameObject();
                var image = gameObject.AddComponent<Image>();
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                image.color = color;

                var value = 0.5f;
                image.MultiplyColorA(value);
                Assert.AreApproximatelyEqual(r, image.color.r);
                Assert.AreApproximatelyEqual(g, image.color.g);
                Assert.AreApproximatelyEqual(b, image.color.b);
                Assert.AreApproximatelyEqual(a * value, image.color.a);
            }
        }

        #endregion

        #region slider

        [Test]
        public void SetSlider()
        {
            // Range
            {
                var gameObject = new GameObject();
                var slider = gameObject.AddComponent<Slider>();
                var (min1, max1) = (0.1f, 0.2f);
                slider.minValue = min1;
                slider.maxValue = max1;

                var (min2, max2) = (0.3f, 0.4f);
                slider.SetRange(min2, max2);
                Assert.AreApproximatelyEqual(min2, slider.minValue);
                Assert.AreApproximatelyEqual(max2, slider.maxValue);
            }
        }

        #endregion
    }
}