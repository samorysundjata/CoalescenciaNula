using System;

namespace CoalescenciaNula
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MenuPrincipal();
            }
        }

        private static void Resultado()
        {
            Console.WriteLine("A primeira chamada é nula, vai retomar zero.");

            int? x = null;

            var resultx = x ?? 0;

            try
            {
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

            Console.ReadKey();
        }

        private static bool MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Esta é a demonstração da Coalescência Nula.");
            Console.WriteLine("Para ver o exemplo digite: Entrar");
            Console.WriteLine("Para fechar tudo digite: Sair");
            Console.Write("\r\nEscolha uma opção:  ");

            switch (Console.ReadLine())
            {
                case "Entrar":
                    Resultado();
                    return true;
                case "Sair":
                    return false;
                default:
                    return true;
            }
        }

        #endregion Private Methods
    }
}