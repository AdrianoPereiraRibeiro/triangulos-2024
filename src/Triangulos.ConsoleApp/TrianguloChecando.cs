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
            public int ProcessamentoIF()
            {
                if (x == y || y == z) { retorno = 1; };
                if (x == y && x == z) { retorno = 0; };
                if (x != y && x != z && y != z) { retorno = 2; };

                return retorno;
            }




        }
    }
}
