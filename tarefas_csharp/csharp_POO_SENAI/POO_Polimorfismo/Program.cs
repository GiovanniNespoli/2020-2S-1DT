using System;
using POO_Polimorfismo.classes;

namespace POO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan man = new MegaMan();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Seu nome é {man.Name} e usa o {man.Buster} que faz com que ");
            man.correr();

            Console.WriteLine("");

            Zero zz = new Zero();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Seu nome é {zz.Name} e usa uma {zz.Sword} que faz com que ");
            zz.pular();
        }
    }
}
