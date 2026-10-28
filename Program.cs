// //задание 1
// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// string worldLow = word.ToLower();
// int count = 0;

// for (int i=0; i < word.Length; i++){
//     if (worldLow[i] == 'а') {
//         count++;
//     }
// }
// Console.WriteLine(count);

// //задание 2
// Console.Write("Имя файла: ");
// string fileName = Console.ReadLine();

// if (fileName.EndsWith(".cs")) {
//     Console.WriteLine("Это файл C#");
// } else if (fileName.EndsWith("(.png") || fileName.EndsWith("(.jpg")) {
//     Console.WriteLine("Это изображение");
// } else {
//     Console.WriteLine("неизвестный тип");
// }

// if (fileName.StartsWith("Lab")) {
//     Console.WriteLine("Это лабораторная работа");
// } 

// if (fileName.Contains("test")) {
// Console.WriteLine("Тестовый файл");
// }

// //задание 3
// Console.Write("Введите фразу: ");
// string phrase = Console.ReadLine();

// Console.WriteLine($"Фраза большими буквами: {phrase.ToUpper()}");
// Console.WriteLine($"Замена пробелов: {phrase.Replace(" ", "_")}");

// if (phrase.ToLower().Contains("стоп")) {
//     Console.WriteLine("Стоп-слово найдено!");
// }

// // задание 4
// //4.1
// Console.Write("Введите дату в формате ГГГГ-ММ-ДД: ");
// string date = Console.ReadLine();

// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);

// Console.WriteLine($"Дата в новом формате: {day}.{month}.{year}");

// //4.2
// Console.Write("Введите телефон (11 цифр): ");
// string phone = Console.ReadLine();

// string p0 = phone.Substring(0, 1);
// string p1 = phone.Substring(1, 3);
// string p2 = phone.Substring(4, 3);
// string p3 = phone.Substring(7, 2);
// string p4 = phone.Substring(9, 2);

// Console.WriteLine($"Телефон в новом формате: +{p0} ({p1}) {p2}-{p3}-{p4}");

// //Задание 5
// Console.Write("Введите строку: ");
// string text = Console.ReadLine();

// int probel = 0;
// int glasnie = 0;
// string glas = "аеёиоуыэюя";

// string lowText = text.ToLower();
// for (int i = 0; i < text.Length; i++)
// {
//     if (lowText[i] == ' ')
//     {
//         probel++;
//     }
//     if (glas.Contains(lowText[i]))
//     {
//         glasnie++;
//     }
// }
// Console.WriteLine($"количество символов {text.Length}");
// Console.WriteLine($"количество пробелов {probel}");
// Console.WriteLine($"количество гласных букв {glasnie}");

// //задание 6
// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// string revers = "";

// for (int i = word.Length - 1; i >= 0; i--) {
//     revers += word[i];
// }

// Console.WriteLine($"Слово задом наперёд: {revers}");

// if (word.ToLower() == revers.ToLower()) {
//     Console.WriteLine("Слово является палиндромом");
// } else {
//     Console.WriteLine("Слово не является палиндромом");
// }

//Итоговая задача. «Проверка email»
Console.Write("Введите адрес электронной почты: ");
string email = Console.ReadLine();

int dog = 0;
string low = email.ToLower();

if (email.Length < 5)
{
    Console.WriteLine("Адрес некорректен. Длина меньше 5 символов");
    return;
}

for (int i = 0; i < email.Length; i++) {
    if (email[i] == '@') {
        dog++;
    }
}

if (dog != 1) {
    Console.WriteLine("Адрес некорректен. В нём должен быть один символ @");
    return;
}
if (email[0] == '@' || email[email.Length - 1] == '@') {
    Console.WriteLine("Адрес некорректен. Он не должен начинаться или заканчиваться на @");
    return;
}
if (email.Contains(" ")) {
    Console.WriteLine("Адрес некорректен. В нём не должно быть пробелов");
    return;
}
if (!low.EndsWith(".ru") && !low.EndsWith(".com")) {
    Console.WriteLine("Адрес некорректен. Он должен заканчиваться на .ru или .com");
    return;
}
Console.WriteLine("Адрес корректен");
Console.WriteLine(low);

// //Дополнительное задание ★★★
// using System.Text;

// Console.Write("Введите строку: ");
// string str = Console.ReadLine();

// var sb = new StringBuilder();
// string glasn = "аеёиоуыэюя";

// for (int i=0; i<str.Length; i++) {
//     char letter = str[i];
//     if (!glasn.Contains(char.ToLower(letter))) {
//         sb.Append(letter);
//     }
// }
// Console.WriteLine(sb.ToString());