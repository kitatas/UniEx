using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class QuaternionTest
    {
        [Test]
        public void Set()
        {
            // Set X
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.SetX(0.5f);
                Assert.AreApproximatelyEqual(quaternion.x, 0.5f);
            }

            // Set Y
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.SetY(0.5f);
                Assert.AreApproximatelyEqual(quaternion.y, 0.5f);
            }

            // Set Z
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.SetZ(0.5f);
                Assert.AreApproximatelyEqual(quaternion.z, 0.5f);
            }

            // Set W
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.SetW(0.5f);
                Assert.AreApproximatelyEqual(quaternion.w, 0.5f);
            }
        }

        [Test]
        public void Add()
        {
            // Add X
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.AddX(0.5f);
                Assert.AreApproximatelyEqual(quaternion.x, 0.8f);
            }

            // Add Y
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.AddY(0.5f);
                Assert.AreApproximatelyEqual(quaternion.y, 0.8f);
            }

            // Add Z
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.AddZ(0.5f);
                Assert.AreApproximatelyEqual(quaternion.z, 0.8f);
            }

            // Add W
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.AddW(0.5f);
                Assert.AreApproximatelyEqual(quaternion.w, 0.8f);
            }
        }

        [Test]
        public void Multiply()
        {
            // Multiply X
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.MultiplyX(0.5f);
                Assert.AreApproximatelyEqual(quaternion.x, 0.15f);
            }

            // Multiply Y
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.MultiplyY(0.5f);
                Assert.AreApproximatelyEqual(quaternion.y, 0.15f);
            }

            // Multiply Z
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.MultiplyZ(0.5f);
                Assert.AreApproximatelyEqual(quaternion.z, 0.15f);
            }

            // Multiply W
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.MultiplyW(0.5f);
                Assert.AreApproximatelyEqual(quaternion.w, 0.15f);
            }
        }

        [Test]
        public void Clamp()
        {
            // Clamp X 1
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampX(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(quaternion.x, 0.2f);
            }

            // Clamp X 2
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampX(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(quaternion.x, 0.4f);
            }

            // Clamp Y 1
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampY(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(quaternion.y, 0.2f);
            }

            // Clamp Y 2
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampY(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(quaternion.y, 0.4f);
            }

            // Clamp Z 1
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampZ(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(quaternion.z, 0.2f);
            }

            // Clamp Z 2
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampZ(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(quaternion.z, 0.4f);
            }

            // Clamp W 1
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampW(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(quaternion.w, 0.2f);
            }

            // Clamp W 2
            {
                var quaternion = new Quaternion(0.3f, 0.3f, 0.3f, 0.3f);
                quaternion.ClampW(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(quaternion.w, 0.4f);
            }
        }

        [Test]
        public void To()
        {
            // Tuple
            {
                var (x, y, z, w) = new Quaternion(0.1f, 0.2f, 0.3f, 0.4f).ToTuple();
                Assert.AreEqual(x, 0.1f);
                Assert.AreEqual(y, 0.2f);
                Assert.AreEqual(z, 0.3f);
                Assert.AreEqual(w, 0.4f);
            }
        }
    }
}