using System;

class UnitConverter1
{
    // Introduction
    public static void Main()
    {
        Console.WriteLine("Welcome to the Unit Converte r  ");
        Console.WriteLine("This tool can help you convert distances, temperatures, and weights between various units.");

        // Menu-driven program
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Convert Distance (km ↔ miles)");
            Console.WriteLine("2. Convert Temperature (°C ↔ °F)");
            Console.WriteLine("3. Convert Weight (kg ↔ lbs)");
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

    // Method for Distance Conversion (km ↔ miles)
    static void ConvertDistance1()
    {
        Console.WriteLine("\nConvert Distance:");
        Console.WriteLine("1. Kilometers to Miles");
        Console.WriteLine("2. Miles to Kilometers");
        Console.Write("Enter your choice (1-2): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice! Returning to main menu.");
            return;
        }

        double result;
        if (choice == 1)
        {
            Console.Write("Enter distance in kilometers: ");
            double kilometers;
            if (!double.TryParse(Console.ReadLine(), out kilometers))
            {
                Console.WriteLine("Invalid input! Returning to main menu.");
                return;
            }
            result = kilometers * 0.621371;
            Console.WriteLine($"{kilometers} kilometers is equal to {result:F2} miles.");
        }
        else if (choice == 2)
        {
            Console.Write("Enter distance in miles: ");
            double miles;
            if (!double.TryParse(Console.ReadLine(), out miles))
            {
                Console.WriteLine("Invalid input! Returning to main menu.");
                return;
            }
            result = miles / 0.621371;
            Console.WriteLine($"{miles} miles is equal to {result:F2} kilometers.");
        }
    }

    // Method for Temperature Conversion (°C ↔ °F)
    static void ConvertTemperature1()
    {
        Console.WriteLine("\nConvert Temperature:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1-2): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice! Returning to main menu.");
            return;
        }

        double result;
        if (choice == 1)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius;
            if (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Invalid input! Returning to main menu.");
                return;
            }
            result = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is equal to {result:F2}°F.");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit;
            if (!double.TryParse(Console.ReadLine(), out fahrenheit))
            {
                Console.WriteLine("Invalid input! Returning to main menu.");
                return;
            }
            result = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F is equal to {result:F2}°C.");
        }
    }

    // Method for Weight Conversion (kg ↔ lbs)
    static void ConvertWeight1()
    {
        Console.WriteLine("\nConvert Weight:");
        Console.WriteLine("1. Kilograms to Pounds");
        Console.WriteLine("2. Pounds to Kilograms");
        Console.Write("Enter your choice (1-2): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice! Returning to main menu.");
            return;
        }

        double result;
        if (choice == 1)
        {
            Console.Write("Enter weight in kilograms: ");
            double kilograms;
            if (!double.TryParse(Console.ReadLine(), out kilograms))
            {
                Console.WriteLine("Invalid input! Returning to main menu.");
                return;
            }
            result = kilograms * 2.20462;
            Console.WriteLine($"{kilograms} kg is equal to {result:F2} lbs.");
        }
        else if (choice == 2)
        {
            Console.Write("Enter weight in pounds: ");
            double pounds;
            if (!double.TryParse(Console.ReadLine(), out pounds))
            {
                Console.WriteLine("Invalid input! Returning to main menu.");
                return;
            }
            result = pounds / 2.20462;
            Console.WriteLine($"{pounds} lbs is equal to {result:F2} kg.");
        }
    }
}
