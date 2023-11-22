using ConvertidorAFD.Clases;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Configuraciones c = new();
            //c.ConfigurarTexto(this);
        }
        bool archivoCargado = false;

        private void LimpiarControles()
        {
            txtContenidoArchivo.Clear();
            txtAlfabeto.Clear();
            txtEstados.Clear();
            txtEstadosDeAceptacion.Clear();
            lblEstadoInicial.Visible = false;
            dgvMatrizTransicion1.DataSource = null;
            dgvMatrizTransicion2.DataSource = null;
            lblMatrizTransicion1.Visible = false;
            lblMatrizTransicion2.Visible = false;
            dgvMatrizTransicion1.Visible = false;
            dgvMatrizTransicion2.Visible = false;
        }

        private void TextoDefecto(bool activo)
        {
            string fuente = "Segoe UI";
            float tamanio = 11.25F;

            if (activo)
            {
                txtRutaArchivo.Font = new Font(fuente, tamanio, FontStyle.Italic, GraphicsUnit.Point);
                txtRutaArchivo.Text = "Arrastre aquí el archivo de texto";
                txtRutaArchivo.ForeColor = ColorTranslator.FromHtml("#6C757D");
            }
            else
            {
                txtRutaArchivo.Font = new Font(fuente, tamanio, FontStyle.Regular, GraphicsUnit.Point);
                txtRutaArchivo.Clear();
                txtRutaArchivo.ForeColor = ColorTranslator.FromHtml("#343A40");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            TextoDefecto(true);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            txtRutaArchivo.DragEnter += TxtRutaArchivo_DragEnter;
            txtRutaArchivo.DragDrop += TxtRutaArchivo_DragDrop;

            lblEstadoInicial.Visible = false;
            lblMatrizTransicion1.Visible = false;
            lblMatrizTransicion2.Visible = false;
            dgvMatrizTransicion1.Visible = false;
            dgvMatrizTransicion2.Visible = false;

            lblAutor.Text = "Carnet: 9490-17-969. Nombre: Yelsyn Adrid Hernández Crúz";
            dgvMatrizTransicion1.TabStop = false;

            TextoDefecto(true);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtRutaArchivo_DragEnter(object sender, DragEventArgs e)
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

        private void TxtRutaArchivo_DragDrop(object sender, DragEventArgs e)
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

                        TextoDefecto(false);
                        txtRutaArchivo.Text = archivos[0];
                        LimpiarControles();
                        GeneradorInicial generadorInicial = new();

                        using (var sr = new StreamReader(fs))
                        {
                            while ((linea = sr.ReadLine()) != null)
                            {
                                generadorInicial.ProcesarLinea(lblEstadoInicial, txtContenidoArchivo, txtEstados, txtAlfabeto, txtEstadosDeAceptacion, dgvMatrizTransicion1, linea);
                            }
                        }
                        archivoCargado = true;
                        lblMatrizTransicion1.Visible = true;
                        lblMatrizTransicion2.Visible = true;
                        dgvMatrizTransicion1.Visible = true;
                        dgvMatrizTransicion2.Visible = true;
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