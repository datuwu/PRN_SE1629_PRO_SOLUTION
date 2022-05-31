using System.Linq;
using PRN.Se1629;

string[] names = { "le", "thanh", "dat", "UwU", "uWu" };

var orderedNames = names.OrderBy(x => x.Length);

foreach (var name in orderedNames)
{
    Console.WriteLine(name);
}

Console.WriteLine("===============");

SortedSet<string> sorted = new SortedSet<string>(names) ;

foreach (var name in sorted)
{
    Console.WriteLine(name);
}

Console.WriteLine("===============");
foreach (var name in names.Select(x => x.Contains("a"))){
    Console.WriteLine(name);
}
Console.WriteLine("===============");
var items = from w in names  
           where w.Contains("a")
           select w;
foreach (var item in items) 
{ 
    Console.WriteLine(item); 
}

Console.WriteLine("===============");
foreach (var a in names.Where(n=>n.Length>4))
{
    Console.WriteLine(a);
}

int[] nums = { 1, 2, 3 };
Console.WriteLine(nums.Sum(x=>x*2));

//Define tap hop student
List<Student> students = new List<Student>();
students.Add(new Student(1, 8.5));
students.Add(new Student(2, 9.5));
students.Add(new Student(3, 7.5));
students.Add(new Student(4, 10));

var data = students.OrderBy(s => s.Mark);

foreach(var item in data)
{
    Console.WriteLine(item);
}