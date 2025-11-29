using GTA;
using GTA.Math;
using GTA.UI;
using System.Collections.Generic;

namespace NativeUICompat.Core
{
    public class Menu
    {
        public string Title { get; set; }
        public List<MenuItem> Items { get; } = new List<MenuItem>();

        public int SelectedIndex { get; set; } = 0;
        public bool Visible { get; set; } = false;

        public Menu(string title)
        {
            Title = title;
        }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public MenuItem GetSelectedItem()
        {
            if (SelectedIndex < 0 || SelectedIndex >= Items.Count) return null;
            return Items[SelectedIndex];
        }
    }
}
