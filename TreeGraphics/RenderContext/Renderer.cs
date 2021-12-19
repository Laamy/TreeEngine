using TreeGraphics.Structs;
using Rectangle = TreeGraphics.Structs.Rectangle;

namespace TreeGraphics.RenderContext
{
    public class Renderer
    {
        System.Drawing.Bitmap frame;

        public Vector2 size;
        public float framerate = 60;

        public void StartDrawing()
        {
            frame = new System.Drawing.Bitmap((int)size.x, (int)size.y);
        }

        public Vector2 GetSizeByRect(Rectangle rect)
        {
            Vector2 size = new Vector2();
            // w, x, y, z
            size.x = rect.x - rect.w;
            size.y = rect.y - rect.z;

            return size;
        }
        public Vector2 GetPosByRect(Rectangle rect)
        {
            Vector2 pos = new Vector2();

            pos.x = rect.x;
            pos.y = rect.y;

            return pos;
        }

        public void FillRectangle(Vector2 pos, Vector2 size, System.Drawing.Color colour)
        {
            for (int x = (int)pos.x; x < (pos.x + size.x); x++)
            {
                for (int y = (int)pos.y; y < (pos.y + size.y); y++)
                {
                    Draw(new Vector2(x, y), colour);
                    //frame.SetPixel(x, y, colour);
                }
            }
        }

        public void Draw(Vector2 pos, System.Drawing.Color colour) => frame.SetPixel((int)pos.x, (int)pos.y, colour);

        public System.Drawing.Bitmap EndDrawing()
        {
            return frame;
        }
    }
}
