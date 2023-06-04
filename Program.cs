// Задание №1

List<Dictionary<string, int>> students = new();
int studentID = 0;

while (true)
{
    Dictionary<string, int> grades = new()
    {
        { "Информатика", 0 },
        { "Разработка игр", 0 },
        { "Основы алгоритмизации", 0 }
    };
    students.Add(grades);
    Console.WriteLine($"Студент с id {studentID}");
    Console.Write("Введите оценку по информатике: ");
    students[studentID]["Информатика"] = int.Parse(Console.ReadLine());
    Console.Write("Введите оценку по разработке игр: ");
    students[studentID]["Разработка игр"] = int.Parse(Console.ReadLine());
    Console.Write("Введите оценку по основам алгоритмизации ");
    students[studentID]["Основы алгоритмизации"] = int.Parse(Console.ReadLine());
    studentID++;
    Console.WriteLine("Продолжить? y/n");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}

studentID = 0;
foreach (var grades in students)
{
    Console.Write($"Ученик с id {studentID}");
    foreach (var grade in grades)
    {
        Console.Write($"|{grade.Key}|{grade.Value}|");
    }
    studentID++;
    Console.WriteLine();
}

// Задание 2

Random random = new();
List<int> numbers = new();
int arrayLength;

Console.Write("Введите длину массива: ");
arrayLength = int.Parse(Console.ReadLine());

for (int i = 0; i < arrayLength; i++)
{
    numbers.Add(random.Next(-5, 5));
}

Console.WriteLine("Вывод всех элементов массива");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine("\nВывод массива в обратном порядке");
for (int i = numbers.Count - 1;i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine("\nВывод массива через 1");
for (int i = 0; i < numbers.Count; i+=2)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine("\nВывод массива пока не встретится -1");
for (int i = 0; i < numbers.Count; i ++)
{
    if (numbers[i] == -1)
    {
        Console.WriteLine("\nВстретился элемент -1");
        break;
    }
    Console.Write(numbers[i] + " ");
}
