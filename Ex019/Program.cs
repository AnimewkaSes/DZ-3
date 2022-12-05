using System;


internal class Program

{
    private static void Main(string[] args)
    {
        char rest;
    do{
        Console.Clear();
        Console.WriteLine("Программа для определения пятизначного числа на палиндром");
        Console.WriteLine("Введите число");
        string num = Console.ReadLine();
        string revs = "";
        char [] numRevs =  num.ToCharArray();
        Array.Reverse(numRevs);
        revs = new string(numRevs);

        bool result = num.Equals(revs);

        if (result)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
        }
        Console.Write("Для продолжения введите y, для завершения любая клавиша: ");
rest = Convert.ToChar(Console.ReadLine());
}
while (rest =='y');
}
}
