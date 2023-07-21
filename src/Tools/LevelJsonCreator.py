import sys

# Another tool, simply run this file with specified arguments and It will generate a JSON file for the level data :D
# Usage: "python LevelJsonCreator.py <pathToLevel> <upfile> <downFile> <rightFile> <leftFile>"

def main():
    if len(sys.argv) >= 5:
            # check if any of the files are called null; so we can write null to the json file
            for i in range(1, len(sys.argv)):
                if sys.argv[i] == "null":
                    sys.argv[i] = "null"
            pathToLevel = sys.argv[1]
            upFile = sys.argv[2]
            downFile = sys.argv[3]
            rightFile = sys.argv[4]
            leftFile = sys.argv[5]
            file = open("LevelData.json", "w")
            file.write("{\n")
            file.write("\t\"pathToTextFile\": \"" + pathToLevel + "\",\n")
            file.write("\t\"upFile\": \"" + upFile + "\",\n")
            file.write("\t\"downFile\": \"" + downFile + "\",\n")
            file.write("\t\"rightFile\": \"" + rightFile + "\",\n")
            file.write("\t\"leftFile\": \"" + leftFile + "\"\n")
            file.write("}")
            file.close()
    else:
        print("Not enough or no arguments, usage: \"python LevelJsonCreator.py <pathToLevel> <upfile> <downFile> <rightFile> <leftFile>\"")

if __name__ == "__main__":
    main()