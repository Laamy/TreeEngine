namespace TreeGraphics.Structs
{
    public struct Vector2
    {
        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public float x, y;

        #region Operators

        public static Vector2 operator -(Vector2 a) => new Vector2(-a.x, -a.y);

        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.x + b.x, a.y + b.y);
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.x - b.x, a.y - b.y);
        public static Vector2 operator *(Vector2 a, float b) => new Vector2(a.x * b, a.y * b);
        public static Vector2 operator *(float a, Vector2 b) => new Vector2(b.x * a, b.y * a);
        public static Vector2 operator /(Vector2 a, float b) => new Vector2(a.x / b, a.y / b);

        #region Equal

        public static bool operator ==(Vector2 fdsgb, Vector2 dbfg)
        {
            float x = fdsgb.x - dbfg.x;
            float y = fdsgb.y - dbfg.y;
            return (x == 0 && y == 0);
        }
        public static bool operator !=(Vector2 fdsgb, Vector2 dbfg) => !(fdsgb == dbfg);

        #endregion

        #endregion
    }
}
