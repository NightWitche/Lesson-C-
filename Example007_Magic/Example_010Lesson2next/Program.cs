// Массивы в С#!!! Примеры.


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
//}//           0    1    2   3   4   5   6     7    8
// int[] array = { 551, 892, 35, 48, 1556, 689, 778, 889, 90 };
//// что бы обратится к ячейке массива
////array[1] = 14;
////Console.WriteLine(array[4]);

// int max = Max (
//     Max(array[0],array[1],array[2]),
//     Max(array[3],array[4],array[5]),
//     Max(array[6],array[7],array[8]));

// Console.WriteLine(max);


//// Имеется одномерный массив array из n элементов, 
////требуется найти элемент массива равный find. 
//// (а то, что несоотвествует, тоже как -то обозначить)

// int[] array = {1,52,14,26,14,4,56,12,16,18};

// int n = array.Length; ////длинна массива
// int find = 14;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break; // -преврать, когда несколько одинаковых чисел, что бы находил первое.
//     }    
//     index++;
// }

//// А теперь тоже самое но с синтаксисом и генератором случайных чисел (обожаю его), 
////который заполнит массив.

void FillArray(int[] collection) // коллекция аргумент для заполнения массива
{
    int lenght = collection.Length;
    int index = 0; // начало
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;  //index = index+1
    }
}

void PrintArray(int[] col) // void метод ничего не возвращает return использовать нельзя
{
    int count = col.Length;
    int position = 0; // вместо index,а так тот же самый смысл
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int [] array = new int [10]; //создает новый массив в данном случае из 10 элементов.

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,5);
Console.WriteLine(pos);
