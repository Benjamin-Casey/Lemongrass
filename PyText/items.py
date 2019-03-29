class Item:
    def __init_(self, name, description):
        self.name = name
        self.description = description

    def __str__(self):
        return """{}""".format(self.description)
