using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check;

internal struct Check
{    
    string Title { get => "\t\tSilpo"; }
    string Wishes { get => "Come to us again"; }        
    double TotalPrice { get; set; }

    List<Product> Products = new List<Product>();

    public Check(int countProduct)
    {
        CreateCheck(countProduct);        
    }

    void CreateCheck(int countProducts)
    {
        for(int item = 0; item < countProducts; item++)
        {
            Products.Add(new Product());
        }
    }

    public void PrintCheck()
    {
        Console.SetWindowSize(40, 20);
        Console.SetBufferSize(40, 20);
        Console.WriteLine(Title);
        Console.WriteLine("----------------------------------------");
        foreach (Product product in Products)
        {
            TotalPrice += product.PriceWithDiscount;
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Total price: {Math.Floor(TotalPrice)} uah\n\n{Wishes}");
        Console.Read();
    }
}

internal struct Product
{
    string Name { get; set; }
    double Price { get; set; }
    double Discount { get; set; }    
    public double PriceWithDiscount { get; set; }

    public Product()
    {
        Random rnd = new Random();
        Name = "Product X";
        Price = rnd.Next(30, 180);
        Discount = rnd.NextDouble();
        PriceWithDiscount = Price - (Price * Discount);
    }

    public override string ToString()
    {
        return $"{Name} - {Price} - {Math.Floor(100 * Discount)} - {PriceWithDiscount:F2}";
    }
}
