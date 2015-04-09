from random import randrange
rand_num = randrange(1,100)

def Main():
    print("Try to guess the number (1-100).")
    choice = int(input("> "))

    while True:
        numCheck(rand_num, choice)

def numCheck(a, b):
    if b < a:
        print("HIGHER!")
        print("\n")
        Main()
    elif b > a:
        print("LOWER!")
        print("\n")
        Main()
    elif b == a:
        print("YOU WIN!")
        quit()

if __name__ == '__main__':
    Main()
