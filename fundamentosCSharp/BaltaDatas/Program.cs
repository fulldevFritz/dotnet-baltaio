using System.Globalization;

Console.Clear();


Console.WriteLine(DateTime.DaysInMonth(2024, 2));

static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}

Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
Console.WriteLine(IsWeekend(DateTime.Now.AddDays(1).DayOfWeek));
Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

// var timeSpan = new TimeSpan();

// var timeSpanNanosegundos = new TimeSpan(1);

// var timeSpanHoraMinutoSegundo = new TimeSpan(5, 18, 8);

// var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50,10);

// var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(15, 12, 55, 8, 100);

// Console.WriteLine(timeSpan);
// Console.WriteLine(timeSpanNanosegundos);
// Console.WriteLine(timeSpanHoraMinutoSegundo);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundo);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);

// Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12,0,0)));

// var data = DateTime.Now;

// var utcDate = DateTime.UtcNow;

// Console.WriteLine(DateTime.Now);
// Console.WriteLine(utcDate);

// Console.WriteLine(utcDate.ToLocalTime());

// var timezoneAustralia =
//     TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

// Console.WriteLine(timezoneAustralia);

// var horaAustralia = 
//     TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

// Console.WriteLine(horaAustralia);

// var timezones = TimeZoneInfo.GetSystemTimeZones();


// foreach (var timezone in timezones)
// {
//     Console.WriteLine(timezone.Id);
//     Console.WriteLine(timezone);
//     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
//     Console.WriteLine("---------------");
// }

//Console.WriteLine(string.Format("{0:D}", data));

// var pt = new CultureInfo("pt-PT");

// var br = new CultureInfo("pt-BR");

// var en = new CultureInfo("en-US");

// var de = new CultureInfo("de-DE");

// var atual = CultureInfo.CurrentCulture;


// Console.WriteLine(data.ToString("D", br));

// Console.WriteLine(data.ToString("D", de));

// Console.WriteLine(data.ToString("D", atual));

// if (data.Date == DateTime.Now.Date)
//     Console.WriteLine("É igual");

// Console.WriteLine(data.AddDays(40));
// Console.WriteLine(data.AddMonths(1));
// Console.WriteLine(data.AddYears(1));

//var formatada = String.Format("{0:u}", data);

//var data = new DateTime(2020, 10, 12, 8, 23, 14);

// var formatada = String.Format("{0:dd-MM-yyyy hh:mm:ss ff zzz}", data);

// Console.WriteLine(data);
// Console.WriteLine(data.Year);
// Console.WriteLine(data.Month);
// Console.WriteLine(data.Day);
// Console.WriteLine(data.Hour);
// Console.WriteLine(data.Minute);
// Console.WriteLine(data.Second);
// Console.WriteLine(data.DayOfWeek);
// Console.WriteLine(data.DayOfYear);
