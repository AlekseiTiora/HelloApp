using HelloApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Users.ToList();
    Console.WriteLine("Список пользователей:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}- {u.Gender}");
    }
}


