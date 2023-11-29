using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhondt
{
    public class Szamol
    {
        private List<Partok> adatok;

        public Szamol(List<Partok> adatok)
        {
            this.adatok = adatok;
        }
        public void Kiir()
        {
            foreach (Partok partok in adatok)
            {
                Console.WriteLine($"Partok száma: {partok.Parts.Count}");

                foreach (Part part in partok.Parts)
                {
                    Console.WriteLine($"Neve: {part.PartNev}, Nemzetiseg: {part.Nemzete}, Szavszam.:{part.SzavazatSzam}, Szazalek:{part.Szazalek}");
                }

                Console.WriteLine();
            }
        }

        public void Lefuttat()
        { 
        
        }
    }
}
