using System;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    }
    public string getCardNum() {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public string getFirstName() {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    public void setCardNum(string newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose one from the following options... ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit?");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you. Your new balance is: {0}", currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw?");
            double withdrawal = double.Parse(Console.ReadLine());
            // Check if the user has enough money 
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance :( ");

            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you. Have a good day :) ")
             }

        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance: {0} $", currentUser.getBalance);
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1234123412341234", 3012, "Alaa", "Abdalqader", 1150.31));
        cardHolders.Add(new cardHolder("1111222233334444", 1206, "Huthayfa", "Shaheen", 7195.00));
        cardHolders.Add(new cardHolder("1478258936971346", 2801, "Sondos", "Abdalqader", 2837.50)); ;
        cardHolders.Add(new cardHolder("7895456212384568", 2706, "Joman", "Jaafreh", 12555.00));
        cardHolders.Add(new cardHolder("1919254632587489", 3005, "Ahmad", "Abdalqader", 1234.56));

        // Prompt the user
        Console.WriteLine("Welcome to the simple ATM");
        Console.WriteLine("Please insert your debit card number");

        string debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Consol.ReadLine();
                // Check 
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if(currentUser != null) { break;  }
                else
                {
                    Consol.WriteLine("Card not recognized. Please try again");

                }
            }
            catch
            {
                Consol.WriteLine("Card not recognized. Please try again");
            }
        }

        Console.WriteLine("Please Enter ypur pin: ");

        int newPin = 0;

        while (true)
        {
            try
            {
                newPin = Int.Parse(Consol.ReadLine());
                // Check 
                if (currentUser.getPin() == newPin) { break; }
                else
                {
                    Consol.WriteLine("Incorrect Pin number. Please try again");

                }
            }
            catch
            {
                Consol.WriteLine("Incorrect Pin number. Please try again");
            }
        }

        Console.WriteLine("Welcome {0} :) ", currentUser.getFirstName);
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());

            }
            catch
            {

            }

            if(option == 1) { deposit(currentUser); }
            else if(option == 2) { withdraw(currentUser); }
            else if(option == 3) { balance(currentUser); }
            else if(option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you ! Have a good day");
    }
}