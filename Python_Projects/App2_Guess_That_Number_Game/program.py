import random

print('-------------------------------')
print('    Guess That Number Game')
print('-------------------------------')
print()

the_number = random.randint(0, 100)
guess = -1

name = input('Player what is your name? ')
while guess != the_number:
    guess_text = input('Guess a number between 0 and 100: ')
    guess = int(guess_text)

    if guess < the_number:
        print('Sorry {1} your guess of {0} was too LOW.' .format(guess, name))
    elif guess > the_number:
        print('Sorry {1} your guess of {0} was too HIGH.'.format(guess, name))
    else:
        print('Excellent work {1} your guess of {0} was perfect!.'.format(guess, name))

print('done')