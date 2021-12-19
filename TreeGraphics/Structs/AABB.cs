using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraphics.Structs
{
    public struct AABB
    {
        public AABB(Vector3 position, Vector3 size)
        {
            lower = position;
            upper = position + size;
        }
        public Vector3 lower, upper;

        public void Set(Vector3 position, Vector3 size)
        {
            lower = position;
            upper = position + size;
        }
    }
}
