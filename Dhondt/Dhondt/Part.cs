﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhondt
{
    /// <summary>
    /// A pártot reprezentáló osztály, tárolja a párt nevét, nemzetét és szavazatszámát.
    /// </summary>
    public class Part
    {
        public string PartNev { get; set; }
        public int Nemzete { get; set; }
        public int SzavazatSzam { get; set; }
        public int Szazalek { get; set; }

        public Part(string partNev, int nemzete, int szavazatSzam,int szazalek)
        {
            PartNev = partNev;
            Nemzete = nemzete;
            SzavazatSzam = szavazatSzam;
            Szazalek = szazalek;
        }
    }
}