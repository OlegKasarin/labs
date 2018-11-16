namespace Lab1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolbox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.panelFigures = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudShapesSize = new System.Windows.Forms.NumericUpDown();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.panelPencil = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPencilThickness = new System.Windows.Forms.NumericUpDown();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelToolbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFigures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapesSize)).BeginInit();
            this.panelPencil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPencilThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelToolbox
            // 
            this.panelToolbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelToolbox.Controls.Add(this.panel1);
            this.panelToolbox.Controls.Add(this.panelFigures);
            this.panelToolbox.Controls.Add(this.panelPencil);
            this.panelToolbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelToolbox.Location = new System.Drawing.Point(0, 24);
            this.panelToolbox.Name = "panelToolbox";
            this.panelToolbox.Size = new System.Drawing.Size(187, 634);
            this.panelToolbox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Location = new System.Drawing.Point(3, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 107);
            this.panel1.TabIndex = 4;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearAll.Location = new System.Drawing.Point(9, 51);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(161, 42);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColor.Location = new System.Drawing.Point(9, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(161, 42);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panelFigures
            // 
            this.panelFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFigures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFigures.Controls.Add(this.tbText);
            this.panelFigures.Controls.Add(this.btnText);
            this.panelFigures.Controls.Add(this.btnElipse);
            this.panelFigures.Controls.Add(this.btnPolygon);
            this.panelFigures.Controls.Add(this.label3);
            this.panelFigures.Controls.Add(this.nudShapesSize);
            this.panelFigures.Controls.Add(this.btnSquare);
            this.panelFigures.Controls.Add(this.btnRectangle);
            this.panelFigures.Controls.Add(this.btnCircle);
            this.panelFigures.Location = new System.Drawing.Point(3, 90);
            this.panelFigures.Name = "panelFigures";
            this.panelFigures.Size = new System.Drawing.Size(177, 417);
            this.panelFigures.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shape size";
            // 
            // nudShapesSize
            // 
            this.nudShapesSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudShapesSize.Location = new System.Drawing.Point(9, 372);
            this.nudShapesSize.Name = "nudShapesSize";
            this.nudShapesSize.Size = new System.Drawing.Size(161, 29);
            this.nudShapesSize.TabIndex = 3;
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSquare.Location = new System.Drawing.Point(9, 99);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(161, 42);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRectangle.Location = new System.Drawing.Point(9, 51);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(161, 42);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCircle.Location = new System.Drawing.Point(9, 3);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(161, 42);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // panelPencil
            // 
            this.panelPencil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPencil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPencil.Controls.Add(this.label4);
            this.panelPencil.Controls.Add(this.nudPencilThickness);
            this.panelPencil.Location = new System.Drawing.Point(3, 3);
            this.panelPencil.Name = "panelPencil";
            this.panelPencil.Size = new System.Drawing.Size(177, 168);
            this.panelPencil.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pencil size";
            // 
            // nudPencilThickness
            // 
            this.nudPencilThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPencilThickness.Location = new System.Drawing.Point(9, 38);
            this.nudPencilThickness.Name = "nudPencilThickness";
            this.nudPencilThickness.Size = new System.Drawing.Size(161, 29);
            this.nudPencilThickness.TabIndex = 1;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(187, 24);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(513, 634);
            this.pnlDraw.TabIndex = 2;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPolygon.Location = new System.Drawing.Point(9, 147);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(161, 42);
            this.btnPolygon.TabIndex = 6;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnElipse.Location = new System.Drawing.Point(9, 195);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(161, 42);
            this.btnElipse.TabIndex = 7;
            this.btnElipse.Text = "Elipse";
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnText
            // 
            this.btnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnText.Location = new System.Drawing.Point(9, 243);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(161, 42);
            this.btnText.TabIndex = 8;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(9, 291);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(161, 29);
            this.tbText.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 658);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.panelToolbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint BSUiR Lab 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelToolbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelFigures.ResumeLayout(false);
            this.panelFigures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapesSize)).EndInit();
            this.panelPencil.ResumeLayout(false);
            this.panelPencil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPencilThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelToolbox;
        private System.Windows.Forms.Panel panelFigures;
        private System.Windows.Forms.Panel panelPencil;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown nudPencilThickness;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudShapesSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnText;
    }
}

