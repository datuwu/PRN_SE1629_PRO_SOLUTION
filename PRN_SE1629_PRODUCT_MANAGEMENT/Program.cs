namespace Prn.Se1629;
using static System.Console;
public class Program
{
    public static void Main()
    {
        //Khai bao doi tuong ManageProduct
        ProductManagement productManagement = new ProductManagement();

        //Them n product vao
        productManagement.Add(new Product(1, "Dell", "15 inch, new feature 2022", 1500, 100));
        productManagement.Add(new Product(2, "Lenovo", "15 inch, new feature 2022", 1500, 200));
        productManagement.Add(new Product(3, "HP", "15 inch, new feature 2022", 1500, 300));
        productManagement.Add(new Product(4, "Acer", "15 inch, new feature 2022", 1500, 400));

        //Call display
        productManagement.Display();

    }
}