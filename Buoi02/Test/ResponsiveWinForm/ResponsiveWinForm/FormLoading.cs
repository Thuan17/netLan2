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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    timeline.Width += 3;
        //    if (timeline.Width >= 899)
        //    {
               
        //        timer1.Stop();/*/*vao properties enable=true*/
        //        ResponsiveForm Main = new ResponsiveForm();
        //        Main.Show();
        //        this.Hide();
        //    }
        //}

        private void FormLoading_Load(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Loi He THong");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {/* có hai cách dùng time*/
            ///// //cách 1

            timeline.Width += 3;
            if (timeline.Width >= 899)
            {

                timer1.Stop();/*/*vao properties enable=true*/
             
                ResponsiveForm Main = new ResponsiveForm();
                Main.Show();
                this.Hide();
                MessageBox.Show("Xin Chào");
            }


            ///// //cách 2
            //if (progressBar1.Value < 100)
            //{
            //    progressBar1.Value += 1;
            //    label2.Text = progressBar1.Value.ToString() + "%";

            //}
            //else
            //{
            //    timer1.Stop();
            //    ResponsiveForm Main = new ResponsiveForm();
            //    Main.Show();
            //    this.Hide();
            //    MessageBox.Show("Loi He THong");
            //}
        }
    }
}
