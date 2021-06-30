using System;

namespace forr
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("selecione um número: ");
            int resp = int.Parse( Console.ReadLine());

            for( int r = 0; r <=10; r++)
            {
                
                Console.WriteLine($"{resp} x {r} = {resp * r}");
            }
        }
    }
}
