using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts
{
    
    class BaseComissionEmployee : CommisionEmployee
    { 
        private decimal _salary;
        public BaseComissionEmployee(int id, string firstName, string lastName, Date? hireDate, Date? bornDate, bool isActive, float commisionPercentaje, decimal sales, decimal salary) : base(id, firstName, lastName, hireDate, bornDate, isActive, commisionPercentaje, sales)
        {
            Salary = salary;
        }
        public decimal Salary { get => _salary; set => _salary = ValidateSalary(value); }
        public override string ToString()
        {
            return
                $"{base.ToString()}\n\t"
               + $"SalaryBase..........:" + $"{_salary,20:C2}\n\t"
               + $"Salary.........:" + $"{GetValueToPay(),20:C2}";
        }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Salary;
        }

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 500000)
            {
                throw new Exception($"The Salary:{salary:C2}, the lees than the $500.000. ");
            }
            return salary;
        }
    }
}