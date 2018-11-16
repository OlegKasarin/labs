using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Main : Form
    {
        // Global values
        bool startPaint = false;
        Graphics graphics;
        // nullable int for storing Null value
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        bool drawPolygon = false;
        bool drawElipse = false;
        bool drawText = false;

        // Point of entry
        public Main()
        {
            InitializeComponent();
            // Init graphic object in panel
            graphics = pnlDraw.CreateGraphics();
            // Init other object
            nudPencilThickness.Value = 1;
            nudShapesSize.Value = 30;
        }

        // Close application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        // Allotment current button
        public void OffButton(Button btn) => btn.Enabled = false;

        // Erase button
        public void OnButton(Button btn) => btn.Enabled = true;

        // Enable drawing cicle shapes
        private void btnCircle_Click(object sender, EventArgs e)
        {
            if (drawCircle)
            {
                drawCircle = false;

                OnButton(btnRectangle);
                OnButton(btnSquare);
                OnButton(btnElipse);
                OnButton(btnPolygon);
                OnButton(btnText);
            }
            else
            {
                drawCircle = true;                
                startPaint = false;

                OffButton(btnRectangle);
                OffButton(btnSquare);
                OffButton(btnElipse);
                OffButton(btnPolygon);
                OffButton(btnText);
            }
        }

        // Enable drawing rectangle shapes
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            if (drawRectangle)
            {
                drawRectangle = false;

                OnButton(btnCircle);
                OnButton(btnSquare);
                OnButton(btnElipse);
                OnButton(btnPolygon);
                OnButton(btnText);
            }
            else
            {
                drawRectangle = true;
                startPaint = false;

                OffButton(btnCircle);
                OffButton(btnSquare);
                OffButton(btnElipse);
                OffButton(btnPolygon);
                OffButton(btnText);
            }
        }

        // Enable drawing square shapes
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (drawSquare)
            {
                drawSquare = false;

                OnButton(btnCircle);
                OnButton(btnRectangle);
                OnButton(btnElipse);
                OnButton(btnPolygon);
                OnButton(btnText);
            }
            else
            {
                drawSquare = true;
                startPaint = false;

                OffButton(btnCircle);
                OffButton(btnRectangle);
                OffButton(btnElipse);
                OffButton(btnPolygon);
                OffButton(btnText);
            }
        }

        // Enable drawing polygon shapes
        private void btnPolygon_Click(object sender, EventArgs e)
        {
            if (drawPolygon)
            {
                drawPolygon = false;

                OnButton(btnCircle);
                OnButton(btnRectangle);
                OnButton(btnElipse);
                OnButton(btnSquare);
                OnButton(btnText);
            }
            else
            {
                drawPolygon = true;
                startPaint = false;

                OffButton(btnCircle);
                OffButton(btnRectangle);
                OffButton(btnElipse);
                OffButton(btnSquare);
                OffButton(btnText);
            }
        }

        // Enable drawing elipse shapes
        private void btnElipse_Click(object sender, EventArgs e)
        {
            if (drawElipse)
            {
                drawElipse = false;

                OnButton(btnCircle);
                OnButton(btnRectangle);
                OnButton(btnPolygon);
                OnButton(btnSquare);
                OnButton(btnText);
            }
            else
            {
                drawElipse = true;
                startPaint = false;

                OffButton(btnCircle);
                OffButton(btnRectangle);
                OffButton(btnPolygon);
                OffButton(btnSquare);
                OffButton(btnText);
            }
        }

        // Enable drawing text shapes
        private void btnText_Click(object sender, EventArgs e)
        {
            if (drawText)
            {
                drawText = false;

                OnButton(btnCircle);
                OnButton(btnRectangle);
                OnButton(btnPolygon);
                OnButton(btnSquare);
                OnButton(btnElipse);
            }
            else
            {
                drawText = true;
                startPaint = false;

                OffButton(btnCircle);
                OffButton(btnRectangle);
                OffButton(btnPolygon);
                OffButton(btnSquare);
                OffButton(btnElipse);
            }
        }

        // Event fired when the mouse pointer is moved over the Panel(pnl_Draw).
        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawText && startPaint)
            {
                // Setting the Pen BackColor and line Width
                Pen pen = new Pen(btnColor.BackColor, float.Parse(nudPencilThickness.Text));
                graphics.DrawLine(pen, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));

                initX = e.X;
                initY = e.Y;
            }
        }

        // Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (!drawSquare && !drawRectangle && !drawCircle && !drawPolygon && !drawElipse)
                startPaint = true;

            // Use Solid Brush for filling the graphic shapes
            SolidBrush solidBrush = new SolidBrush(btnColor.BackColor);

            // Get shape size
            string shapeSize = nudShapesSize.Text;

            if (drawSquare)
            {
                // Setting the width and height same for creating square.
                // Getting the width and Heigt value from Textbox(txt_ShapeSize)
                graphics.FillRectangle(solidBrush, e.X, e.Y, int.Parse(shapeSize), int.Parse(shapeSize));
            }
            if (drawRectangle)
            {
                // Setting the width twice of the height
                graphics.FillRectangle(solidBrush, e.X, e.Y, 2 * int.Parse(shapeSize), int.Parse(shapeSize));
            }
            if (drawCircle)
            {
                graphics.FillEllipse(solidBrush, e.X, e.Y, int.Parse(shapeSize), int.Parse(shapeSize));
            }
            if (drawPolygon)
            {
                Point[] DOWN = new Point[] { new Point(e.X, e.Y), new Point(e.X + 50, e.Y + e.Y), new Point(e.X + 45, e.Y + 45) };
                Point[] UP = new Point[] { new Point(e.X, e.Y + 55), new Point(e.X + 50, e.Y + 55), new Point(e.X + 45, e.Y + 50) };

                graphics.FillPolygon(solidBrush, DOWN);
                graphics.FillPolygon(solidBrush, UP);
            }
            if (drawElipse)
            {
                graphics.DrawEllipse(new Pen(btnColor.BackColor, int.Parse(shapeSize)), new Rectangle(e.X, e.Y, 50, 30));
            }
            if (drawText)
            {
                if (string.IsNullOrEmpty(tbText.Text))
                {
                    MessageBox.Show("Text box is empty");
                }
                else
                {
                    graphics.DrawString(tbText.Text, Font, Brushes.Black, e.X, e.Y);
                }
            }
        }

        // Erase
        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        // Clear draw panel
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            pnlDraw.Invalidate();
            tbText.Clear();
            btnColor.BackColor = Color.Black;
            nudPencilThickness.Value = 1;
            nudShapesSize.Value = 30;
        }

        // Set color
        private void btnColor_Click(object sender, EventArgs e)
        {
            // Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                btnColor.BackColor = colorDialog.Color;
        }        
    }
}