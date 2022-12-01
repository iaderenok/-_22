int count = 0;
string[] arr = { "13465", "2666", "333", "765" };
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        count++;
    }
}

Console.WriteLine($"длина второго массива -> [{count}]");
