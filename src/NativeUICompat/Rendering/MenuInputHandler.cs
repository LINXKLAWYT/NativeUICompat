using GTA;
using NativeUICompat.Core;

namespace NativeUICompat.Rendering
{
    public class MenuInputHandler
    {
        public void Process(Menu menu)
        {
            if (!menu.Visible) return;

            if (Game.IsControlJustPressed(GTA.Control.PhoneUp))
                menu.SelectedIndex = (menu.SelectedIndex - 1 + menu.Items.Count) % menu.Items.Count;

            if (Game.IsControlJustPressed(GTA.Control.PhoneDown))
                menu.SelectedIndex = (menu.SelectedIndex + 1) % menu.Items.Count;
        }
    }
}
