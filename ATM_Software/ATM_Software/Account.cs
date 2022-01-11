using System;
namespace ATM_Software
{
    public class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Balance { get; set; }
        public long CardNo { get; set; }
        public int Pin { get; set; }

        public Account()
        {
            //Sample Card
            Name = "Namaz";
            Surname = "Gulahmadov";
            Balance = 1250;
            CardNo = 1234123412341234;
            Pin = 3456;
        }

        public void ShowCashAvailability()
        {
            Console.WriteLine($"Available Balance: {Balance}");
            Console.WriteLine("");
        }

        public void CashWithdrawl(int withdrawn)
        {
            if(withdrawn <= Balance)
            {
                Console.WriteLine("");
                Balance = Balance - withdrawn;
                Console.WriteLine($"New Balance: {Balance}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Not enough fund");
                Console.WriteLine("");
            }
            
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"Cardholder Name: {Name} {Surname}");
            Console.WriteLine("");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine("");
        }

        public void ThousandWithdraw()
        {
            if(Balance >= 1000)
            {
                Balance = Balance - 1000;
                Console.WriteLine($"New Balance: {Balance}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Not enough fund");
                Console.WriteLine("");
            }
        }

        public void NewPin(int newPin)
        {
            Pin = newPin;
            Console.WriteLine("Your PIN has successfully changed");
        }

    }
}
