using HelloApp;

using (ApplicationContext bb = new ApplicationContext())
{
   /* // создаем два объекта User
    User Nikita = new User { Name = "Nikita", Age = 33, Gender = "Male" };
    User Olesja = new User { Name = "Olesja", Age = 26, Gender ="female" };

    // добавляем их в бд
    db.Users.Add(tom);
    db.Users.Add(alice);
    db.SaveChanges();
    Console.WriteLine("Objektide salvestamine õnnestus");

    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Objektide loend:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age} - {u.Gender}");
    }*/
    using (ApplicationContext db = new ApplicationContext())
    {
        User Nikita = new User { Name = "Nikita", Age = 33, Gender = "Male" };
        User Olesja = new User { Name = "Olesja", Age = 26, Gender = "female" };

        // Добавление
        db.Users.Add(Nikita);
        db.Users.Add(Olesja);
        db.SaveChanges();
        Console.WriteLine("Objektide salvestamine õnnestus");

    }

    // получение
    using (ApplicationContext db = new ApplicationContext())
    {
        // получаем объекты из бд и выводим на консоль
        var users = db.Users.ToList();
        Console.WriteLine("Andmed pärast lisamist:");
        foreach (User u in users)
        {
            Console.WriteLine($"{u.Id}.{u.Name} - {u.Age} - {u.Gender}");
        }
    }

    // Редактирование
    using (ApplicationContext db = new ApplicationContext())
    {
        // получаем первый объект
        User? user = db.Users.FirstOrDefault();
        if (user != null)
        {
            user.Name = "Bob";
            user.Age = 44;
            user.Gender = "Male";
            //обновляем объект
            //db.Users.Update(user);
            db.SaveChanges();
        }
        // выводим данные после обновления
        Console.WriteLine("\nAndmed pärast redigeerimist:");
        var users = db.Users.ToList();
        foreach (User u in users)
        {
            Console.WriteLine($"{u.Id}.{u.Name} - {u.Age} - {u.Gender}");
        }
    }

    // Удаление
    using (ApplicationContext db = new ApplicationContext())
    {
        // получаем первый объект
        User? user = db.Users.FirstOrDefault();
        if (user != null)
        {
            //удаляем объект
            db.Users.Remove(user);
            db.SaveChanges();
        }
        // выводим данные после обновления
        Console.WriteLine("\nAndmed pärast kustutamist:");
        var users = db.Users.ToList();
        foreach (User u in users)
        {
            Console.WriteLine($"{u.Id}.{u.Name} - {u.Age} - {u.Gender}");
        }
    }
}