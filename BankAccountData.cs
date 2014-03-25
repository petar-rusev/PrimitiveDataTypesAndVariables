using System;

class BankAccountData
{
    static void Main()
    {
        string FirstName = "Petar";
        string MiddleName = "Rusev";
        string LastName = "Rusev";

        object Holder = FirstName + " " + MiddleName + " " + LastName;
        Decimal Balance = 85789452344;
        string BankName = "First Investment Bank";
        string IBAN = "BG49STSA93000035574047";
        long FirstCard = 8594213698745261;
        long SecondCard = 9685324789856372;
        long ThirdCard = 7796435897967483;

        Console.WriteLine("Holder: {0}\nBalance: {1} \u20a4\nBank Name: {2}\nIBAN: {3}\nNumber Credit Card 1: {4}\nNumber Credit Card 2: {5}\nNumber Credit Card 3: {6}\n",Holder,Balance,BankName,IBAN,FirstCard,SecondCard,ThirdCard);
    }
}

