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
            lblRutaArchivo = new Label();
            lblContenido = new Label();
            lblEstados = new Label();
            lblAlfabeto = new Label();
            btnLimpiar = new Button();
            lblEstadosDeAceptacion = new Label();
            tlpBase = new TableLayoutPanel();
            lblEstadoInicial = new Label();
            txtContenidoArchivo = new TextBox();
            txtEstados = new TextBox();
            txtAlfabeto = new TextBox();
            txtEstadosDeAceptacion = new TextBox();
            btnCerrar = new Button();
            dgvTablaTransicion = new DataGridView();
            lblTablaTransicion = new Label();
            tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaTransicion).BeginInit();
            SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.AllowDrop = true;
            txtRutaArchivo.BackColor = SystemColors.Menu;
            tlpBase.SetColumnSpan(txtRutaArchivo, 3);
            txtRutaArchivo.Dock = DockStyle.Bottom;
            txtRutaArchivo.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            txtRutaArchivo.Location = new Point(354, 64);
            txtRutaArchivo.Margin = new Padding(4, 5, 4, 5);
            txtRutaArchivo.MaxLength = 500;
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(457, 25);
            txtRutaArchivo.TabIndex = 4;
            txtRutaArchivo.DragDrop += txtRutaArchivo_DragDrop;
            // 
            // lblRutaArchivo
            // 
            lblRutaArchivo.Anchor = AnchorStyles.Right;
            lblRutaArchivo.AutoSize = true;
            lblRutaArchivo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRutaArchivo.ForeColor = SystemColors.HotTrack;
            lblRutaArchivo.Location = new Point(302, 64);
            lblRutaArchivo.Margin = new Padding(4, 8, 4, 0);
            lblRutaArchivo.Name = "lblRutaArchivo";
            lblRutaArchivo.Size = new Size(44, 20);
            lblRutaArchivo.TabIndex = 3;
            lblRutaArchivo.Text = "Ruta:";
            // 
            // lblContenido
            // 
            lblContenido.Anchor = AnchorStyles.Bottom;
            lblContenido.AutoSize = true;
            lblContenido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContenido.ForeColor = SystemColors.HotTrack;
            lblContenido.Location = new Point(93, 142);
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
            lblEstados.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstados.ForeColor = SystemColors.HotTrack;
            lblEstados.Location = new Point(395, 142);
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
            lblAlfabeto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlfabeto.ForeColor = SystemColors.HotTrack;
            lblAlfabeto.Location = new Point(547, 142);
            lblAlfabeto.Margin = new Padding(4, 0, 4, 0);
            lblAlfabeto.Name = "lblAlfabeto";
            lblAlfabeto.Size = new Size(71, 20);
            lblAlfabeto.TabIndex = 7;
            lblAlfabeto.Text = "Alfabeto:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom;
            btnLimpiar.BackColor = SystemColors.GradientInactiveCaption;
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(354, 9);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 33);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstadosDeAceptacion
            // 
            lblEstadosDeAceptacion.Anchor = AnchorStyles.Bottom;
            lblEstadosDeAceptacion.AutoSize = true;
            lblEstadosDeAceptacion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadosDeAceptacion.ForeColor = SystemColors.HotTrack;
            lblEstadosDeAceptacion.Location = new Point(695, 122);
            lblEstadosDeAceptacion.Margin = new Padding(4, 0, 4, 0);
            lblEstadosDeAceptacion.Name = "lblEstadosDeAceptacion";
            lblEstadosDeAceptacion.Size = new Size(85, 40);
            lblEstadosDeAceptacion.TabIndex = 8;
            lblEstadosDeAceptacion.Text = "Estados de aceptación";
            // 
            // tlpBase
            // 
            tlpBase.BackColor = SystemColors.Window;
            tlpBase.ColumnCount = 5;
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.003F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3313332F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3313332F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3313332F));
            tlpBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.003F));
            tlpBase.Controls.Add(lblRutaArchivo, 0, 1);
            tlpBase.Controls.Add(txtRutaArchivo, 1, 1);
            tlpBase.Controls.Add(btnLimpiar, 1, 0);
            tlpBase.Controls.Add(lblEstadoInicial, 2, 0);
            tlpBase.Controls.Add(lblContenido, 0, 2);
            tlpBase.Controls.Add(lblEstados, 1, 2);
            tlpBase.Controls.Add(lblAlfabeto, 2, 2);
            tlpBase.Controls.Add(lblEstadosDeAceptacion, 3, 2);
            tlpBase.Controls.Add(txtContenidoArchivo, 0, 3);
            tlpBase.Controls.Add(txtEstados, 1, 3);
            tlpBase.Controls.Add(txtAlfabeto, 2, 3);
            tlpBase.Controls.Add(txtEstadosDeAceptacion, 3, 3);
            tlpBase.Controls.Add(btnCerrar, 4, 4);
            tlpBase.Controls.Add(dgvTablaTransicion, 4, 3);
            tlpBase.Controls.Add(lblTablaTransicion, 4, 2);
            tlpBase.Dock = DockStyle.Fill;
            tlpBase.Location = new Point(0, 0);
            tlpBase.Margin = new Padding(4, 5, 4, 5);
            tlpBase.Name = "tlpBase";
            tlpBase.RowCount = 5;
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpBase.Size = new Size(1168, 818);
            tlpBase.TabIndex = 0;
            // 
            // lblEstadoInicial
            // 
            lblEstadoInicial.Anchor = AnchorStyles.Bottom;
            lblEstadoInicial.AutoSize = true;
            lblEstadoInicial.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoInicial.ForeColor = SystemColors.HotTrack;
            lblEstadoInicial.Location = new Point(528, 20);
            lblEstadoInicial.Margin = new Padding(4, 0, 4, 7);
            lblEstadoInicial.Name = "lblEstadoInicial";
            lblEstadoInicial.Size = new Size(108, 20);
            lblEstadoInicial.TabIndex = 2;
            lblEstadoInicial.Text = "[Estado inicial]";
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.BackColor = SystemColors.Control;
            txtContenidoArchivo.BorderStyle = BorderStyle.FixedSingle;
            txtContenidoArchivo.Dock = DockStyle.Fill;
            txtContenidoArchivo.Location = new Point(4, 167);
            txtContenidoArchivo.Margin = new Padding(4, 5, 4, 5);
            txtContenidoArchivo.Multiline = true;
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.ReadOnly = true;
            txtContenidoArchivo.Size = new Size(342, 586);
            txtContenidoArchivo.TabIndex = 10;
            // 
            // txtEstados
            // 
            txtEstados.BackColor = SystemColors.Control;
            txtEstados.BorderStyle = BorderStyle.FixedSingle;
            txtEstados.Dock = DockStyle.Fill;
            txtEstados.Location = new Point(354, 167);
            txtEstados.Margin = new Padding(4, 5, 4, 5);
            txtEstados.Multiline = true;
            txtEstados.Name = "txtEstados";
            txtEstados.ReadOnly = true;
            txtEstados.Size = new Size(147, 586);
            txtEstados.TabIndex = 11;
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.BackColor = SystemColors.Control;
            txtAlfabeto.BorderStyle = BorderStyle.FixedSingle;
            txtAlfabeto.Dock = DockStyle.Fill;
            txtAlfabeto.Location = new Point(509, 167);
            txtAlfabeto.Margin = new Padding(4, 5, 4, 5);
            txtAlfabeto.Multiline = true;
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.ReadOnly = true;
            txtAlfabeto.Size = new Size(147, 586);
            txtAlfabeto.TabIndex = 12;
            // 
            // txtEstadosDeAceptacion
            // 
            txtEstadosDeAceptacion.BackColor = SystemColors.Control;
            txtEstadosDeAceptacion.BorderStyle = BorderStyle.FixedSingle;
            txtEstadosDeAceptacion.Dock = DockStyle.Fill;
            txtEstadosDeAceptacion.Location = new Point(664, 167);
            txtEstadosDeAceptacion.Margin = new Padding(4, 5, 4, 5);
            txtEstadosDeAceptacion.Multiline = true;
            txtEstadosDeAceptacion.Name = "txtEstadosDeAceptacion";
            txtEstadosDeAceptacion.ReadOnly = true;
            txtEstadosDeAceptacion.Size = new Size(147, 586);
            txtEstadosDeAceptacion.TabIndex = 13;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCerrar.Location = new Point(1005, 767);
            btnCerrar.Margin = new Padding(4, 5, 15, 18);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(148, 33);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvTablaTransicion
            // 
            dgvTablaTransicion.AllowUserToAddRows = false;
            dgvTablaTransicion.AllowUserToDeleteRows = false;
            dgvTablaTransicion.AllowUserToResizeColumns = false;
            dgvTablaTransicion.AllowUserToResizeRows = false;
            dgvTablaTransicion.BackgroundColor = SystemColors.Control;
            dgvTablaTransicion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaTransicion.Dock = DockStyle.Fill;
            dgvTablaTransicion.GridColor = SystemColors.Control;
            dgvTablaTransicion.Location = new Point(819, 167);
            dgvTablaTransicion.Margin = new Padding(4, 5, 4, 5);
            dgvTablaTransicion.Name = "dgvTablaTransicion";
            dgvTablaTransicion.ReadOnly = true;
            dgvTablaTransicion.RowHeadersWidth = 51;
            dgvTablaTransicion.RowTemplate.Height = 25;
            dgvTablaTransicion.Size = new Size(345, 586);
            dgvTablaTransicion.TabIndex = 14;
            // 
            // lblTablaTransicion
            // 
            lblTablaTransicion.Anchor = AnchorStyles.Bottom;
            lblTablaTransicion.AutoSize = true;
            lblTablaTransicion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTablaTransicion.ForeColor = SystemColors.HotTrack;
            lblTablaTransicion.Location = new Point(919, 142);
            lblTablaTransicion.Margin = new Padding(4, 0, 4, 0);
            lblTablaTransicion.Name = "lblTablaTransicion";
            lblTablaTransicion.Size = new Size(145, 20);
            lblTablaTransicion.TabIndex = 9;
            lblTablaTransicion.Text = "Matriz de transición";
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
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtRutaArchivo;
        private Label lblRutaArchivo;
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
    }
}