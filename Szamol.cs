using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhondt
{
    public class Szamol
    {
        private Partok p;

        public Szamol()
        {
            p = new Partok("input.txt");

        }

        public List<int> Kivalasztott()
        {
            List<int> ki = new List<int>();

            return ki;
        }
        public void MatrixKi()
        {
            List<int> MatrixSzamok = new List<int>();
            for (int i = 1; i <= Partok.Partszam; i++)
            {
                for (int j = 1; j <= Partok.Mandatum; j++)
                {
                    MatrixSzamok.Add((int)Math.Round((double)p.Parts[i % Partok.Partszam].SzavazatSzam / j, 0));
                }
            }
            for (int i = 0; i < 60; i++)
            {
                Console.Write(MatrixSzamok[i]+" ");
            }
        }
    }
}
