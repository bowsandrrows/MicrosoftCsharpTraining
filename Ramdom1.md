### 🎲 Basic Usage of `Random` in C#
```csharp
Random rnd = new Random(); // Create a Random object

int number = rnd.Next();         // Any positive integer
int bounded = rnd.Next(1, 101);  // Number from 1 to 100
double decimalVal = rnd.NextDouble(); // Between 0.0 and 1.0
byte[] buffer = new byte[5];
rnd.NextBytes(buffer);          // Fills buffer with random bytes
```

### Key Differences from Python
| Concept             | Python                        | C#                              |
|---------------------|-------------------------------|----------------------------------|
| Create randomizer   | `import random` (built-in)    | `Random rnd = new Random();`    |
| Integer range       | `random.randint(1, 100)`      | `rnd.Next(1, 101)`              |
| Float 0–1           | `random.random()`             | `rnd.NextDouble()`              |
| Shuffle/List ops    | `random.shuffle(myList)`      | Use LINQ or manual logic        |

### Watch Out For...
- **Seeding**: If you create multiple `Random` instances quickly (e.g., in a loop), they might generate the same values because they use the system clock as a seed. Reuse a single instance if possible!
- **Thread Safety**: `Random` isn't thread-safe. For multi-threaded apps, use `System.Random.Shared` in .NET 6+ or `ThreadLocal<Random>`.

