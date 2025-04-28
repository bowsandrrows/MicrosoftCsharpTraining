
# from time import sleep
# import os


# icons_list = [".", "..", "...", "....", ".....", "......"]

# for i in range(5):
#     os.system('cls' if os.name == 'nt' else 'clear') # clears the console at start
#     for j in icons_list:
#         print(f"Searching {j}")
#         sleep(0.5)
#         os.system('cls' if os.name == 'nt' else 'clear') # clears the console after each iteration


from time import sleep
import os

# ANSI color codes
YELLOW = "\033[93m"
RED = "\033[91m"
GREEN = "\033[92m"
BLUE = "\033[94m"
RESET = "\033[0m"  # Resets color back to default

icons_list = [f"{YELLOW}.", f"{RED}..", f"{BLUE}...", f"{RED}....", f"{GREEN}.....", f"{BLUE}......"]

for i in range(5):
    os.system('cls' if os.name == 'nt' else 'clear')  # Clears the console at start
    for j in icons_list:
        print(f"{GREEN}Searching {j}{RESET}")  # Reset ensures the color doesn't persist
        sleep(0.5)
        os.system('cls' if os.name == 'nt' else 'clear')  # Clears the console after each iteration

print("Could not find it")