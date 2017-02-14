using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Console
{
    public class Menu
    {
        public string Title { get; set; }
        public string Bio { get; set; }
        public Section[] Sections { get; set; }
        
            
        //Constructor - run when "new" keyword is used
        public Menu()
        {
            
        }

        public Menu(string title)
        {
            Title = title;
        }
        public string Print()
        {
            var builder = new StringBuilder();

            builder.AppendLine(Title);
            builder.AppendLine();

            foreach (var section in Sections)
            {
                builder.AppendLine($"  {section.Title}");
                foreach (var menuItem in section.MenuItems)
                {
                    builder.AppendLine($"    {menuItem.Name} {menuItem.Price:C}");
                    builder.AppendLine($"    {menuItem.Description}");
                    builder.AppendLine($"     {"Calories"} {menuItem.Calories}");
                    builder.AppendLine();
                };

              
            }
            builder.AppendLine(Bio);
            builder.AppendLine();

            return builder.ToString();
        }
    }
}
