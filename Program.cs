int studentsAmount = -1;
int pagesAmount = -1;

while (studentsAmount <= 0 || pagesAmount <= 0)
{
    Console.Write("Введите количество одногруппников: ");
    studentsAmount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество страниц для печати: ");
    pagesAmount = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Вам нужно распечатать {studentsAmount * pagesAmount} страниц");