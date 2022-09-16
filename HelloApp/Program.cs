using HelloApp;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User tom = new User { Name = "Nikita", Age = 33, Gender = "Male" };
    User alice = new User { Name = "Olesja", Age = 26, Gender ="female" };

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
    }
}