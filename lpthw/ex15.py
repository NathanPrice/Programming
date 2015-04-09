# Takes the sys module and only imports the argv function
from sys import argv

# Sets the arguments
script, filename = argv

# This assigns the function to open a file to the variable txt
txt = open(filename)

# Prints out the name of the file.
print "Here's your file %r:" % filename
# Actually opens and prints the file you assigned in your arguements.
print txt.read()

# Closes the file.
txt.close()