using System;
using System.Windows.Forms;

namespace LoucaLiza.utils
{
    class FormUtils
    {
        private Form _sourceForm;
        private Form _targetForm;

        public FormUtils(Form source, Form target)
        {
            _sourceForm = source;
            _targetForm = target;
        }

        private void OpenNewWindowControlledEvent()
        {
            _sourceForm.Enabled = false;
            _targetForm.Show();

            _targetForm.FormClosing += form_TargetFormClosing;
        }

        private void form_TargetFormClosing(object sender, FormClosingEventArgs e)
        {
            _sourceForm.Enabled = true;
        }

        public static void OpenNewWindow(Form source, Form target)
        {
            new FormUtils(source, target).OpenNewWindowControlledEvent();
        }
    }
}
