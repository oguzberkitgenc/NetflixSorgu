using System.Runtime.InteropServices;

namespace NetflixSorgu
{
    public class MouseOlaylari
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public static void SolMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sol Tıkladı
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            //Sol Bıraktı
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
    }
}
