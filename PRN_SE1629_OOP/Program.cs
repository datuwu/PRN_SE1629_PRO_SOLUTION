namespace PRN.SE1629;

using System.Collections;
using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        /*1. create a new object Employee*/
        /* Employee e = new Employee();
        e.Id = 1;
        e.Name = "Dong";
        e.Salary = 150.55d;

        WriteLine(e); */
         
        //Employee emp = new Employee(160d,1,"Dao");
        //emp.Name = "Dat";
        //WriteLine(emp);
        /*2. create a list of employee and display list*/
        ArrayList lstEmps = new ArrayList();
        /*lstEmps.Add(new Employee(10, 1, "Xuan"));
        lstEmps.Add(new Employee(10, 2, "Ha"));
        lstEmps.Add(new Employee(10, 3, "Thu"));
        lstEmps.Add(new Employee(10, 4, "Dong"));*/

        Employee emp = new Employee(1, "Dong", 152d
            , new DateOnly(), new Address(13, "CMT8", "P13", "Q10", "HCM"));
        
        
        WriteLine(emp);
        Display(lstEmps);

        
        ReadLine();

    }

    private static void Display(ArrayList lstData)
    {
        foreach (Employee e in lstData)
        {
            WriteLine(e);
        }

        for(int i = 0; i < lstData.Count; i++)
        {
            WriteLine(lstData[i]);
        }
    }
}