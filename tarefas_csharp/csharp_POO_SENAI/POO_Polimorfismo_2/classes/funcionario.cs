using System;
namespace POO_Polimorfismo_2.classes

{
    public class funcionario
    {
        
        public string[] lista = {"gigio", "giovanni", "gi"};

       public void Mostrar(){
            for( int i = 0; i < lista.Length; i++){

                Console.WriteLine(lista[i]);
            }
        }

      public void Mostrar(int indice){
            
            Console.WriteLine(lista[indice]);
        }

        public void Mostrar(string busca)
        {
            for( int i = 0; i < lista.Length; i++)
            {
                if(busca == lista[i])
                {
                    Console.WriteLine($"Boa você achou uma nome na nossa lista ({busca})");
                } 
            }
        }
    }
}