using TreeGraphics.Structs;

namespace TreeGraphics.Objects
{
    public abstract class EmptyObj
    {
        public EmptyObj(string name, Vector3 pos, Vector3 size)
        {
            this.name = name;
            position.Set(pos, size);
        }

        public string name;
        public AABB position;
    }
}
