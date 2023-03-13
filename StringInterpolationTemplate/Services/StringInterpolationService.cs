using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services; 

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    // 2. 2019.01.22
    public string Number02()
    {
        var today = _date.Now;
        return $"{today:yyyy.MM.d}";
    }

    // 3. Day 22 of January, 2019
    public string Number03()
    {
        var today = _date.Now;
        return $"Day {today:dd} of {today:MMMM}, {today:yyyy}";
    }

    // 4. Year: 2019, Month: 01, Day: 22
    public string Number04()
    {
        var today = _date.Now;
        return $"Year: {today:yyyy}, Month: {today:mm}, Day: {today:dd}";
    }

    // 5. Tuesday (10 spaces total, right aligned)
    public string Number05()
    {
        var today = _date.Now;
        return $"{today,10:dddd}";
    }

    // 6. 11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
    public string Number06()
    {
        var today = _date.Now;
        return $"{today,10:h:mm tt}{today,10:dddd}";
    }

    // 7. h:11, m:01, s:27
    public string Number07()
    {
        var today = _date.Now;
        return $"h:{today:hh}, m:{today:mm}, s:{today:ss}";
    }

    // 8. 2019.01.22.11.01.27
    public string Number08()
    {
        var today = _date.Now;
        return $"{today:yyyy.MM.dd.h.mm.ss}";
    }

    // 9. Output as Currency
    public string Number09()
    {
        var pi = Math.PI;
        return $"{pi:c}";
    }

    // 10.Output as right-alined (10 spaces), number with 3 decimal places
    public string Number10()
    {
        var pi = Math.PI;
        return $"{pi,10:n3}";
    }

    // 11. Write one additional item to output the year (2023) as a hexadecimal -- needs :X2
    public string Number11()
    {
        var currentYear = DateTime.Now.Year;
        var yearHex = currentYear.ToString("X");
        return $"{yearHex}";
        
    }

}
