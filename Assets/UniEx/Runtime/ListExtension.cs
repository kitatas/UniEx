using System.Collections.Generic;
using UnityEngine;

namespace UniEx
{
    public static class ListExtension
    {
        /// <summary>
        /// Get the last index of list.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Last index of list.</returns>
        public static int GetLastIndex<T>(this IList<T> self)
        {
            return self.Count - 1;
        }

        /// <summary>
        /// Get the random index of list.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Random index of list.</returns>
        public static int GetRandomIndex<T>(this IList<T> self)
        {
            return Random.Range(0, self.Count);
        }

        /// <summary>
        /// Get the random element of list.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Random element of list.</returns>
        public static T GetRandom<T>(this IList<T> self)
        {
            return self[self.GetRandomIndex()];
        }

        /// <summary>
        /// Returns true if list is null.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Judge result.</returns>
        public static bool IsNull<T>(this IList<T> self)
        {
            return self == null;
        }

        /// <summary>
        /// Returns true if the element of list by index is null.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <param name="index">Index of the list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Judge result.</returns>
        public static bool IsNull<T>(this IList<T> self, int index)
        {
            return self[index] == null;
        }

        /// <summary>
        /// Returns true if index is outside the bounds of the list.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <param name="index">Index of the list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Judge result.</returns>
        public static bool IsOutOfRange<T>(this IList<T> self, int index)
        {
            return index.IsBetween(0, self.GetLastIndex()) == false;
        }

        /// <summary>
        /// If true is returned, the value is the element of list by index.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <param name="index">Index of the list.</param>
        /// <param name="value">The element of list by index.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <returns>Judge result.</returns>
        public static bool TryGetValue<T>(this IList<T> self, int index, out T value)
        {
            if (self.IsNull() || self.IsOutOfRange(index) || self.IsNull(index))
            {
                value = default;
                return false;
            }

            value = self[index];
            return true;
        }

        /// <summary>
        /// Execute the action on each element of the list.
        /// </summary>
        /// <param name="self">Self list.</param>
        /// <param name="action">The action for element of the list.</param>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        public static void Each<T>(this IList<T> self, System.Action<T> action)
        {
            if (self.IsNull()) return;

            foreach (var element in self)
            {
                if (element is null) continue;

                action?.Invoke(element);
            }
        }
    }
}