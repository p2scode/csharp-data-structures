using DataStructures;

var list = new DynamicArray<int>();
for (int i = 1; i <= 10; i++)
    list.Add(i * 10);

Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
Console.WriteLine(list[9]);
Console.WriteLine(list[12]);