
Console.Write("Enter array Length: ");
int len = int.Parse(Console.ReadLine());

double[] array = new double[len];

for (int i = 0; i < len; i++)
{
    Console.Write($"Enter Number {i + 1}: ");
    array[i] = double.Parse(Console.ReadLine());
}

//------------------Max & Min------------------//
double min = array[0];
double max = array[0];
foreach (double d in array)
{
    if (d < min)
    {
        min = d;
    }
    if (d > max)
    {
        max = d;
    }
}
Console.WriteLine("---------------Max & Min---------------");
Console.WriteLine($"Max: {max}      Min: {min}");

//------------------Reverse------------------//
Console.WriteLine("---------------Reverse---------------");
double[] reverse = new double[len];
int j = 0;
Console.Write("Reverse is: ");
for (int i = len - 1; i >= 0; i--)
{
    reverse[j] = array[i];
    Console.Write($"{reverse[j]} , ");
    j++;
}
Console.WriteLine();

//------------------Sort------------------//
Console.WriteLine("---------------Sort---------------");
double temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int k = 0; k < array.Length - 1 - i; k++)
    {
        if (array[k] > array[k + 1])
        {
            temp = array[k + 1];
            array[k + 1] = array[k];
            array[k] = temp;
        }
    }
}
Console.Write("Sorted array: ");
foreach (double a in array)
{
    Console.Write($"{a}, ");
}
Console.WriteLine();


//------------------Duplicates------------------//
Console.WriteLine("---------------Duplicates---------------");

double[] duplicateCheck = new double[array.Length]; 
int duplicateIndex = 0;

for (int i = 0; i < array.Length; i++)
{
    double currentValue = array[i];
    int count = 0;
    int[] indices = new int[array.Length]; 
    int indexCount = 0; 

    
    bool alreadyChecked = false;
    for (int k = 0; k < duplicateIndex; k++)
    {
        if (duplicateCheck[k] == currentValue)
        {
            alreadyChecked = true;
            break;
        }
    }

    if (alreadyChecked)
    {
        continue; 
    }

    
    for (int z = 0; z < array.Length; z++)
    {
        if (array[z] == currentValue)
        {
            count++;
            indices[indexCount] = z; 
            indexCount++;
        }
    }

    if (count > 1)
    {
        Console.Write($"{currentValue}: {count} times at indices: ");
        for (int k = 0; k < indexCount; k++)
        {
            Console.Write(indices[k] + " "); 
        }
        Console.WriteLine();
    }

    
    duplicateCheck[duplicateIndex] = currentValue;
    duplicateIndex++;
}
Console.WriteLine("---------------Common Elements---------------");
Console.Write("Enter array Length: ");
int len2 = int.Parse(Console.ReadLine());

double[] array2 = new double[len2];


for (int i = 0; i < len2; i++)
{
    Console.Write($"Enter Number {i + 1}: ");
    array2[i] = double.Parse(Console.ReadLine());
}

for (int x = 0; x < len; x++)
{
    for (int y = 0; y < len2; y++)
    {
        if (array[x] == array2[y])
        {
            Console.Write($"{array[x]} ");
            break; 
        }
    }
}
Console.WriteLine();
    