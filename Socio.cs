namespace ProjetoEntidadeClasseEmpresa
{
    public class Socio
    {
        public string Nome {get;set;}
        public string Cpf {get;set;}
        public string Rg {get;set;}
        public DateTime Nascimento {get;set;}
        public string Telefone {get;set;}
        public string Endereco {get;set;}

        public void ConfirmarCadastro(string nome, string cpf, string telefone, 
                                    string endereco = "Rua Lilás, 45")
        {

            var resultado = Matematica.Dobro(2);
            Console.WriteLine($"Nome:{nome} - CPF: {cpf} - Telefone: {telefone} -Endereco:{endereco}");
        }

        public void ExibirMensagem()
        {

                Console.WriteLine("Olá");
        }
    }
}