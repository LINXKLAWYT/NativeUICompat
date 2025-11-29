using System.Collections.Generic;

namespace NativeUICompat.Core
{
    public class ListItem : MenuItem
    {
        public List<string> Options { get; set; }
        public int Index { get; set; }

        public ListItem(string text, List<string> options, int index = 0, string description = "")
            : base(text, description)
        {
            Options = options;
            Index = index;
        }
    }
}
