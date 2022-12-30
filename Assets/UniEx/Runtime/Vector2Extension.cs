using UnityEngine;

namespace UniEx
{
    public static class Vector2Extension
    {
        /// <summary>
        /// Set x component of an existing Vector2.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Vector2 SetX(this ref Vector2 self, float x)
        {
            self.Set(x, self.y);
            return ref self;
        }

        /// <summary>
        /// Set y component of an existing Vector2.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Vector2 SetY(this ref Vector2 self, float y)
        {
            self.Set(self.x, y);
            return ref self;
        }

        /// <summary>
        /// Add x component of an existing Vector2.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Vector2 AddX(this ref Vector2 self, float x)
        {
            return ref self.SetX(self.x + x);
        }

        /// <summary>
        /// Add y component of an existing Vector2.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Vector2 AddY(this ref Vector2 self, float y)
        {
            return ref self.SetY(self.y + y);
        }

        /// <summary>
        /// Multiply x component of an existing Vector2.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Vector2 MultiplyX(this ref Vector2 self, float x)
        {
            return ref self.SetX(self.x * x);
        }

        /// <summary>
        /// Multiply y component of an existing Vector2.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Vector2 MultiplyY(this ref Vector2 self, float y)
        {
            return ref self.SetY(self.y * y);
        }

        /// <summary>
        /// Clamps the given vector x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static ref Vector2 ClampX(this ref Vector2 self, float min, float max)
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
        public static ref Vector2 ClampY(this ref Vector2 self, float min, float max)
        {
            return ref self.SetY(Mathf.Clamp(self.y, min, max));
        }

        /// <summary>
        /// Returns the squared length of this vector to the target.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <param name="target">Target vector.</param>
        /// <returns>The squared length of this vector to the target.</returns>
        public static float GetSqrLength(this Vector2 self, Vector2 target)
        {
            return Vector2.SqrMagnitude(self - target);
        }

        /// <summary>
        /// Convert to Tuple.
        /// </summary>
        /// <param name="self">Self vector.</param>
        /// <returns>Convert result.</returns>
        public static (float x, float y) ToTuple(this Vector2 self)
        {
            return (self.x, self.y);
        }
    }
}