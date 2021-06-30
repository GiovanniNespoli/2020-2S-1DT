using System;
using Controller;
using View;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoController cc = new CartaoController();

            cc.Listar();
        }
    }
}
