using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class ColorTest
    {
        [Test]
        public void Set()
        {
            // Set R
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.SetR(0.5f);
                Assert.AreApproximatelyEqual(color.r, 0.5f);
            }

            // Set G
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.SetG(0.5f);
                Assert.AreApproximatelyEqual(color.g, 0.5f);
            }

            // Set B
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.SetB(0.5f);
                Assert.AreApproximatelyEqual(color.b, 0.5f);
            }

            // Set A
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.SetA(0.5f);
                Assert.AreApproximatelyEqual(color.a, 0.5f);
            }
        }

        [Test]
        public void Add()
        {
            // Add R
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.AddR(0.5f);
                Assert.AreApproximatelyEqual(color.r, 0.8f);
            }

            // Add G
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.AddG(0.5f);
                Assert.AreApproximatelyEqual(color.g, 0.8f);
            }

            // Add B
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.AddB(0.5f);
                Assert.AreApproximatelyEqual(color.b, 0.8f);
            }

            // Add A
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.AddA(0.5f);
                Assert.AreApproximatelyEqual(color.a, 0.8f);
            }
        }

        [Test]
        public void Multiply()
        {
            // Multiply R
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.MultiplyR(0.5f);
                Assert.AreApproximatelyEqual(color.r, 0.15f);
            }

            // Multiply G
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.MultiplyG(0.5f);
                Assert.AreApproximatelyEqual(color.g, 0.15f);
            }

            // Multiply B
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.MultiplyB(0.5f);
                Assert.AreApproximatelyEqual(color.b, 0.15f);
            }

            // Multiply A
            {
                var color = new Color(0.3f, 0.3f, 0.3f, 0.3f);
                color.MultiplyA(0.5f);
                Assert.AreApproximatelyEqual(color.a, 0.15f);
            }
        }

        [Test]
        public void To()
        {
            // Tuple
            {
                var (r, g, b, a) = new Color(0.1f, 0.2f, 0.3f, 0.4f).ToTuple();
                Assert.AreApproximatelyEqual(r, 0.1f);
                Assert.AreApproximatelyEqual(g, 0.2f);
                Assert.AreApproximatelyEqual(b, 0.3f);
                Assert.AreApproximatelyEqual(a, 0.4f);
            }
        }
    }
}