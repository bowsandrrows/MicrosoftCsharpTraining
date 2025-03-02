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

string my_first = "5";
string my_second = "7";     // not advisable to convert, could be decimal.
int message = int.Parse(my_first) + int.Parse(my_second);
Console.WriteLine(message);

string value1 = "5";
string value2 = "7";
int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result2);

Console.WriteLine("\t---------------------------------------\n");



/* 
When you know you're performing a narrowing conversion, you need to perform a cast. 
Casting is an instruction to the C# compiler that you know precision may be lost, 
but you're willing to accept it.
If you're unsure whether you lose data in the conversion, write code to perform a 
conversion in two different ways and observe the changes. 

The term widening conversion means that you're attempting to convert a value from a 
data type that could hold less information to a data type that can hold more information.
When you know you're performing a widening conversion, you can rely on implicit conversion. 
The compiler handles implicit conversions.
*/
