# Game
import Player, Tiles
from Commands import commands, command_info

player = Player.player
world = Tiles.world


# Everything within the following loop is a tick in the game.
while player.victory == False and player.is_alive():

	# Print tile description
	print(player.current_tile())

	# Print available commands
	for command in command_info:
		print("{} - {}".format(command, command_info[command]))

	player_input = input("\nWhat would you like to do?\n")

	# If the command entered by the player is not valid, it will return a KeyError.
	try:
		commands[player_input]()
	except KeyError:
		print("That is not a valid command.")
		player_input = input("What would you like to do?\n")