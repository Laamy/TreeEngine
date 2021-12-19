using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraphics.Structs
{
    public struct Rectangle
    {
        public Rectangle(Vector2 pos, Vector2 size)
        {
            this.w = pos.x;
            this.x = pos.x - size.x;
            this.y = pos.y;
            this.z = pos.y - size.y;
        }
        public Rectangle(float w = 0, float x = 0, float y = 0, float z = 0)
        {
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float w, x, y, z;
    }
}
