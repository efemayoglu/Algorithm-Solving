#!/bin/python3

import os
import sys
import datetime

#
# Complete the timeConversion function below.
#

#Sample Input 0
#07:05:45PM
#Sample Output 0
#19:05:45

def timeConversion(s):
    #
    # Write your code here.
    #
    isAm = s.find("AM")>-1
    isPm = s.find("PM")>-1
    s = s.replace("AM","")
    s = s.replace("PM","")
    
    hour = int(s.split(":")[0])
    minute = int(s.split(":")[1])
    second = int(s.split(":")[2])
    
    if isAm:
        if hour < 12:
            pass
        else: 
            hour = 0    
    elif isPm:
        if hour < 12:
            hour += 12
            
    
    formattedSeconds = "{0:0=2d}".format(second)
    formattedMinute = "{0:0=2d}".format(minute)
    formattedHour = "{0:0=2d}".format(hour)

    return f"{formattedHour}:{formattedMinute}:{formattedSeconds}"


if __name__ == '__main__':
    f = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    f.write(result + '\n')

    f.close()
