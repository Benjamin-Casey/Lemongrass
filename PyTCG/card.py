class Card():
    def __init__(self, name, text, cost):
        self.name = name
        self.text = text
        self.cost = cost

    def __str__(self):
        return """{}\n========\nCost: {}\n{}""".format(self.name, self.cost, self.description)


class Creature(Card):
    def __init__(self, name, text, cost, attack, health):
        Card.__init__(self, name, text, cost)
        self.attack = attack
        self.health = attack

    def __str___(self):
        return """{}\n========\nCost: {}\n{}\nAttack: {}\nHealth: {}""".format(self.name, self.cost, self.description, self.attack, self.health)


class Spell(Card):
    def __init__(self, name, text, cost, attack, health):
        Card.__init__(self, name )