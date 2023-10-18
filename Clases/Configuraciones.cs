using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorAFD.Clases
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

            for (int fila = 0; fila < dgv.Rows.Count; fila++)
            {
                if (fila % 2 == 0)
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = Color.Silver;
                }
                else
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }
    }
}
