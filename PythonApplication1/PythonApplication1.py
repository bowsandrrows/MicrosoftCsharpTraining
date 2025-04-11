from module1 import conversion, sayHello
sayHello()

print("\n\tRunning Python Code\n")

myDecimal = 2.14
print(f"This is decimal: {myDecimal}")

myInt = myDecimal
print(f"This is integer: {myInt:02}")


my_result = conversion("2", "3")
print(f"Converted string to Integer: {my_result}")


data = "12345John Smith          5000  3  "
print(data)
updated_data = data[:5] + data[25:]  # Remove characters from index 5 to 25
print(updated_data)
