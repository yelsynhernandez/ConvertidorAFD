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
            txtRutaArchivo = new TextBox();
            lblContenido = new Label();
            lblEstados = new Label();
            lblAlfabeto = new Label();
            btnLimpiar = new Button();
            lblEstadosDeAceptacion = new Label();
            tlpBase = new TableLayoutPanel();
            lblTitulo = new Label();
            txtContenidoArchivo = new TextBox();
            txtEstados = new TextBox();
            txtAlfabeto = new TextBox();
            txtEstadosDeAceptacion = new TextBox();
            dgvMatrizTransicion1 = new DataGridView();
            lblTablaTransicion = new Label();
            dgvMatrizTransicion2 = new DataGridView();
            label1 = new Label();
            btnCerrar = new Button();
            lblEstadoInicial = new Label();
            tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTransicion1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTransicion2).BeginInit();
            SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.AllowDrop = true;
            txtRutaArchivo.Anchor = AnchorStyles.None;
            txtRutaArchivo.BackColor = Color.FromArgb(13, 19, 33);
            txtRutaArchivo.BorderStyle = BorderStyle.FixedSingle;
            tlpBase.SetColumnSpan(txtRutaArchivo, 2);
            txtRutaArchivo.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            txtRutaArchivo.ForeColor = Color.FromArgb(240, 235, 216);
            txtRutaArchivo.Location = new Point(4, 90);
            txtRutaArchivo.Margin = new Padding(4);
            txtRutaArchivo.MaxLength = 500;
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(714, 25);
            txtRutaArchivo.TabIndex = 4;
            txtRutaArchivo.DragDrop += TxtRutaArchivo_DragDrop;
            // 
            // lblContenido
            // 
            lblContenido.Anchor = AnchorStyles.Bottom;
            lblContenido.AutoSize = true;
            lblContenido.BackColor = Color.Transparent;
            lblContenido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContenido.ForeColor = Color.FromArgb(240, 235, 216);
            lblContenido.Location = new Point(168, 135);
            lblContenido.Margin = new Padding(4, 0, 4, 0);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(164, 20);
            lblContenido.TabIndex = 5;
            lblContenido.Text = "Contenido del archivo:";
            // 
            // lblEstados
            // 
            lblEstados.Anchor = AnchorStyles.Bottom;
            lblEstados.AutoSize = true;
            lblEstados.BackColor = Color.Transparent;
            lblEstados.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstados.ForeColor = Color.FromArgb(240, 235, 216);
            lblEstados.Location = new Point(579, 135);
            lblEstados.Margin = new Padding(4, 0, 4, 0);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(64, 20);
            lblEstados.TabIndex = 6;
            lblEstados.Text = "Estados:";
            // 
            // lblAlfabeto
            // 
            lblAlfabeto.Anchor = AnchorStyles.Bottom;
            lblAlfabeto.AutoSize = true;
            lblAlfabeto.BackColor = Color.Transparent;
            lblAlfabeto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlfabeto.ForeColor = Color.FromArgb(240, 235, 216);
            lblAlfabeto.Location = new Point(797, 135);
            lblAlfabeto.Margin = new Padding(4, 0, 4, 0);
            lblAlfabeto.Name = "lblAlfabeto";
            lblAlfabeto.Size = new Size(71, 20);
            lblAlfabeto.TabIndex = 7;
            lblAlfabeto.Text = "Alfabeto:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top;
            btnLimpiar.BackColor = Color.FromArgb(116, 140, 171);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(13, 19, 33);
            btnLimpiar.Location = new Point(759, 89);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 27);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // lblEstadosDeAceptacion
            // 
            lblEstadosDeAceptacion.Anchor = AnchorStyles.Bottom;
            lblEstadosDeAceptacion.AutoSize = true;
            lblEstadosDeAceptacion.BackColor = Color.Transparent;
            lblEstadosDeAceptacion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadosDeAceptacion.ForeColor = Color.FromArgb(240, 235, 216);
            lblEstadosDeAceptacion.Location = new Point(976, 135);
            lblEstadosDeAceptacion.Margin = new Padding(4, 0, 4, 0);
            lblEstadosDeAceptacion.Name = "lblEstadosDeAceptacion";
            lblEstadosDeAceptacion.Size = new Size(159, 20);
            lblEstadosDeAceptacion.TabIndex = 8;
            lblEstadosDeAceptacion.Text = "Estados de aceptación";
            // 
            // tlpBase
            // 
            tlpBase.BackColor = Color.FromArgb(29, 45, 68);
            tlpBase.BackgroundImageLayout = ImageLayout.Stretch;
            tlpBase.ColumnCount = 4;
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.86327F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0455761F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.04558F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.04558F));
            tlpBase.Controls.Add(lblTitulo, 0, 0);
            tlpBase.Controls.Add(lblContenido, 0, 3);
            tlpBase.Controls.Add(lblEstados, 1, 3);
            tlpBase.Controls.Add(lblAlfabeto, 2, 3);
            tlpBase.Controls.Add(lblEstadosDeAceptacion, 3, 3);
            tlpBase.Controls.Add(txtContenidoArchivo, 0, 4);
            tlpBase.Controls.Add(txtEstados, 1, 4);
            tlpBase.Controls.Add(txtAlfabeto, 2, 4);
            tlpBase.Controls.Add(txtEstadosDeAceptacion, 3, 4);
            tlpBase.Controls.Add(dgvMatrizTransicion1, 0, 6);
            tlpBase.Controls.Add(lblTablaTransicion, 0, 5);
            tlpBase.Controls.Add(dgvMatrizTransicion2, 1, 6);
            tlpBase.Controls.Add(label1, 1, 5);
            tlpBase.Controls.Add(btnCerrar, 3, 7);
            tlpBase.Controls.Add(txtRutaArchivo, 0, 2);
            tlpBase.Controls.Add(btnLimpiar, 2, 2);
            tlpBase.Controls.Add(lblEstadoInicial, 3, 2);
            tlpBase.Dock = DockStyle.Fill;
            tlpBase.Location = new Point(0, 0);
            tlpBase.Margin = new Padding(4);
            tlpBase.Name = "tlpBase";
            tlpBase.RowCount = 8;
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpBase.Size = new Size(1168, 695);
            tlpBase.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Bottom;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            tlpBase.SetColumnSpan(lblTitulo, 4);
            lblTitulo.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(240, 235, 216);
            lblTitulo.Location = new Point(438, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 31);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Convertidor de AFN a AFD";
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.BackColor = Color.FromArgb(62, 92, 118);
            txtContenidoArchivo.BorderStyle = BorderStyle.FixedSingle;
            txtContenidoArchivo.Dock = DockStyle.Fill;
            txtContenidoArchivo.Location = new Point(4, 159);
            txtContenidoArchivo.Margin = new Padding(4);
            txtContenidoArchivo.Multiline = true;
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.ReadOnly = true;
            txtContenidoArchivo.Size = new Size(492, 151);
            txtContenidoArchivo.TabIndex = 10;
            // 
            // txtEstados
            // 
            txtEstados.BackColor = Color.FromArgb(62, 92, 118);
            txtEstados.BorderStyle = BorderStyle.FixedSingle;
            txtEstados.Dock = DockStyle.Fill;
            txtEstados.Location = new Point(504, 159);
            txtEstados.Margin = new Padding(4);
            txtEstados.Multiline = true;
            txtEstados.Name = "txtEstados";
            txtEstados.ReadOnly = true;
            txtEstados.Size = new Size(214, 151);
            txtEstados.TabIndex = 11;
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.BackColor = Color.FromArgb(62, 92, 118);
            txtAlfabeto.BorderStyle = BorderStyle.FixedSingle;
            txtAlfabeto.Dock = DockStyle.Fill;
            txtAlfabeto.Location = new Point(726, 159);
            txtAlfabeto.Margin = new Padding(4);
            txtAlfabeto.Multiline = true;
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.ReadOnly = true;
            txtAlfabeto.Size = new Size(214, 151);
            txtAlfabeto.TabIndex = 12;
            // 
            // txtEstadosDeAceptacion
            // 
            txtEstadosDeAceptacion.BackColor = Color.FromArgb(62, 92, 118);
            txtEstadosDeAceptacion.BorderStyle = BorderStyle.FixedSingle;
            txtEstadosDeAceptacion.Dock = DockStyle.Fill;
            txtEstadosDeAceptacion.Location = new Point(948, 159);
            txtEstadosDeAceptacion.Margin = new Padding(4);
            txtEstadosDeAceptacion.Multiline = true;
            txtEstadosDeAceptacion.Name = "txtEstadosDeAceptacion";
            txtEstadosDeAceptacion.ReadOnly = true;
            txtEstadosDeAceptacion.Size = new Size(216, 151);
            txtEstadosDeAceptacion.TabIndex = 13;
            // 
            // dgvMatrizTransicion1
            // 
            dgvMatrizTransicion1.AllowUserToAddRows = false;
            dgvMatrizTransicion1.AllowUserToDeleteRows = false;
            dgvMatrizTransicion1.AllowUserToResizeColumns = false;
            dgvMatrizTransicion1.AllowUserToResizeRows = false;
            dgvMatrizTransicion1.BackgroundColor = Color.FromArgb(61, 92, 118);
            dgvMatrizTransicion1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrizTransicion1.Dock = DockStyle.Fill;
            dgvMatrizTransicion1.GridColor = SystemColors.Control;
            dgvMatrizTransicion1.Location = new Point(4, 353);
            dgvMatrizTransicion1.Margin = new Padding(4);
            dgvMatrizTransicion1.Name = "dgvMatrizTransicion1";
            dgvMatrizTransicion1.ReadOnly = true;
            dgvMatrizTransicion1.RowHeadersWidth = 51;
            dgvMatrizTransicion1.RowTemplate.Height = 25;
            dgvMatrizTransicion1.Size = new Size(492, 287);
            dgvMatrizTransicion1.TabIndex = 14;
            // 
            // lblTablaTransicion
            // 
            lblTablaTransicion.Anchor = AnchorStyles.Bottom;
            lblTablaTransicion.AutoSize = true;
            lblTablaTransicion.BackColor = Color.Transparent;
            lblTablaTransicion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTablaTransicion.ForeColor = Color.FromArgb(240, 235, 216);
            lblTablaTransicion.Location = new Point(172, 329);
            lblTablaTransicion.Margin = new Padding(4, 0, 4, 0);
            lblTablaTransicion.Name = "lblTablaTransicion";
            lblTablaTransicion.Size = new Size(155, 20);
            lblTablaTransicion.TabIndex = 9;
            lblTablaTransicion.Text = "Matriz de transición 1";
            // 
            // dgvMatrizTransicion2
            // 
            dgvMatrizTransicion2.AllowUserToAddRows = false;
            dgvMatrizTransicion2.AllowUserToDeleteRows = false;
            dgvMatrizTransicion2.AllowUserToResizeColumns = false;
            dgvMatrizTransicion2.AllowUserToResizeRows = false;
            dgvMatrizTransicion2.BackgroundColor = Color.FromArgb(62, 92, 118);
            dgvMatrizTransicion2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpBase.SetColumnSpan(dgvMatrizTransicion2, 3);
            dgvMatrizTransicion2.Dock = DockStyle.Fill;
            dgvMatrizTransicion2.GridColor = SystemColors.Control;
            dgvMatrizTransicion2.Location = new Point(504, 353);
            dgvMatrizTransicion2.Margin = new Padding(4);
            dgvMatrizTransicion2.Name = "dgvMatrizTransicion2";
            dgvMatrizTransicion2.ReadOnly = true;
            dgvMatrizTransicion2.RowHeadersWidth = 51;
            dgvMatrizTransicion2.RowTemplate.Height = 25;
            dgvMatrizTransicion2.Size = new Size(660, 287);
            dgvMatrizTransicion2.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            tlpBase.SetColumnSpan(label1, 3);
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(240, 235, 216);
            label1.Location = new Point(755, 329);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 18;
            label1.Text = "Matriz de transición 2";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(116, 140, 171);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(13, 19, 33);
            btnCerrar.Location = new Point(1005, 652);
            btnCerrar.Margin = new Padding(4, 4, 15, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(148, 28);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // lblEstadoInicial
            // 
            lblEstadoInicial.Anchor = AnchorStyles.Bottom;
            lblEstadoInicial.AutoSize = true;
            lblEstadoInicial.BackColor = Color.Transparent;
            lblEstadoInicial.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoInicial.ForeColor = Color.FromArgb(240, 235, 216);
            lblEstadoInicial.Location = new Point(1002, 94);
            lblEstadoInicial.Margin = new Padding(4, 0, 4, 6);
            lblEstadoInicial.Name = "lblEstadoInicial";
            lblEstadoInicial.Size = new Size(108, 20);
            lblEstadoInicial.TabIndex = 2;
            lblEstadoInicial.Text = "[Estado inicial]";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1168, 695);
            Controls.Add(tlpBase);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leer autómata";
            Load += FrmPrincipal_Load;
            tlpBase.ResumeLayout(false);
            tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTransicion1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTransicion2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtRutaArchivo;
        private Label lblContenido;
        private Label lblEstados;
        private Label lblAlfabeto;
        private Button btnLimpiar;
        private Label lblEstadosDeAceptacion;
        private TableLayoutPanel tlpBase;
        private TextBox txtEstados;
        private Button btnCerrar;
        private TextBox txtContenidoArchivo;
        private TextBox txtAlfabeto;
        private TextBox txtEstadosDeAceptacion;
        private Label lblEstadoInicial;
        private DataGridView dgvMatrizTransicion1;
        private Label lblTablaTransicion;
        private Label lblTitulo;
        private DataGridView dgvMatrizTransicion2;
        private Label label1;
    }
}