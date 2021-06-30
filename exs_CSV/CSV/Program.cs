using System;
using Controller;
using Model;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController PC = new ProdutoController();
            
            PC.escrever();
            PC.Listar();
        }
    }
}
