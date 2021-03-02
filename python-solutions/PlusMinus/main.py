
#!/bin/python3

import math
import os
import random
import re
import sys


# Complete the plusMinus function below.
def plusMinus(arr):
    myArr = {0:0, 1:0, -1:0}
    for i in arr:
        if i == 0:
            myArr[0]+=1
        elif i <0:
            myArr[-1]+=1
        else:
            myArr[1]+=1
    positiveRatio = '%.6f'%(myArr[1]/len(arr)) if myArr[1]>0 else '%.6f'%0
    negativeRatio = '%.6f'%(myArr[-1]/len(arr)) if myArr[-1]>0  else '%.6f'%0
    zeroRatio = '%.6f'%(myArr[0]/len(arr)) if myArr[0]>0  else '%.6f'%0
    for i in [positiveRatio, negativeRatio,zeroRatio]:
        print(i)

if __name__ == '__main__':
    # n = int(input())

    # arr = list(map(int, input().rstrip().split()))

    arr = [1,-1,-5,0,0,5,23,2,2,3]
    plusMinus(arr)
