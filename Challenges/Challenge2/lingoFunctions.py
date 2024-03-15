# lingoFunctions

# COLORS ------------------------------------------------------------------------------------------------------------

class colors:
    RED = '\033[91m'
    GREEN = '\033[92m'
    YELLOW = '\033[93m'
    BLUE = '\033[94m'
    MAGENTA = '\033[95m'
    CYAN = '\033[96m'
    WHITE = '\033[97m'
    RESET = '\033[0m'

# IMPORT -----------------------------------------------------------------------------------------------------------

import random

# TITLE SCREEN WORKING ---------------------------------------------------------------------------------------------

def titleScreenOptions():
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


# TITLE SCREEN LOOK ---------------------------------------------------------------------------------------------

def titleScreen():
    print(colors.BLUE + "                 WELCOME TO LINGO                  \n" + colors.RESET)
    print(colors.CYAN + "                 > PLAY                  \n" + colors.RESET)
    print(colors.CYAN + "                 > HELP                  \n" + colors.RESET)
    print(colors.CYAN + "                 > QUIT                  \n" + colors.RESET)
    titleScreenOptions()


# HELP MENU ----------------------------------------------------------------------------------------------------

def helpMenu():
    print("\nHELP: \n")
    print("Raad het ENGELSE 5-letterige woord voordat de pogingen op zijn.\n")
    print("Als een geraden letter goed is én op de juiste plek zal er een + staan.\nAls de letter in het woord zit maar niet op de juiste plek zal er een - staan.\n")
    print("Je kunt tot 5 keer raden. \n")
    print("Zorg ervoor dat je in lowercase typt.\n")
    print(colors.BLUE + "                 LINGO                  \n" + colors.RESET)
    print(colors.CYAN + "                 > PLAY                  \n" + colors.RESET)
    print(colors.CYAN + "                 > HELP                  \n" + colors.RESET)
    print(colors.CYAN + "                 > QUIT                  \n" + colors.RESET)
    titleScreenOptions()


# WORD ----------------------------------------------------------------------------------------------------

def pickWord():
    # wordList = ["cheer"] # -> voor testen
    wordList = [
        'abide', 'about', 'aisle', 'alien', 'alive', 'alloy', 'alpha', 'among', 'angry', 'ankle',
        'apple', 'april', 'argue', 'array', 'asset', 'aunty', 'awake', 'bacon', 'badge', 'basic',
        'batch', 'beach', 'beard', 'beast', 'begin', 'being', 'belle', 'berry', 'bible', 'birth',
        'black', 'blade', 'blank', 'blend', 'bless', 'blind', 'bliss', 'block', 'blood', 'blues',
        'board', 'boast', 'bonus', 'boost', 'bound', 'brave', 'bread', 'break', 'brick', 'bride',
        'brief', 'brisk', 'broad', 'broth', 'brown', 'brush', 'bunch', 'burnt', 'burst', 'bushy',
        'buyer', 'cabin', 'cable', 'cache', 'cagey', 'camel', 'canal', 'candy', 'carve', 'catch',
        'cause', 'cease', 'chain', 'chair', 'chalk', 'charm', 'chase', 'cheek', 'cheer', 'chess',
        'chief', 'child', 'chill', 'china', 'chive', 'cigar', 'civic', 'civil', 'claim', 'clamp',
        'clash', 'clean', 'clear', 'clerk', 'click', 'cliff', 'climb', 'clock', 'close', 'cloth'
    ]

    return random.choice(wordList)


# LINGO ----------------------------------------------------------------------------------------------------

def lingo():
    chosenWord = pickWord()
    guessAttempts = 0 

    while guessAttempts < 5:
        # print(chosenWord) # -> voor testen

        chosenWordCopy = list(chosenWord)  # kopie 

        guess = input("Voer je woord in: ").lower()
        resultGuess = [""] * len(guess)

        if len(guess) != 5:
            print(colors.RED + "Niet goed, je woord moet 5 letters lang zijn. Probeer opnieuw." + colors.RESET)
            continue

        if guess == chosenWord:
            print(colors.GREEN + "Gefeliciteerd, dat is juist!" + colors.RESET)
            break

        # in woord en op juiste plek:
        for i in range(len(guess)):
            if guess[i] == chosenWord[i]:
                resultGuess[i] = "+"
                chosenWordCopy[i] = "." # vervangt index met . 

        # in woord maar niet op juiste plek:
        for i in range(len(guess)):
            if resultGuess[i] == "":
                if guess[i] in chosenWordCopy:
                    resultGuess[i] = "-"
                    chosenWordCopy[chosenWordCopy.index(guess[i])] = "." # vervangt index met ook .

        # rest wordt "x" (niet in het woord voorkomend)
        for i in range(len(guess)):
            if resultGuess[i] == "":
                resultGuess[i] = "x"

        print("Feedback:", resultGuess)
        print("Raad pogingen over:", 5 - guessAttempts, "\n")
        guessAttempts += 1

    if guessAttempts >= 5:
        print("Sorry, je hebt geen poging meer over.")
        print("Het woord was:", chosenWord)
