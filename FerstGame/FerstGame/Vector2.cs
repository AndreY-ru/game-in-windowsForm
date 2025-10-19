using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerstGame
{
    public struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public void Normalize()
        {
            float length = (float)Math.Sqrt(X * X + Y * Y);
            if (length > 0)
            {
                X /= length;
                Y /= length;
            }
        }

        public void SetX(float x)
        {
            X = x;
        }
        public void SetY(float y)
        {
            Y = y;
        }
    }
}
