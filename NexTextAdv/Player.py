# Player
import Tiles

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
		self.available_actions = []
		self.gameState = None
		#self.name = name


	def is_alive(self):
		# Returns true if plaer is alive
		return player.hp > 0


	def current_tile(self):
		for tile in Tiles.world:
			if tile.x == self.x and tile.y == self.y and tile.z == self.z:
				return tile
		print("\nError, no tile found!\n")


	def print_inventory(self):
		for item in self.inventory:
			print(item)
			

	# Moves the player in chosen direction.
	def move_north(self):
		self.y += 1

	def move_south(self):
		self.y -= 1

	def move_east(self):
		self.x += 1

	def move_west(self):
		self.x -= 1

	def move_up(self):
		self.z += 1
		
	def move_down(self):
		self.z -= 1


	def get_moves(self):
		# Adds tiles next to the player to list of adjacent tiles.
		self.available_actions = []

		for tile in Tiles.world:
			# Check if tile is next to player. If it is, add the corresponding command to move there.
			if tile.x == self.x + 1 and tile.y == self.y:
				available_actions.append(move_east())

			if tile.x == self.x - 1 and tile.y == self.y: 
				available_actions.append(move_west())

			if tile.y == self.y + 1 and tile.x == self.x:
				available_actions.append(move_north())

			if tile.y == self.y - 1 and tile.x == self.x:
				available_actions.append(move_south())


# Create player object
player = Player()