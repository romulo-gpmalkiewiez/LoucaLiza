using System;
using System.Windows.Forms;

namespace LoucaLiza.utils
{
    class FormUtils
    {
        private Form _sourceForm;
        private Form _targetForm;
        private bool _dialog;

        public FormUtils(Form source, Form target)
        {
            _sourceForm = source;
            _targetForm = target;
        }

        public FormUtils isDialog()
        {
            _dialog = true;
            return this;
        }

        private void OpenNewWindowControlledEvent()
        {
            if (_dialog)
            {
                _sourceForm.Enabled = false;
            }
            else
            {
                _sourceForm.Visible = false;
            }
            _targetForm.Show();

            _targetForm.FormClosing += form_TargetFormClosing;
        }

        private void form_TargetFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dialog)
            {
                _sourceForm.Enabled = true;
            }
            else
            {
                _sourceForm.Visible = true;
            }
        }

        public static void OpenNewWindow(Form source, Form target)
        {
            new FormUtils(source, target).OpenNewWindowControlledEvent();
        }

        public static void OpenNewDialog(Form source, Form target)
        {
            new FormUtils(source, target).isDialog().OpenNewWindowControlledEvent();
        }
    }
}
