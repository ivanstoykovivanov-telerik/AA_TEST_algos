https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017-January/Day-2/4.%20Order%20Pizza/README.md



Order Pizza
Description
Your task is to process a pizza order. The order is consisted of a sentence.

The sentence obeys the following rules:

The sentence will start with the word Iskam and end with .
Words will be separated by whitespace (spaces, tabs, new lines)
Each pizza will be given by name
names can contain whitespace
names are case-insensitive
Example: Iskam vegetarianska.
The pizza keyword may be used, just ignore it
Examples:
Iskam pizza vegetarianska.
Iskam vegetarianska pizza.
Several pizzas of one kind can be requested with a number before the pizza name
Example: Iskam 2 vegetarianska.
Products can be excluded from a pizza using the bez <product> words
product names can contain whitespace
product names are case-insensitive
Examples:
Iskam vegetarianska bez domaten sos.
Iskam 2 vegetarianska bez kashkaval. - excluded from both
Iskam 3 vegetarianska 2 bez chushki. - excluded from 2 of the 3 pizzas
Iskam vegetarianska bez domaten sos bez chushki. - excluding several products
Iskam 2 vegetarianska 1 bez domaten sos bez kashkaval. - excluding multiple products from one pizza
Iskam 2 vegetarianska 1 bez luk 1 bez tsarevitsa. - excluding products from different pizzas
Different types of pizza can be ordered separated by , or i
Example: Iskam karbonara, barbekyu pile i formadzhi.
Find the quantity of each product needed for the order. Print each product as:


