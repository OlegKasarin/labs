using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Main : Form
    {
        private LowLevelKeyboardListener _listener;

        // Constructor with no parameters
        public Main()
        {
            InitializeComponent();
        }

        // Run notepad from computer
        private void btnRunNotepad_Click(object sender, EventArgs e)
        {
            try
            {
                Process Proc = new Process();
                Proc.StartInfo.FileName = "notepad.exe";
                Proc.EnableRaisingEvents = true;

                Proc.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Create new object using DLL
            _listener = new LowLevelKeyboardListener();
            // Hang up the handler for pressing
            _listener.OnKeyPressed += _listener_OnKeyPressed;
            // Run
            _listener.HookKeyboard();
        }

        // Running when user write something by keyboard
        void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            rtbMain.Text += e.KeyPressed.ToString();
        }

        // Removing the hook from the notebook
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _listener.UnHookKeyboard();
        }

        // Clear text box
        private void btnClear_Click(object sender, EventArgs e) => rtbMain.Clear();
    }
}