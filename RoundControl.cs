using demoForWinFormFrame.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{
    public partial class RoundControl : UserControl
    {
        private int radius = 10;
        public int Radius
        {
            get { return radius; }
            set { 
                radius = value;
                Invalidate();
            }
        }
        private SolidBrush backgroundBrush = new SolidBrush(SystemColors.Control);
        private Color backgroundColor = SystemColors.Control;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;

                if (backgroundBrush != null)
                    backgroundBrush.Dispose();

                if (backgroundColor == Color.Transparent)
                    backgroundBrush = null;
                else
                    backgroundBrush = new SolidBrush(backgroundColor);

                Invalidate();
            }
        }
        private Color borderColor = SystemColors.Control;
        private Pen borderPen = new Pen(ControlPaint.Light(SystemColors.Control, 0.0f), 0);

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;

                if (borderPen != null)
                    borderPen.Dispose();

                borderPen = new Pen(borderColor, borderWidth);

                Invalidate();
            }
        }
        private float borderWidth = 1.0f;
        public float BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                borderPen = new Pen(ControlPaint.Light(BorderColor, 0.0f), borderWidth);
                Invalidate();
            }
        }

        public RoundControl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawBorder (g);
            drawBackground(g);

        }
        private void drawBorder(Graphics g) =>
            g.DrawRoundedRectangle(borderPen, 10, 10, Width - 20, Height - 20, radius);

        private void drawBackground(Graphics g)
        {
            if (backgroundBrush != null)
            {
                g.FillRoundedRectangle(backgroundBrush, 10, 10, Width - 20, Height - 20, radius);
            }
        }

        private void RoundControl_Load(object sender, EventArgs e)
        {

        }
    }
}
