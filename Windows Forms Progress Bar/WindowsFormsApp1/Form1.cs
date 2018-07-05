using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterWindow();
        }

        private void CenterWindow()
        {
            this.StartPosition = FormStartPosition.Manual;
            Size bound = Screen.PrimaryScreen.Bounds.Size;
            this.Left = (bound.Width - this.Width) / 2;
            this.Top = (bound.Height - this.Height) / 2;
        }

        private void btnMarquee_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            progressBar1.Visible = true;

            // Display the ProgressBar control.
            progressBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            progressBar1.Maximum = 50;
            // Set the initial value of the ProgressBar.
            progressBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar1.Step = 1;
            // Set a style
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value = 1;

            // Loop through all files to copy.
            int secs = timer.Elapsed.Seconds;
            while (secs < 5)
            {
                tbValueProgress.Text = $"{secs}";
                // Refresh to visualize
                tbValueProgress.Refresh();

                // Perform the increment on the ProgressBar.
                progressBar1.Value = progressBar1.Value == progressBar1.Maximum
                    ? progressBar1.Minimum
                    : progressBar1.Value + progressBar1.Step;

                // Sleep value controls the animation speed
                Thread.Sleep(35);
                secs = timer.Elapsed.Seconds;
            }

            progressBar1.Value = 1;
            progressBar1.Visible = false;
            timer.Stop();
        }

        private void btnContinous_Click_1(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            progressBar1.Visible = true;

            // Display the ProgressBar control.
            progressBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            progressBar1.Maximum = 100;
            // Set the initial value of the ProgressBar.
            progressBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar1.Step = 1;
            // Set a style
            progressBar1.Style = ProgressBarStyle.Continuous;

            // Loop through all files to copy.
            while (timer.Elapsed.Seconds < 7)
            {
                // Perform the increment on the ProgressBar.
                progressBar1.PerformStep();
            }

            progressBar1.Visible = false;
            timer.Stop();
        }
    }
}
