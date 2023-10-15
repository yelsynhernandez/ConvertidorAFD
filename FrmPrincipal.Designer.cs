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
            dgvTablaTransicion = new DataGridView();
            lblTablaTransicion = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnCerrar = new Button();
            lblEstadoInicial = new Label();
            tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaTransicion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtRutaArchivo.Location = new Point(4, 101);
            txtRutaArchivo.Margin = new Padding(4, 5, 4, 5);
            txtRutaArchivo.MaxLength = 500;
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(714, 25);
            txtRutaArchivo.TabIndex = 4;
            txtRutaArchivo.DragDrop += txtRutaArchivo_DragDrop;
            // 
            // lblContenido
            // 
            lblContenido.Anchor = AnchorStyles.Bottom;
            lblContenido.AutoSize = true;
            lblContenido.BackColor = Color.Transparent;
            lblContenido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContenido.ForeColor = Color.LightYellow;
            lblContenido.Location = new Point(168, 154);
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
            lblEstados.ForeColor = Color.LightYellow;
            lblEstados.Location = new Point(579, 154);
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
            lblAlfabeto.ForeColor = Color.LightYellow;
            lblAlfabeto.Location = new Point(797, 154);
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
            btnLimpiar.ForeColor = Color.FromArgb(240, 235, 216);
            btnLimpiar.Location = new Point(759, 99);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 28);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstadosDeAceptacion
            // 
            lblEstadosDeAceptacion.Anchor = AnchorStyles.Bottom;
            lblEstadosDeAceptacion.AutoSize = true;
            lblEstadosDeAceptacion.BackColor = Color.Transparent;
            lblEstadosDeAceptacion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadosDeAceptacion.ForeColor = Color.LightYellow;
            lblEstadosDeAceptacion.Location = new Point(976, 154);
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
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.003F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3313332F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3313332F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3313332F));
            tlpBase.Controls.Add(lblTitulo, 0, 0);
            tlpBase.Controls.Add(lblContenido, 0, 3);
            tlpBase.Controls.Add(lblEstados, 1, 3);
            tlpBase.Controls.Add(lblAlfabeto, 2, 3);
            tlpBase.Controls.Add(lblEstadosDeAceptacion, 3, 3);
            tlpBase.Controls.Add(txtContenidoArchivo, 0, 4);
            tlpBase.Controls.Add(txtEstados, 1, 4);
            tlpBase.Controls.Add(txtAlfabeto, 2, 4);
            tlpBase.Controls.Add(txtEstadosDeAceptacion, 3, 4);
            tlpBase.Controls.Add(dgvTablaTransicion, 0, 6);
            tlpBase.Controls.Add(lblTablaTransicion, 0, 5);
            tlpBase.Controls.Add(dataGridView1, 1, 6);
            tlpBase.Controls.Add(label1, 1, 5);
            tlpBase.Controls.Add(btnCerrar, 3, 7);
            tlpBase.Controls.Add(txtRutaArchivo, 0, 2);
            tlpBase.Controls.Add(btnLimpiar, 2, 2);
            tlpBase.Controls.Add(lblEstadoInicial, 3, 2);
            tlpBase.Dock = DockStyle.Fill;
            tlpBase.Location = new Point(0, 0);
            tlpBase.Margin = new Padding(4, 5, 4, 5);
            tlpBase.Name = "tlpBase";
            tlpBase.RowCount = 8;
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 164F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 388F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpBase.Size = new Size(1168, 818);
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
            lblTitulo.Location = new Point(438, 24);
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
            txtContenidoArchivo.Location = new Point(4, 179);
            txtContenidoArchivo.Margin = new Padding(4, 5, 4, 5);
            txtContenidoArchivo.Multiline = true;
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.ReadOnly = true;
            txtContenidoArchivo.Size = new Size(492, 154);
            txtContenidoArchivo.TabIndex = 10;
            // 
            // txtEstados
            // 
            txtEstados.BackColor = Color.FromArgb(62, 92, 118);
            txtEstados.BorderStyle = BorderStyle.FixedSingle;
            txtEstados.Dock = DockStyle.Fill;
            txtEstados.Location = new Point(504, 179);
            txtEstados.Margin = new Padding(4, 5, 4, 5);
            txtEstados.Multiline = true;
            txtEstados.Name = "txtEstados";
            txtEstados.ReadOnly = true;
            txtEstados.Size = new Size(214, 154);
            txtEstados.TabIndex = 11;
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.BackColor = Color.FromArgb(62, 92, 118);
            txtAlfabeto.BorderStyle = BorderStyle.FixedSingle;
            txtAlfabeto.Dock = DockStyle.Fill;
            txtAlfabeto.Location = new Point(726, 179);
            txtAlfabeto.Margin = new Padding(4, 5, 4, 5);
            txtAlfabeto.Multiline = true;
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.ReadOnly = true;
            txtAlfabeto.Size = new Size(214, 154);
            txtAlfabeto.TabIndex = 12;
            // 
            // txtEstadosDeAceptacion
            // 
            txtEstadosDeAceptacion.BackColor = Color.FromArgb(62, 92, 118);
            txtEstadosDeAceptacion.BorderStyle = BorderStyle.FixedSingle;
            txtEstadosDeAceptacion.Dock = DockStyle.Fill;
            txtEstadosDeAceptacion.Location = new Point(948, 179);
            txtEstadosDeAceptacion.Margin = new Padding(4, 5, 4, 5);
            txtEstadosDeAceptacion.Multiline = true;
            txtEstadosDeAceptacion.Name = "txtEstadosDeAceptacion";
            txtEstadosDeAceptacion.ReadOnly = true;
            txtEstadosDeAceptacion.Size = new Size(216, 154);
            txtEstadosDeAceptacion.TabIndex = 13;
            // 
            // dgvTablaTransicion
            // 
            dgvTablaTransicion.AllowUserToAddRows = false;
            dgvTablaTransicion.AllowUserToDeleteRows = false;
            dgvTablaTransicion.AllowUserToResizeColumns = false;
            dgvTablaTransicion.AllowUserToResizeRows = false;
            dgvTablaTransicion.BackgroundColor = Color.FromArgb(62, 92, 118);
            dgvTablaTransicion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaTransicion.Dock = DockStyle.Fill;
            dgvTablaTransicion.GridColor = SystemColors.Control;
            dgvTablaTransicion.Location = new Point(4, 376);
            dgvTablaTransicion.Margin = new Padding(4, 5, 4, 5);
            dgvTablaTransicion.Name = "dgvTablaTransicion";
            dgvTablaTransicion.ReadOnly = true;
            dgvTablaTransicion.RowHeadersWidth = 51;
            dgvTablaTransicion.RowTemplate.Height = 25;
            dgvTablaTransicion.Size = new Size(492, 378);
            dgvTablaTransicion.TabIndex = 14;
            // 
            // lblTablaTransicion
            // 
            lblTablaTransicion.Anchor = AnchorStyles.Bottom;
            lblTablaTransicion.AutoSize = true;
            lblTablaTransicion.BackColor = Color.Transparent;
            lblTablaTransicion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTablaTransicion.ForeColor = Color.LightYellow;
            lblTablaTransicion.Location = new Point(172, 351);
            lblTablaTransicion.Margin = new Padding(4, 0, 4, 0);
            lblTablaTransicion.Name = "lblTablaTransicion";
            lblTablaTransicion.Size = new Size(155, 20);
            lblTablaTransicion.TabIndex = 9;
            lblTablaTransicion.Text = "Matriz de transición 1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(62, 92, 118);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpBase.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(504, 376);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(660, 378);
            dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            tlpBase.SetColumnSpan(label1, 3);
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(755, 351);
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
            btnCerrar.ForeColor = Color.FromArgb(240, 235, 216);
            btnCerrar.Location = new Point(1005, 772);
            btnCerrar.Margin = new Padding(4, 5, 15, 18);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(148, 28);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEstadoInicial
            // 
            lblEstadoInicial.Anchor = AnchorStyles.Bottom;
            lblEstadoInicial.AutoSize = true;
            lblEstadoInicial.BackColor = Color.Transparent;
            lblEstadoInicial.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoInicial.ForeColor = Color.LightYellow;
            lblEstadoInicial.Location = new Point(1002, 106);
            lblEstadoInicial.Margin = new Padding(4, 0, 4, 7);
            lblEstadoInicial.Name = "lblEstadoInicial";
            lblEstadoInicial.Size = new Size(108, 20);
            lblEstadoInicial.TabIndex = 2;
            lblEstadoInicial.Text = "[Estado inicial]";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1168, 818);
            Controls.Add(tlpBase);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leer autómata";
            Load += FrmPrincipal_Load;
            tlpBase.ResumeLayout(false);
            tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaTransicion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dgvTablaTransicion;
        private Label lblTablaTransicion;
        private Label lblTitulo;
        private DataGridView dataGridView1;
        private Label label1;
    }
}