// See https://aka.ms/new-console-template for more information
using HelloApp;
//https://metanit.com/sharp/efcore/2.16.php
using (ApplicationContext db = new ApplicationContext())
{
    //await db.Database.EnsureDeletedAsync();
    bool isCreated = db.Database.EnsureCreated();
    if (isCreated) Console.WriteLine("Data Base is created");
    else Console.WriteLine("Data base was already created");
    bool isAvalaible = db.Database.CanConnect();
    if (isAvalaible) Console.WriteLine("Data base is avalible");
    else Console.WriteLine("data base is not avalible");
}
using (helloappContext db = new helloappContext())
{
    // создаем два объекта User
    //User tom = new User { Name = "Tom", Age = 33 };
    //User alice = new User { Name = "Alice", Age = 26 };

    // добавляем их в бд
    //db.Users.Add(tom);
    //db.Users.Add(alice);
    //db.SaveChanges();
    //Console.WriteLine("object are saved");

    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("objects:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}


