# Tiles/World

class Tile:
	def __init__(self, name, description,  x, y , z):
		self.name = name
		self.description = description
		self.x = x
		self.y = y
		self.z = z

	def __str__(self_):
		return """Name: {}\n Description{}\n""".format(self.name, self.description)


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
#meadow = Tile("Meadow", "Blah", 0, 0, 0)