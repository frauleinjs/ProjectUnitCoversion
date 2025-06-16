using System;

class UnitConverter1
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Unit Converter");
        Console.WriteLine("This tool can help you convert distances, temperatures, and weights between various units.");

        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Convert Distance (km, meters, cm, miles, feet, inches, yards)");
            Console.WriteLine("2. Convert Temperature (°C, °F, K)");
            Console.WriteLine("3. Convert Weight (kg, lbs, grams, ounces, stones)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input! Please select a valid option.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ConvertDistance1();
                    break;
                case 2:
                    ConvertTemperature1();
                    break;
                case 3:
                    ConvertWeight1();
                    break;
                case 4:
                    exitProgram = true;
                    Console.WriteLine("Thank you for using the Unit Converter. Goodbye!");
                    break;
            }
        }
    }

    static void ConvertDistance1()
    {
        Console.WriteLine("\nConvert Distance:");
        Console.WriteLine("1. Kilometers to Miles");
        Console.WriteLine("2. Miles to Kilometers");
        Console.WriteLine("3. Meters to Feet");
        Console.WriteLine("4. Feet to Meters");
        Console.WriteLine("5. Centimeters to Inches");
        Console.WriteLine("6. Inches to Centimeters");
        Console.WriteLine("7. Yards to Meters");
        Console.WriteLine("8. Meters to Yards");
        Console.Write("Enter your choice (1-8): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
        {
            Console.WriteLine("Invalid choice! Returning to main menu.");
            return;
        }

        double input, result;

        switch (choice)
        {
            case 1:
                Console.Write("Enter distance in kilometers: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 0.621371;
                Console.WriteLine($"{input} kilometers is equal to {result:F2} miles.");
                break;

            case 2:
                Console.Write("Enter distance in miles: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 0.621371;
                Console.WriteLine($"{input} miles is equal to {result:F2} kilometers.");
                break;

            case 3:
                Console.Write("Enter distance in meters: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 3.28084;
                Console.WriteLine($"{input} meters is equal to {result:F2} feet.");
                break;

            case 4:
                Console.Write("Enter distance in feet: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 3.28084;
                Console.WriteLine($"{input} feet is equal to {result:F2} meters.");
                break;

            case 5:
                Console.Write("Enter length in centimeters: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 0.393701;
                Console.WriteLine($"{input} centimeters is equal to {result:F2} inches.");
                break;

            case 6:
                Console.Write("Enter length in inches: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 0.393701;
                Console.WriteLine($"{input} inches is equal to {result:F2} centimeters.");
                break;

            case 7:
                Console.Write("Enter length in yards: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 0.9144;
                Console.WriteLine($"{input} yards is equal to {result:F2} meters.");
                break;

            case 8:
                Console.Write("Enter length in meters: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 0.9144;
                Console.WriteLine($"{input} meters is equal to {result:F2} yards.");
                break;
        }
    }

    static void ConvertTemperature1()
    {
        Console.WriteLine("\nConvert Temperature:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.WriteLine("5. Fahrenheit to Kelvin");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        Console.Write("Enter your choice (1-6): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid choice! Returning to main menu.");
            return;
        }

        double input, result;

        switch (choice)
        {
            case 1:
                Console.Write("Enter temperature in Celsius: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = (input * 9 / 5) + 32;
                Console.WriteLine($"{input}°C is equal to {result:F2}°F.");
                break;

            case 2:
                Console.Write("Enter temperature in Fahrenheit: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = (input - 32) * 5 / 9;
                Console.WriteLine($"{input}°F is equal to {result:F2}°C.");
                break;

            case 3:
                Console.Write("Enter temperature in Celsius: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input + 273.15;
                Console.WriteLine($"{input}°C is equal to {result:F2} K.");
                break;

            case 4:
                Console.Write("Enter temperature in Kelvin: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input - 273.15;
                Console.WriteLine($"{input} K is equal to {result:F2}°C.");
                break;

            case 5:
                Console.Write("Enter temperature in Fahrenheit: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = (input + 459.67) * 5 / 9;
                Console.WriteLine($"{input}°F is equal to {result:F2} K.");
                break;

            case 6:
                Console.Write("Enter temperature in Kelvin: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = (input * 9 / 5) - 459.67;
                Console.WriteLine($"{input} K is equal to {result:F2}°F.");
                break;
        }
    }

    static void ConvertWeight1()
    {
        Console.WriteLine("\nConvert Weight:");
        Console.WriteLine("1. Kilograms to Pounds");
        Console.WriteLine("2. Pounds to Kilograms");
        Console.WriteLine("3. Grams to Ounces");
        Console.WriteLine("4. Ounces to Grams");
        Console.WriteLine("5. Stones to Pounds");
        Console.WriteLine("6. Pounds to Stones");
        Console.Write("Enter your choice (1-6): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid choice! Returning to main menu.");
            return;
        }

        double input, result;

        switch (choice)
        {
            case 1:
                Console.Write("Enter weight in kilograms: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 2.20462;
                Console.WriteLine($"{input} kg is equal to {result:F2} lbs.");
                break;

            case 2:
                Console.Write("Enter weight in pounds: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 2.20462;
                Console.WriteLine($"{input} lbs is equal to {result:F2} kg.");
                break;

            case 3:
                Console.Write("Enter weight in grams: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 0.035274;
                Console.WriteLine($"{input} grams is equal to {result:F2} ounces.");
                break;

            case 4:
                Console.Write("Enter weight in ounces: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 0.035274;
                Console.WriteLine($"{input} ounces is equal to {result:F2} grams.");
                break;

            case 5:
                Console.Write("Enter weight in stones: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input * 14;
                Console.WriteLine($"{input} stones is equal to {result:F2} pounds.");
                break;

            case 6:
                Console.Write("Enter weight in pounds: ");
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Returning to main menu.");
                    return;
                }
                result = input / 14;
                Console.WriteLine($"{input} pounds is equal to {result:F2} stones.");
                break;
        }
    }
}
