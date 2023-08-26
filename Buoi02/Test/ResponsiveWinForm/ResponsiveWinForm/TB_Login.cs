using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveWinForm
{
    public partial class TB_Login : Form
    {
        public TB_Login()
        {
            InitializeComponent();
        }
        private enum enmAction 
        {
            wait,
            close,
            start,
        }
        private TB_Login.enmAction action;
        private int x , y ;

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        public void showAlter(string noidung)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            String fname;
            for (int i = 1; i <= 10; i++)
            {
                fname = "alter" + i.ToString();
                TB_Warring frm = (TB_Warring)Application.OpenForms[fname];
                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.label1.Text = noidung;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
