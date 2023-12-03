namespace StirnReihe.Logic;

public class Person
{
    //Angaben der Person
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Height { get; set; }

    public override string ToString()
    {
        return $"{FirstName}, {LastName},{Height}";
    }
}

