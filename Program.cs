using System;

class Program
{
    static void Main(string[] args) {
        string firstName = "Sadakov";
        string lastName = "Denis";
        string cup1 = "Tea";
        string cup2 = "Coffe";
        string tempValue;

        Console.WriteLine($"Имя: {firstName} Фамилия: {lastName}");
        tempValue = firstName;
        firstName = lastName;
        lastName = tempValue;
        Console.WriteLine($"Имя: {firstName} Фамилия: {lastName}");
        Console.Write('\n');

        Console.WriteLine($"Чашка 1: {cup1} Чашка 2: {cup2}");
        tempValue = cup1;
        cup1 = cup2;
        cup2 = tempValue;
        Console.WriteLine($"Чашка 1: {cup1} Чашка 2: {cup2}");
    }
}

