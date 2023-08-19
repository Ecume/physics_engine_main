using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public static readonly Vector Zero = new Vector(0f, 0f);

        // Vector addittion
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        //Vector subtraction
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        //Vector sign change
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        //Vector multiplication
        public static Vector operator *(Vector v, float scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        //Vector division
        public static Vector operator /(Vector v, float scalar)
        {
            return new Vector(v.X / scalar, v.Y / scalar);
        }

        //Vector equality check
        public bool Equal(Vector other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        //Vector equality check
        public override bool Equals(object obj)
        {
            if(obj is Vector other )
            {
                return this.Equal(other);
            }
            
            return false;
        }

        //Get hashcode for vector
        public override int GetHashCode()
        {
            return new { this.X, this.Y }.GetHashCode();

        }

        //Use hashcode to convert vector to string
        public override string ToString()
        {
            return $"X: {this.X}, Y: {this.Y}";
        }

    } 
}
