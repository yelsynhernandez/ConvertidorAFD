using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerAutomata.Clases
{
    internal class Configuraciones
    {
        public void configurarTabla(DataGridView dgv)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.RowHeadersVisible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
