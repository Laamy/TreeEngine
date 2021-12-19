using TreeGraphics.Premade.Visual;
using TreeGraphics.Structs;

namespace TreeGraphics.RenderContext
{
    public class CRenderer
    {
        System.Drawing.Bitmap frame;

        public Camera camera = new Camera();

        public Vector2 size;
        public int frameDelay = 1;

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

            pos.x = rect.w;
            pos.y = rect.y;

            return pos;
        }

        public void FillRectangle(Vector2 pos, Vector2 size, System.Drawing.Color colour)
        {
            for (int x = (int)pos.x; x < (pos.x + size.x); x++)
            {
                for (int y = (int)pos.y; y < (pos.y + size.y); y++)
                {
                    Draw(new Vector2(-camera.transform.x + x + (this.size.x / 2), -camera.transform.y + y + (this.size.y / 2)), colour);
                }
            }
        }

        public void Draw(Vector2 pos, System.Drawing.Color colour)
        {
            try
            {
                if (pos.x >= 0 && pos.y >= 0 && pos.x < size.x && pos.y < size.y)// dont render shit when its not on the screen
                {
                    /*for (int a = (int)pos.x; a < camera.viewScale; a++)
                    {
                        for (int b = (int)pos.y; b < camera.viewScale; b++)
                        {
                            frame.SetPixel((int)pos.x * camera.viewScale + a, (int)pos.y * camera.viewScale + b, colour);
                        }
                    }*/
                    frame.SetPixel((int)pos.x, (int)pos.y, colour);
                }
            }
            catch { }
        }
        public System.Drawing.Bitmap EndDrawing()
        {
            return frame;
        }
    }
}
