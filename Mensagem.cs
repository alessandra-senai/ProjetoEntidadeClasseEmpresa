namespace ProjetoEntidadeClasseEmpresa
{
    internal class Mensagem
    {
        internal void BemVindo()
        {
            Console.WriteLine("Seja bem-vindo");
        }

        protected void Quinta()
        {
            Console.WriteLine("Hoje é quinta-feira");
        }

        public void Geral()
        {
            Console.WriteLine("Boa noite!");
        }
        private void Sexta()
        {
            Console.WriteLine("Hoje não é sexta-feira");
        }

    }

}