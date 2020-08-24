using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnhancedPainter
{
    public partial class PainterForm : Form
    {
        bool ShouldPaint { get; set; } = false; // Whether to paint
        //private ColorOption Color { get; set; };

        public PainterForm()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // Should paint when mouse button is pressed down
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;

        }

        // stop painting when the mouse button is released
        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint) // Check if mouse button is being pressed 
            {
                // Draw where the mouse pointer is present
                using (Graphics graphics = drawingPanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
                }
            }
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void colorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SizeGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
