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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblMatrizTransicion1 = new Label();
            dgvMatrizTransicion2 = new DataGridView();
            lblMatrizTransicion2 = new Label();
            btnCerrar = new Button();
            lblEstadoInicial = new Label();
            lblAutor = new Label();
            tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTransicion1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTransicion2).BeginInit();
            SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.AllowDrop = true;
            txtRutaArchivo.BackColor = Color.FromArgb(233, 236, 239);
            txtRutaArchivo.BorderStyle = BorderStyle.FixedSingle;
            tlpBase.SetColumnSpan(txtRutaArchivo, 2);
            txtRutaArchivo.Dock = DockStyle.Fill;
            txtRutaArchivo.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            txtRutaArchivo.ForeColor = Color.FromArgb(108, 117, 125);
            txtRutaArchivo.Location = new Point(4, 94);
            txtRutaArchivo.Margin = new Padding(4);
            txtRutaArchivo.MaxLength = 500;
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(773, 26);
            txtRutaArchivo.TabIndex = 4;
            txtRutaArchivo.DragDrop += TxtRutaArchivo_DragDrop;
            // 
            // lblContenido
            // 
            lblContenido.Anchor = AnchorStyles.Bottom;
            lblContenido.AutoSize = true;
            lblContenido.BackColor = Color.Transparent;
            lblContenido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContenido.ForeColor = Color.FromArgb(33, 37, 41);
            lblContenido.Location = new Point(183, 149);
            lblContenido.Margin = new Padding(4, 0, 4, 0);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(175, 21);
            lblContenido.TabIndex = 5;
            lblContenido.Text = "Contenido del archivo:";
            // 
            // lblEstados
            // 
            lblEstados.Anchor = AnchorStyles.Bottom;
            lblEstados.AutoSize = true;
            lblEstados.BackColor = Color.Transparent;
            lblEstados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstados.ForeColor = Color.FromArgb(33, 37, 41);
            lblEstados.Location = new Point(626, 149);
            lblEstados.Margin = new Padding(4, 0, 4, 0);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(70, 21);
            lblEstados.TabIndex = 6;
            lblEstados.Text = "Estados:";
            // 
            // lblAlfabeto
            // 
            lblAlfabeto.Anchor = AnchorStyles.Bottom;
            lblAlfabeto.AutoSize = true;
            lblAlfabeto.BackColor = Color.Transparent;
            lblAlfabeto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlfabeto.ForeColor = Color.FromArgb(33, 37, 41);
            lblAlfabeto.Location = new Point(862, 149);
            lblAlfabeto.Margin = new Padding(4, 0, 4, 0);
            lblAlfabeto.Name = "lblAlfabeto";
            lblAlfabeto.Size = new Size(78, 21);
            lblAlfabeto.TabIndex = 7;
            lblAlfabeto.Text = "Alfabeto:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top;
            btnLimpiar.BackColor = Color.FromArgb(0, 80, 157);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(233, 236, 239);
            btnLimpiar.Location = new Point(818, 94);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(165, 29);
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
            lblEstadosDeAceptacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadosDeAceptacion.ForeColor = Color.FromArgb(33, 37, 41);
            lblEstadosDeAceptacion.Location = new Point(1056, 149);
            lblEstadosDeAceptacion.Margin = new Padding(4, 0, 4, 0);
            lblEstadosDeAceptacion.Name = "lblEstadosDeAceptacion";
            lblEstadosDeAceptacion.Size = new Size(173, 21);
            lblEstadosDeAceptacion.TabIndex = 8;
            lblEstadosDeAceptacion.Text = "Estados de aceptación";
            // 
            // tlpBase
            // 
            tlpBase.BackColor = Color.FromArgb(248, 249, 250);
            tlpBase.BackgroundImageLayout = ImageLayout.Stretch;
            tlpBase.ColumnCount = 4;
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.86327F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.045578F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.045578F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.045578F));
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
            tlpBase.Controls.Add(lblMatrizTransicion1, 0, 5);
            tlpBase.Controls.Add(dgvMatrizTransicion2, 1, 6);
            tlpBase.Controls.Add(lblMatrizTransicion2, 1, 5);
            tlpBase.Controls.Add(btnCerrar, 3, 7);
            tlpBase.Controls.Add(txtRutaArchivo, 0, 2);
            tlpBase.Controls.Add(btnLimpiar, 2, 2);
            tlpBase.Controls.Add(lblEstadoInicial, 3, 2);
            tlpBase.Controls.Add(lblAutor, 0, 1);
            tlpBase.Dock = DockStyle.Fill;
            tlpBase.Location = new Point(0, 0);
            tlpBase.Margin = new Padding(4);
            tlpBase.Name = "tlpBase";
            tlpBase.RowCount = 8;
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpBase.Size = new Size(1264, 561);
            tlpBase.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Bottom;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            tlpBase.SetColumnSpan(lblTitulo, 4);
            lblTitulo.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(386, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(492, 31);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Sistema de conversión de matrices AFN a AFD";
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.BackColor = Color.FromArgb(233, 236, 239);
            txtContenidoArchivo.BorderStyle = BorderStyle.FixedSingle;
            txtContenidoArchivo.Dock = DockStyle.Fill;
            txtContenidoArchivo.Location = new Point(4, 174);
            txtContenidoArchivo.Margin = new Padding(4);
            txtContenidoArchivo.Multiline = true;
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.ReadOnly = true;
            txtContenidoArchivo.Size = new Size(533, 108);
            txtContenidoArchivo.TabIndex = 10;
            // 
            // txtEstados
            // 
            txtEstados.BackColor = Color.FromArgb(233, 236, 239);
            txtEstados.BorderStyle = BorderStyle.FixedSingle;
            txtEstados.Dock = DockStyle.Fill;
            txtEstados.Location = new Point(545, 174);
            txtEstados.Margin = new Padding(4);
            txtEstados.Multiline = true;
            txtEstados.Name = "txtEstados";
            txtEstados.ReadOnly = true;
            txtEstados.Size = new Size(232, 108);
            txtEstados.TabIndex = 11;
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.BackColor = Color.FromArgb(233, 236, 239);
            txtAlfabeto.BorderStyle = BorderStyle.FixedSingle;
            txtAlfabeto.Dock = DockStyle.Fill;
            txtAlfabeto.Location = new Point(785, 174);
            txtAlfabeto.Margin = new Padding(4);
            txtAlfabeto.Multiline = true;
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.ReadOnly = true;
            txtAlfabeto.Size = new Size(232, 108);
            txtAlfabeto.TabIndex = 12;
            // 
            // txtEstadosDeAceptacion
            // 
            txtEstadosDeAceptacion.BackColor = Color.FromArgb(233, 236, 239);
            txtEstadosDeAceptacion.BorderStyle = BorderStyle.FixedSingle;
            txtEstadosDeAceptacion.Dock = DockStyle.Fill;
            txtEstadosDeAceptacion.Location = new Point(1025, 174);
            txtEstadosDeAceptacion.Margin = new Padding(4);
            txtEstadosDeAceptacion.Multiline = true;
            txtEstadosDeAceptacion.Name = "txtEstadosDeAceptacion";
            txtEstadosDeAceptacion.ReadOnly = true;
            txtEstadosDeAceptacion.Size = new Size(235, 108);
            txtEstadosDeAceptacion.TabIndex = 13;
            // 
            // dgvMatrizTransicion1
            // 
            dgvMatrizTransicion1.AllowUserToAddRows = false;
            dgvMatrizTransicion1.AllowUserToDeleteRows = false;
            dgvMatrizTransicion1.AllowUserToResizeColumns = false;
            dgvMatrizTransicion1.AllowUserToResizeRows = false;
            dgvMatrizTransicion1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvMatrizTransicion1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMatrizTransicion1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatrizTransicion1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrizTransicion1.Dock = DockStyle.Fill;
            dgvMatrizTransicion1.GridColor = SystemColors.ActiveBorder;
            dgvMatrizTransicion1.Location = new Point(4, 330);
            dgvMatrizTransicion1.Margin = new Padding(4);
            dgvMatrizTransicion1.Name = "dgvMatrizTransicion1";
            dgvMatrizTransicion1.ReadOnly = true;
            dgvMatrizTransicion1.RowHeadersWidth = 51;
            dgvMatrizTransicion1.RowTemplate.Height = 25;
            dgvMatrizTransicion1.Size = new Size(533, 166);
            dgvMatrizTransicion1.TabIndex = 14;
            // 
            // lblMatrizTransicion1
            // 
            lblMatrizTransicion1.Anchor = AnchorStyles.Bottom;
            lblMatrizTransicion1.AutoSize = true;
            lblMatrizTransicion1.BackColor = Color.Transparent;
            lblMatrizTransicion1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatrizTransicion1.ForeColor = Color.FromArgb(33, 37, 41);
            lblMatrizTransicion1.Location = new Point(188, 305);
            lblMatrizTransicion1.Margin = new Padding(4, 0, 4, 0);
            lblMatrizTransicion1.Name = "lblMatrizTransicion1";
            lblMatrizTransicion1.Size = new Size(164, 21);
            lblMatrizTransicion1.TabIndex = 9;
            lblMatrizTransicion1.Text = "Matriz de transición 1";
            // 
            // dgvMatrizTransicion2
            // 
            dgvMatrizTransicion2.AllowUserToAddRows = false;
            dgvMatrizTransicion2.AllowUserToDeleteRows = false;
            dgvMatrizTransicion2.AllowUserToResizeColumns = false;
            dgvMatrizTransicion2.AllowUserToResizeRows = false;
            dgvMatrizTransicion2.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvMatrizTransicion2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMatrizTransicion2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMatrizTransicion2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpBase.SetColumnSpan(dgvMatrizTransicion2, 3);
            dgvMatrizTransicion2.Dock = DockStyle.Fill;
            dgvMatrizTransicion2.GridColor = SystemColors.Control;
            dgvMatrizTransicion2.Location = new Point(545, 330);
            dgvMatrizTransicion2.Margin = new Padding(4);
            dgvMatrizTransicion2.Name = "dgvMatrizTransicion2";
            dgvMatrizTransicion2.ReadOnly = true;
            dgvMatrizTransicion2.RowHeadersWidth = 51;
            dgvMatrizTransicion2.RowTemplate.Height = 25;
            dgvMatrizTransicion2.Size = new Size(715, 166);
            dgvMatrizTransicion2.TabIndex = 19;
            // 
            // lblMatrizTransicion2
            // 
            lblMatrizTransicion2.Anchor = AnchorStyles.Bottom;
            lblMatrizTransicion2.AutoSize = true;
            lblMatrizTransicion2.BackColor = Color.Transparent;
            tlpBase.SetColumnSpan(lblMatrizTransicion2, 3);
            lblMatrizTransicion2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatrizTransicion2.ForeColor = Color.FromArgb(33, 37, 41);
            lblMatrizTransicion2.Location = new Point(819, 305);
            lblMatrizTransicion2.Margin = new Padding(4, 0, 4, 0);
            lblMatrizTransicion2.Name = "lblMatrizTransicion2";
            lblMatrizTransicion2.Size = new Size(167, 21);
            lblMatrizTransicion2.TabIndex = 18;
            lblMatrizTransicion2.Text = "Matriz de transición 2";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(0, 80, 157);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(233, 236, 239);
            btnCerrar.Location = new Point(1081, 515);
            btnCerrar.Margin = new Padding(4, 4, 17, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(166, 30);
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
            lblEstadoInicial.ForeColor = Color.FromArgb(33, 37, 41);
            lblEstadoInicial.Location = new Point(1088, 104);
            lblEstadoInicial.Margin = new Padding(4, 0, 4, 6);
            lblEstadoInicial.Name = "lblEstadoInicial";
            lblEstadoInicial.Size = new Size(108, 20);
            lblEstadoInicial.TabIndex = 2;
            lblEstadoInicial.Text = "[Estado inicial]";
            // 
            // lblAutor
            // 
            lblAutor.Anchor = AnchorStyles.Top;
            lblAutor.AutoSize = true;
            tlpBase.SetColumnSpan(lblAutor, 4);
            lblAutor.ForeColor = Color.FromArgb(33, 37, 41);
            lblAutor.Location = new Point(600, 50);
            lblAutor.Name = "lblAutor";
            lblAutor.Padding = new Padding(0, 5, 0, 0);
            lblAutor.Size = new Size(63, 23);
            lblAutor.TabIndex = 20;
            lblAutor.Text = "[Autor]";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1264, 561);
            Controls.Add(tlpBase);
            Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
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
        private Label lblMatrizTransicion1;
        private Label lblTitulo;
        private DataGridView dgvMatrizTransicion2;
        private Label lblMatrizTransicion2;
        private Label lblAutor;
    }
}