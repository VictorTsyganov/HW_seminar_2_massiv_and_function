// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.Clear();

string [] array = {"Понедельник", "Вторник", "Среду", "Четверг", "Пятницу", "Субботу", "Воскресенье"};

Console.Write("Введите число обозначающее день недели (от 1 до 7): ");
int number = int.Parse(Console.ReadLine());

if ( number > 0 && number < 6)
{
    Console.WriteLine($"Введенное число {number} обозначает {array[number - 1]}. Это будний день.");
}
else if (number >= 6 && number < 8)
{
    Console.WriteLine($"Введенное число {number} обозначает {array[number - 1]}. Это выходной.");
}
else
{
    Console.WriteLine($"Введенное число {number} за пределами заданного интервала. Необходимо число (от 1 до 7).");
}