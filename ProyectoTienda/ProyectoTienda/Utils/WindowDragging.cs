using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoTienda.Utils
{
    public class WindowDragging
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void ApplyWindowDragging(Control control)
        {
            ReleaseCapture();
            SendMessage(control.Handle, 0x112, 0xf012, 0);
        }
    }
}
