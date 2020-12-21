using System;
using Prodotti;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumatore
{
    class Program
    {
        static void Main(string[] args)
        {
            double prezzo = 0;
            int quantita = 0;
            for (int count = 0;  count < 3; count++)
            {
                prezzo = gestioneProdotto.InserisciPrezzo(count);
                quantita = gestioneProdotto.InserisciQuantita(count);
                gestioneProdotto.StampaVideo(quantita, prezzo, count);
            }
            Console.ReadLine();
            
        }
    }
}
