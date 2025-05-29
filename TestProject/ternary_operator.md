### C# Ternary Operator & Nested Ternary  
The **ternary operator** (`condition ? trueResult : falseResult`) is a shorthand for `if-else` statements.  

#### Example:
```csharp
int num = 10;
string result = (num % 2 == 0) ? "Even" : "Odd";
Console.WriteLine(result);
```
**Output:** `Even`  

#### **Nested Ternary**
You can nest ternary operators for multiple conditions, but use them carefully to keep code readable.  

```csharp
int score = 85;
string grade = (score >= 90) ? "A" :
               (score >= 80) ? "B" :
               (score >= 70) ? "C" : "F";
Console.WriteLine(grade);
```
**Output:** `B`  

#### **Tip:**  
Use parentheses for clarity when nesting ternaries. If readability suffers, consider using `if-else` instead.  
