using System.Runtime.InteropServices;

namespace HomeworkWindowsAppLesson1
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, "Form1");
            if (hWnd != IntPtr.Zero)
            {
                SendMessage(hWnd, 0x000C, IntPtr.Zero, "New name of form!");
                
            }
        }
    }
}
