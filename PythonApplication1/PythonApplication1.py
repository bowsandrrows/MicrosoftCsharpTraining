from module1 import conversion, sayHello
sayHello()

print("\n\tRunning Python Code\n")

myDecimal = 2.14
print(f"This is decimal: {myDecimal}")

myInt = myDecimal
print(f"This is integer: {myInt:02}")


my_result = conversion("2", "3")
print(f"Converted string to Integer: {my_result}")

"""
1.	data[:5] extracts the substring from the start of the string up to (but not including) index 5.
2.	data[25:] extracts the substring starting from index 25 to the end of the string.
3.	Concatenating these two parts effectively removes the characters from index 5 to 25, similar to the Remove method in C#.
"""
data = "12345John Smith          5000  3  "
print(data)
updated_data = data[:5] + data[25:]  # Remove characters from index 5 to 25
print(updated_data)
