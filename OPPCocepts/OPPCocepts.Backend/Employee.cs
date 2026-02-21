using System;
using System.Collections.Generic;
using System.Text;

namespace OPPCocepts.Backend;

public abstract class Employee
{
    protected Employee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
        BornDate = bornDate;
        HireDate = hireDate;
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public bool IsActive { get; set; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
               $"Value to pay {GetValueToPay}";
    }
    public abstract decimal GetValueToPay();
}

