using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoTrabalhadores.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public  int Hours { get; set; }
    }
}
