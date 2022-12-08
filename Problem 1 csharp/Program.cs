// See https://aka.ms/new-console-template for more information

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

values.Sort();
values.Reverse();

int final = 0;

for (int i = 0; i < 3; i++)
{
    final += values[i];
}
Console.WriteLine(final);