string[] Array =
{ "Sunday", "2",
"Monday", "33",
"Tuersday",
"Wednesday", "one",
"Thirsday", ";-)",
"Friday", "O7",
"Saturday" };
Console.WriteLine("[{0}]", string.Join(", ", Array));
Console.WriteLine();
string[] ResultArray = new string[Array.Length];
var realSize = 0;
foreach (var element in Array)
{
    if (element.Length <= 3)
    {
        ResultArray[realSize] = element;
        realSize++;
    }
}
Console.WriteLine("[{0}]", string.Join(" ", ResultArray));
Console.WriteLine();
