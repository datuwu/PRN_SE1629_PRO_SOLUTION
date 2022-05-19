

namespace PRN.SE1629;
public class Employee:Person
{
    /*field, data*/
    private int _id;

    /*properties*/
    public double Salary { get; init; } //.NET 5+
    public int Id { get => _id; set => _id = value; }
    public string NameOfCompany { get; } = "FPT Edu";
    
    /*constructor*/
    public Employee(int id, string name, double salary, 
        DateOnly dob, Address address):base(name,dob,address)
    {
        this._id = id;
        this.Salary = salary;
    }

    /*constructor no param*/
    public Employee()
    {
        
    }


    public override string? ToString()
    {
        return $"ID = {this.Id}, name = {this.Name}, " +
            $"Salary = {Salary}, Name of company = {NameOfCompany}, Address = {Address}";
    }
}
