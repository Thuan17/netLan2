﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HuynhGiaThuan
{
    class Bai5
    {
        public int MaHang;
        public string TenHang;
        public double DonGia;
        public DateTime NgaySanXuat, NgayHetHan;
        public string GhiChu;
        public void setMaHang(int mahang) { 
            this.MaHang = mahang; }
        public void setTenHang(string tenhang)
        {
            if (tenhang != null)
            {
                this.TenHang = tenhang;
            }
            else {
                tenhang = "xxx";
            }
           
            
        }
        public void setDonGia(double dongia) { this.DonGia = dongia; }
        public void setNSX(DateTime nsx) { this.NgaySanXuat = nsx; }
        public void setNHH(DateTime nhh) { this.NgayHetHan = nhh; }
        public void setGhiChu(string ghichu) { this.GhiChu = ghichu; }
        


        public int getMahang() { return MaHang; }
        public string getTenHang() {  return TenHang; }
        public double getDonGia() { return DonGia; }
        public DateTime getNSX() { return NgaySanXuat; }
        public DateTime getNHH() { return NgayHetHan; }



        public bool checkMH() 

        {
            if (MaHang == null)
            { 
                return false;
            }
            return true;
        }


      


    }
}
