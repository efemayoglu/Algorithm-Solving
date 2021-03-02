#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'gradingStudents' function below.
#
# The function is expected to return an INTEGER_ARRAY.
# The function accepts INTEGER_ARRAY grades as parameter.
#

def gradingStudents(grades):
    # Write your code here
    
    newList = []
    for i in grades:
        nextMultiple5 = 5
        
        if i>40 or (i+5 - (i%5))>=40:
            if i % 5 > 0:
                nextMultiple5 = 5 - (i%5)
            
            if (i+nextMultiple5) - i < 3:
                newList.append(i+nextMultiple5)  
            else:
                newList.append(i)            
        else:
            newList.append(i)            
        
    return newList

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    grades_count = int(input().strip())

    grades = []

    for _ in range(grades_count):
        grades_item = int(input().strip())
        grades.append(grades_item)

    result = gradingStudents(grades)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
