
import sys
f = open("TestLevel.txt", "w")
#checks count of arguments if 2 use arguments provided and if 0 its default 44 22 and if provided 1 or more than 2 than it returns error
if(len(sys.argv) == 0):
    x = 44
    y = 22

    for i in range(y):
        f.write("*"*x+"\n")
elif(len(sys.argv) == 3):
    try:
        x = int(sys.argv[1])
        y = int(sys.argv[2])
    except TypeError:
        print("inserted arguments are as a decimal number or some other unsupported data-type")

    for i in range(y):
        f.write("*"*x+"\n")
else:
    print("Error: Too much or too less arguments")




f.close()

