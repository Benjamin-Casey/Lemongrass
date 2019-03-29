class Player:
    def __innit__(self):
        self.hp = 100
        self.inventory = []
        self.weapon = None
        self.attack = self.weapon.attack
        self.x = 0
        self.y = 0

    
    def inventory(self):
        for item in self.inventory:
            print(item.description)

    def move(self, direction):
        if direction == north:
            player.y += 1
        elif direction == south:
            player.y -= 1
        elif direction == east:
            player.x += 1
        elif direction == west:
            player.x -= 1
        else:
            raise Exception("Invalid direction input.")

    def attack(self, target):
        if self.attack == 0:
            print("")

