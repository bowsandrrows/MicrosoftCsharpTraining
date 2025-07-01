the classic way—using a `foreach` or `for` loop—to reverse each string in a `List<string>` and store the results in a **new list**, all without LINQ.

---

### Using `foreach` loop:
```csharp
List<string> original = new List<string> { "apple", "banana", "cherry" };
List<string> reversed = new List<string>();

foreach (string word in original)
{
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    reversed.Add(new string(chars));
}

foreach (string rev in reversed)
{
    Console.WriteLine(rev);
}
```

---

### Using `for` loop:
```csharp
List<string> original = new List<string> { "apple", "banana", "cherry" };
List<string> reversed = new List<string>();

for (int i = 0; i < original.Count; i++)
{
    char[] chars = original[i].ToCharArray();
    Array.Reverse(chars);
    reversed.Add(new string(chars));
}

foreach (string rev in reversed)
{
    Console.WriteLine(rev);
}
```

---

Both approaches do the job without LINQ and are great for beginners or anyone looking for a more explicit, step-by-step style.
