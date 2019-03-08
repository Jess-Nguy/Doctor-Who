using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Doctor
    {
        public Doctor(int ordinal, string actor, int series, int age, string debut)
        {
            this.ordinal = ordinal;
            this.actor = actor;
            this.series = series;
            this.age = age;
            this.debut = debut;
        }

        public int ordinal{get; } //PK of Doctor, FK doctor

        public string actor { get; }

        public int series { get; }

        public int age { get; }

        public string debut { get; } // FK of Episode Story.
    }
}
