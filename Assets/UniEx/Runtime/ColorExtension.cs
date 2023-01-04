using UnityEngine;

namespace UniEx
{
    public static class ColorExtension
    {
        /// <summary>
        /// Set r component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="r">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Color SetR(this ref Color self, float r)
        {
            self.r = r;
            return ref self;
        }

        /// <summary>
        /// Set g component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="g">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Color SetG(this ref Color self, float g)
        {
            self.g = g;
            return ref self;
        }

        /// <summary>
        /// Set b component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="b">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Color SetB(this ref Color self, float b)
        {
            self.b = b;
            return ref self;
        }

        /// <summary>
        /// Set a component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="a">Set value.</param>
        /// <returns>Set result.</returns>
        public static ref Color SetA(this ref Color self, float a)
        {
            self.a = a;
            return ref self;
        }

        /// <summary>
        /// Add r component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="r">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Color AddR(this ref Color self, float r)
        {
            return ref self.SetR(self.r + r);
        }

        /// <summary>
        /// Add g component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="g">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Color AddG(this ref Color self, float g)
        {
            return ref self.SetG(self.g + g);
        }

        /// <summary>
        /// Add b component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="b">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Color AddB(this ref Color self, float b)
        {
            return ref self.SetB(self.b + b);
        }

        /// <summary>
        /// Add a component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="a">Add value.</param>
        /// <returns>Add result.</returns>
        public static ref Color AddA(this ref Color self, float a)
        {
            return ref self.SetA(self.a + a);
        }

        /// <summary>
        /// Multiply r component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="r">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Color MultiplyR(this ref Color self, float r)
        {
            return ref self.SetR(self.r * r);
        }

        /// <summary>
        /// Multiply g component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="g">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Color MultiplyG(this ref Color self, float g)
        {
            return ref self.SetG(self.g * g);
        }

        /// <summary>
        /// Multiply b component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="b">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Color MultiplyB(this ref Color self, float b)
        {
            return ref self.SetB(self.b * b);
        }

        /// <summary>
        /// Multiply a component of an existing Color.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <param name="a">Multiply value.</param>
        /// <returns>Multiply result.</returns>
        public static ref Color MultiplyA(this ref Color self, float a)
        {
            return ref self.SetA(self.a * a);
        }

        /// <summary>
        /// Convert to Tuple.
        /// </summary>
        /// <param name="self">Self color.</param>
        /// <returns>Convert result.</returns>
        public static (float r, float g, float b, float a) ToTuple(this Color self)
        {
            return (self.r, self.g, self.b, self.a);
        }
    }
}