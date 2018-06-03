https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2015/6.%20Words%20(Doncho)/Words.doc



You task is to find strings in text 
You are given a word and a text.
The word can be split into two parts – prefix and suffix.
The concatenation of the prefix and the suffix results in the whole word.
Example: If the word is "John" all possible prefixes and suffixes are:
    • Prefix ""(empty string) and suffix "John"
        ◦ Same as prefix "John" and suffix "" (empty string)
    • Prefix "J" and suffix "ohn"
    • Prefix "Jo" and suffix "hn"
    • Prefix "Joh" and suffix "n"
Given a text, find the count of all possible combinations of prefixes and suffixes of the word in the text.
Input
The input data should be read from the console.
It consists of two lines:
    • On the first line you will find the word
    • On the second line you will find the text
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
On the only output line print the count of combinations of the words.
Constraints
    • word will be with length between 1 and 10, inclusive.
    • text will be with length between 1 and 500000, inclusive.
    • The symbols in the word and in the text will be only small Latin letters (‘a’-‘z’)
    • Allowed working time for your program: 0.5 seconds.
    • Allowed memory: 64 MB.