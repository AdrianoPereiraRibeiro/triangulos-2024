namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        public class TrianguloChecando
        {
            public double x;
            public double y;
            public double z;
            public int retorno;
            public string resposta;
            public string ProcessamentoIF()
            {
                if (x == y || y == z || x == z) { retorno = 1; };
                if (x == y && x == z && y == z) { retorno = 0; };
                if (x != y && x != z && y != z) { retorno = 2; };

                switch (retorno)
                {
                    case 0:
                        resposta = ("O triângulo é equilátero.");
                        break;
                    case 1:
                        resposta = ("O triângulo é isósceles. ");
                        break;
                    case 2:
                        resposta = ("O triângulo é escaleno. ");
                        break;
                }
                return resposta;
            }

        }
    }
    
}
