namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PinNumber PIN = new PinNumber();
            Console.WriteLine("Please set your PIN number:");
            int userPIN = int.Parse(Console.ReadLine());
            PIN.GetPinNumber(userPIN);
            Console.WriteLine("Welcome! For security purposes, please enter your PIN number:");
            int inputPIN = int.Parse(Console.ReadLine());


            BankAccount account = new BankAccount();
            // Check if the entry is valid
            bool valid;

            if (inputPIN == userPIN)
            {
                do
                {
                    Console.WriteLine("Please type a number to choose from the following options:");
                    Console.WriteLine(" Option 1: Deposit\n " +
                        "Option 2: Withdrawal\n " +
                        "Option 3: Get Balance\n " +
                        "Option 4: Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter an amount to deposit:");
                            double amountDeposit = double.Parse(Console.ReadLine());
                            account.Deposit(amountDeposit);
                            Console.WriteLine("Your new balance:");
                            Console.WriteLine(account.GetBalance());
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Please enter an amount to withdraw:");
                            double amountWithdraw = double.Parse(Console.ReadLine());
                            account.Withdraw(amountWithdraw);
                            Console.WriteLine("Your new balance:");
                            Console.WriteLine(account.GetBalance());
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Your current balance:");
                            Console.WriteLine(account.GetBalance());
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using our Bank App! Have a nice day!");
                            valid = false;
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            valid = false;
                            break;
                    }
                } while (valid);
            }
            else
            {
                Console.WriteLine("Wrong PIN Number");
            }

        }
    }
}
