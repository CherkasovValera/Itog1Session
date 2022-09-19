// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Clear();
string[] CreateArray; string[] NewArray;

CreateArray = new string[] { "Hallo", "Bay", "Salut", ":-)", "Ups", "Ura", "Amba" };
NewArray = new string[7];

for (int i = 0; i < CreateArray.Length; i++)
{
    Console.Write(CreateArray[i] + "\t ");
}
Console.WriteLine();
int k = 0;
for (int i = 0; i < CreateArray.Length; i++)
{
    if (CreateArray[i].Length <= 3)
    {
        NewArray[k] = CreateArray[i];
    }
    Console.Write(NewArray[k] + " ");
    k++;
}


