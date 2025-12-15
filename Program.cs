using Linq.Database;
using Linq.Models;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefenen met Linq");

            // ### Oefening 1: Alle voorbeelden ophalen
            // Haal alle voorbeelden op uit de database en toon de naam en beschrijving.
            Console.WriteLine("Oefening 1 Alle voorbeelden ophalen");
            using (var context = new VoorbeeldDBContext())
            {
                var voorbeelden = context.Voorbeelden.ToList();

                foreach (var voorbeeld in voorbeelden)
                {
                    Console.WriteLine($"Naam: {voorbeeld.Name}; Beschrijving: {voorbeeld.Description}");                    
                }

            }

            // ### Oefening 2: Filteren op rol
            // Haal alle voorbeelden op die de rol `Administrator` hebben.


        }
    }
}
