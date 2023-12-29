using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_02
{

    class BT02
    {
        static void Main(string[] args)
        {
            Account my=new Account("171005", "PhamDucTrong", 10000);
            
            Console.Write(" Enter ID: ");
            string id = Console.ReadLine();
            Console.Write(" Enter Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Balance: ");
            int balance = int.Parse(Console.ReadLine());
            Account your = new Account("170906", "NguyenVanKhuong", 20000);
            Console.WriteLine("Thong tin tai khoan");
            Console.WriteLine("My account:[ID:{0}, Name: {1}, Balance: {2}]", my.GetID(), my.GetName(), my.GetBalance());
            Console.WriteLine("My account:[ID:{0}, Name: {1}, Balance: {2}]", your.GetID(), your.GetName(), your.GetBalance());
            my.Debit(700);
            my.TranferTo(your, 200);
            Console.WriteLine("Thong tin giao dich");
            Console.WriteLine("My account:[ID:{0}, Name: {1}, Balance: {2}]", my.GetID(), my.GetName(), my.GetBalance());
            Console.WriteLine("My account:[ID:{0}, Name: {1}, Balance: {2}]", your.GetID(), your.GetName(), your.GetBalance());
            Console.ReadKey();
        }
    }
}
