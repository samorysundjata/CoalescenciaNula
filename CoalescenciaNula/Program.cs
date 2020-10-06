using System;

namespace CoalescenciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");

            int? x = Console.Read();


            var resultx = x ?? 0;


            Console.WriteLine(resultx);


            int? y = 10;


            var resulty = y ?? 0;


            Console.WriteLine(resulty);

            Console.WriteLine("Digite ENTER duas vezes para sair");
            Console.ReadKey();

        }
    }
}
