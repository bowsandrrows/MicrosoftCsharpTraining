`String.Format()` in C# is a method used to format strings by inserting values into placeholders within a string template. These placeholders are defined using curly braces `{}` and are indexed starting from 0. Let's break it down with examples and show the output.

### **Syntax**

```csharp
String.Format(formatString, arg0, arg1, ...)
```

- `formatString`: The string template containing placeholders like `{0}`, `{1}`, etc.
- `arg0, arg1...`: The values to be inserted into the placeholders.

**Example 1: Simple String Formatting**

```csharp
string name = "Alice";
int age = 30;
string formattedString = String.Format("My name is {0} and I am {1} years old.", name, age);
Console.WriteLine(formattedString);
```
**Output:**
```
My name is Alice and I am 30 years old.
```
### **Example 2: Formatting Numbers**

```csharp
double price = 1234.56;
string formattedPrice = String.Format("The price is {0:C}.", price); // {0:C} formats the number as currency
Console.WriteLine(formattedPrice);
```
**Output:**
```
The price is $1,234.56. (or the currency symbol based on your locale)
```
### **Example 3: Formatting Dates**

```csharp
DateTime today = DateTime.Now;
string formattedDate = String.Format("Today's date is {0:MMMM dd, yyyy}.", today); // {0:MMMM dd, yyyy} formats the date
Console.WriteLine(formattedDate);
```
**Output:**
```
Today's date is March 30, 2025.
```
**Example 4: Aligning Strings**

```csharp
string left = String.Format("{0,-10}", "Left");  // Aligns to the left
string right = String.Format("{0,10}", "Right"); // Aligns to the right
Console.WriteLine($"'{left}'");
Console.WriteLine($"'{right}'");
```
**Output:**
```
'Left      '
'     Right'
```
**Key Notes**

- You can use format specifiers (like `C` for currency, `D` for decimals, `X` for hexadecimal) to control the appearance of the values.
- Proper indexing matters: `{0}`, `{1}`, etc., correspond to the positional arguments passed to the `String.Format()` method.

This method is flexible and makes it easy to build complex strings dynamically. 

## An example demonstrating why proper indexing matters when using `String.Format()`:

**Example: Indexing in `String.Format()`**

```csharp
string firstName = "John";
string lastName = "Doe";
int age = 25;

// Correct indexing
string correct = String.Format("Hello, my name is {0} {1} and I am {2} years old.", firstName, lastName, age);

// Incorrect indexing
string incorrect = String.Format("Hello, my name is {0} {2} and I am {1} years old.", firstName, lastName, age);

Console.WriteLine("Correct: " + correct);
Console.WriteLine("Incorrect: " + incorrect);
```
**Output:**
```
Correct: Hello, my name is John Doe and I am 25 years old.
Incorrect: Hello, my name is John 25 and I am Doe years old.
```
**Explanation:**

- The **correct string** uses `{0}` for the first argument (`firstName`), `{1}` for the second (`lastName`), and `{2}` for the third (`age`). The placeholders match their respective positions.
- In the **incorrect string**, the indexing is mismatched:
  - `{0}` correctly references `firstName`.
  - `{2}` mistakenly references `age` instead of `lastName`.
  - `{1}` references `lastName` instead of `age`.

This misalignment leads to confusing and incorrect output. Proper indexing ensures each placeholder matches the intended value! Would you like more examples or a deeper dive into formatting techniques?