def myfunction(var1, var2):
	print "You have %r apples." % var1
	print "You also have %r oranges." % var2
	print "Looks like someone won't be seeing the doctor anytime soon."
	
print "Ver: 1"
myfunction(10, 20)

print "Ver: 2"
test1 = 15
test2 = 30
myfunction(test1, test2)

print "Ver: 3"
myfunction(50 + 2, 13 + 6)

print "Ver: 4"
myfunction(test1 + 23, test2 + 4)

print "Ver: 5"
print "Apples? "
test3 = raw_input()
print "Oranges? "
test4 = raw_input()
myfunction(test3, test4)

print "Ver: 6"
print "Press enter to see the function again."
ent = raw_input()
myfunction(21, 34)