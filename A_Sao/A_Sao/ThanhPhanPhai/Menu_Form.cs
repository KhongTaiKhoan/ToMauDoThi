using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Sao.ThanhPhanPhai
{
    public partial class Menu_Form : UserControl
    {
        private Form1_interface form1_Interface;
        public Menu_Form()
        {
            InitializeComponent();
            setUP();
        }

        public Menu_Form(Form1_interface form1_Interface)
        {
            InitializeComponent();
            this.form1_Interface = form1_Interface;
            setUP();
        }

        private void setUP(){
            flMain.Size = this.Size;
            flControl.Size = new Size(flMain.Size.Width,100);

            flControl.Padding = new Padding((flControl.Width - btnStart.Width) / 2, 20, 0, 0);
            lbMTK.Margin = new Padding((flControl.Width - btnStart.Width) / 2, 5, 0, 0);
            rtxtMTK.Size = new Size(btnStart.Size.Width, rtxtMTK.Height);
            rtxtMTK.Margin = new Padding((flControl.Width - btnStart.Width) / 2, 0, 0, 0);


            btnStart.Click += Start_Click;
            btnReset.Click += Reset_Click;
            btnHelp.Click += Help_Click;
        }
        public void hienThiMaTranKe(bool [,]mtk, int count) {
            string[] lines = new string[count];
            for (int i = 0; i<count; i++) {
                string line = "";
                for (int j = 0; j < count; j++) {
                    line += mtk[i,j] ? "1 " : "0 ";
                }
                lines[i] = line;
            }
            rtxtMTK.Lines = lines;

        }


        private void Start_Click(object sender, EventArgs e) {
            form1_Interface.Start();
        }
        private void Reset_Click(object sender, EventArgs e) {
            rtxtMTK.Text = "";
            form1_Interface.Reset();
        }
        private void Help_Click(object sender, EventArgs e) {
            string help = "Hướng dẫn sử dụng \n" +
                     "- Click trái chuột để tạ mới một đỉnh\n" +
                     "- DoubleClick vào đỉnh để bắt đầu tạo cạnh. DoubleClick vào đỉnh khác để kết thúc.\n" +
                     "- Click trái chuột ra bên ngoài nếu như không muốn tạo cạnh nữa\n" +
                     "- Click trái chuột vào đỉnh để di chuyển đỉnh. Click trái chuột một lần nữa để kết thức.";
            MessageBox.Show(help);
        } 
}
}
