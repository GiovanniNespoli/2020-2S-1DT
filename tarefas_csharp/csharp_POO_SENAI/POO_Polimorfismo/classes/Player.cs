using System;
namespace POO_Polimorfismo.classes
{
    public abstract class Player
    {
        private float velociade;
        private float forcaPaulo;

        // metodo

        public virtual void correr(){
            this.velociade = 8000;
            Console.WriteLine($"A VELOCIADE DELE SEJA MAIS DE {this.velociade}");
        }
        public virtual void pular(){
            this.forcaPaulo = 8000;
            Console.WriteLine($"O PULO DELE SEJA MAIS DE {this.forcaPaulo}");
        }
    }
}