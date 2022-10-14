namespace ProjetoEntidadeClasseEmpresa
{
     public static class Validacao
    {
        public static bool CampoNuloOuEspaco(this string campo)
        {
            return String.IsNullOrWhiteSpace(campo);
        }
    }
}