namespace API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

//optional operatior = string can be nullable -> string?
//we turned it off because it is going to cause a lot of errors in the program
    public string Summary { get; set; }
}
