using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class MathfTest
    {
        [Test]
        public void IsBetween()
        {
            // Is Between (int)
            {
                int self1 = 0;
                Assert.IsTrue(self1.IsBetween(-1, 1));
                Assert.IsFalse(self1.IsBetween(1, 3));
            }

            // Is Between (float)
            {
                float self1 = 0.0f;
                Assert.IsTrue(self1.IsBetween(-1, 1));
                Assert.IsFalse(self1.IsBetween(1, 3));
            }
        }

        [Test]
        public void IsEqual()
        {
            // Is Equal (int)
            {
                int self = 1;
                Assert.IsTrue(self.IsEqual(1));
                Assert.IsFalse(self.IsEqual(2));
            }

            // Is Equal (float)
            {
                float self = 1.5f;
                Assert.IsTrue(self.IsEqual(1.5f));
                Assert.IsFalse(self.IsEqual(2.5f));
            }
        }

        [Test]
        public void IsZero()
        {
            // Is Zero (int)
            {
                int self1 = 0;
                Assert.IsTrue(self1.IsZero());

                int self2 = 1;
                Assert.IsFalse(self2.IsZero());
            }

            // Is Zero (float)
            {
                float self1 = 0.0f;
                Assert.IsTrue(self1.IsZero());

                float self2 = 0.1f;
                Assert.IsFalse(self2.IsZero());
            }
        }

        [Test]
        public void IsEven()
        {
            // Is Even
            {
                int self1 = 4;
                Assert.IsTrue(self1.IsEven());

                int self2 = 3;
                Assert.IsFalse(self2.IsEven());
            }
        }


        [Test]
        public void Clamp()
        {
            // Clamp Increment
            {
                int self = 1;

                self.ClampIncrement(3);
                Assert.AreEqual(self, 2);

                self.ClampIncrement(3);
                Assert.AreEqual(self, 3);

                self.ClampIncrement(3);
                Assert.AreEqual(self, 3);
            }

            // Clamp Decrement
            {
                int self = 3;

                self.ClampDecrement(1);
                Assert.AreEqual(self, 2);

                self.ClampDecrement(1);
                Assert.AreEqual(self, 1);

                self.ClampDecrement(1);
                Assert.AreEqual(self, 1);
            }
        }

        [Test]
        public void Repeat()
        {
            // Repeat Increment
            {
                int self = 1;

                self.RepeatIncrement(1, 3);
                Assert.AreEqual(self, 2);

                self.RepeatIncrement(1, 3);
                Assert.AreEqual(self, 3);

                self.RepeatIncrement(1, 3);
                Assert.AreEqual(self, 1);
            }

            // Repeat Decrement
            {
                int self = 3;

                self.RepeatDecrement(1, 3);
                Assert.AreEqual(self, 2);

                self.RepeatDecrement(1, 3);
                Assert.AreEqual(self, 1);

                self.RepeatDecrement(1, 3);
                Assert.AreEqual(self, 3);
            }
        }
    }
}