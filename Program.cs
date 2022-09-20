string[] array = {"Hello", "2", "world", ":-)"};
var array2 = new string[array.Length];
int i = 0;
foreach (var element in array)
{
    if (element.Length <= 3)
    {
        array2[i] = element; Console.Write(array2[i] + ", "); i++;
    }
}