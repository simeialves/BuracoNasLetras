using System;
using System.Collections.Generic;

namespace BuracoNasLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;

            Console.WriteLine("Digite o texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Texto inserido: " + Texto);
            Console.WriteLine("Tamanho do texto: " + ContadorDeLetras(Texto));
            Console.WriteLine("Total de palavras: " + ContadorDePalavras(Texto));
            Console.WriteLine("Total de buracos no texto: " + ContadorDeBuracos(Texto));
        }
        public static int ContadorDeLetras(string TextoDigitado)
        {
            int Contador = 0;

            for (int i = 0; i < TextoDigitado.Length; i++)
            {
                if (Char.IsLetterOrDigit(TextoDigitado[i]) || Char.IsWhiteSpace(TextoDigitado[i]))
                {
                    Contador++;
                }
            }

            return Contador;
        }
        public static int ContadorDePalavras(string TextoDigitado)
        {
            int Contador = 1;

            for (int i = 0; i < TextoDigitado.Length; i++)
            {
                if (Char.IsWhiteSpace(TextoDigitado[i]))
                {
                    Contador++;
                }
            }

            return Contador;
        }
        public static int ContadorDeBuracos(string TextoDigitado)
        {
            int Contador = 0;

            for (int i = 0; i < TextoDigitado.Length; i++)
            {
                if (
                    TextoDigitado[i] == 'A' ||
                    TextoDigitado[i] == 'D' ||
                    TextoDigitado[i] == 'O' ||
                    TextoDigitado[i] == 'P' ||
                    TextoDigitado[i] == 'Q' ||
                    TextoDigitado[i] == 'R' ||
                    TextoDigitado[i] == 'a' ||
                    TextoDigitado[i] == 'b' ||
                    TextoDigitado[i] == 'd' ||
                    TextoDigitado[i] == 'e' ||
                    TextoDigitado[i] == 'g' ||
                    TextoDigitado[i] == 'o' ||
                    TextoDigitado[i] == 'p' ||
                    TextoDigitado[i] == 'q'

                    )
                    Contador++;
                else if (TextoDigitado[i] == 'B')
                {
                    Contador += 2;
                }
            }

            return Contador;
        }
    }
}
