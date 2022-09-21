﻿// See https://aka.ms/new-console-template for more information
using HelloApp;
//https://metanit.com/sharp/efcore/2.16.php
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    // создаем два объекта User
    User user1 = new User { Name = "Tom", Age = 33 };
    User user2 = new User { Name = "Alice", Age = 26 };

    // добавляем их в бд
    db.Users.AddRange(user1, user2);
    db.SaveChanges();
}
// получение данных
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}