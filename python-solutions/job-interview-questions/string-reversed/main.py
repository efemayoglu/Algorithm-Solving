string = "hello Tom, nice to meet you!"



def reverseString():
    splittedArray = string.split(" ")
    array = []
    newstring = ""
    for i in range(len(splittedArray)):
        # array.pop()
        if splittedArray[i].find(",")>-1:
            print(f"before replace ,{splittedArray}")
            splittedArray[i] = splittedArray[i].replace(",","")
            print(f"after replace ,{splittedArray}")

            myreversed =list(reversed(splittedArray[:i])) 
            for j in range(i):
                newstring += myreversed[len(myreversed)-1:][0]
                if splittedArray[j+1]:
                    newstring+ " "
            newstring+=","

    print(f"newstring={newstring}")
    print(f"splittedArray={splittedArray}")

print(list(reversed(string.split(" "))))
reverseString()