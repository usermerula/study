Console.Clear();

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 1000)
    Console.WriteLine("Вы ввели не трехзначное число!");
else  
    Console.WriteLine(number / 10 % 10);