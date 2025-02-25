using System.Diagnostics;
using POOconcepts;
try
{
    var secretary = new SalaryEmployee(1, "sandra", "Martinez",new Date(2020,3,4),new Date(1987,2,10),true,2500000);
    var manager = new SalaryEmployee(2, "Fabio", "ochoa", new Date(1950, 3, 4), new Date(1987, 2, 10), true, 34400000.15M);

    var employees = new List<Employee>() { secretary, manager };
    foreach (var employee in employees)
    { 
    Console.WriteLine(employee);
    Console.WriteLine("_____________________________________________________________");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
