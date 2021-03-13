#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'getTotalX' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER_ARRAY a
#  2. INTEGER_ARRAY b
#

def getTotalX(a, b):
    arr = calculateForArr(a,b)
    return arr

def calculateForArr(arr1, arr2):
    myset = {-8}
    for i in arr1:
        if calculateIntoTheArray(i,arr1):
            for j in arr2:
                isFalse = False
                if calculateBy2param(j,i) == True:
                    pass
                else:
                    isFalse = True
            if  isFalse == False:
                myset.add(i)
    return myset
def calculateBy2param(param1, param2):
    return True if param1 % param2 == 0 else False                   
    # Write your code here
    
def calculateIntoTheArray(elem, arr):
    for i in arr:
        if i%elem != 0:
            return False
    return True                        
    # Write your code here
    

if __name__ == '__main__':
    fptr = sys.stdout  

    first_multiple_input = input().rstrip().split()

    n = int(first_multiple_input[0])

    m = int(first_multiple_input[1])

    arr = list(map(int, input().rstrip().split()))

    brr = list(map(int, input().rstrip().split()))

    total = getTotalX(arr, brr)

    fptr.write(str(total) + '\n')

    fptr.close()
