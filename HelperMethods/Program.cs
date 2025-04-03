Console.WriteLine("\tWorking With Helper Methods\n\t\t*******\n\n");

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

#region Multi-separator
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
#endregion


#region Challenge Unit 6 of 10
/*
1.To create the string array message, split the pangram string on the space character.
2.Create a new newMessagearray that stores a reversed copy of the "word" string from the message array.
3.Loop through each element in the message array, reverse it, and store this element in newMessage array.
4.Join "word" strings from the array newMessage, using a space again, to create the desired single string to write to the console.
 */
/*
// Exercise - Complete a challenge to reverse words in a sentence

//string pangram = "The quick brown fox jumps over the lazy dog";

//List<string> wordsList = [.. pangram.Split(' ')];
//List<char> chars;
//for (int i = 0; i < wordsList.Count; i++)
//{
//    chars = new List<char>(wordsList[i].ToCharArray().Reverse());
//    foreach (var item in chars)
//    {
//        Console.Write(item);
//    }
//    Console.Write(" "); // Adds a space after each reversed word
//}
//Console.WriteLine();


string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangram2 = pangram.Split(" ");
string[] newMessagearray = pangram2.ToArray();
char[] reversedChars;

foreach (var i in newMessagearray)
{
    reversedChars = i.ToCharArray();
    Array.Reverse(reversedChars);
    foreach (var item in reversedChars)
    {

        item.ToString().Split(' ');
        Console.Write(item);
        
    }
    Console.Write(" ");
}
*/
#endregion


#region Complete a challenge to parse a string of orders, sort the orders and tag possible errors
/* output
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
 */

//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//string[] individualOrders = orderStream.Split(',');
//Array.Sort(individualOrders);

//for (int i = 0; i < individualOrders.Length; i++)
//{
//    if (individualOrders[i].Length < 4 || individualOrders[i].Length > 4)
//    {
//        Console.WriteLine(individualOrders[i] + "\t- Error");
//    }
//    else
//    {
//        Console.WriteLine(individualOrders[i]);
//    }

//}

#endregion


#region
/*
//  string formatting basics

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// output: Price: $123.45 (Save $50.00)

//----------------------------------------------------------------------------------------------------------------------------------------------

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// output: Measurement: 123,456.79 units
// By default, the N numeric format specifier displays only two digits after the decimal point.

// to display more precision, you can do that by adding a number after the specifier.
// The following code will display four digits after the decimal point using the N4 specifier. 
decimal measurement2 = 123456.78912m;
Console.WriteLine($"Measurement: {measurement2:N4} units");
// output: Measurement: 123,456.7891 units

//----------------------------------------------------------------------------------------------------------------------------------------------
// the P format specifier to format percentages and rounds to 2 decimal places. Add a number
// afterwards to control the number of values displayed after the decimal point.
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
// output: Tax rate: 36.79%

//----------------------------------------------------------------------------------------------------------------------------------------------

// Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also
// passed in based on their position.

// String variables can store strings created using formatting techniques.
decimal initialPrice = 67.55m;
decimal salePrice = 59.99m;

string priceReductionDetails = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (initialPrice - salePrice), initialPrice);
Console.WriteLine(priceReductionDetails);
// output: You saved $7.56 off the regular $67.55 price.

// combine multiple formatted strings
decimal regularPrice = 67.55m;
decimal reducedPrice = 59.99m;
string priceReduction = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (regularPrice - reducedPrice), regularPrice);

priceReduction += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
Console.WriteLine(priceReduction);
// output: You saved $7.56 off the regular $67.55 price. A discount of 11.19%!

//----------------------------------------------------------------------------------------------------------------------------------------------
*/

/*
 
1. You can use composite formatting or string interpolation to format strings.
2. With composite formatting, you use a string template containing one or more replacement tokens in the form {0}. You also supply a list of arguments 
   that are matched with the replacement tokens based on their order. Composite formatting works when using string.Format() or Console.WriteLine().
3. With string interpolation, you use a string template containing the variable names you want replaced surrounded by curly braces. Use the $ directive 
   before the string template to indicate you want the string to be interpolated.
4. Format currency using a :C specifier.
5. Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like {myNumber:N3}.
6. Format percentages using the :P format specifier.
7. Formatting currency and numbers depend on the end user's culture, a five character code that includes the user's country/region and language (per the 
   settings on their computer).

 */

