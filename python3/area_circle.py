import math

def Main():
    try:
        print("Enter Radius: ")
        radius = float(input("> "))

        area_form = math.pi * radius ** 2
        area = round(area_form, 2)
        print("Area:", area)
    except:
        print("You did not enter a number!")
        Main()

if __name__ == '__main__':
    Main()
