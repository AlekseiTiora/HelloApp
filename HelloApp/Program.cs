using HelloApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.Sqlite;
using System.Data.SqlClient;

using (ApplicationContext db = new ApplicationContext())
{
    SqlParameter param = new()
    {
        ParameterName = "@userName",
        SqlDbType = System.Data.SqlDbType.VarChar,
        Direction = System.Data.ParameterDirection.Output,
        Size = 50
    };
    db.Database.ExecuteSqlRaw("GetUserWithMaxAge @userName OUT", param);
    Console.WriteLine(param.Value);
}