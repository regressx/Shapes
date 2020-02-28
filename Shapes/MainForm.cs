using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shapes.Presenters;

namespace Shapes
{
    public partial class MainForm : Form, IMainView
    {
        private Graphics _graphics;
        public MainForm()
        {
            InitializeComponent();

        }

        #region Events

        public event EventHandler<DrawEventArgs> DrawShape;

        #endregion


        public new void Show()
        {
            Application.Run(this);
        }

        public void ShowShape(Image image,int x, int y)
        {
            drawShapesPanel.Refresh();
            _graphics.DrawImage(image, new PointF(x, y));
        }

        public string GetShapeType()
        {
            if (shapesTypesListBox.SelectedItem != null)
            {
                return (string) shapesTypesListBox.SelectedItem;
            }

            return string.Empty;
        }

        private int X = 0;
        private int Y = 0;
        private int w = 0;
        private int h = 0;

        bool drawingStatus = false;

        private void drawShapesPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawingStatus)
            {
                drawingStatus = false;
                DrawShape?.Invoke(sender, new DrawEventArgs(X, Y, w, h));
            }
            else
            {
                drawingStatus = true;
                X = e.X;
                Y = e.Y;
            }
        }

        private void drawShapesPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingStatus)
            {
                toolStripStatusLabel2.Text = e.X.ToString();
                toolStripStatusLabel4.Text = e.Y.ToString();
                w = (int) Math.Sqrt(Math.Pow(X - e.X, 2));
                h = (int) Math.Sqrt(Math.Pow(Y - e.Y, 2));
                if (w != 0 && h != 0)
                {
                    DrawShape?.Invoke(sender, new DrawEventArgs(X, Y, w, h));
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _graphics = drawShapesPanel.CreateGraphics();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            _graphics = drawShapesPanel.CreateGraphics();
        }
    }
}
