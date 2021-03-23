## EasyMatch
Easier Regex [Easy Match]
Based off of notLegends [EasyMatch](https://github.com/LegendWasTaken/EasyMatch) for Javascript | 

## Example
```csharp 
string str = "1.0 Testing 1x1";
string pattern = "{decimal} Testing {math}";
Matcher match = new Matcher("{", "}");
foreach (string matches in match.match(str, pattern))
    Console.WriteLine(matches);
```
## Output
_Will ouput:
[1.0
1x1]_


**This works by going word by word comparing your (text) and your (pattern). It looks for the differences, then replaces the (pattern text: {decimal}) with the original text ({1.0}).**
            
