using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UniEx
{
    public static class UiExtension
    {
        #region rectTransform

        /// <summary>
        /// Get world point from screen point.
        /// </summary>
        /// <param name="self">Self rectTransform.</param>
        /// <param name="camera">Screen space camera.</param>
        /// <param name="worldPoint">World point to convert.</param>
        /// <returns>World point.</returns>
        public static Vector3 GetWorldFromScreenPoint(this RectTransform self, Camera camera, Vector3 worldPoint)
        {
            var point = RectTransformUtility.WorldToScreenPoint(camera, worldPoint);
            RectTransformUtility.ScreenPointToWorldPointInRectangle(self, point, camera, out var result);
            return result;
        }

        /// <summary>
        /// Get local point from screen point.
        /// </summary>
        /// <param name="self">Self rectTransform.</param>
        /// <param name="camera">Screen space camera.</param>
        /// <param name="worldPoint">World point to convert.</param>
        /// <returns>Local point.</returns>
        public static Vector2 GetLocalFromScreenPoint(this RectTransform self, Camera camera, Vector3 worldPoint)
        {
            var point = RectTransformUtility.WorldToScreenPoint(camera, worldPoint);
            RectTransformUtility.ScreenPointToLocalPointInRectangle(self, point, camera, out var result);
            return result;
        }

        #endregion

        #region graphic.color

        /// <summary>
        /// Set base color r of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="r">Set value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Set result.</returns>
        public static T SetColorR<T>(this T self, float r) where T : Graphic
        {
            var color = self.color;
            self.color = color.SetR(r);
            return self;
        }

        /// <summary>
        /// Set base color g of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="g">Set value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Set result.</returns>
        public static T SetColorG<T>(this T self, float g) where T : Graphic
        {
            var color = self.color;
            self.color = color.SetG(g);
            return self;
        }

        /// <summary>
        /// Set base color b of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="b">Set value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Set result.</returns>
        public static T SetColorB<T>(this T self, float b) where T : Graphic
        {
            var color = self.color;
            self.color = color.SetB(b);
            return self;
        }

        /// <summary>
        /// Set base color a of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="a">Set value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Set result.</returns>
        public static T SetColorA<T>(this T self, float a) where T : Graphic
        {
            var color = self.color;
            self.color = color.SetA(a);
            return self;
        }

        /// <summary>
        /// Add base color r of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="r">Add value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Add result.</returns>
        public static T AddColorR<T>(this T self, float r) where T : Graphic
        {
            var color = self.color;
            self.color = color.AddR(r);
            return self;
        }

        /// <summary>
        /// Add base color g of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="g">Add value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Add result.</returns>
        public static T AddColorG<T>(this T self, float g) where T : Graphic
        {
            var color = self.color;
            self.color = color.AddG(g);
            return self;
        }

        /// <summary>
        /// Add base color b of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="b">Add value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Add result.</returns>
        public static T AddColorB<T>(this T self, float b) where T : Graphic
        {
            var color = self.color;
            self.color = color.AddB(b);
            return self;
        }

        /// <summary>
        /// Add base color a of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="a">Add value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Add result.</returns>
        public static T AddColorA<T>(this T self, float a) where T : Graphic
        {
            var color = self.color;
            self.color = color.AddA(a);
            return self;
        }

        /// <summary>
        /// Multiply base color r of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="r">Multiply value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Multiply result.</returns>
        public static T MultiplyColorR<T>(this T self, float r) where T : Graphic
        {
            var color = self.color;
            self.color = color.MultiplyR(r);
            return self;
        }

        /// <summary>
        /// Multiply base color g of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="g">Multiply value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Multiply result.</returns>
        public static T MultiplyColorG<T>(this T self, float g) where T : Graphic
        {
            var color = self.color;
            self.color = color.MultiplyG(g);
            return self;
        }

        /// <summary>
        /// Multiply base color b of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="b">Multiply value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Multiply result.</returns>
        public static T MultiplyColorB<T>(this T self, float b) where T : Graphic
        {
            var color = self.color;
            self.color = color.MultiplyB(b);
            return self;
        }

        /// <summary>
        /// Multiply base color a of the Graphic.
        /// </summary>
        /// <param name="self">Self graphic.</param>
        /// <param name="a">Multiply value.</param>
        /// <typeparam name="T">Derived from Graphic class.</typeparam>
        /// <returns>Multiply result.</returns>
        public static T MultiplyColorA<T>(this T self, float a) where T : Graphic
        {
            var color = self.color;
            self.color = color.MultiplyA(a);
            return self;
        }

        #endregion

        #region slider

        /// <summary>
        /// Set minimum and maximum floating point value of the Slider.
        /// </summary>
        /// <param name="self">Self slider.</param>
        /// <param name="min">The minimum floating point value of the Slider.</param>
        /// <param name="max">The maximum floating point value of the Slider.</param>
        /// <returns>Set result.</returns>
        public static Slider SetRange(this Slider self, float min, float max)
        {
            self.minValue = min;
            self.maxValue = max;
            return self;
        }

        #endregion

        #region pointerEventData

        /// <summary>
        /// Get vector by dragging
        /// </summary>
        /// <param name="self">Self pointerEventData.</param>
        /// <returns>Drag vector.</returns>
        public static Vector2 GetDragVector(this PointerEventData self)
        {
            return self.pressPosition - self.position;
        }

        #endregion
    }
}