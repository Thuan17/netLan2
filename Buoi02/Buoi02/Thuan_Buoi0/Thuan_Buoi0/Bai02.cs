using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuan_Buoi0
{
    class Bai02
    {
        private int MSSV;
        private string FullName;
        private float DiemLT, DiemTH;

        public void setMSS(int MSSV) {
            this.MSSV = MSSV;
        }


        public void checkDiem(float DiemLT)
        {
            if (DiemLT < 0 || DiemLT > 10) { 
                
            }
        }




        public float DiemTB()
        {
            return ((DiemLT + DiemTH) / 2);
        }
        public void Out(int msvv, string fName, float diemLT, float diemTh,float diemtb)
        {
            MSSV = msvv;
            FullName = fName;
            DiemLT = diemLT;
            DiemTH = diemTh;
           
        }

       
    }
}
