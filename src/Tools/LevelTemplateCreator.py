import sys

def writeToFile(x, y, name):
    f = open(name, "w")

    for i in range(y):
        if (i == 0 or i + 1 == y):
            f.write("*" * x + "\n")
        else:
            f.write("*" + " " * (x - 2) + "*\n")
    f.close()

#checks count of arguments if 2 use arguments provided and if 0 its default 44x22 and if provided 1 or more than 2 than it returns error
if(len(sys.argv) == 0):
    x = 44
    y = 23
    name = "Level.txt"
    writeToFile(x, y, name)

elif (len(sys.argv) == 1):
    x = 44
    y = 23
    name = sys.argv[1]
    writeToFile(x, y, name)

elif (len(sys.argv) == 3):
    try:
        x = int(sys.argv[1])
        y = int(sys.argv[2])
        name = "Level.txt"
        writeToFile(x, y, name)
    except TypeError:
        print("inserted arguments are as a decimal number or some other unsupported data-type")
elif (len(sys.argv) == 4):
    try:
        x = int(sys.argv[1])
        y = int(sys.argv[2])
        name = sys.argv[3]
        writeToFile(x, y, name)
    except TypeError:
        sys.exit("inserted arguments are as a decimal number or some other unsupported data-type")
else:
    sys.exit("Error: Too much or too few arguments")

