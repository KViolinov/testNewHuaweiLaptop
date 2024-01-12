int[] masiv = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] novMasiv = new int[masiv.Length];

for (int i = 0; i < novMasiv.Length; i++)
{
    novMasiv[i] = masiv[i];
}

masiv.Reverse();

Console.WriteLine(String.Join(" ", masiv));

foreach (int i in novMasiv)
{
    Console.Write($"{i * 2} ");
}
Console.WriteLine();

int n = int.Parse(Console.ReadLine());

int[] novNovMasiv = new int[n];

novNovMasiv = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Console.WriteLine(String.Join(" ", novNovMasiv));

for (int i = 0; i < novNovMasiv.Length; i++)
{
    Console.Write($"{Math.Pow(novNovMasiv[i], i)} ");
}