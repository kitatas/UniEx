using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class Vector2Test
    {
        [Test]
        public void To()
        {
            // Tuple
            {
                var vector = new Vector2(1.0f, 2.0f);
                var (x, y) = vector.ToTuple();
                Assert.AreApproximatelyEqual(vector.x, x);
                Assert.AreApproximatelyEqual(vector.y, y);
            }
        }

        [Test]
        public void Set()
        {
            // X
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var value = 2.0f;
                vector.SetX(value);
                Assert.AreApproximatelyEqual(value, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // Y
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var value = 2.0f;
                vector.SetY(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(value, vector.y);
            }
        }

        [Test]
        public void Add()
        {
            // X
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var value = 2.0f;
                vector.AddX(value);
                Assert.AreApproximatelyEqual(x + value, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // Y
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var value = 2.0f;
                vector.AddY(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y + value, vector.y);
            }
        }

        [Test]
        public void Multiply()
        {
            // X
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var value = 2.0f;
                vector.MultiplyX(value);
                Assert.AreApproximatelyEqual(x * value, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // Y
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var value = 2.0f;
                vector.MultiplyY(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y * value, vector.y);
            }
        }

        [Test]
        public void Clamp()
        {
            // X 1
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                vector.ClampX(min, max);
                Assert.AreApproximatelyEqual(max, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // X 2
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                vector.ClampX(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // X 3
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                vector.ClampX(min, max);
                Assert.AreApproximatelyEqual(min, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // Y 1
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                vector.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(max, vector.y);
            }

            // Y 2
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                vector.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
            }

            // Y 3
            {
                var vector = new Vector2(2.9f, 3.1f);
                var (x, y) = vector.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                vector.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(min, vector.y);
            }
        }

        [Test]
        public void Length()
        {
            // SqrLength
            {
                var vector = new Vector2(3.0f, 3.0f);
                var target = new Vector2(3.0f, 4.0f);
                Assert.AreApproximatelyEqual(Vector2.SqrMagnitude(vector - target), vector.GetSqrLength(target));
            }
        }
    }
}