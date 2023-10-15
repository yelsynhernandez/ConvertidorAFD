using System.Collections.Immutable;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LeerAutomata.Clases;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        bool archivoCargado = false;

        private void limpiarControles()
        {
            txtContenidoArchivo.Clear();
            txtAlfabeto.Clear();
            txtEstados.Clear();
            txtEstadosDeAceptacion.Clear();
            lblEstadoInicial.Visible = false;
            dgvMatrizTransicion1.Rows.Clear();
            dgvMatrizTransicion1.Columns.Clear();
        }

        private void textoDefecto(bool activo)
        {
            string fuente = "Times New Roman";
            float tamanio = 11.25F;

            if (activo)
            {
                txtRutaArchivo.Font = new Font(fuente, tamanio, FontStyle.Italic, GraphicsUnit.Point);
                txtRutaArchivo.Text = "Arrastre aquí el archivo de texto";
                txtRutaArchivo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8D99AE");
            }
            else
            {
                txtRutaArchivo.Font = new Font(fuente, tamanio, FontStyle.Regular, GraphicsUnit.Point);
                txtRutaArchivo.Clear();
                txtRutaArchivo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0EBD8");
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
                if (!archivoCargado)
                {
                    string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                    if (Path.GetExtension(archivos[0]).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        string linea = "";
                        var fs = new FileStream(archivos[0], FileMode.Open, FileAccess.Read);

                        textoDefecto(false);
                        txtRutaArchivo.Text = archivos[0];
                        limpiarControles();
                        GeneradorInicial generadorInicial = new GeneradorInicial();

                        using (var sr = new StreamReader(fs))
                        {
                            while ((linea = sr.ReadLine()) != null)
                            {
                                generadorInicial.procesarLinea(lblEstadoInicial, txtContenidoArchivo, txtEstados, txtAlfabeto, txtEstadosDeAceptacion, dgvMatrizTransicion1, linea);
                            }
                        }
                        archivoCargado = true;
                        generadorInicial.iniciarConvertidor(dgvMatrizTransicion2);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, arrastra un archivo de texto (.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    archivoCargado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}