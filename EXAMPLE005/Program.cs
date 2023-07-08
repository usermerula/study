Console.Clear();
Console.WriteLine("Введите день недели: 1-7");

int number = Convert.ToInt32(Console.ReadLine());


if (number == 7 || number == 6)
    Console.WriteLine("Выходной!");
else
    Console.WriteLine("Не выходной!");