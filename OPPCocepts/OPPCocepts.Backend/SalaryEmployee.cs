namespace OPPCocepts.Backend;

public class SalaryEmployee : Employee
{
    private decimal _salary;

    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal salary) : 
        base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        Salary = salary;
    }

    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalay(value);
    }

    public override decimal GetValueToPay() => Salary;

    public override string ToString() => base.ToString();

    private decimal ValidateSalay(decimal salary)
    {
        if (salary < 2000000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2.000.000.");
        }
        return salary;
    }
}
