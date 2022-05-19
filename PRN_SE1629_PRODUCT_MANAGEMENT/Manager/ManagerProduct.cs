namespace Prn.Se1629;

public class ProductManagement : IProduct
{
    private Product[] lstProduct;
    private int size; //So luong phan tu trong mang 1 chieu lstProduct
    public Product[] LstProduct { get => lstProduct; set => lstProduct = value; }


    public ProductManagement()
    {
        this.lstProduct = new Product[Utils.InitLengProduct];
        this.size = 0;
    }
    
    public ProductManagement(Product[] lstProduct)
    {
        this.lstProduct = lstProduct;
        foreach (Product p in lstProduct)
        {
            if (p != null)
            {
                this.size++;
            }
        }
    }



    //
    public void Add(Product p)
    {
        //Viet giai thuat de add phan tu vao mang 1 chieu tinh
        //1. Check xem mang con trong ko
        CheckSize();
        //2. Neu mang con suc chua, chi viec add product vao
        this.lstProduct[this.size++] = p;
    }

    private void CheckSize()
    {
        if (this.size >= this.lstProduct.Length)
        {
            //thuc hien mo rong array ra
            Product[] tmp = new Product[this.size * 2];
            //hot du lieu tu array cu sang moi
            for (int i = 0; i < this.size; i++)
            {
                tmp[i] = this.lstProduct[i];
            }
            this.lstProduct = tmp;
        }
    }

    public bool Delete(Product p)
    {
        int index = 0;
        //Tim phan tu p co trong mang hay ko
        foreach (var item in this.lstProduct)
        {
            
            if (item is not null && item.Id == p.Id)
            {
                
                //Neu tim thay roi thi xoa di
                for (int i = index; i < size; i++)
                {
                    lstProduct[i] = lstProduct[i + 1];
                }
                lstProduct[size-1] = null;
                return true;
            }
            index++;

        }
        return false;
    }

    public void Display()
    {
        foreach (Product p in this.lstProduct)
        {
            Console.WriteLine(p);
        }
    }

    public Product GetProduct(int productId)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        throw new NotImplementedException();
    }
}
