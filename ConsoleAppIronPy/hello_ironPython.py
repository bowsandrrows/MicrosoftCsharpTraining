# IronPython

import clr
clr.AddReference("System.Windows.Forms")
from System.Windows.Forms import Form
clr.AddReference("System")
from System import DateTime

# Create a simple Windows Form
form = Form()
form.Text = "Hello from IronPython!"
form.ShowDialog()



# print("\t-"*12)
# print("Hello")