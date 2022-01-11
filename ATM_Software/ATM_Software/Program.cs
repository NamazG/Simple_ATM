using System;

namespace ATM_Software
{
    class Program
    {
        static void Main(string[] args)
        {

            long result = 0;
            //Checking Card Number------------------------------------------------------------------------------------------->

            Account account = new Account();

            string num = "";
            while (num.Length != 16 || long.TryParse(num, out result) != true || result != account.CardNo)
            {
                Console.WriteLine("Please enter 16 digits card number:");
                Console.WriteLine("");
                num = Console.ReadLine();
                Console.WriteLine("");

                if (num.Length == 16 && long.TryParse(num, out result) == true && result == account.CardNo)
                {

                    //Checking PIN------------------------------------------------------------------------------------------>

                    string pin = "";
                    int res = 0;

                    while (pin.Length != 4 || int.TryParse(pin, out res) != true || res != account.Pin)
                    {
                        Console.WriteLine("Please enter 4 digits PIN:");
                        Console.WriteLine("");
                        pin = Console.ReadLine();
                        Console.WriteLine("");

                        if (pin.Length == 4 && int.TryParse(pin, out res) == true && res == account.Pin)
                        {

                            //Checking input option------------------------------------------------------------------------>

                            int inp = 0;
                            string input = "";

                            while (inp != 9)
                            {
                                Console.WriteLine("Choose an option:");
                                Console.WriteLine("1 - Cash Availability");
                                Console.WriteLine("2 - Cash Withdrawal");
                                Console.WriteLine("3 - Show Account Info");
                                Console.WriteLine("4 - 1000$ withdraw");
                                Console.WriteLine("5 - Set new PIN");
                                Console.WriteLine("9 - Exit");
                                Console.WriteLine("");
                                input = Console.ReadLine();
                                Console.WriteLine("");

                                if (int.TryParse(input, out int resultInp) == true)
                                {
                                    inp = resultInp;
                                    //Input #1---------------------------------------------------------------------------->
                                    if (inp == 1)
                                    {
                                        account.ShowCashAvailability();

                                    }
                                    //Input #2---------------------------------------------------------------------------->
                                    else if (inp == 2)
                                    {
                                        Console.WriteLine("Please enter withdrawal amount: ");
                                        Console.WriteLine("");

                                        string inputAmount = Console.ReadLine();
                                        int amount = int.Parse(inputAmount);

                                        account.CashWithdrawl(amount);

                                    }
                                    //Input #3--------------------------------------------------------------------------->
                                    else if (inp == 3)
                                    {
                                        account.ShowAccountInfo();
                                    }
                                    //Input #4--------------------------------------------------------------------------->
                                    else if (inp == 4)
                                    {
                                        account.ThousandWithdraw();
                                    }
                                    //Input #5--------------------------------------------------------------------------->
                                    else if (inp == 5)
                                    {
                                        Console.WriteLine("New PIN:");
                                        string newPin = Console.ReadLine();
                                        Console.WriteLine("");
                                        int value = 0;
                                        
                                        while (newPin.Length != 4 || int.TryParse(newPin, out value) != true || value == res)
                                        {
                                            Console.WriteLine("New PIN:");
                                            newPin = Console.ReadLine();
                                            Console.WriteLine("");

                                            if (int.TryParse(newPin, out value) == true)
                                            {
                                                account.NewPin(value);
                                            }
                                        }
                                    }
                                    //Input #9--------------------------------------------------------------------------->
                                    else if (inp == 9)
                                    {
                                        Console.WriteLine("Have a good day!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter correct option");
                                        Console.WriteLine("");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter valid option");
                                    Console.WriteLine("");
                                }
                            }

                        }

                    }

                }

            }
        }
    }
}
