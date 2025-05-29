`Math.Abs()` is a method in C# (and other .NET languages) that returns the absolute value of a given number. The absolute value of a number is its non-negative value, meaning it removes any negative sign.

### Usage
You can use `Math.Abs()` with different numeric types such as `int`, `double`, `decimal`, etc.

### Example
```csharp
using System;

class Program
{
    static void Main()
    {
        int num1 = -10;
        double num2 = -3.5;
        
        Console.WriteLine(Math.Abs(num1)); // Output: 10
        Console.WriteLine(Math.Abs(num2)); // Output: 3.5
    }
}
```
### How It Works
- If the input is positive or zero, it remains unchanged.
- If the input is negative, `Math.Abs()` removes the negative sign.
