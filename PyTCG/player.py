class Player:
    """
    Mana - available mana. Increments each turn.
    Hand - cards in hand.
    Health - players current life total.
    """
    def __init__(self):
        self.maxMana = 0
        self.availableMana = 0
        self.hand = 4
        self.health = 20

    def __str__(self):
        return """{} health.\n{} cards in hand.\n{}/{} mana.""".format(self.health, self.hand, self.availableMana, self.maxMana)

    def isAlive(self):
        return self.health > 0

