/*
 * *Class name: Banking App
 * Version: 1
 * Author: Rabo
*/

void BuildBankingApp()
{
    int choice;
    double depositAmount;
    double accountBalance=1000.00;
    double withdrawAmount;

    Console.WriteLine("Please choose an option:");
    Console.WriteLine("========================");
    Console.WriteLine("1. Deposit ");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. View current account information");
    Console.WriteLine("4. Please choose an option (1-3)");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1 || choice == 2 || choice == 3)
    {
        if (choice == 1)
        {
            Console.WriteLine("You have chosen to deposit");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");
            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if (choice == 2)
        {
            Console.WriteLine("You have chosen to withdraw");
            Console.WriteLine("How much do you want to withdraw?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");
            accountBalance -= withdrawAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if (choice == 3)
        { 
            Console.WriteLine("You have chosen to view your current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else
        {
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please choose 1 or 2");
    }

    }
    BuildBankingApp(); // Loop back to the main menu

