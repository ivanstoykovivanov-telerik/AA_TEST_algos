https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Exams/2015/4.%20Positive%20Strings%20(Niki)


Problem 4 – Positive Strings
We call a sequence of characters a “positive string” if it represents a list of positive integers (with no leading zeros), separated by a single comma character. The list should also be increasing.
For example, the strings "1,4,8", "26", and "10,100,100000000000000" are positive strings, while "3,4,4", "2,3,4,", "0" and "2,03,4" are not.
By given string template with digit characters (‘0’-‘9’), comma characters (‘,’) and question marks (‘?’) replace all question marks with either a digit character or a comma character, so that the result is a positive string as defined above.
If there are multiple solutions, find the smallest lexicographically string and print it on the console. The lexicographical order of the characters is “,0123456789”.
If it is not possible to construct a positive string with the given template, print "invalid".
Input
On the first console input line there will be the template string.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The lexicographically smallest positive string that can be constructed with the given template should be printed on the console. If no such positive string can be constructed – print “invalid” instead.
Constraints
    • template will contain between 1 and 64 characters, inclusive.
        ◦ In 67% of the tests template will contain more than 20 characters.
    • Allowed working time for your program: 0.10 seconds. Allowed memory: 32 MB.
Examples

