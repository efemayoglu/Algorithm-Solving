#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the countApplesAndOranges function below.
def countApplesAndOranges(s, t, a, b, apples, oranges):
    myApple = calculateTheArr(apples,a)
    myOranges = calculateTheArr(oranges, b)

    m1 = detectionAppleOrOrangeByLimit(myApple,s,t)
    m2 = detectionAppleOrOrangeByLimit(myOranges,s,t)

    print(len(m1))
    print(len(m2))

def detectionAppleOrOrangeByLimit(arr, lowerLimit, upperLimit):
    m = []
    for i in arr:
        if i >= lowerLimit and i<=upperLimit:
            m.append(i)
    return m

def calculateTheArr(arr, val):
    m = []
    for i in range(len(arr)):
       m.append(arr[i] + val)
    return m


if __name__ == '__main__':
    st = input().split()

    s = int(st[0])

    t = int(st[1])

    ab = input().split()

    a = int(ab[0])

    b = int(ab[1])

    mn = input().split()

    m = int(mn[0])

    n = int(mn[1])

    apples = list(map(int, input().rstrip().split()))

    oranges = list(map(int, input().rstrip().split()))

    countApplesAndOranges(s, t, a, b, apples, oranges)
