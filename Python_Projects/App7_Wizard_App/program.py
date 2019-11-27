import random
from time import sleep

from characters import Wizard, Creature, Dragon


def main():
    print_header()
    game_loop()


def print_header():
    print('----------------------------------')
    print('          WIZARD GAME')
    print('----------------------------------')


def game_loop():
    creatures = [
        Creature('Toad', 3),
        Creature('Bat', 7),
        Creature('Lion', 25),
        Dragon('Dragon', 60, True, True),
        Wizard('Evil Wizard', 1000),
    ]

    hero = Wizard("Gandolf", 75)

    while True:

        active_creature = random.choice(creatures)

        print("A fiendish {} of level {} emerges from a forest subdued in fog.".format(active_creature.name,
                                                                                       active_creature.level))
        action = input("What will you choose to do? [A]ttack, [R]unaway, or [L]ookaround?\n").lower()

        if action == 'a':
            print("{} approaches the {} ready to engage in fearsome battle!\n".format(hero.name, active_creature.name))

            if hero.attack(active_creature):
                creatures.remove(active_creature)
            else:
                print('{} retreats to a cave to rest for 5 days.'.format(hero.name))
                sleep(5)
                print('{} returns replenished in mind and body and is ready for new advenctures.'.format(hero.name))

        elif action == 'r':
            print('You have chosen to run away! ')
        elif action == 'l':
            print('Gazing off into the distance, {} sees:\n'.format(hero.name))
            for creature in creatures:
                print("* A {} of level {}\n".format(creature.name, creature.level))
        else:
            print('Exiting the game.')
            break


if __name__ == '__main__':
    main()
