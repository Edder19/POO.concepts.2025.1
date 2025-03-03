using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts;


public class HourlyEmployee : Employee
{
   
    private int _workinghours;
    private decimal _hourValue;

    public HourlyEmployee(int id, string firstName, string lastName, Date? hireDate, Date? bornDate, bool isActive,int workinghours ,decimal hourValue ) : base(id, firstName, lastName, hireDate, bornDate, isActive)
    {
        HoursValue= hourValue; 
        WorkingHours = workinghours;
    }

    public int WorkingHours { get => _workinghours; set => _workinghours =ValidateWorkingHours (value); }
    public decimal HoursValue { get => _hourValue; set => _hourValue = ValidateHourValue(value); }

    
    public override string ToString() 
    { 
        return $"{base.ToString()}\n\t"+
               $"Working hours..: " +$"{WorkingHours,20:N2}\n\t" + 
               $"Hour Value.....: " +$"{ HoursValue,20:C2}\n\t" +
               $"Salary.........: " + $"{GetValueToPay(),20:C2}";
    }
    public override decimal GetValueToPay()
    { 
        return WorkingHours * HoursValue;
    }
    private decimal ValidateHourValue(decimal hourValue) 
    { 
        if (hourValue < 10000) 
        { 
            throw new ArgumentOutOfRangeException($"The hour value: {hourValue:C2} is less than minimum salary."); 
        } return hourValue;
    }
    private int ValidateWorkingHours(int workingHours) 
    { 
        if (workingHours < 0) 
        { 
            throw new ArgumentOutOfRangeException($"The working ours: {workingHours:N0} is not valid."); 
        } return workingHours; 
    }

}

