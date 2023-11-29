using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
namespace Dhondt
{
    
    /// <summary>
    /// A program belépési pontja és fő vezérlője.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Partok.Mandatum = Convert.ToInt32(File.ReadAllLines("input.txt").Take(1).First());
            List<Partok> adatok = File.ReadAllLines("input.txt").Skip(1).Select(sor => new Partok(sor)).ToList();
            Szamol sz = new Szamol(adatok);
            sz.Kiir();
            Console.ReadLine();
        }
    }
}
