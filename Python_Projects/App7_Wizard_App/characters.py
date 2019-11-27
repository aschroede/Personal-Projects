import random


class Creature:
    def __init__(self, name, level):
        self.name = name
        self.level = level

    def self_defence(self):
        creature_role = random.randint(1, 12) * self.level
        return creature_role


class Wizard(Creature):
    def __init__(self, name, level):
        super().__init__(name, level)

    def attack(self, creature):
        wizard_role = self.self_defence()
        creature_role = creature.self_defence()

        print(
            "{} rolls a mighty {} while {} fiercely contests with a {}.\n".format(self.name, wizard_role, creature.name,
                                                                                  creature_role))

        if wizard_role >= creature_role:
            print('{} has overwhelmed the villainous {} and achieved victory!\n'.format(self.name, creature.name))
            return True
        else:
            print('{} has succumbed to the power of the {} and has been vanquished!\n'.format(self.name, creature.name))
            return False


class Dragon(Creature):
    def __init__(self, name, level, armor, breaths_fire):
        super().__init__(name, level)
        self.armor = armor
        self.breaths_fire = breaths_fire

    def self_defence(self):
        base_skill = super().self_defence()
        fire_mod = random.randint(2, 5) if self.breaths_fire else 1
        armor_mod = self.armor * 1.1 if self.armor else 1
        return base_skill * fire_mod * int(armor_mod)
