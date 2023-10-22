using System.Data;
using System.Windows.Forms;

namespace ConvertidorAFD.Clases
{
    internal class Configuraciones
    {
        public void ConfigurarTabla(DataGridView dgv)
        {
            DataGridViewCellStyle style = new();
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.RowHeadersVisible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //style.Font = new Font(dgv.Font, FontStyle.Regular);
            style.ForeColor = ColorTranslator.FromHtml("#000000");
            dgv.DefaultCellStyle = style;
            for (int fila = 0; fila < dgv.Rows.Count; fila++)
            {
                if (fila % 2 == 0)
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0077B6");
                }
                else
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#48CAE4");
                }
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    textBox.ForeColor = ColorTranslator.FromHtml("#F5EBE0");
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
