/*void Method1().-метод которыйничего ве получают и не возврашают.
void Method1()
{
   Console.WriteLine("Автор..."); 
}
Method1();*/

 //Вид2 -группа методов что-то принемают но нечего не возвращают.

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "новый текст");
*/
/*
 int Method3()
    {
        return DateTime.Now.Year;
    }
 int year = Method3();
Console.WriteLine(year);
*/
/*-4 группа методов которая что-то принемает и что-то возвращает.
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, " asdf ");
Console.WriteLine(res);
*/
//- синтаксис цикла for 
/* string Method4(int count, string text)
{
   
    string result = String.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
        
    }
    return result;
}

string res = Method4(10, " z ");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//===== Работа ст екстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленикие буквы "к" заменить большими "К",
// а большие "С" заменить маленикими "с".

// Ясна ли задача?

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие пруского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю. ";

 // string s = "qwerty"
 //             012345
 // s[3] // r

 /* string Replase(string text, char oldValue, char newValue) 
 {
    string result = String.Empty;

    int lenght = text. Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
 
    return result;
 } 

 string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);
*/
// 1.Найти позицию минимального элемента в неотсортированной частимассива.
// 2.Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3.Повторять пока есть неотсортированные позиции.

/* int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}
PrintArray(arr);
 SelectionSort(arr);

PrintArray(arr);
*/