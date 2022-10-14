namespace ProjetoEntidadeClasseEmpresa
{
    public class Processar    
    {

        public string  DigitarCampoId()
        {
            Console.WriteLine("Digitar Id:");

            string valorDigitado = Console.ReadLine();

            return ProcessaCampoId(valorDigitado);
        }


        private string ProcessaCampoId(string id)
        {
            while(Validacao.CampoNuloOuEspaco(id))
            {            
                return DigitarCampoId();                
            }   
            return id;
        }
    }
}