using GTA.UI;
using NativeUICompat.Core;
using System.Drawing;

namespace NativeUICompat.Rendering
{
    public class MenuRenderer
    {
        public void Draw(Menu menu)
        {
            if (!menu.Visible) return;

            string display = $"~g~{menu.Title}\n";

            for (int i = 0; i < menu.Items.Count; i++)
            {
                var item = menu.Items[i];
                bool selected = (i == menu.SelectedIndex);

                string prefix = selected ? "~w~> " : "  ";
                string color = selected ? "~g~" : "~w~";

                display += $"{prefix}{color}{item.Text}\n";
            }

            Screen.ShowSubtitle(display, 1);
        }
    }
}
