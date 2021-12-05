using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza.View.Components
{
    class PlaceHolderComboBox : ComboBox
    {
        bool isPlaceHolder = true;
        bool userHasTypedInitialPlaceHolder = false;
        string _placeHolderText;

        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get
            {
                if (base.Text == PlaceHolderText && !userHasTypedInitialPlaceHolder)
                {
                    return "";
                }

                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        public PlaceHolderComboBox()
        {
            setPlaceholder();
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
            KeyPress += customKeyPress;
        }

        private void customKeyPress(object sender, EventArgs e)
        {
            KeyPressEventArgs ev = (KeyPressEventArgs) e;
            userHasTypedInitialPlaceHolder = base.Text + ev.KeyChar == PlaceHolderText;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }

        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
            else
            {
                removePlaceHolder();
            }
        }

        private void removePlaceHolder()
        {
            if (isPlaceHolder)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }
    }
}
