i = 3
numbers = []
int = 10

def loop():
	global i
	for i in range (0,10):
		print "At the top i is %d" % i
		numbers.append(i)
		print "Numbers now: ", numbers
		print "At the bottom i is %d" % i
loop()
	
print "The numbers: "

for num in numbers:
	print num