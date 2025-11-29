using GTA.UI;

namespace NativeUICompat.MenuUI
{
    public static class TitleBar
    {
        public static void Draw(string title)
        {
            Screen.ShowSubtitle($"~g~{title}", 1);
        }
    }
}
