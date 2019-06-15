# Game
import Player, Tiles

# Get the player object from the Player.py file (defined at the bottom)
# Get the meadow object Tiles.py
player = Player.player
meadow = Tiles.meadow

# List of tiles in the world
world = [meadow]


while player.victory == False and player.is_alive():

	# Should be a function in world or something
	for tile in world:
		if tile.x == player.x and tile.y == player.y:
			print(tile.description)

	# Should be a function on one line
	p_input = input("What would you like to do?\n")
	if p_input == "move north":
		print("You move north")
		player.move_north()


print("end of file")
input("Hit anything to end.")