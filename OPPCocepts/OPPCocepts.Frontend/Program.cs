using OPPCocepts.Backend;

try
{
    var employee = new Employee(1, "John", "Doe", true, new Date(1990, 5, 15), new Date(2020, 1, 10));
    Console.WriteLine(employee);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

