using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace physics_engine_main

{
    public readonly struct Vector
    {
        public readonly float X;
        public readonly float Y;

        public Vector(float x, float y)
        {
            this.X = x;
            this.Y = y;

        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
    } 
}
