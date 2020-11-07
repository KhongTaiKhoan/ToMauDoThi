using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Sao.ThanhPhanBenTrai
{
    public partial class DinhDoThi : Control
    {

        private Color myColor;
      
        private Size mySize = new Size(25,25);
        private int id;
        private DoThi_Interface dt_int;
        private int rank;
        public DinhDoThi()
        {
            this.Size = MySize;
            InitializeComponent();
        }

        public DinhDoThi(int id,Point p, DoThi_Interface dt)
        {
            this.Size = MySize;
            this.id = id-1;
            dt_int = dt;
            InitializeComponent();
            this.Location = new Point(p.X-MySize.Width/2, p.Y - MySize.Height / 2);

        }

        public Color MyColor { get => myColor; set => myColor = value; }
        public Size MySize { get => mySize; set => mySize = value; }
        public int Id { get => id; set => id = value; }
        public int Rank { get => rank; set => rank = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Rectangle rec = new Rectangle(new Point(1, 1), new Size(MySize.Width-2, MySize.Height - 2));

            SolidBrush solidBrush = new SolidBrush(MyColor);
            Pen pen = new Pen(solidBrush, 1);

            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
           // pe.Graphics.DrawEllipse(pen,rec);
            pe.Graphics.FillEllipse(solidBrush,rec);

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel);

            SolidBrush solidBrushText = new SolidBrush(Color.Black);
            pe.Graphics.DrawString((Id+1).ToString(),font1,solidBrushText,
                new Point(this.Size.Width/2-5,this.Size.Height/2-5));



        }

        private void DrawLine_2(object sender, EventArgs e)
        {
          
            dt_int.doubleClickDinhDoThi(this);
        }

        private void UnSelect(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Right)
            //dt_int.endMovingDinhDoThi(this);
        }

        private void Select(object sender, MouseEventArgs e)
        {
            dt_int.clickDinhDoThi(this,e);
        }

      
    }
}
