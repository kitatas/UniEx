using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UniEx
{
    public static class GameObjectExtension
    {
        /// <summary>
        /// Returns the component of Type type if the game object has one attached, adds a component if it doesn't.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <typeparam name="T">The type of component to retrieve.</typeparam>
        /// <returns>Get or add result.</returns>
        public static T GetOrAddComponent<T>(this GameObject self) where T : Component
        {
            return self.TryGetComponent<T>(out var t) ? t : self.AddComponent<T>();
        }

        /// <summary>
        /// Returns true if the game object has component.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <typeparam name="T">The type of component to check.</typeparam>
        /// <returns>Check result.</returns>
        public static bool HasComponent<T>(this GameObject self) where T : Component
        {
            return self.TryGetComponent<T>(out var t);
        }

        /// <summary>
        /// Returns true if the game object remove component.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="duration">The optional amount of time to delay before destroying the component.</param>
        /// <typeparam name="T">The type of component to remove.</typeparam>
        /// <returns>Remove result.</returns>
        public static bool RemoveComponent<T>(this GameObject self, float duration = 0.0f) where T : Component
        {
            if (self.TryGetComponent<T>(out var t))
            {
                Object.Destroy(t, duration);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Set the tag of this game object.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="tag">The tag to set.</param>
        /// <returns>Self game object.</returns>
        public static GameObject SetTag(this GameObject self, string tag)
        {
            self.tag = tag;
            return self;
        }

        /// <summary>
        /// Set the layer of this game object.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="layer">The layer to set.</param>
        /// <returns>Self game object.</returns>
        public static GameObject SetLayer(this GameObject self, string layer)
        {
            self.layer = LayerMask.NameToLayer(layer);
            return self;
        }

        /// <summary>
        /// Set the child of this game object.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="child">The child to set.</param>
        /// <returns>Self game object.</returns>
        public static GameObject SetChild(this GameObject self, GameObject child)
        {
            child.transform.SetParent(self.transform);
            return self;
        }

        /// <summary>
        /// Set the children of this game object.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="children">The children to set.</param>
        /// <returns>Self game object.</returns>
        public static GameObject SetChildren(this GameObject self, IList<GameObject> children)
        {
            children.Each(x => self.SetChild(x));
            return self;
        }

        /// <summary>
        /// Activates / Deactivates all game objects, depending on the given true or false value.
        /// </summary>
        /// <param name="self">Self list of the game object.</param>
        /// <param name="value">Activate or deactivate the all game objects, where true activates the GameObject and false deactivates the GameObject.</param>
        public static void SetActiveAll(this IList<GameObject> self, bool value)
        {
            self.Each(x => x.SetActive(value));
        }

        /// <summary>
        /// Destroy all game objects.
        /// </summary>
        /// <param name="self">Self list of the game object.</param>
        /// <param name="duration">The optional amount of time to delay before destroying the game object.</param>
        public static void DestroyAll(this IList<GameObject> self, float duration = 0.0f)
        {
            self.Each(x => Object.Destroy(x, duration));
        }

        /// <summary>
        /// Execute the action on each children.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="action">The action for children of the list.</param>
        public static void EachChildren(this GameObject self, Action<GameObject> action)
        {
            self.transform.Cast<Transform>().ToList()
                .Each(x => action?.Invoke(x.gameObject));
        }

        /// <summary>
        /// Activates / Deactivates children, depending on the given true or false value.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="value">Activate or deactivate the children, where true activates the GameObject and false deactivates the GameObject.</param>
        public static void SetActiveChildren(this GameObject self, bool value)
        {
            self.EachChildren(x => x.SetActive(value));
        }

        /// <summary>
        /// Destroy children.
        /// </summary>
        /// <param name="self">Self game object.</param>
        /// <param name="duration">The optional amount of time to delay before destroying the game object.</param>
        public static void DestroyChildren(this GameObject self, float duration = 0.0f)
        {
            self.EachChildren(x => Object.Destroy(x, duration));
        }
    }
}