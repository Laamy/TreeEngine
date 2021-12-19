using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeGraphics.Structs;

namespace TreeGraphics.Premade.Visual
{
    public class Camera
    {
        public Vector3 transform = new Vector3();
        public Vector3 rotations = new Vector3();

        public float fieldOfView = 1;
        public int viewScale = 2;
    }
}
