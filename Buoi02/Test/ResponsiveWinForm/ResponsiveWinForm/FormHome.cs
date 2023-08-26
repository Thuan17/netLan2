using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ResponsiveWinForm
{
    public partial class FormHome : Form
    {




        public FormHome()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.BackColor = Color.Red;

        }

       
        public void Alert(String NoiDung, String Name)
        {
          

            TB_Mess frm = new TB_Mess();
            frm.showAlter(NoiDung, Name);
        
        }      

        private void FormHome_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i >= row; i++) 
            //{ 
            //    Button btn = new Button();
            //    btn.Show();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string noidung = txtNoiDung.Text;
            //if (noidung != null && name != null)
            //{


            //}
            //else {
            //    MessageBox.Show("ssa");
            //}
            this.Alert("tin nhắn chờ", "Gia Thuận");
            //this.Alert(noidung, name);
        }
    }
}
