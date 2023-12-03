using StirnReihe.Logic;
int choice = 0;
LineOfPeople line = new LineOfPeople();

do
{
    Console.WriteLine("Welcome to the Stirnreihe World Record App! Wrhat do you want to do?");
    Console.WriteLine("Add a person to the line");
    Console.WriteLine("Print the line");
    Console.WriteLine("Clear the line");
    Console.WriteLine("Exit");
     choice = int.Parse(Console.ReadLine()!);
    
    switch (choice)
    {
        case 1:
            //erstellt eine neue Person
            Person Person = new Person();
            Console.WriteLine("Please enter the first name of the person");
            Person.FirstName = Console.ReadLine()!;
            Console.WriteLine("Please enter the last name of the person");
            Person.LastName= Console.ReadLine()!;
            Console.WriteLine("Please enter the hight of the person");
            Person.Height= int.Parse(Console.ReadLine()!);
            line.AddToFront(Person);
            break;
        case 2:
            PrintLine(line);
            break;
        case 3:
            line.clear();

            break;
    }
} while (choice != 4);

static void PrintLine(LineOfPeople line)
{
    if (line.First == null)
    {
        Console.WriteLine("The line is empty");
    }
    var current = line.First;
    while (current != null)
    {
        Console.WriteLine(current.Person.ToString());
        current = current.Next;
    }
}
Console.ReadKey();