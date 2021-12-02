using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza.utils
{
    class ComboBoxUtils
    {
        public static void ConfigureComboBoxItems(ComboBox comboBox, string[] sourceItems)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(sourceItems);
            comboBox.DrawItem += delegate(object sender, DrawItemEventArgs e)
            {
                e.DrawBackground();
                if (e.Index > -1)
                {
                    e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
            };
        }
    }
}
