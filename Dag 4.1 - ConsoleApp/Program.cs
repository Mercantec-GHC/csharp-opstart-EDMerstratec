﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
*/

/*
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

//int[] data;
//data = new int[3];
//int[] data = new int[3];
//int[] data = new int[3];
// SELF Reference types include arrays, strings, and classes.

/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);
*/

/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal; //explicit cast (float)

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/

/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
//first.ToString() vs int.Parse(first) or better int.TryParse(first)
*/

/*
 * string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/

//Convert when rounding(?), TryParse otherwise

/*
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
*/

//SELF tryparse logic; true/false (value) and out result update var result
/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
*/

/*
string[] values = { "12,3", "45", "ABC", "11", "DEF" };
string alphabetic = "";
float numeric = 0;
float result = 0;
foreach (var item in values)
{
    if (float.TryParse(item, out numeric))
    {
        result += numeric;
        //Console.WriteLine(numeric + " " + result);
    }
    else
    {
        alphabetic += item;
    }
}
Console.WriteLine($"Message: {alphabetic}\nTotal: {result}");
*/

/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = 0;
result1 = Convert.ToInt32(value1/value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = 0;
result2 = (value2 / (decimal)value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = 0;
result3 = (value3 / (float)value1);
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/