namespace ProjetoEntidadeClasseEmpresa
{
    public static class Matematica
    {
        private static int valor = 2;

        public static double Dobro(this double a)
        {
            return a * valor;
        }

        public static double Metade(this double a)
        {
            return a / valor;
        }
    }

}