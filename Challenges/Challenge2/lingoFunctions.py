# lingoFunctions

# imports: 
import random

# classes:
class colors:
    RED = '\033[91m'
    GREEN = '\033[92m'
    BLUE = '\033[94m'
    CYAN = '\033[96m'
    RESET = '\033[0m'

# functions: 
def titleScreen():
    """
    Function shows and styles the titlescreen. 

    """
    print(colors.BLUE + "                 WELCOME TO LINGO                  \n" + colors.RESET)
    print(colors.CYAN + "                 > PLAY                  \n" + colors.RESET)
    print(colors.CYAN + "                 > HELP                  \n" + colors.RESET)
    print(colors.CYAN + "                 > QUIT                  \n" + colors.RESET)
    titleScreenOptions()

def titleScreenOptions():
    """
    Function shows options in the title screen and handles them: 

    - "play": starts game
    - "quit": closes game
    - "help": shows help menu 
    """

    option = input("> ")
    if option.lower() == "play":
        lingo()
    elif option.lower() == "quit":
        exit()
    elif option.lower() == "help":
        helpMenu()
    else:
        print("Invalid answer, please try again.")
        titleScreenOptions()


def helpMenu():
    """
    Function shows and styles the help menu. 

    """
    print("\nHELP: \n")
    print("Guess the ENGLISH 5-letter word before you run out of attempts.\n")
    print("If a guessed letter is correct and in the right place, there will be a ' + '.\nIf the letter is in the word but not in the right place, there will be a ' - '.\n")
    print("You can guess up to 5 times in 1 game.\n")
    print("Make sure you're typing/ entering your answer in lowercase.\n")
    print(colors.BLUE + "                 LINGO                  \n" + colors.RESET)
    print(colors.CYAN + "                 > PLAY                  \n" + colors.RESET)
    print(colors.CYAN + "                 > HELP                  \n" + colors.RESET)
    print(colors.CYAN + "                 > QUIT                  \n" + colors.RESET)
    titleScreenOptions()

def pickWord():
    """
    Function chooses a random word from a pre defined list of words.
    
    Returns a randomly picked word out of the pre defined list.
    """
    # wordList = [
    #     'abide', 'about', 'aisle', 'alien', 'alive', 'alloy', 'alpha', 'among', 'angry', 'ankle',
    #     'apple', 'april', 'argue', 'array', 'asset', 'aunty', 'awake', 'bacon', 'badge', 'basic',
    #     'batch', 'beach', 'beard', 'beast', 'begin', 'being', 'belle', 'berry', 'bible', 'birth',
    #     'black', 'blade', 'blank', 'blend', 'bless', 'blind', 'bliss', 'block', 'blood', 'blues',
    #     'board', 'boast', 'bonus', 'boost', 'bound', 'brave', 'bread', 'break', 'brick', 'bride',
    #     'brief', 'brisk', 'broad', 'broth', 'brown', 'brush', 'bunch', 'burnt', 'burst', 'bushy',
    #     'buyer', 'cabin', 'cable', 'cache', 'cagey', 'camel', 'canal', 'candy', 'carve', 'catch',
    #     'cause', 'cease', 'chain', 'chair', 'chalk', 'charm', 'chase', 'cheek', 'cheer', 'chess',
    #     'chief', 'child', 'chill', 'china', 'chive', 'cigar', 'civic', 'civil', 'claim', 'clamp',
    #     'clash', 'clean', 'clear', 'clerk', 'click', 'cliff', 'climb', 'clock', 'close', 'cloth'
    # ]
    wordList = ["cheer"] 

    return random.choice(wordList)

def lingo():
    """
    Function simulates the lingo game: 
    
    The player has to guess a word based on feedback from the game.
    """
    chosenWord = pickWord()
    guessAttempts = 0 

    while guessAttempts < 5:
        # print(chosenWord) 

        chosenWordCopy = list(chosenWord) 

        guess = input("Enter your word: ").lower()
        resultGuess = [""] * len(guess)

        if len(guess) != 5:
            print(colors.RED + "Incorrect enter, your word has to be 5 letters long. Try again!" + colors.RESET)
            continue

        if guess == chosenWord:
            print(colors.GREEN + "Congrats, that is correct! You guessed the word." + colors.RESET)
            break

        # wanneer letter in woord & op juiste plek:
        for i in range(len(guess)):
            if guess[i] == chosenWord[i]:
                resultGuess[i] = "+"
                chosenWordCopy[i] = "." # -> vervangt index met . 

        # wanneer in woord maar niet op juiste plek:
        for i in range(len(guess)):
            if resultGuess[i] == "":
                if guess[i] in chosenWordCopy:
                    resultGuess[i] = "-"
                    chosenWordCopy[chosenWordCopy.index(guess[i])] = "." # -> vervangt index met .

        # rest wordt "x" (niet in het woord voorkomend) 
        for i in range(len(guess)):
            if resultGuess[i] == "":
                resultGuess[i] = "x"

        print("Feedback:", resultGuess)
        print("Guessing attempts remaining:", 5 - guessAttempts, "\n")
        guessAttempts += 1

    if guessAttempts >= 5:
        print("Sorry, you don't have any guessing attempts left.")
        print("The word was:", chosenWord)