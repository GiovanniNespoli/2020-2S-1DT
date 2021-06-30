namespace statico
{
    public static class troca
    {
        private static float valorDolar = 5F;
        private static float valorEuro = 6F;



        // metodos static
        public static float dolarReais(float valor)
        {
            return valorDolar * valor;
        }

        public static float reaisDolar(float valor)
        {   
            return valor / valorDolar;
        }

        public static float euroReais(float valor)
        {
            return valorEuro * valor;
        }

        public static float reaisEuro(float valor)
        {
            return valor / valorEuro;
        }
    }
}