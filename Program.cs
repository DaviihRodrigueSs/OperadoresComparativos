using System.Globalization;

namespace OperadoresComparativos
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //operador comparativo  a e menor que 10, o retorno dessa operação deve ser false
            bool c1 = a < 10;

            Console.WriteLine(c1);

            int b = 20;

            // agora pedi para o programa verificar se b e maior ou igual a 20. O retorno deve ser true.
            bool c2 = b >= 20;

            //Pedi para o operador verificar se b e diferente de 20. O retorno deve ser false.
            bool c3 = b != 20;

            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}