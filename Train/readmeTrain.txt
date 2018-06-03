https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017/MiniExam2/3.%20Train/README.md


Train
Steve expirements with different professions. Today he is a train operator.

N amount of potential passengers have requested a ticket to travel with Steve's train. The train route is not yet known. We can enumerate the train stops with the numbers from 1 to L (there will be L stops). Each potential passenger i gives two numbers: Bi and Ei - the stop on which he would board the train and the on which he would get off.

The transport firm in which Steve works has an equal price for all tickets. The train can transport M amount of passengers (Steve is not counted).

Steve works for money. Help him sell as many tickets as possible. Remember not to put more than M amount of passengers at the same time in the train. Consider that on each stop, the people get off before others board the train.

Input
Input is read from the console
On the first line three integer numbers are given - N, M and L
On each of the next M lines two numbers will be given
Bi and Ei for each potential passenger i
Output
Output should be printed to the console
On single line print the maximum number of tickets which Steve can sell
Constraints
1 <= N <= 100 000
1 <= M <= 100 000
1 <= L <= 1 000 000 000
1 <= Bi < Ei <= L
In 30% of test cases M = 1
In another 30% of test cases Ei - Bi <= 100
Time limit: 0.7s
Memory limit: 32 MB
Sample tests