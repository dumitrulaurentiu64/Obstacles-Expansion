
using ClipperLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR
{
    enum Shapes
    {
        Point = 1,
        Polygon = 2
    }
    enum CornerStyle
    {
        Miter = 0,
        Round = 1,
        Square = 2
    }
    class Figura
    {
        public int X, Y;
        public Shapes Shape;
        public int LineWidth;
        public Color DrawColor;
        public Color culoareExp;
        private ClipperLib.JoinType joinType = JoinType.jtMiter;
        public int ExpansionValue { get; set; }
        public List<Point> PolygonPoints;
        public List<Point> ExpandedPolygonPoints;

        public Figura(int x, int y, Shapes shape, int lineWidth, Color drawColor)
        {
            this.X = x;
            this.Y = y;
            this.Shape = shape;
            this.LineWidth = lineWidth;
            this.DrawColor = drawColor;
            ExpansionValue = 0;
        }
        public Figura(List<Point> polygonPoints, Shapes shape, int lineWidth, Color drawColor)
        {
            this.PolygonPoints = polygonPoints;
            this.Shape = shape;
            this.LineWidth = lineWidth;
            this.DrawColor = drawColor;
            ExpansionValue = 0;
        }

        public void SetCornerStyle(CornerStyle style)
        {
            switch (style)
            {
                case CornerStyle.Miter: joinType = JoinType.jtMiter; break;
                case CornerStyle.Round: joinType = JoinType.jtRound; break;
                case CornerStyle.Square: joinType = JoinType.jtSquare; break;
                default: break;
            }
        }

        public void DrawMe(Graphics graphics)
        {
            int grosime = 3;
            // Desenare figura
            Draw(graphics, grosime);
            // Desenare figura expandata
            if (ExpansionValue != 0)
            {
                grosime = ExpansionValue * 2-5;
                Draw(graphics, grosime, ExpansionValue);
            }
        }
        private void Draw(Graphics graphics, int grosime_a, int expansionVal = 0 )
        {
            Pen myPen = new Pen(this.DrawColor, this.LineWidth);
            switch (this.Shape)
            {
                case Shapes.Point:
                    //Console.WriteLine("Punct");
                    graphics.FillRectangle(myPen.Brush, X, Y, 3, 3);
                    break;
                case Shapes.Polygon:
                    //Console.WriteLine("Rectangle");
                    if(expansionVal!=0)
                    {
                        myPen.Width = grosime_a;
                      
                        DrawPolygon(graphics, expansionVal, myPen);
                    }
                    myPen.Width = grosime_a;
                    DrawPolygon(graphics, expansionVal, myPen);
                    break;
            }
        }

        private void DrawPolygon(Graphics graphics, int expansionVal, Pen myPen)
        {
            //Console.WriteLine("for each figura");
            //cmbColor.SelectedItem.ToString()
            if (expansionVal == 0)
            {
                //Console.WriteLine("Figura neexpandata.");
                graphics.DrawPolygon(myPen, PolygonPoints.ToArray());
            }
            else
            {
                myPen.Color = culoareExp;
                //Console.WriteLine("Figura expandat");
                ExpandPolygon(expansionVal);
                graphics.DrawPolygon(myPen, ExpandedPolygonPoints.ToArray());
                myPen.Color = this.DrawColor;
            }
        }

        private void ExpandPolygon(int expansionVal)
        {
            List<IntPoint> convertedList = new List<IntPoint>();
            List<List<IntPoint>> solution = new List<List<IntPoint>>();

            foreach (var p in PolygonPoints)
            {
                convertedList.Add(new IntPoint(p.X, p.Y));
                //Console.WriteLine("punct adaugat:" +p.X +" "+ p.Y);
            }

            solution.Add(convertedList);
            ClipperOffset co = new ClipperOffset();
            co.AddPaths(solution, joinType, EndType.etClosedPolygon);
            co.Execute(ref solution, expansionVal);

            // Salvarea punctelor expandate pentru scrierea in fisier
            ExpandedPolygonPoints = new List<Point>();
            foreach (var p in solution[0])
            {
                ExpandedPolygonPoints.Add(new Point((int)p.X, (int)p.Y));
            }
        }

    }
}
//http://www.angusj.com/delphi/clipper/documentation/Docs/Units/ClipperLib/Types/JoinType.htm?fbclid=IwAR25J1MjvVJ27Ymu_4iIjXIB9kI1_6KHiOo6-5sUigIFbMLPWLo09sioOt0
//https://sourceforge.net/p/polyclipping/discussion/1148419/thread/7b8268d5/
//https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics?view=netframework-4.8
//https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics.drawpolygon?view=netframework-4.8
