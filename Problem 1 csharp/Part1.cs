// See https://aka.ms/new-console-template for more information
/* PART 1
var sr = new StreamReader("TestData.txt");
string? s = "";
List<int> values = new List<int>();
int sum = 0;
while ((s = sr.ReadLine()) != null)
{
    if(s == "")
    {
        values.Add(sum);
        sum = 0;
    }
    else
    {
        sum += int.Parse(s);
    }
}
if(sum != 0)
{
    values.Add(sum);
}
int max = 0;

foreach(int i in values)
{
    if(i > max)
    {
        max = i;
    }
}

Console.WriteLine(max);
*/