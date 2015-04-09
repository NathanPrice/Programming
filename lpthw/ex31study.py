logo =  """
  ^   ^   ^   ^       ^   ^   ^   ^  
 /M\ /a\ /z\ /e\     /G\ /a\ /m\ /e\ 
<___X___X___X___>   <___X___X___X___>
"""

prompt = "> "

print logo
print "(C) Nathan Price 2014\n"

print "(L)eft or (R)ight?"
choice1 = raw_input(prompt)

if choice1 == "l":
	print "(L)eft or (R)ight?"
	choice2 = raw_input(prompt)
	if choice2 == "r":
		print "(L)eft or (R)ight?"
		choice3 = raw_input(prompt)
		if choice3 == "l":
			print "YOU WIN!"
		else:
			print "You fall off the edge and die."
	else:
		print "You fall off the edge and die."
else:
	print "You fall of the edge and die."
