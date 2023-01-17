using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    abstract class BankAccount
    {
        public int Account { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; } = 5000;

        public void Credit(int amout) => Balance += amout;

        public void Debit(int amout)
        {
            if (amout > Balance)
            {
                throw new Exception("Invalid Funds");
            }
            Balance -= amout;
        }
        public abstract void CalculateIntrest();
    }
    class SBAccout1 : BankAccount
    {
        public override void CalculateIntrest()
        {
            var priciple = Balance;
            var time = 0.25;
            var rate = 0.05;
            var interset = priciple * time * rate;
            Credit((int)interset);
        }

    }
    class FDAccount : BankAccount
    {
        public override void CalculateIntrest()
        {
            var principle = Balance;
            var time = 0.25;
            var rate = 0.05;
            var intrest = principle * rate * time;
            Credit((int)intrest);
        }
    }
    class RDAccount : BankAccount
    {
        public override void CalculateIntrest()
        {
            var installment = 2500;
            var rate = 0.07;
            var time = 1;
            var frequency = 10;
            var maturity = installment * rate * time * frequency;

        }
    }
    class AccountFactory
    {
        public static BankAccount CreateAccount(string args)
        {
            if (args.ToUpper() == "SBIACC")
                return new SBAccout1();
            else if (args.ToUpper() == "RDACC")
                return new RDAccount();
            else if (args.ToUpper() == "FDACC")
                return new FDAccount();
            else throw new Exception("This type of Bank is not available");
        }
    }
    enum Banks { SBIAcc, RDAcc, FDAcc };

    class Abstarct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Type Of Bank");
            Array a = Enum.GetValues(typeof(Banks));
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a.GetValue(i));
            }

            string BankType = Console.ReadLine();

            BankAccount acc = AccountFactory.CreateAccount(BankType);
            acc.Account = 1438;
            acc.Name = "Test Name";
            acc.Credit(56000);
            acc.CalculateIntrest();
            Console.WriteLine("The current Balance is : " + acc.Balance);

        }
    }
}
