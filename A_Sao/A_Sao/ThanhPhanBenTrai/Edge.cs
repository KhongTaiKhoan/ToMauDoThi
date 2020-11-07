using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Sao.ThanhPhanBenTrai
{
    class Edge
    {
        private int width;
        private Color color;
        private DinhDoThi start;
        private DinhDoThi end;
        private Graphics gra;
        private Point startP;
        private Point endP;
        public Edge(int width, Color color, DinhDoThi start, DinhDoThi end, Graphics gra)
        {
            this.width = width;
            this.color = color;
            this.start = start;
            this.end = end;
            this.gra = gra;
            setPostion();
          
        }
        public Edge(int width, Color color, DinhDoThi start, Graphics gra)
        {
            this.width = width;
            this.color = color;
            this.start = start;
         
            this.gra = gra;
            setPostion();

        }

        public int Width { get => width; set => width = value; }
        public Color Color { get => color; set => color = value; }
        public DinhDoThi Start { get => start; set => start = value; }
        public DinhDoThi End { get => end; set => end = value; }
        public Graphics Gra { get => gra; set => gra = value; }
        public Point StartP { get => startP; set => startP = value; }
        public Point EndP { get => endP; set => endP = value; }

        public void createLine() {
            Gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = new Pen(Color,Width);
            Gra.DrawLine(pen,StartP,EndP);
        }


        public void Update() {
            Gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            setPostion();
            Pen pen = new Pen(Color, Width);
            Gra.DrawLine(pen, StartP, EndP);
        }

        public void Draw()
        {
            Gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = new Pen(Color, Width);
            Gra.DrawLine(pen, StartP, EndP);
            
        }
       

        public void setPostion() {
            StartP = new Point(start.Location.X + start.Size.Width / 2, start.Location.Y + start.Size.Height / 2);
            
            if(end != null)
               EndP = new Point(end.Location.X + end.Size.Width / 2, end.Location.Y + end.Size.Height / 2);
        }
    }
}
