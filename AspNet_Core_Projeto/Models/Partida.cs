using System;

namespace Models
{
    public class Partida
    {
        public int IdPartida { get; set; }
        public int IdJogador { get; set; }
        public int IdJogador2 { get; set; }
        public DateTime HorarioDeInicio{ get; set; }
        public DateTime HorarioDeTermino{ get; set; }

        
    }
}