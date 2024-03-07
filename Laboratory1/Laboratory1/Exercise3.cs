class Exercise3 
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature in celsius");

        int tempC;
        tempC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Temperature in fahrenheit: " + celsiusToFahrenheit(tempC));

        Console.WriteLine();
        Console.WriteLine("Enter temperature in fahrenheit");
        int tempF;
        tempF = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Temperature in celsius: "+ fahrenheitToCelsius(tempF));


        Console.ReadKey();

    }

    static double celsiusToFahrenheit(int tempC)
    {
        double F = tempC * 9 / 5 +  32;
        return F;
    }

    static double fahrenheitToCelsius(int tempF)
    {
        double C = (tempF - 32) * 5 / 9;
        return C;
    }
}

