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

int newInt = (int)newDecimal; // output 3 (loss of precision)
Console.WriteLine($"This is int: {newInt}");

Console.WriteLine();

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

/* 
When you know you're performing a narrowing conversion, you need to perform a cast. 
Casting is an instruction to the C# compiler that you know precision may be lost, 
but you're willing to accept it.
If you're unsure whether you lose data in the conversion, write code to perform a 
conversion in two different ways and observe the changes. 
*/
