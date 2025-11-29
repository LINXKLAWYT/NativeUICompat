namespace NativeUICompat.Core
{
    public class CheckboxItem : MenuItem
    {
        public bool Checked { get; set; }

        public CheckboxItem(string text, bool isChecked = false, string description = "")
            : base(text, description)
        {
            Checked = isChecked;
        }
    }
}
