using poo.concepts;

try
{
    var date1 = new Date(30, 11, 2025);
    var date2 = new Date(); //(dd-mm-aa)


    Console.WriteLine(date1.ToString());
    Console.WriteLine(date2.ToString());
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}