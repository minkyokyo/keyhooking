using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace AngelInUs
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        Boolean setting = false;
        int min;
        int time = 0;
        public Form1()
        {
            InitializeComponent();
            player.URL = "Step.mp3";
            player.controls.stop();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);
        [DllImport("Kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;

        private LowLevelKeyboardProc _proc = hookProc;
        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
;            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code,IntPtr wParam,IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode.ToString() == "162")
                {
                    MessageBox.Show("You Pressed a CTR");
                }
                return (IntPtr)1;
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnHook();
            player.controls.stop();
            MainLabel.Text = "";
        }


        private void SelectKeyBoardButton_Click(object sender, EventArgs e)
        {
            player.controls.play();
            MainLabel.Text = "즐거운 키보드 청소를 하자";
            timer1.Enabled = true;
            SetHook();
        }

        private void SelectCatButton_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "귀여운 고양이를 막아보자";
            timer1.Enabled = true;
            SetHook();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(setting == true)
            {
                time -= 1;
                if(time<=0)
                {
                    setting = false;
                    time = 0;
                    MessageBox.Show("끝났습니다.");
                }
            }

            //if(progressBar1.Value==100)
            //{
            //    timer1.Enabled = false;
            //}
            //else { progressBar1.Value += 1; }
        }

        private void timeSettingButton_Click(object sender, EventArgs e)
        {
            min = (int)minUpDown.Value;
            for(;min>0;min--)
            {
                time += 1;
            }
            setting = true;
        }
    }
}
