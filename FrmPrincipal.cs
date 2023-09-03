using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        string archivo;
        string[] estados;
        string[] alfabeto;
        char estadoInicial;

        private void limpiarControles()
        {
            txtContenidoArchivo.Clear();
            txtAlfabeto.Clear();
            txtEstados.Clear();
            txtEstadosDeAceptacion.Clear();
            lblEstadoInicial.Visible = false;
            dgvTablaTransicion.Rows.Clear();
            dgvTablaTransicion.Columns.Clear();
        }

        private void textoDefecto(bool activo)
        {
            if (activo)
            {
                txtRutaArchivo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
                txtRutaArchivo.Text = "//Arrastre aquí el archivo de texto";
                txtRutaArchivo.ForeColor = Color.Gray;
            }
            else
            {
                txtRutaArchivo.Clear();
                txtRutaArchivo.Text = archivo;
            }
        }

        private void procesarLinea(string linea)
        {
            if (linea.Length > 0)
            {
                char quintupla;
                string[] partes;

                txtContenidoArchivo.AppendText($"{linea}\r\n");

                partes = linea.Split(new string[] { ":" }, StringSplitOptions.None);
                quintupla = partes[0].ToCharArray()[0];

                switch (quintupla)
                {
                    case 'Q':
                        dividirCadena(partes[1], txtEstados, quintupla);
                        break;
                    case 'T':
                        dividirCadena(partes[1], txtAlfabeto, quintupla);
                        break;
                    case 'i':
                        estadoInicial = partes[1].ToCharArray()[0];
                        lblEstadoInicial.Text = "Estado inicial: " + estadoInicial;
                        lblEstadoInicial.Visible = true;
                        break;
                    case 'A':
                        dividirCadena(partes[1], txtEstadosDeAceptacion, quintupla);
                        break;
                    case 'W':
                        generarTabla(partes[1]);
                        break;
                }
            }
        }
        private void dividirCadena(string cadena, TextBox tx, char valorQuintupla)
        {
            try
            {
                cadena = cadena.Trim('{', '}', ' ');
                string[] valores = cadena.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);
                switch (valorQuintupla)
                {
                    case 'Q':
                        estados = valores;
                        break;
                    case 'T':
                        alfabeto = valores;
                        break;
                }

                foreach (string valor in valores)
                {
                    if (valorQuintupla == 'A')
                    {
                        if (estados.Contains(valor))
                        {
                            tx.AppendText($"{valor}\r\n");
                        }
                        else
                        {
                            tx.AppendText($"{valor} - (Estado no definido)\r\n");
                        }
                    }
                    else
                    {
                        tx.AppendText($"{valor}\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generarTabla(string cadenaTransiciones)
        {
            try
            {
                cadenaTransiciones = cadenaTransiciones.Trim(' ', '{', '}');

                string[] transiciones = cadenaTransiciones.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                DataGridViewTextBoxColumn columna;
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "";
                dgvTablaTransicion.Columns.Add(columna);

                foreach (string cadena in alfabeto)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = cadena;
                    dgvTablaTransicion.Columns.Add(columna);
                }

                foreach (string estado in estados)
                {
                    dgvTablaTransicion.Rows.Add(estado);
                }
                dgvTablaTransicion.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            textoDefecto(true);
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtRutaArchivo.DragEnter += txtRutaArchivo_DragEnter;
            txtRutaArchivo.DragDrop += txtRutaArchivo_DragDrop;

            lblEstadoInicial.Visible = false;
            textoDefecto(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRutaArchivo_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                    if (archivos.Length == 1 && Path.GetExtension(archivos[0]).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRutaArchivo_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string archivo in archivos)
                {
                    if (Path.GetExtension(archivo).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        string linea = "";
                        var fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

                        textoDefecto(false);
                        limpiarControles();

                        using (var sr = new StreamReader(fs))
                        {
                            while ((linea = sr.ReadLine()) != null)
                            {
                                procesarLinea(linea);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, arrastra un archivo de texto (.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}