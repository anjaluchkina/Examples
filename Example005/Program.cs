﻿Console.WriteLine("Введите имя пользователя");
string username = System.Console.ReadLine();

if (username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура это же Маша!");
}
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}
