using POO.Concepts.Core;

var employee = new SalaryEmployee
{
    Id = 1010,
    Firstname = "Sandra",
    Lastname = "Lopez",
    BornDate = new Date(1980, 12, 2),
    HireDate = new Date(2023, 2, 12),
    IsActive = true,
    Salary = 2000000
};

Console.WriteLine(employee);
