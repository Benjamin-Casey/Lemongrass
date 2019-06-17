from Player import player

# Use commands[key]() to call the function inside e.g commands["n"]() calls north.
# If key does not match a value in the dictionary it will produce a KeyError unless
# .get method is used on commands. Then it will return None.
commands = {
	"n":player.move_north,"s":player.move_south, "e":player.move_east, "w":player.move_west,
	"i":player.print_inventory
	}

command_info = {
	"n":"Move north", "s": "Move south", "e":"Move east", "w":"Move west", "i":"Display Invenotry"
	}