using NUnit.Framework;
using UnityEngine;

namespace UniEx.Tests
{
    public sealed class Vector3Test
    {
        [Test]
        public void Property()
        {
            Assert.AreEqual(Vector3Extension.xy, new Vector3(1.0f, 1.0f, 0.0f));
            Assert.AreEqual(Vector3Extension.xz, new Vector3(1.0f, 0.0f, 1.0f));
            Assert.AreEqual(Vector3Extension.yz, new Vector3(0.0f, 1.0f, 1.0f));
        }

        [Test]
        public void Set()
        {
            // Set X
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.SetX(2.0f);
                Assert.AreEqual(vector, new Vector3(2.0f, 3.0f, 3.0f));
            }

            // Set Y
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.SetY(2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 2.0f, 3.0f));
            }

            // Set Z
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.SetZ(2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 3.0f, 2.0f));
            }
        }

        [Test]
        public void Add()
        {
            // Add X
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.AddX(2.0f);
                Assert.AreEqual(vector, new Vector3(5.0f, 3.0f, 3.0f));
            }

            // Add Y
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.AddY(2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 5.0f, 3.0f));
            }

            // Add Z
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.AddZ(2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 3.0f, 5.0f));
            }
        }

        [Test]
        public void Multiply()
        {
            // Multiply X
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.MultiplyX(2.0f);
                Assert.AreEqual(vector, new Vector3(6.0f, 3.0f, 3.0f));
            }

            // Multiply Y
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.MultiplyY(2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 6.0f, 3.0f));
            }

            // Multiply Z
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.MultiplyZ(2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 3.0f, 6.0f));
            }
        }

        [Test]
        public void Clamp()
        {
            // Clamp X 1
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.ClampX(1.0f, 2.0f);
                Assert.AreEqual(vector, new Vector3(2.0f, 3.0f, 3.0f));
            }

            // Clamp X 2
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.ClampX(4.0f, 5.0f);
                Assert.AreEqual(vector, new Vector3(4.0f, 3.0f, 3.0f));
            }

            // Clamp Y 1
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.ClampY(1.0f, 2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 2.0f, 3.0f));
            }

            // Clamp Y 2
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.ClampY(4.0f, 5.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 4.0f, 3.0f));
            }

            // Clamp Z 1
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.ClampZ(1.0f, 2.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 3.0f, 2.0f));
            }

            // Clamp Z 2
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                vector.ClampZ(4.0f, 5.0f);
                Assert.AreEqual(vector, new Vector3(3.0f, 3.0f, 4.0f));
            }
        }

        [Test]
        public void Length()
        {
            // Length
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                var target = new Vector3(3.0f, 4.0f, 5.0f);
                Assert.AreEqual(vector.GetLength(target), Vector3.Magnitude(vector - target));
            }

            // SqrLength
            {
                var vector = new Vector3(3.0f, 3.0f, 3.0f);
                var target = new Vector3(3.0f, 4.0f, 5.0f);
                Assert.AreEqual(vector.GetSqrLength(target), Vector3.SqrMagnitude(vector - target));
            }
        }

        [Test]
        public void To()
        {
            // Tuple
            {
                var (x, y, z) = new Vector3(1.0f, 2.0f, 3.0f).ToTuple();
                Assert.AreEqual(x, 1.0f);
                Assert.AreEqual(y, 2.0f);
                Assert.AreEqual(z, 3.0f);
            }
        }
    }
}