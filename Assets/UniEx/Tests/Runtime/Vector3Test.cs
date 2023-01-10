using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class Vector3Test
    {
        [Test]
        public void Property()
        {
            // xy
            {
                var vector = Vector3Extension.xy;
                Assert.AreApproximatelyEqual(1.0f, vector.x);
                Assert.AreApproximatelyEqual(1.0f, vector.y);
                Assert.AreApproximatelyEqual(0.0f, vector.z);
            }

            // xz
            {
                var vector = Vector3Extension.xz;
                Assert.AreApproximatelyEqual(1.0f, vector.x);
                Assert.AreApproximatelyEqual(0.0f, vector.y);
                Assert.AreApproximatelyEqual(1.0f, vector.z);
            }

            // xz
            {
                var vector = Vector3Extension.yz;
                Assert.AreApproximatelyEqual(0.0f, vector.x);
                Assert.AreApproximatelyEqual(1.0f, vector.y);
                Assert.AreApproximatelyEqual(1.0f, vector.z);
            }
        }

        [Test]
        public void To()
        {
            // Tuple
            {
                var vector = new Vector3(1.0f, 2.0f, 3.0f);
                var (x, y, z) = vector.ToTuple();
                Assert.AreApproximatelyEqual(vector.x, x);
                Assert.AreApproximatelyEqual(vector.y, y);
                Assert.AreApproximatelyEqual(vector.z, z);
            }
        }

        [Test]
        public void Set()
        {
            // X
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.SetX(value);
                Assert.AreApproximatelyEqual(value, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Y
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.SetY(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(value, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Z
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.SetZ(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(value, vector.z);
            }
        }

        [Test]
        public void Add()
        {
            // X
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.AddX(value);
                Assert.AreApproximatelyEqual(x + value, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Y
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.AddY(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y + value, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Z
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.AddZ(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z + value, vector.z);
            }
        }

        [Test]
        public void Multiply()
        {
            // X
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.MultiplyX(value);
                Assert.AreApproximatelyEqual(x * value, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Y
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.MultiplyY(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y * value, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Z
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var value = 2.0f;
                vector.MultiplyZ(value);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z * value, vector.z);
            }
        }

        [Test]
        public void Clamp()
        {
            // X 1
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                vector.ClampX(min, max);
                Assert.AreApproximatelyEqual(max, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // X 2
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                vector.ClampX(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // X 3
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                vector.ClampX(min, max);
                Assert.AreApproximatelyEqual(min, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Y 1
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                vector.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(max, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Y 2
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                vector.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Y 3
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                vector.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(min, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Z 1
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                vector.ClampZ(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(max, vector.z);
            }

            // Z 2
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                vector.ClampZ(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(z, vector.z);
            }

            // Z 3
            {
                var vector = new Vector3(2.9f, 3.0f, 3.1f);
                var (x, y, z) = vector.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                vector.ClampZ(min, max);
                Assert.AreApproximatelyEqual(x, vector.x);
                Assert.AreApproximatelyEqual(y, vector.y);
                Assert.AreApproximatelyEqual(min, vector.z);
            }
        }

        [Test]
        public void Length()
        {
            // Length
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                var target = new Vector3(3.0f, 4.0f, 5.0f);
                Assert.AreApproximatelyEqual(Vector3.Magnitude(vector - target), vector.GetLength(target));
            }

            // SqrLength
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                var target = new Vector3(3.0f, 4.0f, 5.0f);
                Assert.AreApproximatelyEqual(Vector3.SqrMagnitude(vector - target), vector.GetSqrLength(target));
            }
        }
    }
}