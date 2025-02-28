// See https://aka.ms/new-console-template for more information
Console.Title = "Type Conversion";


int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Console.WriteLine();

int myInt = 3;
Console.WriteLine(myInt);

decimal myDesimal = myInt;
Console.WriteLine(myDesimal);

Console.WriteLine();

decimal newDecimal = 3.14m;
Console.WriteLine($"This is decimals: {newDecimal}");

int newInt = (int)newDecimal;
Console.WriteLine($"This is int: {newInt}");