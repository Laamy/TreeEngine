using System.Drawing;
using TreeGraphics.Structs;

namespace TreeGraphics.Objects
{
    public class BoxObj : EmptyObj
    {
        public Color colour;
        public BoxObj(string name, Vector3 pos, Vector3 size, Color colorOfObj) : base(name, pos, size)
        {
            colour = colorOfObj;
        }
    }
}
