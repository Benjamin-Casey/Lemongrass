"""
A program that converts one string to another through the process of encryption.

the ord("...") takes a character (string) and outputs an integer of its value (only takes one character at a time).
LOWERCASE: a = 97, z = 122.
UPPERCASE: A = 65, Z = 90.
SPACE = 32.

chr(...) does the opposite to ord()
"""


def getString():
	"""
	This function collects input from the user and check to see if it is all letters or spaces.
	"""
	message = input("Write a message to be encoded: ")

	for character in message:
		if ord(character) not in range(65, 90) and ord(character) not in range(97, 122) and ord(character) != 32:		# Check each character.
			print("Please ensure there are only letters in the message.")
			getString()			# Recur the function until a valid string is input.

	return message


def getKey():
	"""
	Gets an encryption key from the user and checks to make sure it is valid.
	"""
	# I had a mind blank and struggled with this.
	key = -1
	while key not in range(0, 25):
		try:
			key = int(input("Enter encryption key value between 0 and 25: "))

		except:
			pass

	return key

# Encrypt and Decrypt can probably be merged.

def encrypt(message, key):
	"""
	This function changes each character of a message to a different character by adding the key value
	to its character value and then changes it back to a string. Need to check to make sure if it is
	out of range of the alphabet it cycles back to the begginning.

	Args:
	-- message: The string.
	-- key: The encryption key.
	"""
	preEncrypt = []
	postEncrypt = []
	encryptedMessage = ""

	for character in message:		# Add each character value to a list.
		preEncrypt.append(ord(character))

	for value in preEncrypt:

		if value in range(65, 90):
			value += key		# Add encryption, changing the value of the character.
			if value > 90:		# If the value is out of range of the alphabet, cycle.
				value -= 25
			postEncrypt.append(value)	# Add to post encrypt list.

		elif value in range(97, 122):
			value += key
			if value > 122:
				value -=25
			postEncrypt.append(value)

		elif value == 32:
			postEncrypt.append(value)	# Keeps list in order to cycle through the space.

		else:
			raise Exception("Unexpected value in message.")
	
	
	for item in postEncrypt:
		encryptedMessage += chr(item)

	return encryptedMessage


def decrypt(message, key):
	preDecrypt = []
	postDecrypt = []
	decryptedMessage = ""

	for character in message:		# Add each character value to a list.
		preDecrypt.append(ord(character))

	for value in preDecrypt:

		if value in range(65, 90):
			value -= key		# Add encryption, changing the value of the character.
			if value < 65:		# If the value is out of range of the alphabet, cycle.
				value += 25
			postDecrypt.append(value)	# Add to post encrypt list.

		elif value in range(97, 122):
			value -= key
			if value < 97:
				value +=25
			postDecrypt.append(value)

		elif value == 32:
			postDecrypt.append(value)	# Keeps list in order to cycle through the space.

		else:
			raise Exception("Unexpected value in message.")
	
	
	for item in postDecrypt:
		decryptedMessage += chr(item)

	return decryptedMessage



def main():
	end = False
	while end != True:
		option = input("Encrypt or decrypt? (e/d) ")
		key = getKey()
		message = getString()

		if option == "e":	# Encrypt
			print("Encrypted message:", encrypt(message,key))

		elif option == "d":		# Decrypt
			print("Decrypted message:", decrypt(message,key))

		repeat = input("End? (y/n) ")

		if repeat == "y":
			break

main()