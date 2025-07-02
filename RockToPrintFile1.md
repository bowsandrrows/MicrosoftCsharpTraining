---

## 🔹 LINQ Cheat Sheet (C# Edition)

### 📋 Basic Setup
Make sure this is included:
```csharp
using System.Linq;
```

---

### 🔍 Filtering

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `Where()`             | Filter items by a condition        |
```csharp
var adults = people.Where(p => p.Age >= 18);
```

---

### 🔄 Transformation

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `Select()`            | Project/transform each item        |
```csharp
var names = people.Select(p => p.Name);
```

---

### 🎛️ Sorting

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `OrderBy()` / `OrderByDescending()` | Sort items        |
```csharp
var sorted = people.OrderBy(p => p.Name);
```

---

### 📦 Grouping

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `GroupBy()`           | Group by key                       |
```csharp
var groups = people.GroupBy(p => p.City);
```

---

### 🧪 Quantifiers

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `Any()`               | Check if any match condition       |
| `All()`               | Check if all match condition       |
```csharp
var hasTeens = people.Any(p => p.Age >= 13 && p.Age <= 19);
```

---

### 🔢 Aggregation

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `Count()`             | Count elements                     |
| `Sum()`               | Sum values                         |
| `Average()`           | Calculate average                  |
| `Min()` / `Max()`     | Find min/max                       |
```csharp
var totalAge = people.Sum(p => p.Age);
```

---

### 🔗 Set Operations

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `Distinct()`          | Remove duplicates                  |
| `Union()`             | Combine and deduplicate            |
| `Intersect()`         | Common values                      |
| `Except()`            | Difference                         |
```csharp
var uniqueFruits = fruits1.Union(fruits2);
```

---

### 🧬 Element Operations

| Expression            | Purpose                            |
|-----------------------|------------------------------------|
| `First()` / `FirstOrDefault()` | First match               |
| `Last()` / `LastOrDefault()`   | Last match                |
| `ElementAt()`         | Get by index                       |
| `Single()` / `SingleOrDefault()` | Expect only 1 match     |

---