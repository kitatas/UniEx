using UnityEngine;

namespace UniEx
{
    public static class MathfExtension
    {
        /// <summary>
        /// Returns true if the self integer value is between min and max.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <param name="min">The minimum integer value to compare against.</param>
        /// <param name="max">The maximum integer value to compare against.</param>
        /// <returns>Judge result.</returns>
        public static bool IsBetween(this int self, int min, int max)
        {
            return self >= min && self <= max;
        }

        /// <summary>
        /// Returns true if the self floating point value is between min and max.
        /// </summary>
        /// <param name="self">Self floating point value.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Judge result.</returns>
        public static bool IsBetween(this float self, float min, float max)
        {
            return self >= min && self <= max;
        }

        /// <summary>
        /// Returns true if the self integer value equals target.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <param name="target">Comparison integer value.</param>
        /// <returns>Judge result.</returns>
        public static bool IsEqual(this int self, int target)
        {
            return self == target;
        }

        /// <summary>
        /// Returns true if the self floating point value equals target.
        /// </summary>
        /// <param name="self">Self floating point value.</param>
        /// <param name="target">Comparison floating point value.</param>
        /// <returns>Judge result.</returns>
        public static bool IsEqual(this float self, float target)
        {
            return Mathf.Approximately(self, target);
        }

        /// <summary>
        /// Returns true if the self integer value equals zero.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <returns>Judge result.</returns>
        public static bool IsZero(this int self)
        {
            return self.IsEqual(0);
        }

        /// <summary>
        /// Returns true if the self floating point value equals zero.
        /// </summary>
        /// <param name="self">Self floating point value.</param>
        /// <returns>Judge result.</returns>
        public static bool IsZero(this float self)
        {
            return self.IsEqual(0.0f);
        }

        /// <summary>
        /// Returns true if the self integer value is even.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <returns>Judge result.</returns>
        public static bool IsEven(this int self)
        {
            return self % 2 == 0;
        }

        /// <summary>
        /// Increments and clamps the given value between the given minimum integer and maximum integer values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <param name="max">The maximum integer value to compare against.</param>
        /// <returns>Clamp increment result.</returns>
        public static ref int ClampIncrement(this ref int self, int max)
        {
            self = Mathf.Clamp(self + 1, self, max);
            return ref self;
        }

        /// <summary>
        /// Decrements and clamps the given value between the given minimum integer and maximum integer values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <param name="min">The minimum integer value to compare against.</param>
        /// <returns>Clamp decrement result.</returns>
        public static ref int ClampDecrement(this ref int self, int min)
        {
            self = Mathf.Clamp(self - 1, min, self);
            return ref self;
        }

        /// <summary>
        /// Increments and repeats the given value between the given minimum integer and maximum integer values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <param name="min">The minimum integer value to compare against.</param>
        /// <param name="max">The maximum integer value to compare against.</param>
        /// <returns>Repeat increment result.</returns>
        public static ref int RepeatIncrement(this ref int self, int min, int max)
        {
            self = ++self <= max ? self : min;
            return ref self;
        }

        /// <summary>
        /// Decrements and repeats the given value between the given minimum integer and maximum integer values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self integer value.</param>
        /// <param name="min">The minimum integer value to compare against.</param>
        /// <param name="max">The maximum integer value to compare against.</param>
        /// <returns>Repeat decrement result.</returns>
        public static ref int RepeatDecrement(this ref int self, int min, int max)
        {
            self = --self >= min ? self : max;
            return ref self;
        }
    }
}