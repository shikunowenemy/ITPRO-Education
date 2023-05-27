bool isCorrectValue; // Объявление переменной для проверки корректности введенного значения 
Console.WriteLine("------Задание 1------");
double temperatureCelsius, temperatureFahrenheit, temperatureKelvin; // Объявление переменных температур
while (true) // Бесконечный цикл выполнения программы, пока пользователь не введет правильное значение
{
    Console.WriteLine("Введите температуру по шкале Цельсия: ");
    isCorrectValue = double.TryParse(Console.ReadLine(), out temperatureCelsius); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректные значения");
        continue;
    }
    temperatureFahrenheit = Math.Round(((temperatureCelsius / 9 * 5) + 32), 2); // Вычисление градусов по шкале Фаренгейта
    temperatureKelvin = Math.Round(temperatureCelsius + 273.15, 2); // Вычисление градусов по шкале Кельвина
    Console.WriteLine($"Температура по шкале Фаренгейта: {temperatureFahrenheit}\n" +
        $"Температура по шкале Кельвина: {temperatureKelvin}");
    break; // Завершение цикла
}

Console.WriteLine("------Задание 2------");
double firstValue, secondValue;
while (true)
{
    Console.WriteLine("Добро пожаловать в калькулятор введите операцию:\n" +
    "+ --- сложение\n" +
    "- --- вычитание\n" +
    "* --- умножение\n" +
    "/ --- деление\n" +
    "% --- остаток от деления");
    string mathOperation = Console.ReadLine();
    Console.Write("Введите первое значение: ");
    isCorrectValue = double.TryParse(Console.ReadLine(), out firstValue); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректные значения");
        continue;
    };
    Console.Write("Введите второе значение: ");
    isCorrectValue = double.TryParse(Console.ReadLine(), out secondValue); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректные значения");
        continue;
    };
    switch (mathOperation)
    {
        case "+":
            double sum = Math.Round(firstValue + secondValue, 2); // Вычисление суммы
            Console.WriteLine($"{firstValue} + {secondValue} = {sum}");
            break;
        case "-":
            double difference = Math.Round(firstValue - secondValue, 2);
            Console.WriteLine($"{firstValue} - {secondValue} = {difference}"); // Вычисление разности
            break;
        case "*":
            double product = Math.Round(firstValue * secondValue, 2);
            Console.WriteLine($"{firstValue} * {secondValue} = {product}"); // Вычисление произведения
            break;
        case "/":
            double quotient = Math.Round(firstValue / secondValue, 2);
            Console.WriteLine($"{firstValue} / {secondValue} = {quotient}"); // Вычисление частного
            break;
        case "%":
            double remainder = Math.Round(firstValue % secondValue, 2);
            Console.WriteLine($"Остаток от деления {firstValue} на {secondValue} = {remainder}"); // Вычисление остатка от деления
            break;
        default: // Если операции не существует, то цикл запускается заново
            Console.WriteLine("Некорректная операция");
            continue;
    }
    break; // Завершение цикла
}
Console.WriteLine("------Задание 3------");
Console.WriteLine("Проверим ваши знания на таблицу умножения!");
while (true)
{
    int firstNumber, secondNumber, userAnswer, productValues; // Объявление множимого, множителя, ответа пользователя и произведения чисел
    Console.Write("Введите первое число: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out firstNumber); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректное значение");
        continue;
    };
    Console.Write("Введите второе число: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out secondNumber); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректное значение");
        continue;
    };
    productValues = firstNumber * secondNumber;
    Console.Write("Введите свой ответ: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out userAnswer); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректное значение");
        continue;
    };
    if (userAnswer == productValues)
    {
        Console.WriteLine("Да, ответ правильный!");
    }
    else
    {
        Console.WriteLine($"Вы ошиблись! Правильный ответ {productValues}");
    }
    break;
}
Console.WriteLine("------Задание 4------");
while (true)
{
    int n;
    Console.Write("Введите количество лет: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out n); // Инициализация переменной проверки корректных данных
    if (!isCorrectValue || n < 1 || n > 99) // Если значение некорректно, то цикл начинается заново
    {
        Console.WriteLine("Вы ввели некорректное значение");
        continue;
    };
    int remainder = n % 10; // Инициализация переменой, отбрасывающая десятки
    if (remainder == 0 || remainder >= 5)
    {
        Console.WriteLine($"Мне {n} лет");
    }
    else if (remainder == 1) 
    {
        Console.WriteLine($"Мне {n} год");
    }
    else
    {
        Console.WriteLine($"Мне {n} года");
    }
    break;
}