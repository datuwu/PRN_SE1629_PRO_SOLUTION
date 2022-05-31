namespace PRN.Se1629;

public class Student//:IComparable<Student>
{
    public int Id { get; set; }
    public double Mark { get; set; }

    public Student(int id, double mark)
    {
        Id = id;
        Mark = mark;
    }

    public override string? ToString()
    {
        return $"Id = {Id}, Mark = {Mark}";
    }
    /*
    public int CompareTo(Student? other)
    {
        return this.Mark.CompareTo(other.Mark);
    }*/
}