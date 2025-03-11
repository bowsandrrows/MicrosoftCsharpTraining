// See https://aka.ms/new-console-template for more information


#region
//int first = 2;
//string second = "4";
//string result = first + second;
//Console.WriteLine(result);

//Console.WriteLine();

//int myInt = 3;
//Console.WriteLine(myInt);
//decimal myDesimal = myInt;
//Console.WriteLine(myDesimal);

//Console.WriteLine();

//decimal newDecimal = 3.14m;
//Console.WriteLine($"This is decimals: {newDecimal}");

//int newInt = (int)newDecimal; // output 3 (loss of precision)
//Console.WriteLine($"This is int: {newInt}");

//Console.WriteLine();

//decimal myDecimal = 1.23456789m;
//float myFloat = (float)myDecimal;

//Console.WriteLine($"Decimal: {myDecimal}");
//Console.WriteLine($"Float  : {myFloat}");

//string my_first = "5";
//string my_second = "7";     // not advisable to convert, could be decimal.
//int message = int.Parse(my_first) + int.Parse(my_second);
//Console.WriteLine(message);

//string value1 = "5";
//string value2 = "7";
//int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//Console.WriteLine(result2);

//Console.WriteLine("\t---------------------------------------\n");

//string myInput = "2.71828";
//decimal myInputDecimal = 0;
//if (decimal.TryParse(myInput, out myInputDecimal))
//{
//    Console.WriteLine(myInputDecimal);
//}
//Console.WriteLine((float)myInputDecimal);

//Console.WriteLine("\t---------------------------------------\n");

//int[,] matrix = new int[3, 3]
//{
//    {1, 2, 3},
//    {4, 5, 6},
//    {7, 8, 9}
//};

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("\t---------------------------------------\n");

//string[][][] statesWithCities =
//[
//    [
//        ["California", "Los Angeles", "San Francisco", "San Diego"],
//        ["Texas", "Houston", "Dallas", "Austin"],
//        ["Florida", "Miami", "Orlando", "Tampa"]
//    ],
//    [
//        ["New York", "New York City", "Buffalo", "Rochester"],
//        ["Illinois", "Chicago", "Springfield", "Naperville"],
//        ["Georgia", "Atlanta", "Savannah", "Athens"]
//    ],
//    [
//        ["Nevada", "Las Vegas", "Reno", "Carson City"],
//        ["Colorado", "Denver", "Boulder", "Colorado Springs"],
//        ["Washington", "Seattle", "Spokane", "Tacoma"]
//    ]
//];

//for (int i = 0; i < statesWithCities.Length; i++)
//{
//    for (int j = 0; j < statesWithCities[i].Length; j++)
//    {
//        Console.WriteLine($"State: {statesWithCities[i][j][0]}, First City: {statesWithCities[i][j][1]}");
//    }
//}
#endregion


///* 
//When you know you're performing a narrowing conversion, you need to perform a cast. 
//Casting is an instruction to the C# compiler that you know precision may be lost, 
//but you're willing to accept it.
//If you're unsure whether you lose data in the conversion, write code to perform a 
//conversion in two different ways and observe the changes. 

//The term widening conversion means that you're attempting to convert a value from a 
//data type that could hold less information to a data type that can hold more information.
//When you know you're performing a widening conversion, you can rely on implicit conversion. 
//The compiler handles implicit conversions.
//*/

#region Type Conversion
//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//decimal total = 0m;
//string massage = "";
////foreach (var item in values)
////{
////    if (!item.All(char.IsLetter))
////    {
////        total += decimal.Parse(item);
////    }
////    else if (item.All(char.IsLetter))
////    {
////        massage += item;
////    }
////}
////Console.WriteLine($"Massage: {massage}");
////Console.WriteLine($"Total: {total}");

//for (int i = 0; i < values.Length; i++)
//{
//    if (decimal.TryParse(values[i], out decimal result))
//    {
//        total += result;
//    }
//    else
//    {
//        massage += values[i];
//    }
//}
//Console.WriteLine("\t---------------------------------------");
//Console.WriteLine($"\t\tMassage: {massage}");
//Console.WriteLine($"\t\tTotal: {total}");
//Console.WriteLine("\t---------------------------------------\n");
#endregion


int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2; // 2
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3; // 1.4418604651162790697674418605
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1; // 0.3909091
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

string myString = "4.123456789";
decimal myDecimal = decimal.Parse(myString); // 4.123456789
decimal myNewDecimal = Convert.ToDecimal(myString); // 4.123456789
Console.WriteLine($"Parse: {myDecimal} & {myNewDecimal}");

Console.WriteLine("\t---------------------------------------\n");


float myFloat = 3.14f;
int myInt = (int)myFloat;
Console.WriteLine( myInt);
