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
            public int fail;
            public int ProcessamentoIF()
            {
                if (x + y < z || x + z < y || y + z < x) { retorno = 3; }
                else
                {
                    if (x == y || y == z|| x==z) { retorno = 1; };
                    if (x == y && x == z && z==y) { retorno = 0; };
                    if (x != y && x != z && y != z) { retorno = 2; };
                }
                return retorno;
                
            }




        }
    }
}
