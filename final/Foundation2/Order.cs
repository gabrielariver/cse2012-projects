using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.TotalCost();
        }
        totalCost += customer.IsInUSA() ? 5 : 35; 
        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in products)
        {
            label.AppendLine(product.Name + " (" + product.Id + ")");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return customer.Name + "\n" + customer.Address.ToString();
    }
}
