using System;

namespace C_Sharp_HW20
{
    class Petya : Man
    {
        public override void BeFather(string child) => Console.WriteLine($"Petya is a father to {child}");
        public override void ConceiveChild(string woman) => Console.WriteLine($"Petya conceived a child with {woman}");
        public override void Drive(string car) => Console.WriteLine($"Petya drives a {car}");
        public override void Work(int hours) => Console.WriteLine($"Petya worked {hours} hours");
        public static void ListenMusic(string genre) => Console.WriteLine($"Petya likes to listen to {genre}");
        public static void BuildHouse(string location) => Console.WriteLine($"Petya built a house in {location}");

    }
}
