// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("\tWorking With Helper Methods\n");

/*
In this module, you work with C# arrays to store sequences of values in a single data structure. Once you store data in an array, 
you can modify both the order and contents. Additionally, you can perform complex string operations using array helper methods.
You start by using helper methods to sort or reverse the data. Next, you learn how to remove items from the array and resize the array 
to accommodate new items. Then, you learn to convert a string into an array by splitting it into smaller strings each time a specific character, 
such as a comma, is encountered. The same method can also be used to split a string into an array of characters. 
Finally, you learn how to join all elements of an array into a single string.
 */

#region Sort() and Reverse()

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

Console.WriteLine($"Before: {pallets[0]}, {pallets[1]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

#endregion


