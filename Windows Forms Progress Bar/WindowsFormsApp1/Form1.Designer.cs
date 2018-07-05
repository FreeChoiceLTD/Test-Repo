namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContinous = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnMarquee = new System.Windows.Forms.Button();
            this.tbValueProgress = new System.Windows.Forms.TextBox();
            this.tbDisplaySize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinous
            // 
            this.btnContinous.Location = new System.Drawing.Point(23, 187);
            this.btnContinous.Name = "btnContinous";
            this.btnContinous.Size = new System.Drawing.Size(75, 23);
            this.btnContinous.TabIndex = 0;
            this.btnContinous.Text = "Continous";
            this.btnContinous.UseVisualStyleBackColor = true;
            this.btnContinous.Click += new System.EventHandler(this.btnContinous_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 31);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // btnMarquee
            // 
            this.btnMarquee.Location = new System.Drawing.Point(153, 187);
            this.btnMarquee.Name = "btnMarquee";
            this.btnMarquee.Size = new System.Drawing.Size(75, 23);
            this.btnMarquee.TabIndex = 2;
            this.btnMarquee.Text = "Marquee";
            this.btnMarquee.UseVisualStyleBackColor = true;
            this.btnMarquee.Click += new System.EventHandler(this.btnMarquee_Click);
            // 
            // tbValueProgress
            // 
            this.tbValueProgress.Location = new System.Drawing.Point(12, 113);
            this.tbValueProgress.Name = "tbValueProgress";
            this.tbValueProgress.Size = new System.Drawing.Size(260, 20);
            this.tbValueProgress.TabIndex = 3;
            // 
            // tbDisplaySize
            // 
            this.tbDisplaySize.Location = new System.Drawing.Point(12, 25);
            this.tbDisplaySize.Name = "tbDisplaySize";
            this.tbDisplaySize.Size = new System.Drawing.Size(260, 20);
            this.tbDisplaySize.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbDisplaySize);
            this.Controls.Add(this.tbValueProgress);
            this.Controls.Add(this.btnMarquee);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnContinous);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinous;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnMarquee;
        private System.Windows.Forms.TextBox tbValueProgress;
        private System.Windows.Forms.TextBox tbDisplaySize;
    }
}

