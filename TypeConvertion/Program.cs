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

string myInput = "2.71828";
decimal myInputDecimal = 0;
if (decimal.TryParse(myInput, out myInputDecimal))
{
    Console.WriteLine(myInputDecimal);
}
Console.WriteLine((float)myInputDecimal);

Console.WriteLine("\t---------------------------------------\n");

int[,] matrix = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\t---------------------------------------\n");

string[][][] statesWithCities =
[
    [
        ["California", "Los Angeles", "San Francisco", "San Diego"],
        ["Texas", "Houston", "Dallas", "Austin"],
        ["Florida", "Miami", "Orlando", "Tampa"]
    ],
    [
        ["New York", "New York City", "Buffalo", "Rochester"],
        ["Illinois", "Chicago", "Springfield", "Naperville"],
        ["Georgia", "Atlanta", "Savannah", "Athens"]
    ],
    [
        ["Nevada", "Las Vegas", "Reno", "Carson City"],
        ["Colorado", "Denver", "Boulder", "Colorado Springs"],
        ["Washington", "Seattle", "Spokane", "Tacoma"]
    ]
];

for (int i = 0; i < statesWithCities.Length; i++)
{
    for (int j = 0; j < statesWithCities[i].Length; j++)
    {
        Console.WriteLine($"State: {statesWithCities[i][j][0]}, First City: {statesWithCities[i][j][1]}");
    }
}



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