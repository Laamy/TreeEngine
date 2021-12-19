using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraphics.Keymap
{
    public class Keymap
    {
        [DllImport("user32.dll")] static extern bool GetAsyncKeyState(char v);

        public static bool isKeyDown(char key) => GetAsyncKeyState(key);
        public static bool isKeyUp(char key) => !isKeyDown(key);
    }
}
