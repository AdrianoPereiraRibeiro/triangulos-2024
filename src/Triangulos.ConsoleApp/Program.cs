namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            TrianguloChecando tr = CapturarValores();
            string resposta = tr.ProcessamentoIF();
            Console.WriteLine(resposta);
            Console.ReadLine();
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
