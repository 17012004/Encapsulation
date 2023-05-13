using System;

public class Car
{
    private string _make;    // Private field for storing the make of the car
    private string _model;   // Private field for storing the model of the car
    private int _year;       // Private field for storing the year of the car
    private decimal _mileage;    // Private field for storing the mileage of the car

    public Car(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
        _mileage = 0;   // Initialize mileage to zero when a car is created
    }

    // Getter method for retrieving the make of the car
    public string GetMake()
    {
        return _make;
    }

    // Getter method for retrieving the model of the car
    public string GetModel()
    {
        return _model;
    }

    // Getter method for retrieving the year of the car
    public int GetYear()
    {
        return _year;
    }

    // Getter method for retrieving the mileage of the car
    public decimal GetMileage()
    {
        return _mileage;
    }

    // Setter method for updating the mileage of the car
    public void SetMileage(decimal mileage)
    {
        if (mileage >= 0)
        {
            _mileage = mileage;
        }
        else
        {
            Console.WriteLine("Mileage cannot be negative.");
        }
    }

    // Method for simulating driving the car and updating the mileage
    public void Drive(decimal distance)
    {
        if (distance > 0)
        {
            _mileage += distance;
        }
        else
        {
            Console.WriteLine("Distance must be positive.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Company of the vehicle: ");
        string company = Console.ReadLine();
        Console.WriteLine("model of the vehicle: ");
        string model = Console.ReadLine();
        Console.WriteLine("Year of Purchase: ");
        int Year = int.Parse(Console.ReadLine());
        // Create an instance of the Car class
        Car myCar = new Car(company, model, Year);

        // Accessing the attributes using getter methods
        Console.WriteLine("Make: " + myCar.GetMake());
        Console.WriteLine("Model: " + myCar.GetModel());
        Console.WriteLine("Year: " + myCar.GetYear());
        Console.WriteLine("Mileage: " + myCar.GetMileage());

        // Updating the mileage using a setter method
        myCar.SetMileage(5000);

        // Driving the car
        Console.WriteLine("Kilometers travelled by the vehicle: ");
        decimal dist = Convert.ToDecimal(Console.ReadLine());
        myCar.Drive(dist);

        // Accessing the updated mileage
        Console.WriteLine("Updated Mileage: " + myCar.GetMileage());
    }
}
