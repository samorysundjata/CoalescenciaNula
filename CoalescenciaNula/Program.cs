using System;

namespace CoalescenciaNula
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            Console.WriteLine("Escreva Null na linha abaixo e dê Enter:");

            Console.ReadLine();

            try
            {
                int? x = null;

                var resultx = x ?? 0;

                Console.WriteLine(resultx);
            }
            catch (Exception)
            {
                Console.WriteLine("Erro!");
            }

            Console.WriteLine("Digite ZERO ou DEZ e dê Enter:");

            try
            {
                int? y = Convert.ToInt32(Console.ReadLine());
                var resulty = y ?? 0;
                Console.WriteLine(resulty);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Você não colocou um número!");
            }

            Console.Write("Pressione qualquer tecla para fechar...");
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}