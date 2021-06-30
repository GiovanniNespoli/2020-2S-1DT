using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personagem jogador = new Personagem();

            


            string rr = "";
        
            Console.WriteLine("====================================");
            Console.WriteLine("BEM VINDO A BATALHA");
            Console.WriteLine("====================================");

            Console.WriteLine("INSIRA SEUS DADOS:");
            Console.WriteLine("");
        do{
            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Idade:");
            int idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            Console.Write("Altura (cm):");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Peso (kg):");
            int peso = int.Parse(Console.ReadLine());

            jogador.name = nome;
            jogador.years = idade;
            jogador.heigth = altura;
            jogador.weight = peso;
            jogador.vida = 100;

            Console.WriteLine("");

            Console.WriteLine($"Seu nome é {jogador.name}");
            Console.WriteLine($"Você tem {jogador.years} anos");
            Console.WriteLine($"Você tem {jogador.heigth} cm");
            Console.WriteLine($"Você pesa {jogador.weight} kg");

            Console.WriteLine("");

            Console.WriteLine("Essa informções esão corretas? (s/n)");
            rr =Console.ReadLine();
        }while( rr == "n");

        Console.WriteLine("");

        int força(int idade, int altura, int peso)
        {
           int fim = (altura / peso) * idade;

           return fim;
        }

        int defesa(int altura, int peso)
        {
            int fim = (altura * peso) / 1000;

            return fim;
        }

        Console.WriteLine($"Força: {força(jogador.years, jogador.heigth, jogador.weight)}");
        Console.WriteLine("");
        Console.WriteLine($"Defesa: {defesa(jogador.heigth, jogador.weight)}");
        Console.WriteLine("====================================");

        Console.WriteLine($"Seu personagem terá mais defesa ou ataque? ([a]ataque | [b]defesa)");
        string resp = Console.ReadLine();
        if( resp == "a")
        {
            Console.WriteLine($"+10 de ataque ({força(jogador.years, jogador.heigth, jogador.weight) + 10} de ataque)");
        } else if( resp == "b")
        {
            Console.WriteLine($"+10 de defesa ({defesa(jogador.heigth, jogador.weight) + 10} de defesa)");
        }
        Console.WriteLine("");
        
        Console.WriteLine("====================================");

        Console.WriteLine("Eai amigo, eu sou John um cavaleiro, vejo que voce é novato em, vem vamos treinar seu ataque");

        Console.WriteLine("====================================");

        Personagem jogador2 = new Personagem();
        jogador2.name = "Boneco";
        jogador2.years = 10;
        jogador2.heigth = 150;
        jogador2.weight = 50;
        jogador2.vida = 10;

        Console.WriteLine("TREINO");

        Console.WriteLine($"{jogador.name} VS {jogador2.name}");

        Console.WriteLine("");

        do{
        Console.WriteLine($"{jogador2.name} irá atacar!!");
        Console.WriteLine($"{jogador.name} esquivar ou bloquear? [e]esquivar|[b]bloquear");
        string def = Console.ReadLine();

        if(def == "e")
        {
            Console.WriteLine($"O ataque do {jogador2.name} pegou de raspão!!");
            Console.WriteLine($"Vida restante do {jogador.name}: {jogador.vida + 10 - força(jogador2.years, jogador2.heigth, jogador2.weight)} ");
        } else if( def == "b")
        {
            Console.WriteLine($"O ataque do {jogador2.name} te impulsionou para tras!! (-10 de dano sofrido)");
            Console.WriteLine($"Vida restante do {jogador.name}: {jogador.vida + 10 - força(jogador2.years, jogador2.heigth, jogador2.weight)} ");
        }
        jogador.vida = jogador.vida + 10 - força(jogador2.years, jogador2.heigth, jogador2.weight);

        Console.WriteLine($"{jogador.name} deu um {jogador.atacar()}");
        Console.WriteLine($"UM ATAQUE SUPER EFETIVO");
        Console.WriteLine($"Vida restante do {jogador2.name}: {jogador2.vida - força(jogador.years, jogador.heigth, jogador.weight)}");

        jogador2.vida = jogador2.vida - força(jogador.years, jogador.heigth, jogador.weight);

        Console.WriteLine("====================================");


        }while( jogador2.vida > 0 || jogador.vida > 0);

            Console.WriteLine("Batalha finalizada por dano crítico ao Boneco");
        }
    }
}
