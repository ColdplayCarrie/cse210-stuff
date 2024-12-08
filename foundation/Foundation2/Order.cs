using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal SumOfOrderedProducts()
    {
        decimal sum = 0;
        foreach (Product item in _products)
        {
            sum += item.GetPricePerUnit() * item.GetQuantity();
        }
        return sum;
    }
    
    public decimal GrandTotalOfOrder()
    {
        decimal sum = SumOfOrderedProducts();
        decimal shippingCost = 0.00m;
        if (_customer.IsInUSA() == true)
        {
            shippingCost = 5.00m;
        }
        else
        {
            shippingCost = 35.00m;
        }
        decimal _grandTotalOfOrder = sum + shippingCost;
        return _grandTotalOfOrder;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Items in this order:");
        foreach (Product item in _products)
        {
            string packingLabel = $"{item.GetProductName()}, ID: {item.GetProductID()}";
            Console.WriteLine(packingLabel);
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Ship to: ");
        string name = _customer.GetCustomerName();
        string address = _customer.GetCustomerAddress().DisplayFullAddress();
        Console.WriteLine(name + Environment.NewLine + address);
    }
}