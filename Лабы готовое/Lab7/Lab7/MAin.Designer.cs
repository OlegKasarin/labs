namespace Lab7
{
    partial class Main
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
            this.rtbAllProcesses = new System.Windows.Forms.RichTextBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFirstProcess = new System.Windows.Forms.ComboBox();
            this.cbSecondProcess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbAllProcesses
            // 
            this.rtbAllProcesses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbAllProcesses.Location = new System.Drawing.Point(0, 155);
            this.rtbAllProcesses.Name = "rtbAllProcesses";
            this.rtbAllProcesses.ReadOnly = true;
            this.rtbAllProcesses.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAllProcesses.Size = new System.Drawing.Size(469, 499);
            this.rtbAllProcesses.TabIndex = 0;
            this.rtbAllProcesses.Text = "";
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOn.Location = new System.Drawing.Point(16, 88);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(441, 61);
            this.btnOn.TabIndex = 1;
            this.btnOn.Text = "Run process";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who is in command:";
            // 
            // cbFirstProcess
            // 
            this.cbFirstProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirstProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFirstProcess.FormattingEnabled = true;
            this.cbFirstProcess.Items.AddRange(new object[] {
            "calc",
            "notepad",
            "cmd"});
            this.cbFirstProcess.Location = new System.Drawing.Point(201, 12);
            this.cbFirstProcess.Name = "cbFirstProcess";
            this.cbFirstProcess.Size = new System.Drawing.Size(256, 32);
            this.cbFirstProcess.TabIndex = 3;
            // 
            // cbSecondProcess
            // 
            this.cbSecondProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecondProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSecondProcess.FormattingEnabled = true;
            this.cbSecondProcess.Items.AddRange(new object[] {
            "calc",
            "notepad",
            "cmd"});
            this.cbSecondProcess.Location = new System.Drawing.Point(201, 50);
            this.cbSecondProcess.Name = "cbSecondProcess";
            this.cbSecondProcess.Size = new System.Drawing.Size(256, 32);
            this.cbSecondProcess.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Who submits:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 654);
            this.Controls.Add(this.cbSecondProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFirstProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.rtbAllProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processes BSUiR Lab7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAllProcesses;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFirstProcess;
        private System.Windows.Forms.ComboBox cbSecondProcess;
        private System.Windows.Forms.Label label2;
    }
}

