## Source
https://www.codewars.com/kata/596c6eb85b0f515834000049

## Description
The code provided is supposed replace all the dots . in the specified String str with dashes -<br>
<br>
But it's not working properly.

### Task
Fix the bug so we can all go home early.<br>

### Notes
String str will never be null.<br><br>


## provided code
```
using System.Text.RegularExpressions;

public class Kata
{
  public static string ReplaceDots(string str)
  {
    return new Regex(".").Replace(str, "-");
  }
}
```
