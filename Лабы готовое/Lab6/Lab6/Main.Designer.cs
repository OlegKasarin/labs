namespace Lab6
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
            this.btnRunNotepad = new System.Windows.Forms.Button();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunNotepad
            // 
            this.btnRunNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunNotepad.Location = new System.Drawing.Point(12, 12);
            this.btnRunNotepad.Name = "btnRunNotepad";
            this.btnRunNotepad.Size = new System.Drawing.Size(198, 65);
            this.btnRunNotepad.TabIndex = 0;
            this.btnRunNotepad.Text = "Run notepad";
            this.btnRunNotepad.UseVisualStyleBackColor = true;
            this.btnRunNotepad.Click += new System.EventHandler(this.btnRunNotepad_Click);
            // 
            // rtbMain
            // 
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMain.Location = new System.Drawing.Point(12, 83);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMain.Size = new System.Drawing.Size(280, 328);
            this.rtbMain.TabIndex = 1;
            this.rtbMain.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(216, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 65);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 423);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.btnRunNotepad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hook BSUiR lab6";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunNotepad;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Button btnClear;
    }
}

