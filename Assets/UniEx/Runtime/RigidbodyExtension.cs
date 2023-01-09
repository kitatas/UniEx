using UnityEngine;

namespace UniEx
{
    public static class RigidbodyExtension
    {
        #region 3D

        #region angularVelocity

        /// <summary>
        /// Set the angularVelocity x of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody SetAngularVelocityX(this Rigidbody self, float x)
        {
            var velocity = self.angularVelocity;
            self.angularVelocity = velocity.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the angularVelocity y of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody SetAngularVelocityY(this Rigidbody self, float y)
        {
            var velocity = self.angularVelocity;
            self.angularVelocity = velocity.SetY(y);
            return self;
        }

        /// <summary>
        /// Set the angularVelocity z of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody SetAngularVelocityZ(this Rigidbody self, float z)
        {
            var velocity = self.angularVelocity;
            self.angularVelocity = velocity.SetZ(z);
            return self;
        }

        /// <summary>
        /// Reset the angularVelocity of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <returns>Reset result.</returns>
        public static Rigidbody ResetAngularVelocity(this Rigidbody self)
        {
            self.angularVelocity = Vector3.zero;
            return self;
        }

        /// <summary>
        /// Add the angularVelocity x of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody AddAngularVelocityX(this Rigidbody self, float x)
        {
            return self.SetAngularVelocityX(self.angularVelocity.x + x);
        }

        /// <summary>
        /// Add the angularVelocity y of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody AddAngularVelocityY(this Rigidbody self, float y)
        {
            return self.SetAngularVelocityY(self.angularVelocity.y + y);
        }

        /// <summary>
        /// Add the angularVelocity z of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody AddAngularVelocityZ(this Rigidbody self, float z)
        {
            return self.SetAngularVelocityZ(self.angularVelocity.z + z);
        }

        /// <summary>
        /// Multiply the angularVelocity x of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody MultiplyAngularVelocityX(this Rigidbody self, float x)
        {
            return self.SetAngularVelocityX(self.angularVelocity.x * x);
        }

        /// <summary>
        /// Multiply the angularVelocity y of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody MultiplyAngularVelocityY(this Rigidbody self, float y)
        {
            return self.SetAngularVelocityY(self.angularVelocity.y * y);
        }

        /// <summary>
        /// Multiply the angularVelocity z of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody MultiplyAngularVelocityZ(this Rigidbody self, float z)
        {
            return self.SetAngularVelocityZ(self.angularVelocity.z * z);
        }

        /// <summary>
        /// Clamps the angularVelocity x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody ClampAngularVelocityX(this Rigidbody self, float min, float max)
        {
            return self.SetAngularVelocityX(Mathf.Clamp(self.angularVelocity.x, min, max));
        }

        /// <summary>
        /// Clamps the angularVelocity y between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody ClampAngularVelocityY(this Rigidbody self, float min, float max)
        {
            return self.SetAngularVelocityY(Mathf.Clamp(self.angularVelocity.y, min, max));
        }

        /// <summary>
        /// Clamps the angularVelocity z between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody ClampAngularVelocityZ(this Rigidbody self, float min, float max)
        {
            return self.SetAngularVelocityZ(Mathf.Clamp(self.angularVelocity.z, min, max));
        }

        #endregion

        #region velocity

        /// <summary>
        /// Set the velocity x of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody SetVelocityX(this Rigidbody self, float x)
        {
            var velocity = self.velocity;
            self.velocity = velocity.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the velocity y of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody SetVelocityY(this Rigidbody self, float y)
        {
            var velocity = self.velocity;
            self.velocity = velocity.SetY(y);
            return self;
        }

        /// <summary>
        /// Set the velocity z of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody SetVelocityZ(this Rigidbody self, float z)
        {
            var velocity = self.velocity;
            self.velocity = velocity.SetZ(z);
            return self;
        }

        /// <summary>
        /// Reset the velocity of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <returns>Reset result.</returns>
        public static Rigidbody ResetVelocity(this Rigidbody self)
        {
            self.velocity = Vector3.zero;
            return self;
        }

        /// <summary>
        /// Add the velocity x of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody AddVelocityX(this Rigidbody self, float x)
        {
            return self.SetVelocityX(self.velocity.x + x);
        }

        /// <summary>
        /// Add the velocity y of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody AddVelocityY(this Rigidbody self, float y)
        {
            return self.SetVelocityY(self.velocity.y + y);
        }

        /// <summary>
        /// Add the velocity z of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody AddVelocityZ(this Rigidbody self, float z)
        {
            return self.SetVelocityZ(self.velocity.z + z);
        }

        /// <summary>
        /// Multiply the velocity x of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody MultiplyVelocityX(this Rigidbody self, float x)
        {
            return self.SetVelocityX(self.velocity.x * x);
        }

        /// <summary>
        /// Multiply the velocity y of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody MultiplyVelocityY(this Rigidbody self, float y)
        {
            return self.SetVelocityY(self.velocity.y * y);
        }

        /// <summary>
        /// Multiply the velocity z of the Rigidbody.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody MultiplyVelocityZ(this Rigidbody self, float z)
        {
            return self.SetVelocityZ(self.velocity.z * z);
        }

        /// <summary>
        /// Clamps the velocity x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody ClampVelocityX(this Rigidbody self, float min, float max)
        {
            return self.SetVelocityX(Mathf.Clamp(self.velocity.x, min, max));
        }

        /// <summary>
        /// Clamps the velocity y between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody ClampVelocityY(this Rigidbody self, float min, float max)
        {
            return self.SetVelocityY(Mathf.Clamp(self.velocity.y, min, max));
        }

        /// <summary>
        /// Clamps the velocity z between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody ClampVelocityZ(this Rigidbody self, float min, float max)
        {
            return self.SetVelocityZ(Mathf.Clamp(self.velocity.z, min, max));
        }

        #endregion

        #endregion

        #region 2D

        #region velocity

        /// <summary>
        /// Set the velocity x of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody2D SetVelocityX(this Rigidbody2D self, float x)
        {
            var velocity = self.velocity;
            self.velocity = velocity.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the velocity y of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Rigidbody2D SetVelocityY(this Rigidbody2D self, float y)
        {
            var velocity = self.velocity;
            self.velocity = velocity.SetY(y);
            return self;
        }

        /// <summary>
        /// Reset the velocity of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <returns>Reset result.</returns>
        public static Rigidbody2D ResetVelocity(this Rigidbody2D self)
        {
            self.velocity = Vector2.zero;
            return self;
        }

        /// <summary>
        /// Add the velocity x of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody2D AddVelocityX(this Rigidbody2D self, float x)
        {
            return self.SetVelocityX(self.velocity.x + x);
        }

        /// <summary>
        /// Add the velocity y of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Rigidbody2D AddVelocityY(this Rigidbody2D self, float y)
        {
            return self.SetVelocityY(self.velocity.y + y);
        }

        /// <summary>
        /// Multiply the velocity x of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody2D MultiplyVelocityX(this Rigidbody2D self, float x)
        {
            return self.SetVelocityX(self.velocity.x * x);
        }

        /// <summary>
        /// Multiply the velocity y of the Rigidbody2D.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Rigidbody2D MultiplyVelocityY(this Rigidbody2D self, float y)
        {
            return self.SetVelocityY(self.velocity.y * y);
        }

        /// <summary>
        /// Clamps the velocity x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody2D ClampVelocityX(this Rigidbody2D self, float min, float max)
        {
            return self.SetVelocityX(Mathf.Clamp(self.velocity.x, min, max));
        }

        /// <summary>
        /// Clamps the velocity y between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self rigidbody.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Rigidbody2D ClampVelocityY(this Rigidbody2D self, float min, float max)
        {
            return self.SetVelocityY(Mathf.Clamp(self.velocity.y, min, max));
        }

        #endregion

        #endregion
    }
}