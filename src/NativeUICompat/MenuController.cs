using System.Collections.Generic;
using NativeUICompat.Core;
using NativeUICompat.Rendering;

namespace NativeUICompat
{
    public class MenuController
    {
        private readonly List<Menu> menus = new List<Menu>();
        private readonly MenuRenderer renderer = new MenuRenderer();
        private readonly MenuInputHandler input = new MenuInputHandler();

        public Menu CurrentMenu { get; private set; }

        public void AddMenu(Menu menu)
        {
            menus.Add(menu);
            if (CurrentMenu == null) CurrentMenu = menu;
        }

        public void ShowMenu(Menu menu)
        {
            if (CurrentMenu != null) CurrentMenu.Visible = false;
            CurrentMenu = menu;
            CurrentMenu.Visible = true;
        }

        public void Process()
        {
            if (CurrentMenu == null) return;
            input.Process(CurrentMenu);
            renderer.Draw(CurrentMenu);
        }
    }
}
