// See https://aka.ms/new-console-template for more information
using HelloApp;
//https://metanit.com/sharp/efcore/2.16.php
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    User tom = new User("Tom", 37);
    User bob = new User("Bob", 41);
    db.Users.Add(tom);
    db.Users.Add(bob);
    db.SaveChanges();
}
using (ApplicationContext db = new ApplicationContext())
{
    Console.WriteLine("get data from db");
    var users = db.Users.ToList();
    foreach (var user in users)
        Console.WriteLine($"{user.Name} - {user.Age}");
}