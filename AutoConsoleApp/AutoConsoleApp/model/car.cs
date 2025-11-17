namespace AutoConsoleApp.model;

public class car
{
    private string _model;
    private int _year;

    
    public car(string model, string color, int year)
    {
        Model = model;
        Color = color;
        Year = year;
    }


    public string Model
    {
        get { return _model.Trim(); }
        
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(value, "Model cannot be null or empty.");
            }

            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            _model = value;
        }
    }
    
    public string Color { get; set; }

    public int Year
    {
        get{return _year;}
        set{
            if(value > 1886)
            {
                _year=value;
            }
            else
            {
                throw new ArgumentException("The first car was build 1886???");
            }
        }
}

    public override string ToString()
    {
        return $"Modell: {Model}\n" + $"Color:  {Color}\n" + $"Year:   {Year}\n" + "-----------------------";

    }
    
}