using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class TransformTest
    {
        [Test]
        public void SetPosition()
        {
            // Set Position X
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetPositionX(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(1.0f, 3.0f, 3.0f));
            }

            // Set Position Y
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetPositionY(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 1.0f, 3.0f));
            }

            // Set Position Z
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetPositionZ(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 1.0f));
            }
        }

        [Test]
        public void AddPosition()
        {
            // Add Position X
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddPositionX(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(4.0f, 3.0f, 3.0f));
            }

            // Add Position Y
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddPositionY(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 4.0f, 3.0f));
            }

            // Add Position Z
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddPositionZ(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 4.0f));
            }
        }

        [Test]
        public void MultiplyPosition()
        {
            // Multiply Position X
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyPositionX(2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(6.0f, 3.0f, 3.0f));
            }

            // Multiply Position Y
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyPositionY(2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 6.0f, 3.0f));
            }

            // Multiply Position Z
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyPositionZ(2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 6.0f));
            }
        }

        [Test]
        public void ClampPosition()
        {
            // Clamp Position X 1
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampPositionX(1.0f, 2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(2.0f, 3.0f, 3.0f));
            }

            // Clamp Position X 2
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampPositionX(4.0f, 5.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(4.0f, 3.0f, 3.0f));
            }

            // Clamp Position Y 1
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampPositionY(1.0f, 2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 2.0f, 3.0f));
            }

            // Clamp Position Y 2
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampPositionY(4.0f, 5.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 4.0f, 3.0f));
            }

            // Clamp Position Z 1
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampPositionZ(1.0f, 2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 2.0f));
            }

            // Clamp Position Z 2
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampPositionZ(4.0f, 5.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 4.0f));
            }
        }

        [Test]
        public void SetLocalPosition()
        {
            // Set Local Position X
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalPositionX(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(1.0f, 3.0f, 3.0f));
            }

            // Set Local Position Y
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalPositionY(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 1.0f, 3.0f));
            }

            // Set Local Position Z
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalPositionZ(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 1.0f));
            }
        }

        [Test]
        public void AddLocalPosition()
        {
            // Add Local Position X
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalPositionX(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(4.0f, 3.0f, 3.0f));
            }

            // Add Local Position Y
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalPositionY(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 4.0f, 3.0f));
            }

            // Add Local Position Z
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalPositionZ(1.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 4.0f));
            }
        }

        [Test]
        public void MultiplyLocalPosition()
        {
            // Multiply Local Position X
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalPositionX(2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(6.0f, 3.0f, 3.0f));
            }

            // Multiply Local Position Y
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalPositionY(2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 6.0f, 3.0f));
            }

            // Multiply Local Position Z
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalPositionZ(2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 6.0f));
            }
        }

        [Test]
        public void ClampLocalPosition()
        {
            // Clamp Local Position X 1
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalPositionX(1.0f, 2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(2.0f, 3.0f, 3.0f));
            }

            // Clamp Local Position X 2
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalPositionX(4.0f, 5.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(4.0f, 3.0f, 3.0f));
            }

            // Clamp Local Position Y 1
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalPositionY(1.0f, 2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 2.0f, 3.0f));
            }

            // Clamp Local Position Y 2
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalPositionY(4.0f, 5.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 4.0f, 3.0f));
            }

            // Clamp Local Position Z 1
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalPositionZ(1.0f, 2.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 2.0f));
            }

            // Clamp Local Position Z 2
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalPositionZ(4.0f, 5.0f);
                Assert.AreEqual(gameObject.transform.position, new Vector3(3.0f, 3.0f, 4.0f));
            }
        }

        [Test]
        public void SetEulerAngle()
        {
            // Set EulerAngle X
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetEulerAngleX(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.x, 1.0f);
            }

            // Set EulerAngle Y
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetEulerAngleY(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.y, 1.0f);
            }

            // Set EulerAngle Z
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetEulerAngleZ(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.z, 1.0f);
            }
        }

        [Test]
        public void AddEulerAngle()
        {
            // Add EulerAngle X
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddEulerAngleX(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.x, 5.0f);
            }

            // Add EulerAngle Y
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddEulerAngleY(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.y, 5.0f);
            }

            // Add EulerAngle Z
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddEulerAngleZ(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.z, 5.0f);
            }
        }

        [Test]
        public void MultiplyEulerAngle()
        {
            // Multiply EulerAngle X
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyEulerAngleX(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.x, 6.0f);
            }

            // Multiply EulerAngle Y
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyEulerAngleY(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.y, 6.0f);
            }

            // Multiply EulerAngle Z
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyEulerAngleZ(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.z, 6.0f);
            }
        }

        [Test]
        public void ClampEulerAngle()
        {
            // Clamp EulerAngle X 1
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampEulerAngleX(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.x, 2.0f);
            }

            // Clamp EulerAngle X 2
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampEulerAngleX(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.x, 4.0f);
            }

            // Clamp EulerAngle Y 1
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampEulerAngleY(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.y, 2.0f);
            }

            // Clamp EulerAngle Y 2
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampEulerAngleY(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.y, 4.0f);
            }

            // Clamp EulerAngle Z 1
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampEulerAngleZ(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.z, 2.0f);
            }

            // Clamp EulerAngle Z 2
            {
                var gameObject = new GameObject { transform = { eulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampEulerAngleZ(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.eulerAngles.z, 4.0f);
            }
        }

        [Test]
        public void SetLocalEulerAngle()
        {
            // Set Local EulerAngle X
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalEulerAngleX(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.x, 1.0f);
            }

            // Set Local EulerAngle Y
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalEulerAngleY(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.y, 1.0f);
            }

            // Set Local EulerAngle Z
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalEulerAngleZ(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.z, 1.0f);
            }
        }

        [Test]
        public void AddLocalEulerAngle()
        {
            // Add Local EulerAngle X
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalEulerAngleX(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.x, 5.0f);
            }

            // Add Local EulerAngle Y
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalEulerAngleY(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.y, 5.0f);
            }

            // Add Local EulerAngle Z
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalEulerAngleZ(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.z, 5.0f);
            }
        }

        [Test]
        public void MultiplyLocalEulerAngle()
        {
            // Multiply Local EulerAngle X
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalEulerAngleX(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.x, 6.0f);
            }

            // Multiply Local EulerAngle Y
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalEulerAngleY(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.y, 6.0f);
            }

            // Multiply Local EulerAngle Z
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalEulerAngleZ(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.z, 6.0f);
            }
        }

        [Test]
        public void ClampLocalEulerAngle()
        {
            // Clamp Local EulerAngle X 1
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalEulerAngleX(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.x, 2.0f);
            }

            // Clamp Local EulerAngle X 2
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalEulerAngleX(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.x, 4.0f);
            }

            // Clamp Local EulerAngle Y 1
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalEulerAngleY(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.y, 2.0f);
            }

            // Clamp Local EulerAngle Y 2
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalEulerAngleY(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.y, 4.0f);
            }

            // Clamp Local EulerAngle Z 1
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalEulerAngleZ(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.z, 2.0f);
            }

            // Clamp Local EulerAngle Z 2
            {
                var gameObject = new GameObject { transform = { localEulerAngles = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalEulerAngleZ(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localEulerAngles.z, 4.0f);
            }
        }

        [Test]
        public void SetLocalScale()
        {
            // Set Local Scale X
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalScaleX(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.x, 1.0f);
            }

            // Set Local Scale Y
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalScaleY(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.y, 1.0f);
            }

            // Set Local Scale Z
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.SetLocalScaleZ(1.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.z, 1.0f);
            }
        }

        [Test]
        public void AddLocalScale()
        {
            // Add Local Scale X
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalScaleX(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.x, 5.0f);
            }

            // Add Local Scale Y
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalScaleY(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.y, 5.0f);
            }

            // Add Local Scale Z
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.AddLocalScaleZ(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.z, 5.0f);
            }
        }

        [Test]
        public void MultiplyLocalScale()
        {
            // Multiply Local Scale X
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalScaleX(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.x, 6.0f);
            }

            // Multiply Local Scale Y
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalScaleY(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.y, 6.0f);
            }

            // Multiply Local Scale Z
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.MultiplyLocalScaleZ(2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.z, 6.0f);
            }
        }

        [Test]
        public void ClampLocalScale()
        {
            // Clamp Local Scale X 1
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalScaleX(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.x, 2.0f);
            }

            // Clamp Local Scale X 2
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalScaleX(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.x, 4.0f);
            }

            // Clamp Local Scale Y 1
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalScaleY(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.y, 2.0f);
            }

            // Clamp Local Scale Y 2
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalScaleY(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.y, 4.0f);
            }

            // Clamp Local Scale Z 1
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalScaleZ(1.0f, 2.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.z, 2.0f);
            }

            // Clamp Local Scale Z 2
            {
                var gameObject = new GameObject { transform = { localScale = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.ClampLocalScaleZ(4.0f, 5.0f);
                Assert.AreApproximatelyEqual(gameObject.transform.localScale.z, 4.0f);
            }
        }

        [Test]
        public void Translate()
        {
            // Translate X (Space)
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.TranslateX(2.0f, Space.Self);
                Assert.AreApproximatelyEqual(gameObject.transform.position.x, 5.0f);
            }

            // Translate X (Transform)
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                var other = new GameObject();
                gameObject.transform.TranslateX(2.0f, other.transform);
                Assert.AreApproximatelyEqual(gameObject.transform.position.x, 5.0f);
            }

            // Translate Y (Space)
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.TranslateY(2.0f, Space.Self);
                Assert.AreApproximatelyEqual(gameObject.transform.position.y, 5.0f);
            }

            // Translate Y (Transform)
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                var other = new GameObject();
                gameObject.transform.TranslateY(2.0f, other.transform);
                Assert.AreApproximatelyEqual(gameObject.transform.position.y, 5.0f);
            }

            // Translate Z (Space)
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                gameObject.transform.TranslateZ(2.0f, Space.Self);
                Assert.AreApproximatelyEqual(gameObject.transform.position.z, 5.0f);
            }

            // Translate Z (Transform)
            {
                var gameObject = new GameObject { transform = { position = new Vector3(3.0f, 3.0f, 3.0f) } };
                var other = new GameObject();
                gameObject.transform.TranslateZ(2.0f, other.transform);
                Assert.AreApproximatelyEqual(gameObject.transform.position.z, 5.0f);
            }
        }

        [Test]
        public void To()
        {
            // RectTransform
            {
                var gameObject = new GameObject();
                gameObject.AddComponent<RectTransform>();
                var rectTransform = gameObject.transform.ToRectTransform();
                Assert.AreEqual(rectTransform.GetType(), typeof(RectTransform));
            }
        }
    }
}