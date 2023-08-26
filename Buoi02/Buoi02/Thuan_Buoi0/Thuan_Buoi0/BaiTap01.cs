using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuan_Buoi0
{
    class BaiTap01
    {

        public int x   // property
        {
            get { return x; }   // get method
            set { x = value; }  // set method
        }
        public int y   // property
        {
            get { return y; }   // get method
            set { y = value; }  // set method
        }
        public string nameX   // property
        {
            get { return nameX; }   // get method
            set { nameX = value; }  // set method
        }
        public string nameY  // property
        {
            get { return nameY; }   // get method
            set { nameY = value; }  // set method
        }
       

        public void Out(int x1, int y1, string nameX1, string nameY1)
        {
            x = x1;
            y = y1;
            nameX = nameX1;
            nameY = nameY1;
        }
    }
}
