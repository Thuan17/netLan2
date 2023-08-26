using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveWinForm
{
    public partial class FormSingIn : Form
    {
        public FormSingIn()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Alert(string noidung) { 
            TB_Login frm = new TB_Login();  
            frm.showAlter(noidung); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alert  ("Thuan");

        
            FormLoading load = new FormLoading();
            load.Show();
            this.Hide();
        }
    }
}
