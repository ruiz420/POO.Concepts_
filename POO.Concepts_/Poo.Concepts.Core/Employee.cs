using poo.concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Concepts.Core;

public abstract class Employee
{
    public int Id
    {
        get;
        set;
    }

    public string FirstName
    {
        get;
        set;
    } = null!;

    public string LastName
    {
        get;
        set;
    } = null!;

    public bool IsActive
    {
        get;
        set;
    }

    }
    public Date BornDate
    { 
        get; 
        set; 
    } = null!;

    public Date HireDate 
    { 
        get; 
        set; 
    } = null!;

    public abstract decimal GetValueToPay();

    public override string ToString() => 
        $"Id: {Id}\t{FirstName} {LastName}\n\t" +
        $"HireDate: {HireDate}\n\t" +
        $"Salary......: {GetValueToPay()}";
    
}

