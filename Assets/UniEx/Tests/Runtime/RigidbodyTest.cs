using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class RigidbodyTest
    {
        #region 3D

        [Test]
        public void SetAngularVelocity()
        {
            // Set AngularVelocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.SetAngularVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.x, 0.5f);
            }

            // Set AngularVelocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.SetAngularVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.y, 0.5f);
            }

            // Set AngularVelocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.SetAngularVelocityZ(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.z, 0.5f);
            }

            // Reset AngularVelocity
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ResetAngularVelocity();
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.x, 0.0f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.y, 0.0f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.z, 0.0f);
            }
        }

        [Test]
        public void AddAngularVelocity()
        {
            // Add AngularVelocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.AddAngularVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.x, 0.8f);
            }

            // Add AngularVelocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.AddAngularVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.y, 0.8f);
            }

            // Add AngularVelocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.AddAngularVelocityZ(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.z, 0.8f);
            }
        }

        [Test]
        public void MultiplyAngularVelocity()
        {
            // Multiply AngularVelocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.MultiplyAngularVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.x, 0.15f);
            }

            // Multiply AngularVelocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.MultiplyAngularVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.y, 0.15f);
            }

            // Multiply AngularVelocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.MultiplyAngularVelocityZ(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.z, 0.15f);
            }
        }

        [Test]
        public void ClampAngularVelocity()
        {
            // Clamp AngularVelocity X 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampAngularVelocityX(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.x, 0.2f);
            }

            // Clamp AngularVelocity X 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampAngularVelocityX(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.x, 0.4f);
            }

            // Clamp AngularVelocity Y 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampAngularVelocityY(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.y, 0.2f);
            }

            // Clamp AngularVelocity Y 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampAngularVelocityY(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.y, 0.4f);
            }

            // Clamp AngularVelocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampAngularVelocityZ(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.z, 0.2f);
            }

            // Clamp AngularVelocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.angularVelocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampAngularVelocityZ(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.angularVelocity.z, 0.4f);
            }
        }

        [Test]
        public void SetVelocity()
        {
            // Set Velocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.SetVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.5f);
            }

            // Set Velocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.SetVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.5f);
            }

            // Set Velocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.SetVelocityZ(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.z, 0.5f);
            }

            // Reset AngularVelocity
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ResetVelocity();
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.0f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.0f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.z, 0.0f);
            }
        }

        [Test]
        public void AddVelocity()
        {
            // Add Velocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.AddVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.8f);
            }

            // Add Velocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.AddVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.8f);
            }

            // Add Velocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.AddVelocityZ(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.z, 0.8f);
            }
        }

        [Test]
        public void MultiplyVelocity()
        {
            // Multiply Velocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.MultiplyVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.15f);
            }

            // Multiply Velocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.MultiplyVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.15f);
            }

            // Multiply Velocity Z
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.MultiplyVelocityZ(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.z, 0.15f);
            }
        }

        [Test]
        public void ClampVelocity()
        {
            // Clamp Velocity X 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampVelocityX(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.2f);
            }

            // Clamp Velocity X 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampVelocityX(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.4f);
            }

            // Clamp Velocity Y 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampVelocityY(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.2f);
            }

            // Clamp Velocity Y 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampVelocityY(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.4f);
            }

            // Clamp Velocity Z 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampVelocityZ(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.z, 0.2f);
            }

            // Clamp Velocity Z 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = new Vector3(0.3f, 0.3f, 0.3f);
                rigidbody.ClampVelocityZ(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.z, 0.4f);
            }
        }

        #endregion

        #region 2D

        [Test]
        public void SetVelocity2D()
        {
            // X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.SetVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.5f);
            }

            // Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.SetVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.5f);
            }

            // Reset
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.ResetVelocity();
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.0f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.0f);
            }
        }

        [Test]
        public void AddVelocity2D()
        {
            // Add Velocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.AddVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.8f);
            }

            // Add Velocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.AddVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.8f);
            }
        }

        [Test]
        public void MultiplyVelocity2D()
        {
            // Multiply Velocity X
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.MultiplyVelocityX(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.15f);
            }

            // Multiply Velocity Y
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.MultiplyVelocityY(0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.15f);
            }
        }

        [Test]
        public void ClampVelocity2D()
        {
            // Clamp Velocity X 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.ClampVelocityX(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.2f);
            }

            // Clamp Velocity X 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.ClampVelocityX(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.x, 0.4f);
            }

            // Clamp Velocity Y 1
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.ClampVelocityY(0.1f, 0.2f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.2f);
            }

            // Clamp Velocity Y 2
            {
                var gameObject = new GameObject();
                var rigidbody = gameObject.AddComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(0.3f, 0.3f);
                rigidbody.ClampVelocityY(0.4f, 0.5f);
                Assert.AreApproximatelyEqual(rigidbody.velocity.y, 0.4f);
            }
        }

        #endregion
    }
}