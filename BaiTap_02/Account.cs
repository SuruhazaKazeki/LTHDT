using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_02
{
    class Account
    {
        private string id, name;
        private int balance;// Số dư
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string GetID()
        {
            return id;
        }
        public string GetName()
        {
            return id;
        }
        public int GetBalance()
        {
            return balance;
        }
        public void Credit(int amount)
        {
            if (balance > 0)
                balance += amount;
        }
        public void Debit(int amount)
        {
            if (balance >= amount)
                balance -= amount;
            else
                Console.WriteLine(" So rut lon hon so du");
        }
        public void TranferTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
                Console.WriteLine("So du khong hop le");
        }
    }
}
