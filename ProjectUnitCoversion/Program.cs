using System;
using System.IO;

class UnitConverter1
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Unit Converter");
        Console.WriteLine("This tool supports a wide range of unit conversions.");

        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("\nSelect a conversion option:");
            Console.WriteLine("1. Distance (km ↔ miles)");
            Console.WriteLine("2. Temperature (°C ↔ °F)");
            Console.WriteLine("3. Weight (kg ↔ lbs)");
            Console.WriteLine("4. Length (cm ↔ inches)");
            Console.WriteLine("5. Speed (km/h ↔ mph)");
            Console.WriteLine("6. Area (sq.m ↔ sq.ft)");
            Console.WriteLine("7. Volume (liters ↔ gallons)");
            Console.WriteLine("8. Time (hours ↔ minutes)");
            Console.WriteLine("9. Energy (joules ↔ calories)");
            Console.WriteLine("10. Pressure (bar ↔ psi)");
            Console.WriteLine("11. View Conversion History");
            Console.WriteLine("12. Exit");
            Console.Write("Enter your choice (1-12): ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 12)
            {
                Console.WriteLine("Invalid input! Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1: Convert("Kilometers", "Miles", 0.621371); break;
                case 2: ConvertTemperature(); break;
                case 3: Convert("Kilograms", "Pounds", 2.20462); break;
                case 4: Convert("Centimeters", "Inches", 0.393701); break;
                case 5: Convert("Kilometers/hour", "Miles/hour", 0.621371); break;
                case 6: Convert("Square meters", "Square feet", 10.7639); break;
                case 7: Convert("Liters", "Gallons", 0.264172); break;
                case 8: Convert("Hours", "Minutes", 60); break;
                case 9: Convert("Joules", "Calories", 0.239006); break;
                case 10: Convert("Bar", "Psi", 14.5038); break;
                case 11: ViewConversionHistory(); break;
                case 12:
                    exitProgram = true;
                    Console.WriteLine("Thank you for using the Unit Converter. Goodbye!");
                    break;
            }
        }
    }

    static void Convert(string unit1, string unit2, double factor)
    {
        Console.WriteLine($"\nConvert {unit1} ↔ {unit2}");
        Console.WriteLine($"1. {unit1} to {unit2}");
        Console.WriteLine($"2. {unit2} to {unit1}");
        Console.Write("Enter your choice (1-2): ");

        if (!int.TryParse(Console.ReadLine(), out int direction) || (direction != 1 && direction != 2))
        {
            Console.WriteLine("Invalid choice! Returning to menu.");
            return;
        }

        Console.Write($"Enter value in {(direction == 1 ? unit1 : unit2)}: ");
        if (!double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine("Invalid input! Returning to menu.");
            return;
        }

        double result = (direction == 1) ? value * factor : value / factor;
        string resultMsg = $"{value} {(direction == 1 ? unit1 : unit2)} = {result:F2} {(direction == 1 ? unit2 : unit1)}";
        Console.WriteLine(resultMsg);
        LogConversion(resultMsg);
    }

    static void ConvertTemperature()
    {
        Console.WriteLine("\nConvert Temperature:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1-2): ");

        if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid input! Returning to main menu.");
            return;
        }

        Console.Write($"Enter temperature in {(choice == 1 ? "Celsius" : "Fahrenheit")}: ");
        if (!double.TryParse(Console.ReadLine(), out double temp))
        {
            Console.WriteLine("Invalid input! Returning to main menu.");
            return;
        }

        double result = (choice == 1) ? (temp * 9 / 5) + 32 : (temp - 32) * 5 / 9;
        string resultMsg = $"{temp}°{(choice == 1 ? "C" : "F")} = {result:F2}°{(choice == 1 ? "F" : "C")}";
        Console.WriteLine(resultMsg);
        LogConversion(resultMsg);
    }

    static void LogConversion(string message)
    {
        string folderPath = "ConversionLogs";
        string filePath = Path.Combine(folderPath, "conversion_history.txt");

        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        string logEntry = $"{DateTime.Now}: {message}";
        File.AppendAllText(filePath, logEntry + Environment.NewLine);
    }

    static void ViewConversionHistory()
    {
        string folderPath = "ConversionLogs";
        string filePath = Path.Combine(folderPath, "conversion_history.txt");

        if (!File.Exists(filePath))
        {
            Console.WriteLine("No history found.");
            return;
        }

        Console.WriteLine("\n--- Conversion History ---");
        string[] history = File.ReadAllLines(filePath);
        foreach (string line in history)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("--- End of History ---\n");
    }
}
