https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017/MiniExam1/3.%20Numerology/README.md


Numerology
Description
Pesho thinks that numerology is buggy. That is why he developed his own method of playing with the divine, suitable for programmers.

Here is how to calculate your abilities.

You start with a number (always a number) - your birthday in the format YYYYMMDD. Instead of summing the digits, do the following operations:

Choose two neighbouring digits - a and b
Perform the following operation: (a + b) * (a ^ b) % 10
+ is addition
* is multiplication
^ is bitwise exclusive or (XOR)
% is modulo division
% 10 means get just the last digit
Replace the chosen digits with the result
You get an one-digit shorter number
Repeat the process until you get only a single digit
Pesho noticed that depending on your choices of digits you would get different results in the end. So he advises you to do each possible combination and count how many times you get 0, 1, ... 9.

After you've done all the calculations you can look yourself up in the table:

Digit	Meaning
0	You are a very good programmer
1	You will create very useful programs
2	You are ugly
3	You will always depend on an IDE
4	You like strange languages
5	You loath science fiction
6	6? 6 is still a mystery to Pesho
7	You think class inheritance is magic
8	You do not mind dynamic typing
9	You are going to be famous
