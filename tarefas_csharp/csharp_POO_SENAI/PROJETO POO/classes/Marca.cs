using System;
using System.Collections.Generic;

namespace PROJETO_POO.classes
{
    public class Marca
    {
        private int Codigo { get; set; } 
        public string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }

        public List<Marca> marcas = new List<Marca>();    

        public Marca cadastrar()
        {
            Marca ADDMarca = new Marca();

            Console.WriteLine("Insira o código da marca que será adicionada: ");
            ADDMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome da marca que será adicionada: ");
            ADDMarca.NomeMarca = Console.ReadLine();

            ADDMarca.DataCadastro = DateTime.UtcNow;

            marcas.Add(ADDMarca);

            return ADDMarca;

        }

        public void ListarMarcas()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach(Marca x in marcas)
            {
                Console.WriteLine($"NOME: {x.NomeMarca} // CODIGO: {x.Codigo} // DATA: {x.DataCadastro}");
            }

            Console.ResetColor();
        }
        
        public void DeletarMarca(int cod)
        {
            Console.WriteLine("Insira o codigo a ser deletado: ");
            cod = int.Parse(Console.ReadLine());

            Marca delet = marcas.Find(x => x.Codigo == cod);
            marcas.Remove(delet);
        }
        
    }
}