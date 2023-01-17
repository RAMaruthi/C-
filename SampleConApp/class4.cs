using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Account
    {
        public int AcouId { get; set; }
        public string Name { get; set; }
        public double Balance { get; private set; } = 5000;

        public void Credit(int amout) => Balance += amout;

        public void Debit(int amout)
        {
            if (amout > Balance)

                throw new Exception("Insufficient Funds");
            Balance -= amout;
        }
    }
    class AccoutManager
    {
        private Account[] _accounts = null;
        private int _size = 0;
        public AccoutManager(int size)
        {
            _size = size;
            _accounts = new Account[_size];
        }

        public void AddNewAccount(Account acc)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] == null)
                {
                    _accounts[i] = new Account { AcouId = acc.AcouId, Name = acc.Name };
                    _accounts[i].Credit((int)acc.Balance);
                    return;
                }
            }
        }

        public void Update(Account acc)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] != null && _accounts[i].AcouId == acc.AcouId)
                {
                    _accounts[i].Name = acc.Name;
                    return;
                }
            }
            throw new Exception("Account not found to update");

        }

        public void DeleteAccount(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] != null && _accounts[i].AcouId == id)
                {
                    //.NET does not allow to delete an object. 
                    _accounts[i] = null; //
                    return;
                }
            }
            throw new Exception("No Account found to delete");

        }

        public Account FindAccount(int id)
        {
            foreach (Account acc in _accounts)
            {
                if (acc != null && acc.AcouId == id)
                    return acc;
            }
            throw new Exception("No Account found");
        }

    }
    
    class class4
    {
        static void Main(string[] args)
        {
            //    Account acc = new Account { AcouId = 111, Name = "Maruthi R A" };
            //    Console.WriteLine("The Balance" + "  " + acc.Balance);
            //    acc.Credit(4000);
            //    Console.WriteLine("The Balance" + "  " + acc.Balance);

            //    try
            //    {
            //        acc.Debit(5000);
            //        Console.WriteLine("The Balance" + "  " + acc.Balance);
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }

            //}


            int count = Utilites.GetNumber("Enter The Accout Count U want To create");
            AccoutManager mgr = new AccoutManager(count);
            try
            {
                mgr.FindAccount(123);
            }
            catch (Exception ex)
            {
                Console.WriteLine(  ex.Message);
            }
        }
    }
}
