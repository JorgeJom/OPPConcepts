namespace OPPCocepts.Backend;

public class BaseCommisionEmployee : CommisionEmploye
{
    private decimal _salary;

    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercent, decimal sales, decimal salary) : base(id, firstName, lastName, isActive, bornDate, hireDate, commisionPercent, sales)
    {
        Salary = salary;
    }

    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value);
    }

    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

    override public string ToString() => $"{base.ToString()}" +
        $"\n\tSalary base......: {Salary,20:C2}";

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary base must be greater than or equal to $500,000.");
        }
        return salary;
    }
}
