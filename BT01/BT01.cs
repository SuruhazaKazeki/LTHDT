using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class HinhChuNhat
    {
        private double Dai,Rong;
        public HinhChuNhat()
        {
            Dai = 1.0;
            Rong = 1.0;
        }
        public HinhChuNhat(double Dai,double Rong)
        {
            this.Dai = Dai;
            this.Rong = Rong;
        }
        public void ChinhChieuDai(double Dai)
        {
            this.Dai = Dai;
        }
        public double ChieuDai()
        {
            return Dai;
        }
        public void ChinhChieuRong(double Rong)
        {
            this.Rong = Rong;
        }
        public double ChieuRong()
        {
            return Rong;
        }
        public double DienTich()
        {
            return Dai * Rong;
        }
        public double ChuVi()
        {
            return (Dai + Rong) * 2;
        }
    }
   
    class BT01
    {
        static void Main(string[] args)
        {
            HinhChuNhat r1;
            HinhChuNhat r2;
            r1 = new HinhChuNhat();
            Console.Write("Cho biet chieu dai: ");
            double Dai = double.Parse(Console.ReadLine());
            Console.Write("Cho biet chieu rong: ");
            double Rong = double.Parse(Console.ReadLine());
            r2 = new HinhChuNhat(Dai, Rong);
            Console.WriteLine("---------------Thong tin hinh chu nhat 1----------------");
            Console.WriteLine("Chieu dai : {0}\n Chieu rong :{1}\nDien tich: {2}\n Chu vi {3}", r1.ChieuDai(),r1.ChieuRong(),r1.DienTich(),r1.ChuVi());
            Console.WriteLine("---------------Thong tin hinh chu nhat 2----------------");
            Console.WriteLine("Chieu dai : {0}\n Chieu rong :{1}\nDien tich: {2}\n Chu vi {3}", r2.ChieuDai(), r2.ChieuRong(), r2.DienTich(), r2.ChuVi());
            Console.ReadKey();

        }
    }
}
