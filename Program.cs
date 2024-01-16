using System;
using System.Data;
using System.Runtime.InteropServices;

public abstract class Product{
    protected int productId;
    protected string name;
    protected double price;
    protected String Producer;

    public Product(int productId, String name, double price, String Producer){
        this.productId = productId;
        this.name = name;
        this.price = price;
        this.Producer = Producer;
    }
    public abstract double ComputeTax();
}
public class Book : Product{
    public override double ComputeTax()
    {
      return price * 0.08;
    }
}

class Mobilephone: Product{

    public override double ComputeTax()
    {
        return price *0.1;
    }

}
  class Program{
    static void Main(String[]args){
        Mobilephone phone = new Mobilephone();
        phone.Price = 1000;

        double tax = phone.ComputeTax();
        System.Console.WriteLine("tax for the mobile phone: " + tax);
    }
  }