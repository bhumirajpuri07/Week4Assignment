using System;

class Car
{
    // Properties
    private string brand;
    private int year;
    private float price;

    // Constructor
    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    // Method to display car information
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: ${price:N2}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Car class
        Car myCar = new Car("Toyota", 2022, 25000.50f);

        // Display car information
        Console.WriteLine("Car Information:");
        myCar.DisplayCarInfo();
    }
}
