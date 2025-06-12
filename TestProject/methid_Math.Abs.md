### Named Arguments in Method Calls

The code snippet:

```csharp
CreateEmailAddress(
    employeeFirstNameIndex: corporate[i, 0], 
    employeeLastIndex: corporate[i, 1], 
    corporateDomain
);
```
is using **named arguments** in a method call. Here’s what’s happening:

1. **Named Argument Syntax (`:`)**  
   - `employeeFirstNameIndex:` and `employeeLastIndex:` are **named arguments**.
   - Instead of just passing values in the order defined in the method signature, **named arguments explicitly specify which parameter** they correspond to.
   - This helps readability, especially when dealing with multiple parameters of the same type.

2. **Positional vs. Named Arguments**  
   - You **can** mix named arguments and positional arguments (like `corporateDomain` in this case).  
   - **Positional arguments** are assigned based on their position in the method call, while **named arguments** assign values explicitly to parameters by name.

### Why Use Named Arguments?
Using named arguments makes your code **clearer** and **more maintainable**, especially when:
- The method has multiple parameters.
- Some parameters have default values.
- You want to avoid confusion about argument order.

For example, if the method is defined like this:

```csharp
void CreateEmailAddress(int employeeFirstNameIndex, int employeeLastIndex, string domain) { }
```
Without named arguments:
```csharp
CreateEmailAddress(corporate[i, 0], corporate[i, 1], corporateDomain); // Order matters!
```
With named arguments:

```csharp
CreateEmailAddress(
    employeeFirstNameIndex: corporate[i, 0], 
    employeeLastIndex: corporate[i, 1], 
    domain: corporateDomain
);
```
This makes it **explicit** which values are assigned to which parameters—no guessing!

Example with **optional parameters** or **default values** next? 

**optional parameters** with multiple defaults.

### Example: Multiple Optional Parameters
```csharp
void CreateEmailAddress(
    int employeeFirstNameIndex,
    int employeeLastIndex,
    string domain = "corporate.com",
    string separator = ".",
    bool includeCompanyPrefix = false
)
{
    string prefix = includeCompanyPrefix ? "corp_" : "";
    string email = $"{prefix}{employeeFirstNameIndex}{separator}{employeeLastIndex}@{domain}";
    Console.WriteLine($"Generated Email: {email}");
}
```
### How It Works:
- **`domain`**, **`separator`**, and **`includeCompanyPrefix`** all have default values.
- If you don’t provide them, their defaults (`"corporate.com"`, `"."`, and `false`) are used.

### Calling the Method:
```csharp
CreateEmailAddress(1, 2); 
// Output: Generated Email: 1.2@corporate.com

CreateEmailAddress(1, 2, "example.org"); 
// Output: Generated Email: 1.2@example.org

CreateEmailAddress(1, 2, "custom.net", "_"); 
// Output: Generated Email: 1_2@custom.net

CreateEmailAddress(1, 2, includeCompanyPrefix: true); 
// Output: Generated Email: corp_1.2@corporate.com
```
### Key Takeaways:
✔ You can skip arguments when they have default values.  
✔ Named arguments allow you to **override specific parameters** without worrying about their order.  
✔ Default values simplify method calls while keeping flexibility.

This makes your methods **more adaptable** without overloading them!

let's add some flexibility using **params**, which allows variable-length arguments.

### Using `params` for Variable-Length Arguments

Sometimes, you might want to pass **any number of arguments** to a method, without having to specify each one individually. This is where `params` comes in.

#### Example:
```csharp
void CreateEmailAddresses(string domain = "corporate.com", params string[] employeeNames)
{
    foreach (var name in employeeNames)
    {
        Console.WriteLine($"{name}@{domain}");
    }
}
```
### How It Works:
- `params string[] employeeNames` allows passing **any number of employee names** without specifying a fixed count.
- The method iterates over the names, generating email addresses.

### Calling the Method:
```csharp
CreateEmailAddresses("example.org", "Alice", "Bob", "Charlie");
// Output:
// Alice@example.org
// Bob@example.org
// Charlie@example.org

CreateEmailAddresses("custom.net", "David"); 
// Output:
// David@custom.net

CreateEmailAddresses(); 
// No output—no names passed.
```
### Key Takeaways:
✔ `params` allows a variable number of arguments.  
✔ It must be **the last parameter** in the method signature.  
✔ Optional parameters **can** be combined with `params`.

This is **really powerful** for methods that process a list of values dynamically, like logging systems or bulk actions! 

example where we use named arguments along with `params` for even more control? 

Great! Let's combine **named arguments** with **params** for even more flexibility.

### Using `params` with Named Arguments
By using both features together, we can selectively override parameters while passing variable-length arguments.

#### Example:
```csharp
void CreateEmailAddresses(
    string domain = "corporate.com",
    bool includeCompanyPrefix = false,
    params string[] employeeNames
)
{
    foreach (var name in employeeNames)
    {
        string prefix = includeCompanyPrefix ? "corp_" : "";
        Console.WriteLine($"{prefix}{name}@{domain}");
    }
}
```
### How It Works:
- **`domain`** and **`includeCompanyPrefix`** have default values.
- **`params string[] employeeNames`** allows passing multiple names dynamically.
- Named arguments let you override specific values without worrying about argument order.

### Calling the Method:
```csharp
CreateEmailAddresses("example.org", true, "Alice", "Bob");
// Output:
// corp_Alice@example.org
// corp_Bob@example.org

CreateEmailAddresses(employeeNames: new[] { "Charlie", "David" }, domain: "custom.net");
// Output:
// Charlie@custom.net
// David@custom.net

CreateEmailAddresses(employeeNames: new[] { "Eva", "Frank" }, includeCompanyPrefix: true);
// Output:
// corp_Eva@corporate.com
// corp_Frank@corporate.com
```
### Key Takeaways:
✔ Named arguments help you override specific values.  
✔ `params` allows flexible input handling for multiple values.  
✔ Combining both features keeps the method calls readable and adaptable.

This approach makes bulk operations **efficient** while maintaining customization!

