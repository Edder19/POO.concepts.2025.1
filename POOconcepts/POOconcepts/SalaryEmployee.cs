using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts;

public class SalaryEmployee : Employee
{
    private decimal _salary;
    public SalaryEmployee(int id, string firstName, string lastName, Date? hireDate, Date? bornDate, bool isActive, decimal salary) : base(id, firstName, lastName, hireDate, bornDate, isActive)
    {
        _salary = salary;
    }

    public decimal Salary { get => _salary; set => _salary = ValidateSalary(value); }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
          $"value to pay...:{GetValueToPay(),20:C2}";
    }    
    public override decimal GetValueToPay()
    {
        return Salary;
    }
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 1000000)
        {
            throw new Exception($"The Salary:{salary:C2}, the lees than the minium. ");
        }
        return salary;
    }
}
