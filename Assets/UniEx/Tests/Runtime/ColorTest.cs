using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class ColorTest
    {
        [Test]
        public void To()
        {
            // Tuple
            {
                var color = new Color(0.1f, 0.2f, 0.3f, 0.4f);
                var (r, g, b, a) = color.ToTuple();
                Assert.AreApproximatelyEqual(color.r, r);
                Assert.AreApproximatelyEqual(color.g, g);
                Assert.AreApproximatelyEqual(color.b, b);
                Assert.AreApproximatelyEqual(color.a, a);
            }
        }

        [Test]
        public void Set()
        {
            // R
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.SetR(value);
                Assert.AreApproximatelyEqual(value, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // G
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.SetG(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(value, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // B
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.SetB(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(value, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // A
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.SetA(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(value, color.a);
            }
        }

        [Test]
        public void Add()
        {
            // R
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.AddR(value);
                Assert.AreApproximatelyEqual(r + value, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // G
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.AddG(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g + value, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // B
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.AddB(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b + value, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // A
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.AddA(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a + value, color.a);
            }
        }

        [Test]
        public void Multiply()
        {
            // R
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.MultiplyR(value);
                Assert.AreApproximatelyEqual(r * value, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // G
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.MultiplyG(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g * value, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // B
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.MultiplyB(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b * value, color.b);
                Assert.AreApproximatelyEqual(a, color.a);
            }

            // A
            {
                var color = new Color(0.28f, 0.29f, 0.31f, 0.32f);
                var (r, g, b, a) = color.ToTuple();
                var value = 0.5f;
                color.MultiplyA(value);
                Assert.AreApproximatelyEqual(r, color.r);
                Assert.AreApproximatelyEqual(g, color.g);
                Assert.AreApproximatelyEqual(b, color.b);
                Assert.AreApproximatelyEqual(a * value, color.a);
            }
        }
    }
}