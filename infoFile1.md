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

`color: #61dafb`;
`background-color: #282c34`;

Here are some **cool, attractive colors** that are **easy on the eyes** and work well in **WPF applications**:

1. **Slate Blue (#6A5ACD)** , **rgb(106, 90, 205)** – A soft, muted blue with a hint of purple, offering a calming effect.
2. **Sea Green (#2E8B57)** , **rgb(46, 139, 87)** – A refreshing green that is gentle on the eyes and works well for UI backgrounds.
3. **Steel Gray (#708090)** , **rgb(112, 128, 144)** – A neutral, modern shade that provides a sleek and professional look.
4. **Lavender Mist (#E6E6FA)** , **rgb(230, 230, 250)** – A subtle pastel purple that adds elegance without being overwhelming.
5. **Teal (#008080)** , **rgb(0, 128, 128)** – A balanced mix of blue and green, creating a sophisticated and soothing tone.
6. **Warm Beige (#F5F5DC)**, **rgb(245, 245, 220)** – A soft, warm neutral that enhances readability and reduces eye strain.

You can explore more color palettes [here](https://www.color-hex.com/color-palette/76564) and 
[here](https://www.color-hex.com/color-palette/1009880). If you're designing a WPF app, consider using 
these colors for backgrounds, buttons, and accents to create a visually appealing and comfortable UI.

C# provides several methods for locating characters or substrings within a string. Some commonly used methods include:

- **`IndexOf`**: Finds the index of the first occurrence of a character or substring.
- **`LastIndexOf`**: Finds the index of the last occurrence of a character or substring.
- **`Contains`**: Checks if a substring is present in the string (returns `true` or `false`).
- **`StartsWith` / `EndsWith`**: Checks if a string starts or ends with a given substring.
- **`Substring`**: Extracts a portion of a string based on index.
- **`Regex.Match` / `Regex.IsMatch`**: For more advanced pattern matching using regular expressions.

Here's a quick example using `IndexOf`:

```csharp
string text = "Hello, world!";
int position = text.IndexOf("world");

if (position != -1)
{
    Console.WriteLine($"'world' found at index {position}");
}
else
{
    Console.WriteLine("'world' not found");
}
```