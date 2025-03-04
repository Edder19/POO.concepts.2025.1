using System.Diagnostics;
using POOconcepts;
try
{
    var secretary = new SalaryEmployee(1, "sandra", "Martinez", new Date(2020, 3, 4), new Date(1987, 2, 10), true, 2500000);
    var manager = new SalaryEmployee(2, "Fabio", "ochoa", new Date(1999, 3, 4), new Date(1957, 2, 10), true, 34400000.15M);
    var washer = new HourlyEmployee(3, "Jaime", "Betancour", new Date(1989, 2, 1), new Date(1950, 12, 15), true, 200, 10250.56M);
    var salesPerson1 = new CommisionEmployee(4, "Monica", "Gil", new Date(2000, 7, 2), new Date(1999, 11, 1), true, 0.03f, 10000000M);
    var salesPerson2 = new CommisionEmployee(5, "Jairo", "Galeano", new Date(1980, 10, 18), new Date(1997, 1, 31), true, 0.03f, 300000000M);
    var salesPerson3 = new BaseComissionEmployee(6, "Dexter", "Paniagua", new Date(2021, 5, 28), new Date(1982, 4, 7), true, 0.015f, 97000000M, 650000M);

    var employees = new List<Employee>() { secretary, manager, washer, salesPerson1, salesPerson2, salesPerson3 };
    var total = 0M;
    Console.WriteLine("PAYROLL");

    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine("_____________________________________________________________");
        total += employee.GetValueToPay();
    }
    var invoice1 = new Invoice(1, "Chair", new Date(2025, 2, 5), 4, 350000);
    var invoice2 = new Invoice(2, "Computer", new Date(2025, 2, 5), 2, 2850000);
    var invoice3 = new Invoice(3, "Paper", new Date(2025, 2, 5), 10, 56000);
    var invoices = new List<Invoice>() { invoice1, invoice2, invoice3 };

    Console.WriteLine("EXPENCES");

    foreach (var invoice in invoices)
    { 
     Console.WriteLine(invoice);
    Console.WriteLine("_____________________________________________________________");
    total += invoice.GetValueToPay();
    }
    Console.WriteLine($"ToTal......................................:{total,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
