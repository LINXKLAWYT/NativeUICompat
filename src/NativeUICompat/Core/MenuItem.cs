namespace NativeUICompat.Core
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Description { get; set; }

        public MenuItem(string text, string description = "")
        {
            Text = text;
            Description = description;
        }
    }
}
