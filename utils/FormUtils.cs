using System.Windows.Forms;

namespace LoucaLiza.utils
{
    class FormUtils
    {
        public static void Enable(Form sourceForm)
        {
            sourceForm.Enabled = true;
        }

        public static void Disable(Form sourceForm)
        {
            sourceForm.Enabled = false;
        }
    }
}
