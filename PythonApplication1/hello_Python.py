from time import sleep
import os

# from time import sleep
# import os


# icons_list = [".", "..", "...", "....", ".....", "......"]

# for i in range(5):
#     os.system('cls' if os.name == 'nt' else 'clear') # clears the console at start
#     for j in icons_list:
#         print(f"Searching {j}")
#         sleep(0.5)
#         os.system('cls' if os.name == 'nt' else 'clear') # clears the console after each iteration



def main():
    # Checks if input is not an empty string.
    print("Type the words you're looking for. Separated by comma. Or type Q/q to quit")
    while True:
        try:
            get_user_input = input("\nYour words: ").strip()
            # checks for EOFError (End of File Error)
        except EOFError:                                           
            print("Unexpected input, please try again.")
            continue

        if get_user_input == "":
            print("Empty input. Please try again or type Q/q to quit.")
            continue
        elif get_user_input.lower() == "q":
            break
        else:
            print(search_fun())
            break


def search_fun():
    # ANSI color codes
    YELLOW = "\033[93m"
    RED = "\033[91m"
    GREEN = "\033[92m"
    BLUE = "\033[94m"
    RESET = "\033[0m"  # Resets color back to default

    icons_list = [f"{YELLOW}.", f"{RED}..", f"{BLUE}...", f"{RED}....", f"{GREEN}.....", f"{BLUE}......"]
    for _ in range(1):
        os.system('cls' if os.name == 'nt' else 'clear')  # Clears the console at start
        for i in icons_list:
            for j in range(4).__reversed__():
                print(f"{GREEN}Searching {i}{RESET} {f"{RED} {j}{RESET}"}")  # Reset ensures the color doesn't persist
                sleep(0.5)
                os.system('cls' if os.name == 'nt' else 'clear')  # Clears the console after each iteration

    return("Could not find it")

if __name__ == "__main__":
    main()