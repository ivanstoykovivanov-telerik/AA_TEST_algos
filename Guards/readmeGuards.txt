https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017-January/Day-2/2.%20Guards/README.md


Guards
Description
Once again you have to escape from a maze. You are in the top left corner of the maze and you have to go the bottom right one. You are allowed to go only right and down and passing through a cell takes 1 second.

In some of the cells there will be guards. Here is a picture of a guard:

t is absolutely forbidden to step through a guard's cell. Each guard will be looking in one of the neighbouring cells (up, down, left or right). Going through those cells takes 3 seconds.

Write a program which finds the minimum amount of seconds needed to escape the maze. If it is impossible to escape print Meow.

Input
Input is read from the console
The first line contains two numbers separated by space
The number of rows and number of columns
The second line contains an integer - the number of guards
Each guard is described on a single line with two numbers and direction separated by spaces
the first number is the row on which the guard resides
the second number is the column
the direction is one of U, D, L and R representing the direction in which the guard is looking
Output
Output should be printed on the console
A single line denoting the maximum profit which can be obtained.