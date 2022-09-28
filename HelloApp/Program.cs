// See https://aka.ms/new-console-template for more information
using HelloApp;
//https://metanit.com/sharp/efcore/2.16.php
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using (ApplicationContext db = new ApplicationContext())
{
    User bob = new User("Bob", 30);
    User kate = new User("Kate", 29);
    db.Users.Add(bob);
    db.Users.Add(kate);
    db.SaveChanges();

    var users = db.Users.ToList();
    foreach (User user in users)
    {
        user.Print();
    }
}