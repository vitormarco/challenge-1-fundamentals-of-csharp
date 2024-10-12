using System.Globalization;

namespace Desafio1FundamentosCSharp;
public static class DateNowFormat
{
    public static string GetFullDate()
    {
        var dateNow = DateTime.UtcNow;

        return dateNow.ToLocalTime().ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss ", new CultureInfo("pt-br"));
    }

    public static string GetSimplifyDate()
    {
        var dateNow = DateTime.UtcNow.ToString("dd/MM/yyyy", new CultureInfo("pt-br"));
        return dateNow;
    }

    public static string GetTwentyFourHourTime()
    {
        var dateNow = DateTime.UtcNow.ToLocalTime();

        return dateNow.ToString("HH:mm", new CultureInfo("pt-br"));
    }

    public static string GetDateWithFullMonthName()
    {
        var dateNow = DateTime.UtcNow;
        return dateNow.ToString("dd 'de' MMMM yyyy", new CultureInfo("pt-br"));
    }
}
