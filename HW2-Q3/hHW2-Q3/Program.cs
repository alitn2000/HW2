Console.WriteLine("enter count of numbers");
int len = int.Parse(Console.ReadLine());

Console.WriteLine("enter numbers (with space): ");
string numbers = Console.ReadLine();

string temp = "";
int[] output = new int[len];
int j = 0;
foreach (char i in numbers)
{
    if (char.IsDigit(i))
    {
        temp += i;
    }
    else if (i == ' ')
    {
        output[j] = int.Parse(temp);
        j++;
        temp = "";
    }
    else
    {
        Console.WriteLine("inpute is incorrect!!!");
        return;
    }
    if (temp != "")
    {
        output[j] = int.Parse(temp);
    }

}
for (int i = 0; i< output.Length; i++)
{
    Console.WriteLine($"index [{i }] : {output[i]}");
}