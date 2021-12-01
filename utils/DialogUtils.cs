using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoucaLiza.utils
{
    class DialogUtils
    {
        public static bool ConfirmDelete()
        {
            return MessageBox.Show(
                "Excluir o registro selecionado?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }
    }
}
