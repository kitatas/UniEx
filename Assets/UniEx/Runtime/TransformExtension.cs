using UnityEngine;

namespace UniEx
{
    public static class TransformExtension
    {
        #region position

        /// <summary>
        /// Set the world space position x of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetPositionX(this Transform self, float x)
        {
            var position = self.position;
            self.position = position.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the world space position y of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetPositionY(this Transform self, float y)
        {
            var position = self.position;
            self.position = position.SetY(y);
            return self;
        }

        /// <summary>
        /// Set the world space position z of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetPositionZ(this Transform self, float z)
        {
            var position = self.position;
            self.position = position.SetZ(z);
            return self;
        }

        /// <summary>
        /// Add the world space position x of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddPositionX(this Transform self, float x)
        {
            return self.SetPositionX(self.position.x + x);
        }

        /// <summary>
        /// Add the world space position y of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddPositionY(this Transform self, float y)
        {
            return self.SetPositionY(self.position.y + y);
        }

        /// <summary>
        /// Add the world space position z of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddPositionZ(this Transform self, float z)
        {
            return self.SetPositionZ(self.position.z + z);
        }

        /// <summary>
        /// Multiply the world space position x of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyPositionX(this Transform self, float x)
        {
            return self.SetPositionX(self.position.x * x);
        }

        /// <summary>
        /// Multiply the world space position y of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyPositionY(this Transform self, float y)
        {
            return self.SetPositionY(self.position.y * y);
        }

        /// <summary>
        /// Multiply the world space position z of the Transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyPositionZ(this Transform self, float z)
        {
            return self.SetPositionZ(self.position.z * z);
        }

        /// <summary>
        /// Clamps the world space position x between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampPositionX(this Transform self, float min, float max)
        {
            return self.SetPositionX(Mathf.Clamp(self.position.x, min, max));
        }

        /// <summary>
        /// Clamps the world space position y between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampPositionY(this Transform self, float min, float max)
        {
            return self.SetPositionY(Mathf.Clamp(self.position.y, min, max));
        }

        /// <summary>
        /// Clamps the world space position z between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampPositionZ(this Transform self, float min, float max)
        {
            return self.SetPositionZ(Mathf.Clamp(self.position.z, min, max));
        }

        #endregion

        #region localPosition

        /// <summary>
        /// Set position x of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalPositionX(this Transform self, float x)
        {
            var localPosition = self.localPosition;
            self.localPosition = localPosition.SetX(x);
            return self;
        }

        /// <summary>
        /// Set position y of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalPositionY(this Transform self, float y)
        {
            var localPosition = self.localPosition;
            self.localPosition = localPosition.SetY(y);
            return self;
        }

        /// <summary>
        /// Set position z of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalPositionZ(this Transform self, float z)
        {
            var localPosition = self.localPosition;
            self.localPosition = localPosition.SetZ(z);
            return self;
        }

        /// <summary>
        /// Add position x of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalPositionX(this Transform self, float x)
        {
            return self.SetLocalPositionX(self.localPosition.x + x);
        }

        /// <summary>
        /// Add position y of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalPositionY(this Transform self, float y)
        {
            return self.SetLocalPositionY(self.localPosition.y + y);
        }

        /// <summary>
        /// Add position z of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalPositionZ(this Transform self, float z)
        {
            return self.SetLocalPositionZ(self.localPosition.z + z);
        }

        /// <summary>
        /// Multiply position x of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalPositionX(this Transform self, float x)
        {
            return self.SetLocalPositionX(self.position.x * x);
        }

        /// <summary>
        /// Multiply position y of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalPositionY(this Transform self, float y)
        {
            return self.SetLocalPositionY(self.position.y * y);
        }

        /// <summary>
        /// Multiply position z of the transform relative to the parent transform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalPositionZ(this Transform self, float z)
        {
            return self.SetLocalPositionZ(self.position.z * z);
        }

        /// <summary>
        /// Clamps position x of the transform relative to the parent between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalPositionX(this Transform self, float min, float max)
        {
            return self.SetLocalPositionX(Mathf.Clamp(self.localPosition.x, min, max));
        }

        /// <summary>
        /// Clamps position y of the transform relative to the parent between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalPositionY(this Transform self, float min, float max)
        {
            return self.SetLocalPositionY(Mathf.Clamp(self.localPosition.y, min, max));
        }

        /// <summary>
        /// Clamps position z of the transform relative to the parent between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalPositionZ(this Transform self, float min, float max)
        {
            return self.SetLocalPositionZ(Mathf.Clamp(self.localPosition.z, min, max));
        }

        #endregion

        #region eulerAngles

        /// <summary>
        /// Set the rotation x as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetEulerAngleX(this Transform self, float x)
        {
            var eulerAngles = self.eulerAngles;
            self.eulerAngles = eulerAngles.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the rotation y as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetEulerAngleY(this Transform self, float y)
        {
            var eulerAngles = self.eulerAngles;
            self.eulerAngles = eulerAngles.SetY(y);
            return self;
        }

        /// <summary>
        /// Set the rotation z as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetEulerAngleZ(this Transform self, float z)
        {
            var eulerAngles = self.eulerAngles;
            self.eulerAngles = eulerAngles.SetZ(z);
            return self;
        }

        /// <summary>
        /// Add the rotation x as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddEulerAngleX(this Transform self, float x)
        {
            return self.SetEulerAngleX(self.eulerAngles.x + x);
        }

        /// <summary>
        /// Add the rotation y as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddEulerAngleY(this Transform self, float y)
        {
            return self.SetEulerAngleY(self.eulerAngles.y + y);
        }

        /// <summary>
        /// Add the rotation z as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddEulerAngleZ(this Transform self, float z)
        {
            return self.SetEulerAngleZ(self.eulerAngles.z + z);
        }

        /// <summary>
        /// Multiply the rotation x as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyEulerAngleX(this Transform self, float x)
        {
            return self.SetEulerAngleX(self.eulerAngles.x * x);
        }

        /// <summary>
        /// Multiply the rotation y as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyEulerAngleY(this Transform self, float y)
        {
            return self.SetEulerAngleY(self.eulerAngles.y * y);
        }

        /// <summary>
        /// Multiply the rotation z as Euler angles in degrees.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyEulerAngleZ(this Transform self, float z)
        {
            return self.SetEulerAngleZ(self.eulerAngles.z * z);
        }

        /// <summary>
        /// Clamps the rotation x as Euler angles in degrees between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampEulerAngleX(this Transform self, float min, float max)
        {
            return self.SetEulerAngleX(Mathf.Clamp(self.eulerAngles.x, min, max));
        }

        /// <summary>
        /// Clamps the rotation y as Euler angles in degrees between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampEulerAngleY(this Transform self, float min, float max)
        {
            return self.SetEulerAngleY(Mathf.Clamp(self.eulerAngles.y, min, max));
        }

        /// <summary>
        /// Clamps the rotation z as Euler angles in degrees between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampEulerAngleZ(this Transform self, float min, float max)
        {
            return self.SetEulerAngleZ(Mathf.Clamp(self.eulerAngles.z, min, max));
        }

        #endregion

        #region localEulerAngles

        /// <summary>
        /// Set the rotation x as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalEulerAngleX(this Transform self, float x)
        {
            var localEulerAngles = self.localEulerAngles;
            self.localEulerAngles = localEulerAngles.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the rotation y as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalEulerAngleY(this Transform self, float y)
        {
            var localEulerAngles = self.localEulerAngles;
            self.localEulerAngles = localEulerAngles.SetY(y);
            return self;
        }

        /// <summary>
        /// Set the rotation z as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalEulerAngleZ(this Transform self, float z)
        {
            var localEulerAngles = self.localEulerAngles;
            self.localEulerAngles = localEulerAngles.SetZ(z);
            return self;
        }

        /// <summary>
        /// Add the rotation x as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalEulerAngleX(this Transform self, float x)
        {
            return self.SetLocalEulerAngleX(self.localEulerAngles.x + x);
        }

        /// <summary>
        /// Add the rotation y as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalEulerAngleY(this Transform self, float y)
        {
            return self.SetLocalEulerAngleY(self.localEulerAngles.y + y);
        }

        /// <summary>
        /// Add the rotation z as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalEulerAngleZ(this Transform self, float z)
        {
            return self.SetLocalEulerAngleZ(self.localEulerAngles.z + z);
        }

        /// <summary>
        /// Multiply the rotation x as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalEulerAngleX(this Transform self, float x)
        {
            return self.SetLocalEulerAngleX(self.localEulerAngles.x * x);
        }

        /// <summary>
        /// Multiply the rotation y as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalEulerAngleY(this Transform self, float y)
        {
            return self.SetLocalEulerAngleY(self.localEulerAngles.y * y);
        }

        /// <summary>
        /// Multiply the rotation z as Euler angles in degrees relative to the parent transform's rotation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalEulerAngleZ(this Transform self, float z)
        {
            return self.SetLocalEulerAngleZ(self.localEulerAngles.z * z);
        }

        /// <summary>
        /// Clamps the rotation x as Euler angles in degrees relative to the parent transform's rotation between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalEulerAngleX(this Transform self, float min, float max)
        {
            return self.SetLocalEulerAngleX(Mathf.Clamp(self.localEulerAngles.x, min, max));
        }

        /// <summary>
        /// Clamps the rotation y as Euler angles in degrees relative to the parent transform's rotation between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalEulerAngleY(this Transform self, float min, float max)
        {
            return self.SetLocalEulerAngleY(Mathf.Clamp(self.localEulerAngles.y, min, max));
        }

        /// <summary>
        /// Clamps the rotation z as Euler angles in degrees relative to the parent transform's rotation between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalEulerAngleZ(this Transform self, float min, float max)
        {
            return self.SetLocalEulerAngleZ(Mathf.Clamp(self.localEulerAngles.z, min, max));
        }

        #endregion

        #region localScale

        /// <summary>
        /// Set the scale x of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalScaleX(this Transform self, float x)
        {
            var localScale = self.localScale;
            self.localScale = localScale.SetX(x);
            return self;
        }

        /// <summary>
        /// Set the scale y of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalScaleY(this Transform self, float y)
        {
            var localScale = self.localScale;
            self.localScale = localScale.SetY(y);
            return self;
        }

        /// <summary>
        /// Set the scale z of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Set value.</param>
        /// <returns>Set result.</returns>
        public static Transform SetLocalScaleZ(this Transform self, float z)
        {
            var localScale = self.localScale;
            self.localScale = localScale.SetZ(z);
            return self;
        }

        /// <summary>
        /// Add the scale x of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalScaleX(this Transform self, float x)
        {
            return self.SetLocalScaleX(self.localScale.x + x);
        }

        /// <summary>
        /// Add the scale y of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalScaleY(this Transform self, float y)
        {
            return self.SetLocalScaleY(self.localScale.y + y);
        }

        /// <summary>
        /// Add the scale z of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Add value.</param>
        /// <returns>Add result.</returns>
        public static Transform AddLocalScaleZ(this Transform self, float z)
        {
            return self.SetLocalScaleZ(self.localScale.z + z);
        }

        /// <summary>
        /// Multiply the scale x of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalScaleX(this Transform self, float x)
        {
            return self.SetLocalScaleX(self.localScale.x * x);
        }

        /// <summary>
        /// Multiply the scale y of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalScaleY(this Transform self, float y)
        {
            return self.SetLocalScaleY(self.localScale.y * y);
        }

        /// <summary>
        /// Multiply the scale z of the transform relative to the GameObjects parent.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static Transform MultiplyLocalScaleZ(this Transform self, float z)
        {
            return self.SetLocalScaleZ(self.localScale.z * z);
        }

        /// <summary>
        /// Clamps the scale x of the transform relative to the GameObjects parent between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalScaleX(this Transform self, float min, float max)
        {
            return self.SetLocalScaleX(Mathf.Clamp(self.localScale.x, min, max));
        }

        /// <summary>
        /// Clamps the scale y of the transform relative to the GameObjects parent between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalScaleY(this Transform self, float min, float max)
        {
            return self.SetLocalScaleY(Mathf.Clamp(self.localScale.y, min, max));
        }

        /// <summary>
        /// Clamps the scale z of the transform relative to the GameObjects parent between the given minimum float and maximum float values. Returns the given value if it is within the minimum and maximum range.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="min">The minimum floating point value to compare against.</param>
        /// <param name="max">The maximum floating point value to compare against.</param>
        /// <returns>Clamp result.</returns>
        public static Transform ClampLocalScaleZ(this Transform self, float min, float max)
        {
            return self.SetLocalScaleZ(Mathf.Clamp(self.localScale.z, min, max));
        }

        #endregion

        #region Translate

        /// <summary>
        /// Moves the transform in the direction x and distance of translation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Value along the x axis.</param>
        /// <param name="space">If relativeTo is left out or set to Space.Self the movement is applied relative to the transform's local axes. (the x, y and z axes shown when selecting the object inside the Scene View.) If relativeTo is Space.World the movement is applied relative to the world coordinate system.</param>
        /// <returns>Move result.</returns>
        public static Transform TranslateX(this Transform self, float x, Space space = Space.Self)
        {
            self.Translate(x, 0.0f, 0.0f, space);
            return self;
        }

        /// <summary>
        /// Moves the transform in the direction y and distance of translation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Value along the y axis.</param>
        /// <param name="space">If relativeTo is left out or set to Space.Self the movement is applied relative to the transform's local axes. (the x, y and z axes shown when selecting the object inside the Scene View.) If relativeTo is Space.World the movement is applied relative to the world coordinate system.</param>
        /// <returns>Move result.</returns>
        public static Transform TranslateY(this Transform self, float y, Space space = Space.Self)
        {
            self.Translate(0.0f, y, 0.0f, space);
            return self;
        }

        /// <summary>
        /// Moves the transform in the direction z and distance of translation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Value along the z axis.</param>
        /// <param name="space">If relativeTo is left out or set to Space.Self the movement is applied relative to the transform's local axes. (the x, y and z axes shown when selecting the object inside the Scene View.) If relativeTo is Space.World the movement is applied relative to the world coordinate system.</param>
        /// <returns>Move result.</returns>
        public static Transform TranslateZ(this Transform self, float z, Space space = Space.Self)
        {
            self.Translate(0.0f, 0.0f, z, space);
            return self;
        }

        /// <summary>
        /// Moves the transform in the direction x and distance of translation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="x">Value along the x axis.</param>
        /// <param name="relativeTo">The movement is applied relative to relativeTo's local coordinate system. If relativeTo is null, the movement is applied relative to the world coordinate system.</param>
        /// <returns>Move result.</returns>
        public static Transform TranslateX(this Transform self, float x, Transform relativeTo)
        {
            self.Translate(x, 0.0f, 0.0f, relativeTo);
            return self;
        }

        /// <summary>
        /// Moves the transform in the direction y and distance of translation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="y">Value along the y axis.</param>
        /// <param name="relativeTo">The movement is applied relative to relativeTo's local coordinate system. If relativeTo is null, the movement is applied relative to the world coordinate system.</param>
        /// <returns>Move result.</returns>
        public static Transform TranslateY(this Transform self, float y, Transform relativeTo)
        {
            self.Translate(0.0f, y, 0.0f, relativeTo);
            return self;
        }

        /// <summary>
        /// Moves the transform in the direction z and distance of translation.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <param name="z">Value along the z axis.</param>
        /// <param name="relativeTo">The movement is applied relative to relativeTo's local coordinate system. If relativeTo is null, the movement is applied relative to the world coordinate system.</param>
        /// <returns>Move result.</returns>
        public static Transform TranslateZ(this Transform self, float z, Transform relativeTo)
        {
            self.Translate(0.0f, 0.0f, z, relativeTo);
            return self;
        }

        #endregion

        /// <summary>
        /// Convert to RectTransform.
        /// </summary>
        /// <param name="self">Self transform.</param>
        /// <returns>Convert result.</returns>
        public static RectTransform ToRectTransform(this Transform self)
        {
            return self as RectTransform;
        }
    }
}