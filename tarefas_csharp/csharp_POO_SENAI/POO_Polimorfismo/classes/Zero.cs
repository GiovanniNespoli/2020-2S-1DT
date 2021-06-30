namespace POO_Polimorfismo.classes
{
    public class Zero : Player
    {
        private string name = "Zero";
        public string Name{
            get{ return name;}
        }
        private string sword = "sword";
        public string Sword{
            get{ return sword;}
        }
        public override void pular()
        {
            base.pular();
        }
    }
}