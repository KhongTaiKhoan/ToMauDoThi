using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace A_Sao.ThanhPhanBenTrai
{
    public partial class DoThi_Form : UserControl, DoThi_Interface
    {

        private List<Edge> edges = new List<Edge>();
        private List<DinhDoThi> dinhDoThis = new List<DinhDoThi>();
        public Graphics gra;
        private enum STATE { NONE, DRAWING, UPDATE_LINE, CREATE_DINHDOTHI,MOVE_DINHDOTHI};
        private STATE mainState = STATE.CREATE_DINHDOTHI;
        private DinhDoThi selectedDinhDoThi;

        internal List<Edge> Edges { get => edges; set => edges = value; }
        public List<DinhDoThi> DinhDoThis { get => dinhDoThis; set => dinhDoThis = value; }

        public DoThi_Form()
        {
            InitializeComponent();
           
        }

      

        private void OnClick(object sender, MouseEventArgs e)
        {
            if (mainState == STATE.CREATE_DINHDOTHI)
            {
                DinhDoThi newDinh = new DinhDoThi(DinhDoThis.Count + 1, e.Location, this);

                newDinh.MyColor = Color.Red;

                DinhDoThis.Add(newDinh);
                this.Controls.Add(newDinh);
            }
            else if (mainState == STATE.DRAWING) {
                Edges[Edges.Count - 1].Start.Rank--;
                Edges.RemoveAt(Edges.Count - 1);
                mainState = STATE.CREATE_DINHDOTHI;
                RePaint();
            }
            

        }
        private void Move_M(object sender, MouseEventArgs e)
        {
            if (mainState == STATE.DRAWING)
            {
                Edges[Edges.Count - 1].EndP = e.Location;
                Invalidate();

            }
            else if (mainState == STATE.MOVE_DINHDOTHI) {
                selectedDinhDoThi.Location = e.Location;
              
                RePaint();
            }
          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < Edges.Count; i++)
                Edges[i].Draw();

        }

        //=========================================



        public void clickDinhDoThi(DinhDoThi d, MouseEventArgs e)
        {
            if (mainState == STATE.CREATE_DINHDOTHI)
                moveDinhDoThi(d);
            else if (mainState == STATE.MOVE_DINHDOTHI)
                endMovingDinhDoThi(d);
        }

        public void doubleClickDinhDoThi(DinhDoThi d)
        {
            if (mainState != STATE.DRAWING)
            {
                startDrawLine(d);
            }
            else if (mainState == STATE.DRAWING)
            {
                endDrawLine(d);
            }
        }

        public void RePaint()
        {
            for (int i = 0; i < Edges.Count; i++)
                Edges[i].setPostion();
            Invalidate();
        }




        // ===================================================//
        public void startDrawLine(DinhDoThi d)
        {
            Edges.Add(new Edge(2, Color.Black, d, gra));
            d.Rank++;
            mainState = STATE.DRAWING;

        }

        public void endDrawLine(DinhDoThi d)
        {
            Edges[Edges.Count - 1].End = d;
            d.Rank++;
            Edges[Edges.Count - 1].Update();
            mainState = STATE.CREATE_DINHDOTHI;
            RePaint();
        }

      

        public void moveDinhDoThi(DinhDoThi d)
        {
            selectedDinhDoThi = d;
            mainState = STATE.MOVE_DINHDOTHI;
        }

        public void endMovingDinhDoThi(DinhDoThi d)
        {
            if (mainState != STATE.MOVE_DINHDOTHI) return;
            selectedDinhDoThi = null;
            mainState = STATE.CREATE_DINHDOTHI;
        }

       


        //====================


    }


    public interface DoThi_Interface {

        void startDrawLine(DinhDoThi d);
        void endDrawLine(DinhDoThi d);
        void moveDinhDoThi(DinhDoThi d);
        void endMovingDinhDoThi(DinhDoThi d);

        void clickDinhDoThi(DinhDoThi d, MouseEventArgs e);
        void doubleClickDinhDoThi(DinhDoThi d);
        void RePaint();
        
    }
}
