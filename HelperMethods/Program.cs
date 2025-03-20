// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Security;

Console.WriteLine("\tWorking With Helper Methods\n\t\t*******");

/*
In this module, you work with C# arrays to store sequences of values in a single data structure. Once you store data in an array, 
you can modify both the order and contents. Additionally, you can perform complex string operations using array helper methods.
You start by using helper methods to sort or reverse the data. Next, you learn how to remove items from the array and resize the array 
to accommodate new items. Then, you learn to convert a string into an array by splitting it into smaller strings each time a specific character, 
such as a comma, is encountered. The same method can also be used to split a string into an array of characters. 
Finally, you learn how to join all elements of an array into a single string.
 */

#region Sort() Reverse() Clear()
/*
int[] num = [22, 333, 45, 85, 475, 32, 1, 5, 3];
Array.Sort(num);
foreach (var n in num)
{
    Console.Write(n + ",");
}
Console.WriteLine("\n");
Array.Clear(num, 0, 5);
foreach (var item in num)
{
    if (item != 0)
    {
        Console.WriteLine($"Available numbers: {item}");
    }
    
}


Console.WriteLine("\n-------------------------------\n");

String[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine($"Sorted... count: {pallets.Length}");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine($"Reversed...{pallets.Length}");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);

if (pallets[0] != null) // in order to avoid an exception
    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
#endregion

#region Resize() the array to add more elements.
/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 7); // new elements are null until you assign a value to them.
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
#endregion

#region Resize() the array to remove elements
/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
#endregion

#region ToCharArray() to reverse a string

//string value = "abc123";
//char[] charsArray = value.ToCharArray();
//for (int i = 0; i < charsArray.Length; i+=1)
//{   
//    Console.WriteLine(charsArray[i]);
//}
//Array.Reverse(charsArray);
//// The expression new string(valueArray) creates a new empty instance of the System.String class
//// (which is the same as the string data type in C#) and passes in the char array as a constructor.
//string result = new(charsArray);
//Console.WriteLine(result); // 321cba

//char[] nameArray = ['E', 'd', 'w', 'a', 'r', 'd'];
//string result3 = new(nameArray);
//Console.WriteLine($"\nGot a name: {result3}"); // Got a name: Edward


//foreach (var item in nameArray)
//{
//    string repeat = item.ToString();
//    Console.Write(repeat); // Edward
//} 

#endregion

#region Split() and Join() - Combine all of the chars into a new comma-separated-value string using Join()

//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//// string result = new string(valueArray);
//string result = String.Join(",", valueArray);
//Console.WriteLine(result); // 3,2,1,c,b,a

//string[] items = result.Split(',');
//Console.WriteLine($"The length of items array is: {items.Length}");
//foreach (var item in items)
//{
//    Console.WriteLine(item);
//}
//string newvalue = String.Join("", items);
//Console.WriteLine(newvalue);

#endregion


//Console.Write("Please enter 4 numbers separated by a comma or a dush: ");
//string? prompt = Console.ReadLine();
//char[] separators = [',', ':', '.', '/'];
//int total = 0;

//if (prompt != null)
//{
//    string[] splitPrompt = prompt.Split(separators);

//    foreach (var item in splitPrompt)
//    {
//        total += int.Parse(item);
//    }
//    //int num1 = int.Parse(splitPrompt[0]);
//    //int num2 = int.Parse(splitPrompt[1]); 
//    //int num3 = int.Parse(splitPrompt[2]);
//    //int num4 = int.Parse(splitPrompt[3]);
//    Console.WriteLine($"Total sum of your numbers is: {total}");
//}
//else
//{
//    //isValid = false;
//    Console.WriteLine("We only accept numbers!");
//}

//  if (int.TryParse(item, out int number))

Console.Write("Please enter 4 numbers separated by a comma or a dash: ");
string? prompt = Console.ReadLine()?.Trim();
if (prompt != null)
{
    char[] separators = { ',', ':', '.', '/' };
    string[] numbs = prompt.Split(separators);
    foreach (var item in numbs)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Input was null.");
}

// Exercise - Complete a challenge to reverse words in a sentence


