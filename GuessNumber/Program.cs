// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if (number > 0) {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное.");
// }
// else {
//     Console.WriteLine("Число равно нулю.");
// }



// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());

// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51) {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }



// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());

// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());

// bool goodAttendance = attendance >= 14; // посещаемость >= 75%
// bool goodGrades = practiceGpa >= 3.0;   // оценка не ниже 3

// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }



// string result1;
// if (score >= 60) {
//     result1 = "Зачёт";
// }
// else {
//     result1 = "Незачёт";
// }

// // То же самое в одну строку через тернарный оператор
// string result2 = score >= 60 ? "Зачёт" : "Незачёт";



// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");


// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");


// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} – {parity}.");







// switch (day) {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     default: Console.WriteLine("Неизвестный день"); break;
// }


// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();

// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-242, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО – 20, РПМ – 35");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }



// Console.Write("Введите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());

// switch (dayNumber) {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день – пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной – заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }



// int secret = 22;


// int attempts = 0;
// bool guessed = false;


// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");


// while (!guessed) {

// Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
// string input = Console.ReadLine();


// if (!int.TryParse(input, out int guess)) {
// Console.WriteLine("!!! Введи целое число, а не текст!");
// continue; 
// }


// if (guess < 1 || guess > 100) {
// Console.WriteLine("!!! Число должно быть от 1 до 100!");
// continue;
// }


// attempts++;


// if (guess < secret) {
// int diff = secret - guess;
// string hint = GetHint(diff);
// Console.WriteLine($"↑ Больше! {hint}\n");
// }
// else if (guess > secret) {
// int diff = guess - secret;
// string hint = GetHint(diff);
// Console.WriteLine($"↓ Меньше! {hint}\n");
// }
// else {
// guessed = true; 
// }
// }


// string result = attempts <= 7 
// ? $"Отличный результат! Всего {attempts} попыток." 
// : $"Число найдено за {attempts} попыток. Можно лучше!";


// Console.WriteLine($"Правильно! Загаданное число: {secret}");
// Console.WriteLine(result);



// static string GetHint(int difference) {
// switch (difference) {
// case <= 3:
// return "Горячо!";
// case <= 10:
// return "Тепло.";
// case <= 25:
// return "Прохладно.";
// default:
// return "Холодно!";
// }
// }



Console.WriteLine("Задание 1");
Console.Write("Введите пароль: ");
string password = Console.ReadLine() ?? "";

Console.Write("Подтвердите пароль: ");
string confirmPassword = Console.ReadLine() ?? "";

if (password == confirmPassword) {
    Console.WriteLine("Пароль принят");
}
else {
    Console.WriteLine("Пароль не принят");
}
Console.WriteLine();




Console.WriteLine("Задание 2");
Console.Write("Введите ваш возраст: ");

if (int.TryParse(Console.ReadLine(), out int age)) {
    if (age >= 18) {
        Console.WriteLine("Доступ разрешён");
    }
    else {
        Console.WriteLine("Доступ запрещён");
    }
}
else {
    Console.WriteLine("Ошибка: Введено некорректное число.");
}
Console.WriteLine();


Console.WriteLine("Задание 3");
Console.Write("Введите первое число: ");
double calcNum1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
double calcNum2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите операцию (+, -, *, /): ");
string operation = Console.ReadLine() ?? "";

switch (operation) {
    case "+":
        Console.WriteLine($"{calcNum1} + {calcNum2} = {calcNum1 + calcNum2}");
        break;
    case "-":
        Console.WriteLine($"{calcNum1} - {calcNum2} = {calcNum1 - calcNum2}");
        break;
    case "*":
        Console.WriteLine($"{calcNum1} * {calcNum2} = {calcNum1 * calcNum2}");
        break;
    case "/":
        if (calcNum2 != 0) {
            Console.WriteLine($"{calcNum1} / {calcNum2} = {calcNum1 / calcNum2}");
        }
        else {
            Console.WriteLine("Ошибка: Деление на ноль невозможно!");
        }
        break;
    default:
        Console.WriteLine("Ошибка: Неверная математическая операция.");
        break;
}
Console.WriteLine();


Console.WriteLine("Задание 4");
int sum = 0;

Console.Write("Введите первое число: ");
int posNum1 = int.Parse(Console.ReadLine() ?? "0");
if (posNum1 > 0) sum += posNum1;

Console.Write("Введите второе число: ");
int posNum2 = int.Parse(Console.ReadLine() ?? "0");
if (posNum2 > 0) sum += posNum2;

Console.Write("Введите третье число: ");
int posNum3 = int.Parse(Console.ReadLine() ?? "0");
if (posNum3 > 0) sum += posNum3;

Console.WriteLine($"Сумма положительных чисел: {sum}");
Console.WriteLine();



Console.WriteLine("Задание 5");
Console.WriteLine("Вы — отважный искатель приключений, отправившийся в Темный Лабиринт,");
Console.WriteLine("чтобы найти легендарного Dungeon Master’а.\n");

Console.WriteLine("1. Вы стоите перед первой дверью. Перед вами два пути:");
Console.WriteLine("Путь A: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь B: Пойти по тёмному коридору.");
Console.Write("Выберите путь (A/B): ");
string firstChoice = (Console.ReadLine() ?? "").ToUpper();

if (firstChoice == "A") {
    Console.WriteLine("\nВы вошли в комнату к дракону.");
    Console.WriteLine("Дракон говорит: \"Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.\"");
    Console.Write("Ваш ответ: ");
    string answer = (Console.ReadLine() ?? "").ToLower().Trim();

    if (answer == "рыба") {
        Console.WriteLine("\n  Дракон улыбнулся и открыл дверь в следующую комнату. Вы победили!");
    }
    else {
        Console.WriteLine("\n  Дракон недоволен ответом и съел вас! Игра окончена.");
    }
}
else if (firstChoice == "B") {
    Console.WriteLine("\nВы пошли по тёмному коридору и попали в комнату с двумя дверями.");
    Console.WriteLine("Дерь 1: Старинная дубовая дверь.");
    Console.WriteLine("Дверь 2: Железная дверь, покрытая мхом.");
    Console.Write("Какую дверь откроете? (1/2): ");
    string secondChoice = Console.ReadLine() ?? "";

    if (secondChoice == "1") {
        Console.WriteLine("\n  За дверью скрыты сокровища Dungeon Master’а! Вы богаты и свободны!");
    }
    else if (secondChoice == "2") {
        Console.WriteLine("\n  Вы попали в ловушку с ядовитыми шипами! Игра окончена.");
    }
    else {
        Console.WriteLine("\nВы замешкались, и тьма поглотила вас. Неверный выбор.");
    }
}
else {
    Console.WriteLine("\nВы испугались и убежали обратно. Неверный выбор.");
}