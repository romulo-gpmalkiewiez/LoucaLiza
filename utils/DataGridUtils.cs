using System.Collections.Generic;
using System.Windows.Forms;

namespace LoucaLiza.utils
{
    class DataGridUtils
    {
        public static T GetSelectedEntityById<T>(DataGridView dataGridView, List<T> sourceData)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView.SelectedRows[0].Cells["id"].Value;

                return sourceData.Find(entity =>
                {
                    var id = (int)entity.GetType().GetProperty("Id").GetValue(entity, null);
                    return id == selectedId;
                });
            }

            return default(T);
        }
    }
}
