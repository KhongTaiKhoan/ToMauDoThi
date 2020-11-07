using A_Sao.ThanhPhanBenTrai;
using A_Sao.ThanhPhanPhai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Sao
{
    public partial class Form1 : Form, Form1_interface
    {

        private DoThi_Form dothi;
        private Menu_Form menu;
        private Point tyLe = new Point(6, 4);
        private bool[,] maTranKe;
        private List<Color> Colors = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            Colors.Add(Color.Green);
            Colors.Add(Color.Brown);
            Colors.Add(Color.Blue);
            Colors.Add(Color.Pink);
        }


        private void khoiTaoGiaoDien()
        {
            flLayout.Location = new Point(0, 0);
            flLayout.Size = this.Size;

            this.Controls.Add(flLayout);


            dothi = new DoThi_Form();
            dothi.Size = new Size(this.Size.Width * tyLe.X / (tyLe.X + tyLe.Y), this.Size.Height);
            dothi.gra = dothi.CreateGraphics();
            flLayout.Controls.Add(dothi);

            menu = new Menu_Form(this);
            menu.Size = new Size(this.Size.Width - dothi.Size.Width - 10, this.Size.Height);
            flLayout.Controls.Add(menu);


            //dothi.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            khoiTaoGiaoDien();
        }

        public void Start()
        {
            // B1. xay dung ma tran ke
            taoMaTranKe();
            menu.hienThiMaTranKe(maTranKe, dothi.DinhDoThis.Count);

            // B2. Tien hanh thuat giai tham lam
            // Sap xep cac dinh theo thu tu bac tu lon den nho
            dothi.DinhDoThis = dothi.DinhDoThis.OrderByDescending(d => d.Rank).ToList();
            // thuc hien tham lam duyet mau cau tung dinh tu lon den thap
            thuatGiai();
        }

        public void Reset()
        {
            maTranKe = null;
            dothi.Edges.Clear();
            dothi.DinhDoThis.Clear();
            dothi.gra.Clear(Color.White);
            dothi.Controls.Clear();
            dothi.Invalidate();
        }


        private void taoMaTranKe()
        {
            maTranKe = new bool[dothi.DinhDoThis.Count, dothi.DinhDoThis.Count];
            for (int i = 0; i < dothi.Edges.Count; i++)
            {
                maTranKe[dothi.Edges[i].Start.Id, dothi.Edges[i].End.Id] = true;
                maTranKe[dothi.Edges[i].End.Id, dothi.Edges[i].Start.Id] = true;
            }

        }

        //// Thuat giai
        private void toMau(DinhDoThi d, int index)
        {
            if (index < 0 || index > Colors.Count)
            {
                Random rand = new Random();
                while (true)
                {
                    Color c = Color.FromArgb(255, rand.Next(20, 255), rand.Next(20, 255), rand.Next(20, 255));
                    bool check = Colors.Where(cl => cl.R == c.R && cl.B == c.B && cl.G == c.G) == null;
                    if (check)
                    {
                        Colors.Add(c);
                        break;
                    }
                }
            }
            d.MyColor = Colors[index];
            d.Invalidate();
        }
        private bool[] danhSachKe(DinhDoThi d, int count, List<int> maus)
        {
            bool[] nhan = new bool[Colors.Count];
            for (int i = 0; i < count; i++)
            {
                if (dothi.DinhDoThis[i].Id != d.Id && maTranKe[dothi.DinhDoThis[i].Id, d.Id] && maus[i] !=-1)
                {
                    nhan[maus[i]] = true;
                }
            }
            return nhan;
        }
        private void thuatGiai()
        {
            List<DinhDoThi> dt = dothi.DinhDoThis;
            List<int> maus = new List<int>();
            for (int i = 0; i < dt.Count; i++)  maus.Add(-1); 

            for (int i = 0; i < dt.Count; i++)
            {
                bool[] nhan = danhSachKe(dt[i], dt.Count, maus);
                for (int j = 0; j < nhan.Length; j++)
                {
                    if (!nhan[j])
                    {
                        toMau(dt[i], j);
                        maus[i] = j;
                        break;
                    }
                    else if (j == Colors.Count - 1)
                    {
                        toMau(dt[i], Colors.Count);
                        maus[i] = Colors.Count;
                    
                    }
                }


                //Thread.Sleep(1000);
               
            }
        }
    }


    public interface Form1_interface
    {
        void Start();
        void Reset();
    }
}
