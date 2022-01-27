namespace EditorTexto
{
    partial class frmEditor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.txtReemplazo = new System.Windows.Forms.TextBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.btnCerrarBusqueda = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFuentes = new System.Windows.Forms.Panel();
            this.gboxEjempo = new System.Windows.Forms.GroupBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.lstTamaño = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstilo = new System.Windows.Forms.TextBox();
            this.lstEstilo = new System.Windows.Forms.ListBox();
            this.lblFuente = new System.Windows.Forms.Label();
            this.btnCerrarFuentes = new System.Windows.Forms.Button();
            this.lblFuentes = new System.Windows.Forms.Label();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.lstFuentes = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlFuentes.SuspendLayout();
            this.gboxEjempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem,
            this.regresarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 724);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 25);
            this.panel1.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlBusqueda);
            this.pnlPrincipal.Controls.Add(this.pnlFuentes);
            this.pnlPrincipal.Controls.Add(this.txtTexto);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPrincipal.Size = new System.Drawing.Size(1368, 700);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.txtReemplazo);
            this.pnlBusqueda.Controls.Add(this.btnReemplazar);
            this.pnlBusqueda.Controls.Add(this.btnCerrarBusqueda);
            this.pnlBusqueda.Controls.Add(this.lblResultado);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Location = new System.Drawing.Point(434, 288);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(501, 209);
            this.pnlBusqueda.TabIndex = 4;
            this.pnlBusqueda.Visible = false;
            // 
            // txtReemplazo
            // 
            this.txtReemplazo.Enabled = false;
            this.txtReemplazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtReemplazo.Location = new System.Drawing.Point(22, 157);
            this.txtReemplazo.Name = "txtReemplazo";
            this.txtReemplazo.Size = new System.Drawing.Size(465, 32);
            this.txtReemplazo.TabIndex = 9;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Enabled = false;
            this.btnReemplazar.Location = new System.Drawing.Point(25, 119);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(124, 32);
            this.btnReemplazar.TabIndex = 8;
            this.btnReemplazar.Text = "Reemplazar por:";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // btnCerrarBusqueda
            // 
            this.btnCerrarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarBusqueda.BackColor = System.Drawing.Color.White;
            this.btnCerrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBusqueda.Location = new System.Drawing.Point(462, -1);
            this.btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            this.btnCerrarBusqueda.Size = new System.Drawing.Size(38, 28);
            this.btnCerrarBusqueda.TabIndex = 7;
            this.btnCerrarBusqueda.Text = "X";
            this.btnCerrarBusqueda.UseVisualStyleBackColor = false;
            this.btnCerrarBusqueda.Click += new System.EventHandler(this.btnCerrarBusqueda_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(22, 81);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 32);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBuscar.Location = new System.Drawing.Point(22, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(352, 32);
            this.txtBuscar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar";
            // 
            // pnlFuentes
            // 
            this.pnlFuentes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFuentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFuentes.Controls.Add(this.gboxEjempo);
            this.pnlFuentes.Controls.Add(this.btnCancelar);
            this.pnlFuentes.Controls.Add(this.btnAceptar);
            this.pnlFuentes.Controls.Add(this.lblTamaño);
            this.pnlFuentes.Controls.Add(this.txtTamaño);
            this.pnlFuentes.Controls.Add(this.lstTamaño);
            this.pnlFuentes.Controls.Add(this.label1);
            this.pnlFuentes.Controls.Add(this.txtEstilo);
            this.pnlFuentes.Controls.Add(this.lstEstilo);
            this.pnlFuentes.Controls.Add(this.lblFuente);
            this.pnlFuentes.Controls.Add(this.btnCerrarFuentes);
            this.pnlFuentes.Controls.Add(this.lblFuentes);
            this.pnlFuentes.Controls.Add(this.txtFuente);
            this.pnlFuentes.Controls.Add(this.lstFuentes);
            this.pnlFuentes.Location = new System.Drawing.Point(96, 73);
            this.pnlFuentes.Name = "pnlFuentes";
            this.pnlFuentes.Size = new System.Drawing.Size(1129, 392);
            this.pnlFuentes.TabIndex = 3;
            this.pnlFuentes.Visible = false;
            // 
            // gboxEjempo
            // 
            this.gboxEjempo.Controls.Add(this.lblEjemplo);
            this.gboxEjempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEjempo.Location = new System.Drawing.Point(798, 269);
            this.gboxEjempo.Name = "gboxEjempo";
            this.gboxEjempo.Size = new System.Drawing.Size(291, 81);
            this.gboxEjempo.TabIndex = 13;
            this.gboxEjempo.TabStop = false;
            this.gboxEjempo.Text = "Ejemplo:";
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(103, 32);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(85, 20);
            this.lblEjemplo.TabIndex = 0;
            this.lblEjemplo.Text = "AaBbYyZz";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(987, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCerrarFuentes_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(987, 80);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 32);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamaño.Location = new System.Drawing.Point(794, 57);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(71, 20);
            this.lblTamaño.TabIndex = 10;
            this.lblTamaño.Text = "Tamaño:";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTamaño.Location = new System.Drawing.Point(797, 80);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.ReadOnly = true;
            this.txtTamaño.Size = new System.Drawing.Size(127, 32);
            this.txtTamaño.TabIndex = 9;
            // 
            // lstTamaño
            // 
            this.lstTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTamaño.ForeColor = System.Drawing.Color.Black;
            this.lstTamaño.FormattingEnabled = true;
            this.lstTamaño.ItemHeight = 20;
            this.lstTamaño.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.lstTamaño.Location = new System.Drawing.Point(797, 112);
            this.lstTamaño.Name = "lstTamaño";
            this.lstTamaño.Size = new System.Drawing.Size(127, 144);
            this.lstTamaño.TabIndex = 8;
            this.lstTamaño.SelectedIndexChanged += new System.EventHandler(this.lstTamaño_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estilo de Fuente:";
            // 
            // txtEstilo
            // 
            this.txtEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstilo.Location = new System.Drawing.Point(414, 80);
            this.txtEstilo.Name = "txtEstilo";
            this.txtEstilo.ReadOnly = true;
            this.txtEstilo.Size = new System.Drawing.Size(352, 31);
            this.txtEstilo.TabIndex = 6;
            // 
            // lstEstilo
            // 
            this.lstEstilo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstilo.FormattingEnabled = true;
            this.lstEstilo.Items.AddRange(new object[] {
            "Normal",
            "Oblicua",
            "Negrita",
            "Oblicua Negrita"});
            this.lstEstilo.Location = new System.Drawing.Point(414, 112);
            this.lstEstilo.Name = "lstEstilo";
            this.lstEstilo.Size = new System.Drawing.Size(352, 121);
            this.lstEstilo.TabIndex = 5;
            this.lstEstilo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEstilo_DrawItem);
            this.lstEstilo.SelectedIndexChanged += new System.EventHandler(this.lstEstilo_SelectedIndexChanged);
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuente.Location = new System.Drawing.Point(29, 57);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(64, 20);
            this.lblFuente.TabIndex = 4;
            this.lblFuente.Text = "Fuente:";
            // 
            // btnCerrarFuentes
            // 
            this.btnCerrarFuentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarFuentes.BackColor = System.Drawing.Color.White;
            this.btnCerrarFuentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFuentes.Location = new System.Drawing.Point(1090, -1);
            this.btnCerrarFuentes.Name = "btnCerrarFuentes";
            this.btnCerrarFuentes.Size = new System.Drawing.Size(38, 28);
            this.btnCerrarFuentes.TabIndex = 3;
            this.btnCerrarFuentes.Text = "X";
            this.btnCerrarFuentes.UseVisualStyleBackColor = false;
            this.btnCerrarFuentes.Click += new System.EventHandler(this.btnCerrarFuentes_Click);
            // 
            // lblFuentes
            // 
            this.lblFuentes.BackColor = System.Drawing.Color.White;
            this.lblFuentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuentes.Location = new System.Drawing.Point(0, 0);
            this.lblFuentes.Name = "lblFuentes";
            this.lblFuentes.Size = new System.Drawing.Size(1127, 25);
            this.lblFuentes.TabIndex = 2;
            this.lblFuentes.Text = "Fuentes";
            // 
            // txtFuente
            // 
            this.txtFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtFuente.Location = new System.Drawing.Point(31, 80);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(352, 32);
            this.txtFuente.TabIndex = 1;
            this.txtFuente.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
            // 
            // lstFuentes
            // 
            this.lstFuentes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstFuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFuentes.FormattingEnabled = true;
            this.lstFuentes.Location = new System.Drawing.Point(31, 112);
            this.lstFuentes.Name = "lstFuentes";
            this.lstFuentes.Size = new System.Drawing.Size(352, 238);
            this.lstFuentes.TabIndex = 0;
            this.lstFuentes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFuentes_DrawItem);
            this.lstFuentes.SelectedIndexChanged += new System.EventHandler(this.lstFuentes_SelectedIndexChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(15, 15);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(1338, 670);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.Text = "";
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 749);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Texto";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlFuentes.ResumeLayout(false);
            this.pnlFuentes.PerformLayout();
            this.gboxEjempo.ResumeLayout(false);
            this.gboxEjempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFuentes;
        private System.Windows.Forms.ListBox lstFuentes;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.Label lblFuentes;
        private System.Windows.Forms.Button btnCerrarFuentes;
        private System.Windows.Forms.Label lblFuente;
        private System.Windows.Forms.GroupBox gboxEjempo;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.ListBox lstTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstilo;
        private System.Windows.Forms.ListBox lstEstilo;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Button btnCerrarBusqueda;
        private System.Windows.Forms.Button btnReemplazar;
        public System.Windows.Forms.TextBox txtReemplazo;
        public System.Windows.Forms.RichTextBox txtTexto;
    }
}

