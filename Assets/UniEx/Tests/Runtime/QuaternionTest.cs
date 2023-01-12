using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class QuaternionTest
    {
        [Test]
        public void To()
        {
            // Tuple
            {
                var quaternion = new Quaternion(1.0f, 2.0f, 3.0f, 4.0f);
                var (x, y, z, w) = quaternion.ToTuple();
                Assert.AreApproximatelyEqual(quaternion.x, x);
                Assert.AreApproximatelyEqual(quaternion.y, y);
                Assert.AreApproximatelyEqual(quaternion.z, z);
                Assert.AreApproximatelyEqual(quaternion.w, w);
            }
        }

        [Test]
        public void Set()
        {
            // X
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.SetX(value);
                Assert.AreApproximatelyEqual(value, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Y
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.SetY(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(value, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Z
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.SetZ(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(value, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // W
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.SetW(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(value, quaternion.w);
            }
        }

        [Test]
        public void Add()
        {
            // X
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.AddX(value);
                Assert.AreApproximatelyEqual(x + value, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Y
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.AddY(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y + value, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Z
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.AddZ(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z + value, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // W
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.AddW(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w + value, quaternion.w);
            }
        }

        [Test]
        public void Multiply()
        {
            // X
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.MultiplyX(value);
                Assert.AreApproximatelyEqual(x * value, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Y
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.MultiplyY(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y * value, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Z
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.MultiplyZ(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z * value, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // W
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var value = 2.0f;
                quaternion.MultiplyW(value);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w * value, quaternion.w);
            }
        }

        [Test]
        public void Clamp()
        {
            // X 1
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                quaternion.ClampX(min, max);
                Assert.AreApproximatelyEqual(max, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // X 2
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                quaternion.ClampX(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // X 3
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                quaternion.ClampX(min, max);
                Assert.AreApproximatelyEqual(min, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Y 1
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                quaternion.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(max, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Y 2
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                quaternion.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Y 3
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                quaternion.ClampY(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(min, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Z 1
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                quaternion.ClampZ(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(max, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Z 2
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                quaternion.ClampZ(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // Z 3
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                quaternion.ClampZ(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(min, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // W 1
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (1.0f, 2.0f);
                quaternion.ClampW(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(max, quaternion.w);
            }

            // W 2
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (2.0f, 4.0f);
                quaternion.ClampW(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(w, quaternion.w);
            }

            // W 3
            {
                var quaternion = new Quaternion(2.8f, 2.9f, 3.1f, 3.2f);
                var (x, y, z, w) = quaternion.ToTuple();
                var (min, max) = (4.0f, 5.0f);
                quaternion.ClampW(min, max);
                Assert.AreApproximatelyEqual(x, quaternion.x);
                Assert.AreApproximatelyEqual(y, quaternion.y);
                Assert.AreApproximatelyEqual(z, quaternion.z);
                Assert.AreApproximatelyEqual(min, quaternion.w);
            }
        }
    }
}