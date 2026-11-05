using System.Runtime.InteropServices;

namespace HomeworkWindowsAppLesson1
{

    internal static class Program
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, int type);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Task 1
            MessageBox(IntPtr.Zero, "My name is Alexey", "About Me", 0);
            MessageBox(IntPtr.Zero, "I'm learning C#", "About me 2", 0);
            MessageBox(IntPtr.Zero, "This example of Windows Api", "About Me 3", 0);

            //Task 2
            const uint WM_SETTEXT = 0x000C;
            const uint WM_CLOSE = 0x0010;

            IntPtr targetWindow = FindWindow(null, "Old Title");
            if (targetWindow != IntPtr.Zero)
            {
                SendMessage(targetWindow, WM_SETTEXT, IntPtr.Zero, "New Title");
            }

            SendMessage(targetWindow, WM_CLOSE, IntPtr.Zero, null);

            //Task 3
            Beep(500, 300);
            
            Beep(700, 300);


            
        }
    }
}