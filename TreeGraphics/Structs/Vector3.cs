namespace TreeGraphics.Structs
{
    public struct Vector3
    {
        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float x, y, z;

        #region Operators

        public static Vector3 operator -(Vector3 a) => new Vector3(-a.x, -a.y, -a.z);

        public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector3 operator -(Vector3 a, Vector3 b) => new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector3 operator *(Vector3 a, float b) => new Vector3(a.x * b, a.y * b, a.z * b);
        public static Vector3 operator *(float a, Vector3 b) => new Vector3(b.x * a, b.y * a, b.z * a);
        public static Vector3 operator /(Vector3 a, float b) => new Vector3(a.x / b, a.y / b, a.z / b);

        #region Equal

        public static bool operator ==(Vector3 fdsgb, Vector3 dbfg)
        {
            float x = fdsgb.x - dbfg.x;
            float y = fdsgb.y - dbfg.y;
            float z = fdsgb.z - dbfg.z;
            return (x == 0 && y == 0 && z == 0);
        }
        public static bool operator !=(Vector3 fdsgb, Vector3 dbfg) => !(fdsgb == dbfg);

        #endregion

        #endregion
    }
}
