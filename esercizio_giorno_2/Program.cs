using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_giorno_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona newPersona = new Persona// ho scelto di istanziare le proprietà nella classe Program dove stampo i dati dei metodi richiesti usando Console.writeLine-newPersona è il nuovo oggetto, il costruttore new mi creaq il nuovo oggetto della classe persona.
            {
                Nome = "Marco",
                Cognome = "Pincopallo",
                Eta = 99
            };

            Console.WriteLine(newPersona.GetNome());
            Console.WriteLine(newPersona.GetCognome());
            Console.WriteLine(newPersona.GetEta());
            Console.WriteLine("I dettagli della persona sono: \n" + newPersona.GetDettagli());
            Console.ReadLine();
        }

    }
}
