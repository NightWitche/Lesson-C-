/*===== Работа с текстом
Дан текст. В тексте нужно все пробелы заменить 
черточками, маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".

Всегда спрашивать себя ясна ли задача: на каком языке текст,например? И откуда он у нас
появляется?*/

string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

/* есть какаято строка string s = qwerty ( у каждого символа свое место, как в массиве)
                                  012345
напримет s [3] = r*/

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty; //инициализация пустой строки

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
// string newText = Replace (text, ' ', '|');
// Console.WriteLine (newText);
// Console.WriteLine ();
// string newText = Replace (text, 'к', 'К');
// Console.WriteLine (newText);
Console.WriteLine ();
string newText = Replace (text, 'С', 'с');
Console.WriteLine (newText);