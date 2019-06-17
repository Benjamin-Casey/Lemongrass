# Tiles/World

class Tile:
	def __init__(self, name, description,  x, y , z):
		self.name = name
		self.description = description
		self.x = x
		self.y = y
		self.z = z

	def __str__(self):
		return """\nName: {}\nDescription: {}\n(X, Y): ({},{})\n""".format(self.name, self.description, self.x, self.y)


class Treasure_Room(Tile):
	def __init__(self, name, description, x, y, z, treasure):
		self.treasure = treasure
		super().__init__(name, description, x, y, z)



class Meadow(Tile):
	def __init__(self):
		super().__init__(name = "Meadow",
						description = "blah",
						x = 0, y = 0, z = 0)


# Create tile object - two different ways, I don't know pros cons or the difference.

#meadow = Meadow()
meadow = Tile("Meadow", "Blah", 0, 0, 0)

world = [
	Tile("Meadow", "You stand in a meadow of daisies. To the north lies a forest", 0, 0, 0),
	Tile("Forest", "You stand within a forest. Thick trees stand around you. To the south lies a forest.", 0, 1, 0)
		]