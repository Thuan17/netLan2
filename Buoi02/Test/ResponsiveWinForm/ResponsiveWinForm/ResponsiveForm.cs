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
    public partial class ResponsiveForm : Form
    {
        public ResponsiveForm()
        {
            InitializeComponent();
        }


        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
            label13.Text = button1.Text;
        }



        ///Thao tác Form Con trên Form Cha



        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            label13.Text = button2.Text;

        }

        private void ResponsiveForm_Load(object sender, EventArgs e)
        {

        }
        //public void Alert(String noidung, String name) {
        //    TB_Mess frm = new TB_Mess();
        //    frm.showAlter(noidung,name);
        //}
        public void Alert(String Noidung)
        { 
            TB_Warring frm = new TB_Warring();
            frm.showAlter(Noidung);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Alert("ook ne");
        }
    }
}
