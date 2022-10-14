namespace ProjetoEntidadeClasseEmpresa
{
    public class DerivedPoint :  Point
    {
        
        public void DerivedPointMethod()
        {
            x = 3; // este atributo pertence à classe Point
            y = 5; // este atributo pertence à classe Point

            Console.WriteLine($"Valor de x = { x } - valor de y = { y }");
        }        
    }
}