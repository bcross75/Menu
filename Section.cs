namespace Menu.Console
{
    public class Section
    {

        public string Title { get; set; }
        public MenuItem[] MenuItems { get; set; }

        public Section(string title)
        {
            Title = title;
        }


    }
}
