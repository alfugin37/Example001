﻿// Продолжаем обучение.
Console.Write("Введите имя пользовотеля: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша! ");
}
else 
{
    Console.WriteLine("привет, ");
    Console.WriteLine(username);
}
