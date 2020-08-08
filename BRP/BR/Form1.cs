using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BR
{

    public partial class Form1 : Form
    {
        List<Figura> Figuri = new List<Figura>();
        List<Figura> Backup = new List<Figura>();
        Pen myPen = Pens.Black;
        int drawWidth = 0;
        Color drawColor = Color.Black;
        Color backColor = Color.White;
        Shapes shape = Shapes.Point;
        CornerStyle cornerStyle = CornerStyle.Miter;
        public List<Point> PolygonPoints;
        public Form1()
        {
            InitializeComponent();
            cmbExpand.SelectedIndex = 0;
            cmbCornerType.SelectedIndex = 0;
           // PolygonPoints = new List<Point>();
            cmbColor.SelectedIndex = 1;
        }        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            shape = Shapes.Point;
        }

        private void polyButton_Click(object sender, EventArgs e)
        {
            PolygonPoints = new List<Point>(); // new list, always
            
            foreach (var figura in Figuri.Where(f => f.Shape == Shapes.Point))
            {
                PolygonPoints.Add(new Point(figura.X, figura.Y));
            }
            if (PolygonPoints.Count > 2)
            {
                shape = Shapes.Polygon;
                Figuri.Add(new Figura(PolygonPoints, shape, drawWidth, drawColor));
                Figuri.RemoveAll(p => p.Shape == Shapes.Point);
                Backup.Clear();
                pictureBox1.Refresh();
                shape = Shapes.Point;
            }
            else
            {
                MessageBox.Show("At least three points are needed in order to draw a polygon.", "Warning");
            }

        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            foreach (Figura fig in Figuri)
            { //here we take the value from the combobox of how much should the program expand the object
                fig.ExpansionValue = Convert.ToInt32(cmbExpand.SelectedItem.ToString());
                string culoare = cmbColor.SelectedItem.ToString();
                switch (culoare)
                {
                    case "Red":
                        fig.culoareExp = Color.Red;
                        break;
                    case "Black":
                        fig.culoareExp = Color.Black;
                        break;
                    case "Green":
                        fig.culoareExp = Color.Green;
                        break;
                    case "Blue":
                        fig.culoareExp = Color.Blue;
                        break;
                    default: fig.DrawColor = Color.Black;
                        break;
                }
                
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = (int)(e.X);
            int y = (int)(e.Y);
            Figuri.Add(new Figura(x, y, shape, drawWidth, drawColor));
            Backup.Clear();
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(backColor);
            foreach (Figura fig in Figuri)
            {
                fig.DrawMe(e.Graphics);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCornerType_Click(object sender, EventArgs e)
        {

        }

        private void cmbCornerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cornerStyle = (CornerStyle)cmbCornerType.SelectedIndex;
            foreach (Figura fig in Figuri.Where(f => f.Shape == Shapes.Polygon))
            {
                fig.SetCornerStyle(cornerStyle);
            }
            pictureBox1.Refresh();
        }
    }
}
