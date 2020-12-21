using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodotti
{
    public class gestioneProdotto
    {

        public static double InserisciPrezzo(int n)
        {
            double prezzo;
            do
            {
                Console.Write($"Inserisci Il prezzo dell {n+1}° prodotto: ");
                prezzo = double.Parse(Console.ReadLine());
                if (prezzo < 0)
                    Console.WriteLine("Prezzo non valido.");

            } while (prezzo <=  0);

            return prezzo;
        }

        public static int InserisciQuantita(int n)
        {
            Console.Write($"Inserisci la quantita del {n+1}° prodotto: ");
            int quantita = int.Parse(Console.ReadLine());
            return quantita;
        }

        public static void StampaVideo(int quantita, double prezzo, int n)
        {
            double somma;
            somma = prezzo * quantita;
            Console.WriteLine($"Il prezzo totale del {n+1}° prodotto è {somma}");
        }
    }
}
