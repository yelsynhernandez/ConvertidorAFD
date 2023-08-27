namespace WinFormsApp1
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrar = new Button();
            btnSeleccionarArchivo = new Button();
            txtRutaArchivo = new TextBox();
            lblRutaArchivo = new Label();
            lblContenido = new Label();
            txtContenidoArchivo = new TextBox();
            txtEstados = new TextBox();
            lblEstados = new Label();
            txtAlfabeto = new TextBox();
            lblAlfabeto = new Label();
            btnLimpiar = new Button();
            lblEstadoInicial = new Label();
            txtEstadosDeAceptacion = new TextBox();
            lblEstadosDe = new Label();
            lblDeAceptacion = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Location = new Point(613, 401);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 21);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.Location = new Point(37, 18);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(138, 23);
            btnSeleccionarArchivo.TabIndex = 1;
            btnSeleccionarArchivo.Text = "Seleccionar un arhivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Cursor = Cursors.Hand;
            txtRutaArchivo.Location = new Point(77, 47);
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(473, 23);
            txtRutaArchivo.TabIndex = 2;
            txtRutaArchivo.Click += txtRutaArchivo_Click;
            // 
            // lblRutaArchivo
            // 
            lblRutaArchivo.AutoSize = true;
            lblRutaArchivo.Location = new Point(37, 50);
            lblRutaArchivo.Name = "lblRutaArchivo";
            lblRutaArchivo.Size = new Size(34, 15);
            lblRutaArchivo.TabIndex = 3;
            lblRutaArchivo.Text = "Ruta:";
            // 
            // lblContenido
            // 
            lblContenido.AutoSize = true;
            lblContenido.Location = new Point(37, 95);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(127, 15);
            lblContenido.TabIndex = 4;
            lblContenido.Text = "Contenido del archivo:";
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.Location = new Point(37, 112);
            txtContenidoArchivo.Multiline = true;
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.ReadOnly = true;
            txtContenidoArchivo.Size = new Size(301, 243);
            txtContenidoArchivo.TabIndex = 5;
            // 
            // txtEstados
            // 
            txtEstados.Location = new Point(344, 112);
            txtEstados.Multiline = true;
            txtEstados.Name = "txtEstados";
            txtEstados.ReadOnly = true;
            txtEstados.Size = new Size(100, 245);
            txtEstados.TabIndex = 8;
            // 
            // lblEstados
            // 
            lblEstados.AutoSize = true;
            lblEstados.Location = new Point(344, 95);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(50, 15);
            lblEstados.TabIndex = 7;
            lblEstados.Text = "Estados:";
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.Location = new Point(450, 112);
            txtAlfabeto.Multiline = true;
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.ReadOnly = true;
            txtAlfabeto.Size = new Size(100, 245);
            txtAlfabeto.TabIndex = 10;
            // 
            // lblAlfabeto
            // 
            lblAlfabeto.AutoSize = true;
            lblAlfabeto.Location = new Point(450, 95);
            lblAlfabeto.Name = "lblAlfabeto";
            lblAlfabeto.Size = new Size(55, 15);
            lblAlfabeto.TabIndex = 9;
            lblAlfabeto.Text = "Alfabeto:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(182, 18);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstadoInicial
            // 
            lblEstadoInicial.AutoSize = true;
            lblEstadoInicial.Location = new Point(344, 75);
            lblEstadoInicial.Name = "lblEstadoInicial";
            lblEstadoInicial.Size = new Size(76, 15);
            lblEstadoInicial.TabIndex = 12;
            lblEstadoInicial.Text = "Estado inicial";
            lblEstadoInicial.Visible = false;
            // 
            // txtEstadosDeAceptacion
            // 
            txtEstadosDeAceptacion.Location = new Point(556, 110);
            txtEstadosDeAceptacion.Multiline = true;
            txtEstadosDeAceptacion.Name = "txtEstadosDeAceptacion";
            txtEstadosDeAceptacion.ReadOnly = true;
            txtEstadosDeAceptacion.Size = new Size(100, 245);
            txtEstadosDeAceptacion.TabIndex = 14;
            // 
            // lblEstadosDe
            // 
            lblEstadosDe.AutoSize = true;
            lblEstadosDe.Location = new Point(556, 77);
            lblEstadosDe.Name = "lblEstadosDe";
            lblEstadosDe.Size = new Size(47, 15);
            lblEstadosDe.TabIndex = 13;
            lblEstadosDe.Text = "Estados";
            // 
            // lblDeAceptacion
            // 
            lblDeAceptacion.AutoSize = true;
            lblDeAceptacion.Location = new Point(556, 92);
            lblDeAceptacion.Name = "lblDeAceptacion";
            lblDeAceptacion.Size = new Size(84, 15);
            lblDeAceptacion.TabIndex = 15;
            lblDeAceptacion.Text = "de aceptación:";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 434);
            Controls.Add(lblDeAceptacion);
            Controls.Add(txtEstadosDeAceptacion);
            Controls.Add(lblEstadosDe);
            Controls.Add(lblEstadoInicial);
            Controls.Add(btnLimpiar);
            Controls.Add(txtAlfabeto);
            Controls.Add(lblAlfabeto);
            Controls.Add(txtEstados);
            Controls.Add(lblEstados);
            Controls.Add(txtContenidoArchivo);
            Controls.Add(lblContenido);
            Controls.Add(lblRutaArchivo);
            Controls.Add(txtRutaArchivo);
            Controls.Add(btnSeleccionarArchivo);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Análisis de archivo de texto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnSeleccionarArchivo;
        private TextBox txtRutaArchivo;
        private Label lblRutaArchivo;
        private Label lblContenido;
        private TextBox txtContenidoArchivo;
        private TextBox txtEstados;
        private Label lblEstados;
        private TextBox txtAlfabeto;
        private Label lblAlfabeto;
        private Button btnLimpiar;
        private Label lblEstadoInicial;
        private TextBox txtEstadosDeAceptacion;
        private Label lblEstadosDe;
        private Label lblDeAceptacion;
    }
}