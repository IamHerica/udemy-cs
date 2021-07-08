using System.Collections.Generic;
using Trabalhador.Entities.Enums;

namespace Trabalhador.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } //associação entre 2 classes diferentes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //instanciando para garantir que a lista não seja nula

        public Worker ()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mouth)
        {
            double sum = BaseSalary; //esse valor o trabalhador sempre ganha mensalmente
            foreach (HourContract constract in Contracts)
            {
                if (constract.Date.Year == year && constract.Date.Month == mouth)
                {
                    sum += constract.TotalValue();
                }
            }
            return sum;
        }
    }
}
