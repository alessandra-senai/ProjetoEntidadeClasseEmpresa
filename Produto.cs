using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEntidadeClasseEmpresa
{
    public class Produto
    {
        private int codigo;//atributo ==> caracteristica da Entidade Classe
        private string nome;
        private string descricao;
        private decimal preco_compra;
        private decimal preco_venda;
        private int quantidade;
        private bool ativo = true;
        private DateTime data_cadastro;


    //propriedades -- devo criar as propriedades toda vez que o atributo é private
    public int Codigo
    {
        get{return this.codigo;}
        set{this.codigo = value;}
    }
   
        public void Cadastrar(Produto produto)
        {
           Console.WriteLine($"Produto cadastrado com sucesso - codigo: {produto.codigo}");
        }
    }
}