using System;

namespace C_Sharp_HW20
{
    class Masha : Woman
    {
        public override void BeMother(string child) => Console.WriteLine($"Masha is a mother to {child}");
        public override void GetPregnant(string man) => Console.WriteLine($"Masha got pregnant by {man}");
        public override void Drive(string car) => Console.WriteLine($"Masha drive a {car}");
        public override void Work(int hours) => Console.WriteLine($"Masha worked {hours} hours");
        public static void Graduate(string university) => Console.WriteLine($"Masha graduated {university}");
        public static void GoCinema(string movie) => Console.WriteLine($"Masha went to the cinema on {movie}");

    }
}
