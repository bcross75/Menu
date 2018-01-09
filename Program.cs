namespace Menu.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var pancakes = new MenuItem
            {
                Name = "Buttermilk Pancakes",
                Description = "Just like Mama used to make, but better",
                Price = 5.99m,
                Calories = 600
            };
            
            var cinnamonRoll = new MenuItem
            {
                Name = "Cinnamon Roll",
                Description = "Just what it says",
                Price = 6.99m,
                Calories = 750
            };

            var hashbrowns = new MenuItem
            {
                Name = "Hashbrowns",
                Description = "Yummy breakfast potatoes",
                Price = 2.99m,
                Calories = 220
            };

            var cheese = new MenuItem
            {
                Name = "Cheese",
                Description = "Well, it's cheese",
                Price = .49m,
                Calories = 40
            };

            var coffee = new MenuItem
            {
                Name = "Coffee",
                Description = "Sorry, it's not Starbucks.",
                Price = .89m,
                Calories = 0
            };

            var orangeJuice = new MenuItem
            {
                Name = "Orange Juice",
                Description = "Fresh Squeezed right here",
                Price = 1.59m,
                Calories = 80
            };

            var PeanutButterPie = new MenuItem
            {
                Name = "Peanut Butter Pie",
                Description = "It's a chaotic world out there, eat dessert first!",
                Price = 3.99m,
                Calories = 400
            };

            var appetizers = new Section("Appetizers");
            appetizers.MenuItems = new MenuItem[] { cinnamonRoll };

            var entree = new Section("Entrees");
            entree.MenuItems = new MenuItem[] { pancakes };

            var sides = new Section("Sides");
            sides.MenuItems = new MenuItem[] { hashbrowns, cheese };

            var beverages = new Section("Beverages");
            beverages.MenuItems = new MenuItem[] { coffee, orangeJuice };

            var dessert = new Section("Sweet Treats");
            dessert.MenuItems = new MenuItem[] { PeanutButterPie };

            var menu = new Menu("Luke's Diner");
            menu.Sections = new Section[] { beverages, appetizers, entree, sides, dessert };
            menu.Bio = $@"Our Story - Just a small town girl, {Environment.NewLine} living in a lonely world... no wait, 
 that's not it.";




            Console.WriteLine(menu.Print());
            Console.ReadKey();
        }
    }
}
