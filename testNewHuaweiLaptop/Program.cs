int[] arrayOfNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse) 
    .ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int temp = arrayOfNumbers[0];

    for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
    {
        arrayOfNumbers[j] = arrayOfNumbers[j + 1];
    }

    arrayOfNumbers[arrayOfNumbers.Length - 1] = temp;
}

Console.WriteLine(String.Join(" ", arrayOfNumbers));