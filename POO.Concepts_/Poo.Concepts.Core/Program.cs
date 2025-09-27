namespace poo.concepts;

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public Date()
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int day, int month, int year)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    private int Year
    {
        get => _year;
        set
        {
            _year = ValidateYear(value);
        }
    }

    private int Month
    {
        get => _month;
        set
        {
            _month = ValidateMonth(value);
        }
    }


    private int Day
    {
        get => _day;
        set
        {
            _day = ValidateDay(value, Month, Year);
        }

    }
    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new Exception("Year cannot be negative");
        }
        return year;
    }
    private int ValidateMonth(int month)
    {
        if (month < 0 || month > 12)
        {
            throw new Exception($"el mes:  debe estar entre 1 y 12");
        }
        return month;
    }
    private int ValidateDay(int day, int month, int year)
    {
        if (month < 1 || month > 12)
            throw new Exception($"El mes: {month} no es válido para validar el día");

        int maxDay;
        if (month == 2)
        {
            maxDay = IsLeapYear(year) ? 29 : 28;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            maxDay = 30;
        }
        else
        {
            maxDay = 31;
        }

        if (day < 1 || day > maxDay)
            throw new Exception($"El día: {day} no es válido para el mes {month} y año {year}");

        return day;
    }
}