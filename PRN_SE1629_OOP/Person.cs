namespace PRN.SE1629;

public class Person
{
    public string Name { get; set; }
    public DateOnly DoB { get; set; }
    protected Address Address { get; set; } //Has-a

    public Person()
    {

    }

    public Person(string name, DateOnly doB, Address address)
    {
        Name = name;
        DoB = doB;
        Address = address;
    }
}