using System;

namespace C_Sharp_HW20
{
    public class Vasya : Man
    {
        public override void BeFather(string child) => Console.WriteLine($"Vasya is the father to {child}");
        public override void ConceiveChild(string woman) => Console.WriteLine($"Vasya conceived a child with {woman}");
        public override void Drive(string car) => Console.WriteLine($"Vasya drives a {car}");
        public override void Work(int hours) => Console.WriteLine($"Vasya worked {hours} hours");
        public static void WriteBook(string book) => Console.WriteLine($"Vasya wrote a book {book}");
        public static void GoingVacation(string country) => Console.WriteLine($"Vasya went on vacation to {country}");

    }
}
