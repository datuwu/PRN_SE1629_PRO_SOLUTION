namespace Prn.Se1629;

public interface IProduct
{
    public abstract void Add(Product p);
    bool Update(Product p);
    bool Delete(Product p);
    Product GetProduct(int productId);
    void Display();

}