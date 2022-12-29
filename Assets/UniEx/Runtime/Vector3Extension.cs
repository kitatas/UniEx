using UnityEngine;

namespace UniEx
{
    public static class Vector3Extension
    {
        /// <summary>
        /// Shorthand for writing Vector3(1, 1, 0).
        /// </summary>
        public static Vector3 xy => new Vector3(1.0f, 1.0f, 0.0f);

        /// <summary>
        /// Shorthand for writing Vector3(1, 0, 1).
        /// </summary>
        public static Vector3 xz => new Vector3(1.0f, 0.0f, 1.0f);

        /// <summary>
        /// Shorthand for writing Vector3(0, 1, 1).
        /// </summary>
        public static Vector3 yz => new Vector3(0.0f, 1.0f, 1.0f);

        /// <summary>
        /// Set x component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Vector3 SetX(this ref Vector3 self, float x)
        {
            self.Set(x, self.y, self.z);
            return ref self;
        }

        /// <summary>
        /// Set y component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Vector3 SetY(this ref Vector3 self, float y)
        {
            self.Set(self.x, y, self.z);
            return ref self;
        }

        /// <summary>
        /// Set z component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Vector3 SetZ(this ref Vector3 self, float z)
        {
            self.Set(self.x, self.y, z);
            return ref self;
        }

        /// <summary>
        /// Add x component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Vector3 AddX(this ref Vector3 self, float x)
        {
            return ref self.SetX(self.x + x);
        }

        /// <summary>
        /// Add y component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Vector3 AddY(this ref Vector3 self, float y)
        {
            return ref self.SetY(self.y + y);
        }

        /// <summary>
        /// Add z component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Vector3 AddZ(this ref Vector3 self, float z)
        {
            return ref self.SetZ(self.z + z);
        }

        /// <summary>
        /// Multiply x component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Vector3 MultiplyX(this ref Vector3 self, float x)
        {
            return ref self.SetX(self.x * x);
        }

        /// <summary>
        /// Multiply y component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Vector3 MultiplyY(this ref Vector3 self, float y)
        {
            return ref self.SetY(self.y * y);
        }

        /// <summary>
        /// Multiply z component of an existing Vector3.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Vector3 MultiplyZ(this ref Vector3 self, float z)
        {
            return ref self.SetZ(self.z * z);
        }

        /// <summary>
        /// Clamps the given vector x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Vector3 ClampX(this ref Vector3 self, float min, float max)
        {
            return ref self.SetX(Mathf.Clamp(self.x, min, max));
        }

        /// <summary>
        /// Clamps the given vector y between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Vector3 ClampY(this ref Vector3 self, float min, float max)
        {
            return ref self.SetY(Mathf.Clamp(self.y, min, max));
        }

        /// <summary>
        /// Clamps the given vector z between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Vector3 ClampZ(this ref Vector3 self, float min, float max)
        {
            return ref self.SetZ(Mathf.Clamp(self.z, min, max));
        }

        /// <summary>
        /// Returns the length of this vector to the target.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="target">Target vector.</param>
        /// <returns>The length of this vector to the target.</returns>
        public static float GetLength(this Vector3 self, Vector3 target)
        {
            return Vector3.Magnitude(self - target);
        }

        /// <summary>
        /// Returns the squared length of this vector to the target.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="target">Target vector.</param>
        /// <returns>The squared length of this vector to the target.</returns>
        public static float GetSqrLength(this Vector3 self, Vector3 target)
        {
            return Vector3.SqrMagnitude(self - target);
        }

        /// <summary>
        /// Convert to Tuple.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <returns>Convert result.</returns>
        public static (float x, float y, float z) ToTuple(this Vector3 self)
        {
            return (self.x, self.y, self.z);
        }
    }
}