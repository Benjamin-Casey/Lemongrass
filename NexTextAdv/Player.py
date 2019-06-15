# Player

class Player:
	"""
	HP - Health of the player
	X - X location of the player 
	Y - Y location of the player
	Z - Z location of the player
	inventory - inventory of the player
	name - name of the player
	"""
	def __init__(self):
		self.hp = 100
		self.x = 0
		self.y = 0
		self.z = 0
		self.inventory = []
		self.victory = False
		#self.name = name


	def is_alive(self):
		return player.hp >= 0

	#def move(self, direction)
	def move_north(self):
		self.y += 1


# Create player object
player = Player()