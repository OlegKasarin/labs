using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Main : Form
    {
        Thread thread = null;
        string firstProcessName = "";
        string secondProcessName = "";

        // Constructor with no parameter
        public Main()
        {
            InitializeComponent();
            cbFirstProcess.SelectedIndex = 0;
            cbSecondProcess.SelectedIndex = 1;
        }

        // Form load
        private void Main_Load(object sender, EventArgs e)
        {
            // Get processes list and display
            foreach (Process theprocess in Process.GetProcesses())
            {
                rtbAllProcesses.Text += string.Format("Process: {0} ID: {1}\n", theprocess.ProcessName, theprocess.Id);
            }

            // Run infinity method
            thread = new Thread(RunCalc);
            thread.Start();
        }

        // Infinite method
        public void RunCalc()
        {
            // Infinite loop
            while (true)
            {
                cbFirstProcess.Invoke((MethodInvoker)delegate
                {
                    firstProcessName = cbFirstProcess.Text;
                });
                cbSecondProcess.Invoke((MethodInvoker)delegate
                {
                    secondProcessName = cbSecondProcess.Text;
                });

                // Get object calculator and notepad
                var firstProcess = Process.GetProcesses().Where(x => x.ProcessName.Equals(firstProcessName)).FirstOrDefault();
                var secondProcess = Process.GetProcesses().Where(x => x.ProcessName.Equals(secondProcessName)).FirstOrDefault();

                // If firstProcess was opened -> run secondProcess
                if (firstProcess != null && secondProcess == null)
                    Process.Start(secondProcessName);
                // if firstProcess was closed -> close secondProcess
                else if (firstProcess == null && secondProcess != null)
                {
                    try
                    {
                        Process.GetProcesses().Where(x => x.ProcessName.Equals(secondProcessName)).FirstOrDefault().Kill();
                    }
                    catch (Exception) { }
                }
                // if firstProcess and secondProcess off/on together, continue loop nothing do
                else
                    continue;

                Thread.Sleep(1000);
            }
        }

        // On calculator
        private void btnOn_Click(object sender, EventArgs e)
        {
            Process.Start(cbFirstProcess.Text);
            //cbSecondProcess.Items.Remove(cbFirstProcess.Text);
        }

        // Running when form was closed
        private void Main_FormClosed(object sender, FormClosedEventArgs e) => thread.Abort();
    }
}