#endregion

#region Explore string interpolation
/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number:\t {invoiceNumber}");
Console.WriteLine($"Shares:\t\t {productShares:N3} Products");
Console.WriteLine($"Sub Total:\t {subtotal:C}");
Console.WriteLine($"Tax:\t\t {taxPercentage:P2}");
Console.WriteLine($"Total Billed:\t {total:C}");


string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

string input = "Pad this";

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
//Console.WriteLine(input.PadLeft(12));
//Console.WriteLine(input.PadRight(12));
*/
#endregion


#region Working with padded strings
/*
string paymentID = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

string myWords = "Learning C#";
Console.WriteLine(myWords.PadLeft(12, '-'));
Console.WriteLine(myWords.Length);
*/
#endregion

#region chellenge string interpolation
/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string messageToCustomer1 = $"Dear {customerName}";
string messageToCustomer2 = $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n";
string messageToCustomer3 = $"Currently, you own {currentShares:C} shares at a return of {currentReturn:P}.\r\n";
string messageToCustomer4 = $"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\r\n";

Console.WriteLine(messageToCustomer1.PadLeft(17));
Console.WriteLine(messageToCustomer2.PadLeft(148));
Console.WriteLine(messageToCustomer3.PadLeft(66));
Console.WriteLine(messageToCustomer4.PadLeft(138));

string comparisonsString = "Here's a quick comparison:\n";
Console.WriteLine(comparisonsString.PadLeft(29));

string comparisonMessage1 = $"{currentProduct}";
string comparisonMessage2 = $"{currentReturn:P}";
string comparisonMessage3 = $"{currentProfit:C}";

string comparisonMessage4 = $"{newProduct}";
string comparisonMessage5 = $"{newReturn:P}";
string comparisonMessage6 = $"{newProfit:C}";

Console.Write(comparisonMessage1.PadLeft(13));
Console.Write(comparisonMessage2.PadLeft(15));
Console.WriteLine(comparisonMessage3.PadLeft(17));

Console.Write(comparisonMessage4.PadLeft(17));
Console.Write(comparisonMessage5.PadLeft(11));
Console.WriteLine(comparisonMessage6.PadLeft(17));
*/

// Training for String.Format()
//Console.WriteLine("\r\n");

//decimal myDec1 = 123.45m;
//decimal myDec2 = 321.54m;

//var result = $"{String.Format(format: "{0:C}", myDec1).PadRight(10)}";
//Console.WriteLine(result);

//result += String.Format("{0:C}", myDec2);
//Console.WriteLine($"This is myDec1 and myDec2: {result}");

//var result2 = $"{myDec1:C}";
//var result3 = $"{myDec2:C}";
//Console.WriteLine($"The same: {result2.PadLeft(24, '-')} {result3,9}");
//Console.WriteLine();

//string firstName = "John";
//string lastName = "Doe";
//int age = 25;

//// Correct indexing
//string correct = String.Format("Hello, my name is {0} {1} and I am {2} years old.", firstName, lastName, age);

//// Incorrect indexing
//string incorrect = String.Format("Hello, my name is {0} {2} and I am {1} years old.", firstName, lastName, age);

//Console.WriteLine("Correct: " + correct);
//Console.WriteLine("Incorrect: " + incorrect);

//decimal num = 12345.67m;
//Console.WriteLine(String.Format("{0:N2}", num));

//Console.WriteLine("C110".PadLeft(6, '0'));
#endregion

#region string's IndexOf() and Substring() helper methods

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));



string newMessage = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingSpanPosition = newMessage.IndexOf(openSpan);
int closingSpanPosition = newMessage.IndexOf(closeSpan);

openingSpanPosition += openSpan.Length;

int extractedLength = closingSpanPosition - openingSpanPosition;
Console.WriteLine(newMessage.Substring(openingSpanPosition, extractedLength));
Console.WriteLine($" open span: {openSpan.Length}");

#endregion