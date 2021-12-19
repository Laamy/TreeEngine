using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGraphics.Keymap;
using TreeGraphics.RenderContext;
using TreeGraphics.Structs;

namespace TreeEngine
{
    public partial class Form1 : Form
    {
        CRenderer renderer = new CRenderer();
        int pastFrames = 0;
        int FPS = 0;

        public Form1()
        {
            InitializeComponent();

            renderer.camera.transform.x = 25;
            renderer.camera.transform.y = 64;

            Task.Factory.StartNew(() => {
                while (true)
                {
                    Thread.Sleep(renderer.frameDelay);
                    Update();
                    pastFrames++;
                }
            });

            Task.Factory.StartNew(() => {
                while (true)
                {
                    Thread.Sleep(250);
                    FPS = pastFrames * 4;
                    pastFrames = 0;
                }
            });
        }

        private void Update()
        {
            renderer.size.x = Width;
            renderer.size.y = Height;

            if (Keymap.isKeyDown('S')) renderer.camera.transform.y++;
            if (Keymap.isKeyDown('W')) renderer.camera.transform.y--;

            if (Keymap.isKeyDown('D')) renderer.camera.transform.x++;
            if (Keymap.isKeyDown('A')) renderer.camera.transform.x--;

            renderer.StartDrawing();

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    renderer.FillRectangle(new Vector2((50 + (x * 12)) * renderer.camera.viewScale, (50 + (y * 12)) * renderer.camera.viewScale), new Vector2(10 * renderer.camera.viewScale, 10 * renderer.camera.viewScale), Color.Red);
                }
            }

            var pos = new Vector2(renderer.camera.transform.x * renderer.camera.viewScale, renderer.camera.transform.y * renderer.camera.viewScale);
            pos -= new Vector2(5 * renderer.camera.viewScale, 5 * renderer.camera.viewScale);
            renderer.FillRectangle(pos, new Vector2(10 * renderer.camera.viewScale, 10 * renderer.camera.viewScale), Color.Blue);

            frameDisplay.Image = renderer.EndDrawing();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = $"FPS: {FPS}, XYZ: {renderer.camera.transform.x}, {renderer.camera.transform.y}, {renderer.camera.transform.z}";
        }

        private void exitBtn_Click(object sender, EventArgs e) => Process.GetCurrentProcess().Kill();

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderer.camera.viewScale = int.Parse(viewscaleTxt.Text);
        }
    }
}
