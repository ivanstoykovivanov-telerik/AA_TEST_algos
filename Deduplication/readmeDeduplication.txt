https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017/MasterExam/Day2/8.%20Deduplication/README.md


Deduplication
Description
In computer filesystems each file is represented as a list of blocks. When a new file is created, blocks must be allocated for its content. There are several file systems that make use of the so called CoW technique (this is no cattle power, it's copy on write). When you copy a block (e.g. when copying a file) you can just mark it so that it is known that the block is referenced from more than one place (this is called reference counting). When you want to change the contents of a block only then you allocate a new one, so you do not disturb other references.

Implement several commands for a CoW powered filesystem:

append file BLOCKS
appends the specified content to the file
create the file if it does not exist
blocks should be allocated
copy file1 file2
makes a copy of file1 named file2
new blocks should be allocated for file2
if file1 does not exist create an empty file in its place
if file2 already exist delete it first
cow file1 file2
makes a CoW copy of file1 named file2
the blocks of file1 should be shared with file2
if file1 does not exist create an empty file in its place
if file2 already exist delete it first
remove file
deletes file
unreferenced blocks should be deallocated
dedup
scans the filesystem for repeating blocks and makes them CoW copies
usage
shows the number of currently allocated blocks in the filesystem
e.g. 42 blocks are currently in use.
size file
shows the apparent size of the file
not allocated blocks count for the file
if the file does not exist, then its size is 0 blocks
e.g. gosho.txt is 5 blocks large.
exit
do nothing
no more commands will follow exit
