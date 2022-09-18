

string message = "hel";
 Console.Write($"'{message}'");
string message1 = "hello";
Console.Write($"'{message1}'");
string message2 = "h";
Console.Write($"'{message2}'");
// получаем символ
//char firstChar = message[1]; // символ 'e'
//Console.WriteLine(firstChar);   //e
if (message.Length <= 3|| message1.Length<=3||message2.Length<=3)
{
//message.Length <= 3;

Console.WriteLine();
    Console.WriteLine($"{message.Length <= 3},{message1.Length<=3},{message2.Length<=3} ");  // длина строки  
  
}