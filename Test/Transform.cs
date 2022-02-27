using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020ne.Test
{
    public class Transform
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Transform(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
