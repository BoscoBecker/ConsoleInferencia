using System;

namespace ConsoleInferencia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Warning Var em vez de tipo não é uma boa prática
            var x = 10;
            var y = 10.0;
            var z = " Joao";

            Console.WriteLine(x + y + z);
        }
    }
}
