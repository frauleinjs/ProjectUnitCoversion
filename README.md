# Unit Converter
Convert distances (km ↔ miles), temperature (°C ↔ °F), weights (kg ↔ lbs), etc. Uses a simple menu system.

# Project Overview
Unit conversion is a common challenge in many real-world applications, especially when dealing with multiple systems of measurement such as metric and imperial. Although the mathematical formulas for conversion are straightforward, building a user-friendly and error-proof system requires careful implementation.
This project addresses that challenge by providing a versatile and beginner-friendly C# program that supports:
1. Multiple types of unit conversions.
2. A clear, menu-driven console interface.
3. History logging to keep track of past conversions.
The program serves as both a learning tool for understanding user input handling, file I/O, and error management in C#, and a practical utility for quick and accurate conversions.

# Project Goal and Functionality
The goal of this project is to create a robust C# console application that performs accurate unit conversions across multiple categories, including distance, temperature, weight, length, speed, area, volume, time, energy, and pressure.
This tool simplifies the process of converting between different measurement systems (e.g., metric and imperial) using an intuitive, text-based menu system. It also logs all conversions to a file, allowing users to view a history of past calculations.

# Team Members
Fraulein Joy Sumabat - A00251549  
Milan Shrestha - A00300455
Oluwatoni Kolade - A00288606
Anand Yashwanth - A00321928

# Features Unit Conversion
Support for conversion of distance (km ↔ miles), temperature (°C ↔ °F), and weight (kg ↔ lbs).
Log for conversion history.

# Application Flow
Main menu include 10 option for unit coversion and one more option to view history log.
Selecting one of the unit conversion option take user to a sub menu which include 2 option for relevent unit conversion.

# Console user interface
1. Main menu
    Select a conversion option:
     Distance (km <-> miles)
     Temperature (C <-> F)
     Weight (kg <-> lbs)
     Length (vm <-> inches)
     Speed (km/h <-> mph)
     Area (sq.m <-> sq.ft)
     Volume (liters <-> gallons)
     Time (hours <-> minutes)
     Energy (joules <-> calories)
     Pressue (bar <-> psi)
     View Conversion History
     Exit
     Enter  your choice (1-12): Enter your choice (1-12):

2. Sub menu
    Kilometers to Miles
    Miles to Kilometers
    Enter your choice (1-12):

3. Unit Input and output Display:
     Enter your choice (1-2): 1
     Enter temperature in Celsius: 34
     34 °C = 93.20 °F
     
# Error Handling
User inputs are validated, and feedback is given.

# Tools and Techniques C#
The programming language the unit converter is written in.
Console Application: A text-based menu system is utilized as the user interface.

# sources
[www.w3schools.com](https://www.w3schools.com/cs/index.php)

www.codecademy.com/learn/learn-c-sharp

https://youtu.be/oZIQK9uLgnk

Stackoverflow.com

Mathematical Conversion Formulas: Trivial conversion formulas are applied for every unit type.

Demo Sample The program displays a menu by which the user chooses the conversion type to be performed (distance, temperature, or weight). After a conversion type has been selected, the user inputs the value, and the program converts it, displaying the result to the user. The user can continue converting or exit the application at will.
