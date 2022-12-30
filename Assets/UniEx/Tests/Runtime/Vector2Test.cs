using NUnit.Framework;
using UnityEngine;

namespace UniEx.Tests
{
    public sealed class Vector2Test
    {
        [Test]
        public void Set()
        {
            // Set X
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.SetX(2.0f);
                Assert.AreEqual(vector, new Vector2(2.0f, 3.0f));
            }

            // Set Y
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.SetY(2.0f);
                Assert.AreEqual(vector, new Vector2(3.0f, 2.0f));
            }
        }

        [Test]
        public void Add()
        {
            // Add X
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.AddX(2.0f);
                Assert.AreEqual(vector, new Vector2(5.0f, 3.0f));
            }

            // Add Y
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.AddY(2.0f);
                Assert.AreEqual(vector, new Vector2(3.0f, 5.0f));
            }
        }

        [Test]
        public void Multiply()
        {
            // Multiply X
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.MultiplyX(2.0f);
                Assert.AreEqual(vector, new Vector2(6.0f, 3.0f));
            }

            // Multiply Y
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.MultiplyY(2.0f);
                Assert.AreEqual(vector, new Vector2(3.0f, 6.0f));
            }
        }

        [Test]
        public void Clamp()
        {
            // Clamp X 1
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.ClampX(1.0f, 2.0f);
                Assert.AreEqual(vector, new Vector2(2.0f, 3.0f));
            }

            // Clamp X 2
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.ClampX(4.0f, 5.0f);
                Assert.AreEqual(vector, new Vector2(4.0f, 3.0f));
            }

            // Clamp Y 1
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.ClampY(1.0f, 2.0f);
                Assert.AreEqual(vector, new Vector2(3.0f, 2.0f));
            }

            // Clamp Y 2
            {
                var vector = new Vector2(3.0f, 3.0f);
                vector.ClampY(4.0f, 5.0f);
                Assert.AreEqual(vector, new Vector2(3.0f, 4.0f));
            }
        }

        [Test]
        public void Length()
        {
            // SqrLength
            {
                var vector = new Vector2(3.0f, 3.0f);
                var target = new Vector2(3.0f, 4.0f);
                Assert.AreEqual(vector.GetSqrLength(target), Vector2.SqrMagnitude(vector - target));
            }
        }

        [Test]
        public void To()
        {
            // Tuple
            {
                var (x, y) = new Vector2(1.0f, 2.0f).ToTuple();
                Assert.AreEqual(x, 1.0f);
                Assert.AreEqual(y, 2.0f);
            }
        }
    }
}