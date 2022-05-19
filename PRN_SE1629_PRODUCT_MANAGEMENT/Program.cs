namespace Prn.Se1629;
using static System.Console;
public class Program
{
    public static void Main()
    {
        //Khai bao doi tuong ManageProduct
        ProductManagement productManagement = new ProductManagement();

        //Them n product vao

        Product p = new Product(5, "Apple", "15 inch, new feature 2022", 1500, 200);

        productManagement.Add(new Product(1, "Dell", "15 inch, new feature 2022", 1700, 100));
        
        productManagement.Add(new Product(2, "Lenovo", "15 inch, new feature 2022", 2500, 200));
        productManagement.Add(new Product(3, "HP", "15 inch, new feature 2022", 500, 300));
        productManagement.Add(new Product(4, "Acer", "15 inch, new feature 2022", 100, 400));
        productManagement.Add(p);

        //Loc theo tieu chi nao do
        //-Lay het cac san pham ra
        Product[] lstData = productManagement.LstProduct;
        Product[] resultData = FilterProduct(1500, lstData);

        foreach (Product pro in resultData)
        {
            WriteLine(pro);
        }

        //Call display
        productManagement.Display();
        //Xoa sp
        //productManagement.Delete(p);

        //Call display
        //productManagement.Display();

    }

    private static Product[] FilterProduct(double unitPrice, Product[] lstData)
    {
        int i = 0;
        Product[] resultData = new Product[lstData.Length];
        foreach (Product p in lstData)
        {
            if (p.UnitPrice >= unitPrice)
            {
                resultData[i] = p;
                i++;
            }
        }
        return resultData;
    }
}