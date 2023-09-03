namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void limpiarControles()
        {
            txtRutaArchivo.Clear();
            txtContenidoArchivo.Clear();
            txtAlfabeto.Clear();
            txtEstados.Clear();
            txtEstadosDeAceptacion.Clear();
            lblEstadoInicial.Visible = false;
            txtRutaArchivo.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            txtRutaArchivo.Text = "//Arrastre aquí el archivo de texto";
        }

        private void cargarArchivo()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Seleccionar un archivo de texto";
                openFileDialog.InitialDirectory = @"%USERPFROFILE%";
                openFileDialog.Filter = "Text File (*.txt)|*.txt";
                openFileDialog.FilterIndex = 0;
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    limpiarControles();
                    string archivo = openFileDialog.FileName;
                    txtRutaArchivo.AppendText(archivo);

                    if (archivo.Length > 0)
                    {
                        string extension = Path.GetExtension(archivo);
                        if (extension == ".txt")
                        {
                            string linea = "";
                            var fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
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
                            MessageBox.Show("El archivo seleccionado no es un archivo de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningún archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        dividirCadena(partes[1], txtEstados);
                        break;
                    case 'T':
                        dividirCadena(partes[1], txtAlfabeto);
                        break;
                    case 'i':
                        lblEstadoInicial.Text = "Estado inicial: " + partes[1];
                        lblEstadoInicial.Visible = true;
                        break;
                    case 'A':
                        dividirCadena(partes[1], txtEstadosDeAceptacion);
                        break;
                }
            }
        }
        private void dividirCadena(string cadena, TextBox tx)
        {
            try
            {
                cadena = cadena.Trim('{', '}', ' ');
                string[] valores = cadena.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);

                foreach (string valor in valores)
                {
                    tx.AppendText($"{valor}\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }

        private void txtRutaArchivo_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblEstadosDeAceptacion.Text = $"Estados\r\nde aceptación";
            lblEstadoInicial.Visible = false;
            txtRutaArchivo.Text = "//Arrastre aquí el archivo de texto";
            txtRutaArchivo.ForeColor = Color.Gray;
            txtRutaArchivo.DragEnter += txtRutaArchivo_DragEnter;
            txtRutaArchivo.DragDrop += txtRutaArchivo_DragDrop;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRutaArchivo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length == 1 && Path.GetExtension(files[0]).Equals(".txt", StringComparison.OrdinalIgnoreCase))
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

        private void txtRutaArchivo_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (Path.GetExtension(file).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    txtRutaArchivo.Clear();
                    txtRutaArchivo.AppendText(file);
                    txtRutaArchivo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else
                {
                    MessageBox.Show("Por favor, arrastra un archivo de texto (.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}