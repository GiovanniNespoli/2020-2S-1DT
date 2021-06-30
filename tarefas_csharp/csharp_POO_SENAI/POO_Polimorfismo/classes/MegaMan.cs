namespace POO_Polimorfismo.classes
{
    public class MegaMan : Player
    {
        private string name = "MegaMan";
        public string Name{
            get{return name;}
        }
        private string buster = "Buster";
        public string Buster{
            get{ return buster;}
        }
        public override void correr()
        {
            base.correr();
        }
    }
}