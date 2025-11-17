namespace PersonConsoleApp.model;

public class Person
{
    private string _name;
    
    // private int age;

    
    // Auto Property
    public int Age{get; set; }

    public string Name
    {
        get { return _name; }
        set
        {
            if (value != null)
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be null");
            }
        }
    }


    public Person(string name)
    {
        this._name = name;
    }


    // public string GetName()
    // {
    //     return _name;
    // }
    //
    // public void SetName(string name)
    // {
    //     this._name = (name);
    // }
    
    
}