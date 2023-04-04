// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int FiveDigitNumber = ReadNumber ("FiveDigitNumber");
TryPalindrome (FiveDigitNumber);

int ReadNumber (string argument)
{
    int number;
    Console.WriteLine ($"Input fife-digit number: ");
    while((!int.TryParse(Console.ReadLine(), out number)))
    {
        Console.WriteLine ("It,s not a number");
    }
   return number;
}

void TryPalindrome (int Num)
{
    if (Num/10000 == Num%10 && 
        Num/1000%10 == Num/10%10)
    {
        Console.WriteLine("It,s a palindrome");
    }
    else
    {
        Console.WriteLine("It,s not a palindrome");
    }
}

