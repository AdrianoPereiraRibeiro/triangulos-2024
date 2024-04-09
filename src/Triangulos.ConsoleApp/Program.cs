namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            TrianguloChecando tr = CapturarValores();
            int retorno = tr.ProcessamentoIF();
            VerificarTipoTriangulo(retorno);
            Console.ReadLine();
        }

        public static void VerificarTipoTriangulo(int retorno)
        {
            switch (retorno)
            {
                case 0:
                    Console.WriteLine("O triângulo é equilátero.");
                    break;
                case 1:
                    Console.WriteLine("O triângulo é isósceles. ");
                    break;
                case 2:
                    Console.WriteLine("O triângulo é escaleno. ");
                    break;
                case 3:
                    Console.WriteLine("Isso não é um triangulo");
                    break;
            }
        }

        public static TrianguloChecando CapturarValores()
        {
            TrianguloChecando tr = new TrianguloChecando();
            Console.WriteLine("Digite o valor de X do triângulo:");
            tr.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y do triângulo:");
            tr.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de Z do triângulo:");
            tr.z = Convert.ToDouble(Console.ReadLine());
            return tr;
        }
    }
}
