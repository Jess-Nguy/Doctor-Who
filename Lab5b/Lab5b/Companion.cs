using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Companion
    {      

        public Companion(string name, string actor, int doctor, string debut)
        {
            this.name = name;
            this.actor = actor;
            this.doctor = doctor;
            this.debut = debut;
        }

        public string name { get; }
        public string actor { get; }
        public int doctor { get; }  //FK of Doctor Ordinal
        public string debut { get; } // FK of Episode Story.
    }
}
