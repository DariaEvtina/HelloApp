// See https://aka.ms/new-console-template for more information
using HelloApp;
//https://metanit.com/sharp/efcore/2.16.php
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using (ApplicationContext db = new ApplicationContext())
{
    User tom = new User();
    db.Users.Add(tom); // ! ошибка Microsoft.EntityFrameworkCore.DbUpdateException
    db.SaveChanges();
}