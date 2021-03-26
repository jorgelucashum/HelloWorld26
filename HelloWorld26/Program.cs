using System;

namespace HelloWorld26
{
    class Program
    {
        // DateTimeKind e padrão ISO 8601:
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); // Instancia a data com o padrão do tipo 'Local'.
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc); // Instancia a data com o padrão do tipo 'Utc'.
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58); // Data sem especificação.

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine("");

            // Padrão ISO 8601:
            // yyyy-MM-ddTHH:mm:ssZ // 'Z' No final indica que a data/hora está em Utc. 

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58"); // Convertendo um tipo 'string' para DateTime.
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z"); // Esse formato de string instancia a data com o tipo 'local'.

            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Formato menos recomendado.
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Mais aconselhado converter para horário global com '.ToUniversalTime()'.
        }
    }
}
