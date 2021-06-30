using System.Collections.Generic;
using System;

namespace obj_com_argumentos.classes
{
    public class carrinho
    {
        public float ValorTotal { get; set; }
        
        

        List<Produto> carr = new List<Produto>();

        public void addCar(Produto x)
        {
            carr.Add(x);
        }

        public void mostrarCar()
        {
            if(carr != null)
            {
                foreach(Produto x in carr)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"PRODUTO: {x.P} / CODIGO: {x.Codigo} / NOME: {x.Nome} / PREÇO: {x.Preço}R$");
                    Console.ResetColor();
                }
            }
        }

        public void valorTotal()
        {
            if(carr != null)
            {
                ValorTotal = 0F;

                foreach( Produto x in carr)
                {
                    ValorTotal += x.Preço;
                }
                Console.WriteLine($"O valor da compra no total está em: {ValorTotal}R$");
            }
        }

        public void remover(Produto x)
        {
            carr.Remove(x);
        }

        public void alterarCod( int cod, Produto novo)
        {
            carr.Find(x => x.Codigo == cod).Codigo = novo.Codigo;
        } 
    }
}