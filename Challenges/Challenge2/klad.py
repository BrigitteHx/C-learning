import random

def pickWord():
    # wordList = [
    #     'abide', 'about', 'aisle', 'alien', 'alive', 'alloy', 'alpha', 'among', 'angry', 'ankle',
    #     'apple', 'april', 'argue', 'array', 'asset', 'aunty', 'awake', 'bacon', 'badge', 'basic',
    #     'batch', 'beach', 'beard', 'beast', 'begin', 'being', 'belle', 'berry', 'bible', 'birth',
    #     'board', 'boast', 'bonus', 'boost', 'bound', 'brave', 'bread', 'break', 'brick', 'bride',
    #     'brief', 'brisk', 'broad', 'broth', 'brown', 'brush', 'bunch', 'burnt', 'burst', 'bushy',
    #     'cause', 'cease', 'chain', 'chair', 'chalk', 'charm', 'chase', 'cheek', 'cheer', 'chess',
    #     'chief', 'child', 'chill', 'china', 'chive', 'cigar', 'civic', 'civil', 'claim', 'clamp',
    #     'clash', 'clean', 'clear', 'clerk', 'click', 'cliff', 'climb', 'clock', 'close', 'cloth'
    # ]
    wordList = ["cheer"]
    return random.choice(wordList)

def lingo():
    chosenWord = pickWord()
    guessAttempts = 0 

    while guessAttempts < 5 :
        chosenWordCopy = list(chosenWord) 
        guess = input("Enter your word: ").lower()
        resultGuess = [""] * len(guess)

        if len(guess) != 5:
            print("Incorrect enter, your word has to be 5 letters long. Try again!")
            continue

        if guess == chosenWord:
            print("Congrats, that is correct! You guessed the word.")
            break

        # check letter in woord en juiste plek
        for i in range(len(guess)):
            if guess[i] == chosenWord[i]:
                resultGuess[i] = "+"
                chosenWordCopy[i] = "."

        # check letter in woord niet juiste plek
        for i in range(len(guess)):
            if resultGuess[i] == "":
                if guess[i] in chosenWordCopy:
                    resultGuess[i] = "-"
                    chosenWordCopy[chosenWordCopy.index(guess[i])] = "."

        # rest (niet in woord)
        for i in range(len(guess)):
            if resultGuess[i] == "":
                resultGuess[i] = "x"

        print("Feedback:", resultGuess)
        print("Guessing attempts remaining:", 5 - guessAttempts)
        guessAttempts += 1

    if guessAttempts >= 5:
        print("Sorry, you don't have any guessing attempts left.")
        print("The word was:", chosenWord)

lingo()
