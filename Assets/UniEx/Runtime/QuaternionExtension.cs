using UnityEngine;

namespace UniEx
{
    public static class QuaternionExtension
    {
        /// <summary>
        /// Set x component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Quaternion SetX(this ref Quaternion self, float x)
        {
            self.Set(x, self.y, self.z, self.w);
            return ref self;
        }

        /// <summary>
        /// Set y component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Quaternion SetY(this ref Quaternion self, float y)
        {
            self.Set(self.x, y, self.z, self.w);
            return ref self;
        }

        /// <summary>
        /// Set z component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Quaternion SetZ(this ref Quaternion self, float z)
        {
            self.Set(self.x, self.y, z, self.w);
            return ref self;
        }

        /// <summary>
        /// Set w component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="w">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Quaternion SetW(this ref Quaternion self, float w)
        {
            self.Set(self.x, self.y, self.z, w);
            return ref self;
        }

        /// <summary>
        /// Add x component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Quaternion AddX(this ref Quaternion self, float x)
        {
            return ref self.SetX(self.x + x);
        }

        /// <summary>
        /// Add y component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Quaternion AddY(this ref Quaternion self, float y)
        {
            return ref self.SetY(self.y + y);
        }

        /// <summary>
        /// Add z component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Quaternion AddZ(this ref Quaternion self, float z)
        {
            return ref self.SetZ(self.z + z);
        }

        /// <summary>
        /// Add w component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="w">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Quaternion AddW(this ref Quaternion self, float w)
        {
            return ref self.SetW(self.w + w);
        }

        /// <summary>
        /// Multiply x component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Quaternion MultiplyX(this ref Quaternion self, float x)
        {
            return ref self.SetX(self.x * x);
        }

        /// <summary>
        /// Multiply y component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Quaternion MultiplyY(this ref Quaternion self, float y)
        {
            return ref self.SetY(self.y * y);
        }

        /// <summary>
        /// Multiply z component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Quaternion MultiplyZ(this ref Quaternion self, float z)
        {
            return ref self.SetZ(self.z * z);
        }

        /// <summary>
        /// Multiply w component of an existing Quaternion.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="w">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Quaternion MultiplyW(this ref Quaternion self, float w)
        {
            return ref self.SetW(self.w * w);
        }

        /// <summary>
        /// Clamps the given quaternion x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Quaternion ClampX(this ref Quaternion self, float min, float max)
        {
            return ref self.SetX(Mathf.Clamp(self.x, min, max));
        }

        /// <summary>
        /// Clamps the given quaternion y between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Quaternion ClampY(this ref Quaternion self, float min, float max)
        {
            return ref self.SetY(Mathf.Clamp(self.y, min, max));
        }

        /// <summary>
        /// Clamps the given quaternion z between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Quaternion ClampZ(this ref Quaternion self, float min, float max)
        {
            return ref self.SetZ(Mathf.Clamp(self.z, min, max));
        }

        /// <summary>
        /// Clamps the given quaternion w between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Quaternion ClampW(this ref Quaternion self, float min, float max)
        {
            return ref self.SetW(Mathf.Clamp(self.w, min, max));
        }

        /// <summary>
        /// Convert to Tuple.
        /// </summary>
        /// <param name="self">Self quaternion.</param>
        /// <returns>Convert result.</returns>
        public static (float x, float y, float z, float w) ToTuple(this Quaternion self)
        {
            return (self.x, self.y, self.z, self.w);
        }
    }
}