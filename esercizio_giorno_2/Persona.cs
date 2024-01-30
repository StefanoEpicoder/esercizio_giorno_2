using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_giorno_2 //ESERCIZIO SENZA COSTRUTTORE
{
    internal class Persona// definisco la classe, in questo caso Persona
    {
        public string Nome { get; set; } // definisco le proprietà della classe Persona(sono un modo per accedere ai campi di una classe in modo controllato get e set
        public string Cognome { get; set; } // definisco le proprietà della classe Persona(sono un modo per accedere ai campi di una classe in modo controllato get e set
        public int Eta { get; set; } // definisco le proprietà della classe Persona(sono un modo per accedere ai campi di una classe in modo controllato get e set

        public string GetNome() // scrivo i tre metodi di Nome, Cognome, Eta, sopra ho definito le proprità, qui ritorno il valore 
        {
            return Nome; // ritorno il valore
        }
        public string GetCognome() //metodo
        { 
            return Cognome; //ritorno il valore
        }
        public int GetEta() //metodo
        { 
            return Eta; //ritorno il valore
        }
        public string GetDettagli()
        {
            return "Nome: " + Nome + ", Cognome: " + Cognome + ", Eta: " + Eta;
        }
    }
}
