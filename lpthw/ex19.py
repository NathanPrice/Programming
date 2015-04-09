# Defines and saves block of code for later use
def cheese_and_crackers(cheese_count, boxes_of_crackers):
    print "You have %d cheeses!" % cheese_count
    print "You have %d boxes of crackers!" % boxes_of_crackers
    print "Man that's enough for a party!"
    print "Get a blanket.\n"


# Prints some text and calls our function assigning 20 and 30 to our variables 
print "We can just give the function numbers directly:"
cheese_and_crackers(20, 30)


# Prints some text and creates new variables
print "OR, we can use variables from our script:"
amount_of_cheese = 10
amount_of_crackers = 50

# Calls our function but with the new variables we created earlier
cheese_and_crackers(amount_of_cheese, amount_of_crackers)


# Prints some text and stores the math result in our function variables
print "We can even do math inside too:"
cheese_and_crackers(10 + 20, 5 + 6)


# Prints some text and adds some variables + integers
print "And we can combine the two, variables and math:"
cheese_and_crackers(amount_of_cheese + 100, amount_of_crackers + 1000)