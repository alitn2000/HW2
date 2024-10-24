Console.Write(" enter your string : ");
 string str = Console.ReadLine();
int i = 0;
char s;
int count;
char [] words = new char [str.Length];
int k = 0;
int max = 0;
char ch ='\0';
bool flag = false;
while (i < str.Length)
{
    s = str[i];
    count = 0;
     if (Array.IndexOf(words,s) != -1)
    {
        i++;
        continue;
    }
    else
    {
        for (int j = 0; j < str.Length; j++)
        {

            if (s == str[j])
            {
                count++;

            }
        }
    }
  

    Console.WriteLine($"{s}: {count}");
    words[k] = s;
    i++;
    k++;
    if (count > 1)
    {
        flag = true; 
    }

    if (count >max)
    {
        max = count;
        ch = s;
    }

}
if (!flag)
{
    Console.WriteLine("zero duplicate.");
}
else
{
    Console.WriteLine($"most use ch is : [{ch}] ------> {max}");
}
