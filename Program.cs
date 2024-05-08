using System;

namespace dotNet_goof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

// Checks whether the user has been found with username and password
public async Task<bool> CheckLogin([FromForm] LoginForm formModel)
{
  // Real code should use a hashed and salted password
  var sql = $"SELECT * FROM users WHERE email={formModel.Email} AND password={formModel.Password}";
  return await dbCtx.Users.FromSqlRaw(sql).AnyAsync();
}
