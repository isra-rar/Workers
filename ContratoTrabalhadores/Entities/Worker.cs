using ContratoTrabalhadores.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoTrabalhadores.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        List<HourContract> Contracts { get; set; } = new List<HourContract>();

        Department Department { get; set; }
    }
}
