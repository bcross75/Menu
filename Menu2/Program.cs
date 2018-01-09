using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Menu2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source =.\SQLExpress; Initial Catalog = Menu; Integrated Security = True";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("select m.Name, m.Description, m.CalorieCount, m.Price, c.Name as Category from MenuItem m join Category c on m.CategoryId = c.Id" , connection);
            connection.Open();
            var reader = command.ExecuteReader();
            var menuItems = new List<MenuItem>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    menuItems.Add(new MenuItem
                    {
                        Name = reader.GetString(0),
                        Description = reader.GetString(1),
                        CalorieCount = reader.GetInt32(2),
                        Price = reader.GetDecimal(3),
                        Category = reader.GetString(4)
                    
                    });
                    
                }
            }
            connection.Close();
            foreach(var menuItem in menuItems)
            {
                Console.WriteLine(menuItem.Name);
            }
            Console.ReadKey();
        }
    }
}
