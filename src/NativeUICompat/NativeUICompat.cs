using GTA;

namespace NativeUICompat
{
    public class NativeUICompat : Script
    {
        private MenuController controller;

        public NativeUICompat()
        {
            controller = new MenuController();

            Tick += OnTick;
        }

        private void OnTick(object sender, System.EventArgs e)
        {
            controller.Process();
        }
    }
}
