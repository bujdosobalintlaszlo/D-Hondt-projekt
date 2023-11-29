using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhondt
{
    /// <summary>
    /// A pártokat és kapcsolódó adatokat tároló osztály.
    /// </summary>
    public class Partok
    {
        public static int Partszam { get; set; }
        public static int Mandatum { get; set; }
        public List<Part> Parts { get; set; }

        public Partok()
        {
            Parts = new List<Part>();
        }

        /// <summary>
        /// Sor alapján inicializálja a Partok objektumot.
        /// </summary>
        /// <param name="sor">A sor, amelyből inicializáljuk a Partok objektumot.</param>
        public Partok(string sor)
        {
            Parts = new List<Part>();
            List<string> sorSplit = sor.Split(' ').ToList();
            Parts.Add(new Part(sorSplit[0], int.Parse(sorSplit[1]), int.Parse(sorSplit[2]), int.Parse(sorSplit[3])));
            Partszam++;
        }
    }
}
