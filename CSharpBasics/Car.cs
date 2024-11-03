public class Car
{
    private string color = "blue";
    private string? model;
    private int year;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string? Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value > 1885)  // Cars were invented around 1885
            {
                year = value;
            }
            else
            {
                Console.WriteLine("Invalid year.");
            }
        }
    }


    public void Drive()
    {
        Console.WriteLine($"The {color} {year} {model} car is driving.");
    }
    public void Honk()
    {
        Console.WriteLine("Beep! Beep!!");
    }
}