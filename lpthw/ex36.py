# Prompt for any point where we require any user input
prompt = "> "

# Takes player to shop and lists items
def shop():
	items = ["test", "test2"]
	print items
	
def good():
	print "I knew I saw a good Samaritan in you ;)"
	

# Player chooses good or evil path
def destiny():
	print "Now you must choose your path. Do you prefer..."
	print """
	(1.) Helping those in need or (2.) Bathing in the blood of your enemies?
	"""
	choice = raw_input(prompt)
	if choice == "1":
		good()
	elif choice == "2":
		evil()
	else:
		quit("INVALID SELECTION!")

# Character name entry
def name():
	print "Welcome Adventurer!"
	print "What is thy name?"
	name = raw_input(prompt)
	print "Nice to meet you %s. That sure is an interesting name." % name
	destiny()

# Start of the game
print """
##################################################################################
# ____  ____  _  _  ____     __   ____  _  _  ____  __ _  ____  _  _  ____  ____ #
#(_  _)(  __)( \/ )(_  _)   / _\ (    \/ )( \(  __)(  ( \(_  _)/ )( \(  _ \(  __)#
#  )(   ) _)  )  (   )(    /    \ ) D (\ \/ / ) _) /    /  )(  ) \/ ( )   / ) _) #
# (__) (____)(_/\_) (__)   \_/\_/(____/ \__/ (____)\_)__) (__) \____/(__\_)(____)#
#                                                                                #
##################################################################################
Copyleft 2014 Nathan Price
"""
name()