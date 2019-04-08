"""
    A vignere cypher takes two strings: One is a key, one is the message to encode. Each letter in the string of
the cypher represents a table in the vignere table. Each letter in the message then takes a letter from each of
these tables. e.g:

Key: BOY
Message: RUN
alphabet = ABCDEFGHIJKLMNOPQRSTUVWXYZ
Vignere table 0 = ABCDEFGHIJKLMNOPQRSTUVWXYZ
Vignere table 1 = BCDEFGHIJKLMNOPQRSTUVWXYZA
Vignere table 2 = CDEFGHIJKLMNOPQRSTUVWXYZAB

In the key "Boy", B represents the second letter of the alphabet. Therefore we take the second letter in alphabet which is vignere table 1.
Then in the message "Run", R represents the 18th letter of the alphabet hence its index is 17.
So we take table 1, index 17 for the first character of the encrypted message which is S.
"""

alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"


def getTables():
	"""Returns a list of 26 tables for each letter of the alphabet."""
	tables = []

	for letter in range(len(alpha)):     # For each letter in the alphabet
		slice1 = alpha[:letter]
		slice2 = alpha[letter:]
		newAlpha = slice2 + slice1
		tables.append(newAlpha)

	return tables	# Returns 26 differnt tables.


def getKey():
	"""Returns a string key"""
	return input("Enter a key (String, all caps): ")


def getMessage():
	"""Returns a message to be decoded"""
	return input("Enter a string to be encode: ")


def main():
	key = getKey()
	msg = getMessage()
	tables = getTables()
	encryptedMessage = ""

	while len(key) < len(msg):
		key = key*2		# Key must be at least the same length as the msg.

	for letter in message:


	print("Enxrypted message: {}".format(encryptedMessage))

main()