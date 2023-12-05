using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_ponderada {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i;
            double primeiro, segundo, terceiro, soma, media;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++) {
                Console.WriteLine("Digite tres numeros:");
                primeiro = double.Parse(Console.ReadLine());
                segundo = double.Parse(Console.ReadLine());
                terceiro = double.Parse(Console.ReadLine());

                soma = (primeiro * 0.2) + (segundo * 0.3) + (terceiro * 0.5);
                media = soma / 10;

                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));
            }
        }
    }
}
