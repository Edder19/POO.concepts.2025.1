using System.Diagnostics;
using POOconcepts;
try
{
    var secretary = new SalaryEmployee(1, "sandra", "Martinez",new Date(2020,3,4),new Date(1987,2,10),true,2500000);
    var manager = new SalaryEmployee(2, "Fabio", "ochoa", new Date(1999, 3, 4), new Date(1957, 2, 10), true, 34400000.15M);
    var washer = new HourlyEmployee(3 ,"Jaime", "Betancour", new Date(1989, 2, 1), new Date (1950, 12 , 15),true,200,10250.56M );
    
    var employees = new List<Employee>() { secretary, manager,washer };
    var total = 0M;
    foreach (var employee in employees)
    { 
    Console.WriteLine(employee);
    Console.WriteLine("_____________________________________________________________");
        total += employee.GetValueToPay();
    }
    Console.WriteLine($"ToTal......................................:{total,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
