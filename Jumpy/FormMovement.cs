using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Jumpy
{
    public partial class FormMovement : Form
    {
        public FormMovement()
        {
            InitializeComponent();
        }

        public Bitmap BitmapL, BitmapR;

        private void FormMovement_Load(object sender, EventArgs e)
        {
 

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            this.BackgroundImage = BitmapR;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            maxX = Screen.FromControl(this).Bounds.Width;


            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            this.Size = new Size(BitmapR.Size.Width, BitmapR.Size.Height);

            timer1.Start();
            this.Location = new Point(0, Screen.FromControl(this).Bounds.Height - GetTaskbarPosition().Height - this.Size.Height);
        }

        public static Rectangle GetTaskbarPosition()
        {
            var data = new APPBARDATA();
            data.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(data);
            IntPtr retval = SHAppBarMessage(ABM_GETTASKBARPOS, ref data);
            if (retval == IntPtr.Zero) throw new Win32Exception("Please re-install Windows");
            return new Rectangle(data.rc.left, data.rc.top,
                data.rc.right - data.rc.left, data.rc.bottom - data.rc.top);

        }

        private const int ABM_GETTASKBARPOS = 5;
        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        private static extern IntPtr SHAppBarMessage(int msg, ref APPBARDATA data);
        private struct APPBARDATA
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }

        private struct RECT
        {
            public int left, top, right, bottom;
        }

        bool LevoDesno = true;
        public int maxX, minX, pomeraj = 1;

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (LevoDesno)
            {
                this.Location = new Point(this.Location.X + pomeraj,
                    Screen.FromControl(this).Bounds.Height - GetTaskbarPosition().Height - this.Size.Height);
                if (this.Location.X >= maxX)
                {
                    LevoDesno = false;
                    this.BackgroundImage = BitmapL;
                    this.Size = new Size(BitmapL.Size.Width, BitmapL.Size.Height);
                }
            }
            else
            {
                this.Location = new Point(this.Location.X - pomeraj,
                    Screen.FromControl(this).Bounds.Height - GetTaskbarPosition().Height - this.Size.Height);
                if (this.Location.X <= minX)
                {
                    LevoDesno = true;
                    this.BackgroundImage = BitmapR;
                    this.Size = new Size(BitmapR.Size.Width, BitmapR.Size.Height);
                }
            }
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    }
}
