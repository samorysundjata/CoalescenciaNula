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

            int? x = null;

            var resultx = x ?? 0;

            Console.WriteLine(resultx);

            Console.WriteLine("Digite ZERO ou DEZ e dê Enter:");

            int? y = Convert.ToInt32(Console.ReadLine());

            var resulty = y ?? 0;

            Console.WriteLine(resulty);

            Console.Write("Pressione qualquer tecla para fechar...");
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}