using System.Data;
using System.Windows.Forms;

namespace ConvertidorAFD.Clases
{
    internal class Configuraciones
    {
        public void ConfigurarTabla(DataGridView dgv)
        {
            DataGridViewCellStyle style = new();
            
            dgv.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            for (int columna = 1; columna < dgv.ColumnCount; columna++)
            {
                dgv.Columns[columna].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[columna].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int fila = 0; fila < dgv.Rows.Count; fila++)
            {
                if (fila % 2 == 0)
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E9ECEF");
                }
                else
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CED4DA");
                }
            }

            dgv.RowHeadersVisible = false;

            style.ForeColor = ColorTranslator.FromHtml("#212529");
            dgv.DefaultCellStyle = style;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00509d");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#CED4DA");
            dgv.EnableHeadersVisualStyles = false;
        }

        public DataTable DimensionarDataTable(List<List<string>> matriz)
        {
            DataTable dataTable = new();

            foreach (string nombreColumna in matriz[0])
            {
                dataTable.Columns.Add(nombreColumna);
            }

            for (int fila = 1; fila < matriz.Count; fila++)
            {
                dataTable.Rows.Add(matriz[fila].ToArray());
            }
            return dataTable;
        }

        public void ConfigurarTexto(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox && childControl.Name != "txtRutaArchivo")
                {
                    TextBox textBox = (TextBox)childControl;
                    textBox.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
                    textBox.ForeColor = ColorTranslator.FromHtml("#212529");
                }

                // Recorrer los controles secundarios si existen
                if (childControl.Controls.Count > 0)
                {
                    ConfigurarTexto(childControl);
                }
            }
        }
    }
}
