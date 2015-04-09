# Imports argv from the sys module
from sys import argv

# Sets your arguments
script, input_file = argv

# Function that will read out the file
def print_all(f):
	print f.read()

# Function that will help reload the file
def rewind(f):
	f.seek(0)

# Helps define the line count
def print_a_line(line_count, f):
	print line_count, f.readline()

# Sets the variable that will open the file
current_file = open(input_file)

# Prints some text and makes a newline
print "First let's print the whole file:\n"

# Prints out the file
print_all(current_file)

# Prints some text
print "Now let's rewind, kind of like a tape."

# Reloads the file
rewind(current_file)

# Prints some text
print "Let's print three lines:"

# Sets the line number and then increments it by 1 for each new line
current_line = 1
print_a_line(current_line, current_file)

current_line = current_line + 1
print_a_line(current_line, current_file)

current_line = current_line + 1
print_a_line(current_line, current_file)