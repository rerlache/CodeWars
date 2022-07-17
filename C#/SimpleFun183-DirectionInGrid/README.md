## Source
https://www.codewars.com/kata/58bcd7f2f6d3b11fce000025

## Description
You're standing at the top left corner of an n × m grid and facing towards the right.<br>
Then you start walking one square at a time in the direction you are facing.<br>
If you reach the border of the grid or if the next square you are about to visit has already been visited, you turn right.<br>
You stop when all the squares in the grid are visited. What direction will you be facing when you stop?<br>

Given two integers n and m, denoting the number of rows and columns respectively, find out the direction you will be facing at the end.

Output "L" for left, "R" for right, "U" for up, and "D" for down.

## Example(s)
For `n = 3`, `m = 3`, the output should be "R".<br>
At the end of your walk you will be standing in the middle of the grid facing right.

### Input/Output
[input] integer `n` => number of rows.<br>
1 <= n <= 1000<br>
[input] integer `m` => number of columns.<br>
1 <= m <= 1000<br>
[output] a string
The final direction.