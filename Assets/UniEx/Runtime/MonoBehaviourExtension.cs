using System;
using System.Collections;
using UnityEngine;

namespace UniEx
{
    public static class MonoBehaviourExtension
    {
        /// <summary>
        /// Execute delay action.
        /// </summary>
        /// <param name="self">Self monoBehaviour.</param>
        /// <param name="duration">The time to delay before executing the action.</param>
        /// <param name="action">The action to delay.</param>
        /// <returns>Coroutine.</returns>
        public static Coroutine Delay(this MonoBehaviour self, float duration, Action action)
        {
            return self.StartCoroutine(Delay(duration, action));
        }

        /// <summary>
        /// Execute delay action.
        /// </summary>
        /// <param name="duration">The time to delay before executing the action.</param>
        /// <param name="action">The action to delay.</param>
        /// <returns>IEnumerator.</returns>
        public static IEnumerator Delay(float duration, Action action)
        {
            yield return new WaitForSeconds(duration);

            action?.Invoke();
        }

        /// <summary>
        /// Execute delay frame action.
        /// </summary>
        /// <param name="self">Self monoBehaviour.</param>
        /// <param name="duration">The frame to delay before executing the action.</param>
        /// <param name="action">The action to delay.</param>
        /// <returns>Coroutine.</returns>
        public static Coroutine DelayFrame(this MonoBehaviour self, int duration, Action action)
        {
            return self.StartCoroutine(DelayFrame(duration, action));
        }

        /// <summary>
        /// Execute delay frame action.
        /// </summary>
        /// <param name="duration">The frame to delay before executing the action.</param>
        /// <param name="action">The action to delay.</param>
        /// <returns>IEnumerator.</returns>
        public static IEnumerator DelayFrame(int duration, Action action)
        {
            for (int i = 0; i < duration; i++) yield return null;

            action?.Invoke();
        }
    }
}