namespace ProjetoEntidadeClasseEmpresa
{
    public class Empresa
    {
        private string _nome; //atributo
        private string _telefone;
        private int _totalFuncionarios;

        //propriedades
        public string Nome{
            get{return _nome;}
            set{_nome = value;}
        }
        public string Telefone
        {
            get{return _telefone;}
            set{_telefone = value;}
        }

      
      
    public Empresa(string nome, string telefone, int totalFuncionarios)
    {
        _nome = nome;
        _telefone = telefone;
        _totalFuncionarios = totalFuncionarios;
    }

    }
}