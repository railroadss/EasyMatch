## EasyMatch
Easier Regex [Easy Match]
Based off of notLegends EasyMatch for Javascript

## Example
```csharp            string str = "1.0 Testing 1x1";
            string pattern = "{decimal} Testing {math}";
            Matcher match = new Matcher("{", "}");
            foreach (string matches in match.match(str, pattern))
                Console.WriteLine(matches); ```
Will ouput:
[1.0
1x1]
/////////////////////////////////////////////////
This works by going word by word comparing your (text) and your (pattern). It looks for the differences, then replaces the (pattern text: {decimal}) with the original text {1.0}.
            
