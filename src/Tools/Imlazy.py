f = open("TestLevel.txt", "w")

for i in range(22):
    f.write("*")
    for j in range(44):
        f.write(" ")
    f.write("*\n")

f.close()