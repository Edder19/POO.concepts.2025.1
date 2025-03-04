using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts;

public abstract class Employee : IPay
{
    protected Employee(int id, string firstName, string lastName, Date? hireDate, Date? bornDate, bool isActive)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        HireDate = hireDate;
        BornDate = bornDate;
        IsActive = isActive;
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = null!; 
    public string LastName { get; set; } = null!; 
    public Date? HireDate { get; set; }
    public Date? BornDate { get; set; }
    public bool IsActive { get; set; }
    
    public override string ToString() 
    { 
        return $"{Id}\t{FirstName} {LastName}\n\t" + 
       $"Hired in.......:{HireDate,20}\n\t" + 
       $"Born date......:{BornDate,20}\n\t" + 
       $"Is active......:{IsActive,20}"; }
    public abstract decimal GetValueToPay();

    
}

