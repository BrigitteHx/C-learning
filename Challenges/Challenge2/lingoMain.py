# lingoMain

from lingoFunctions import *

def main():
    while True:
        titleScreen()
        playAgain = input("Would you like to play another round (yes/no): ").lower()
        if playAgain.lower() != "yes":
            break

main()