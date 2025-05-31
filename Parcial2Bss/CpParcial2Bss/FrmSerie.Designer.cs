namespace CpParcial2Bss
{
    partial class FrmSerie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerie));
            this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.erpEpisodios = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).BeginInit();
            this.SuspendLayout();
            // 
            // erpFechaEstreno
            // 
            this.erpFechaEstreno.ContainerControl = this;
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Location = new System.Drawing.Point(302, 16);
            this.lblEpisodios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(55, 13);
            this.lblEpisodios.TabIndex = 17;
            this.lblEpisodios.Text = "Episodios:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(29, 44);
            this.lblSinopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSinopsis.TabIndex = 16;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Título:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(302, 44);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(79, 13);
            this.lblFechaEstreno.TabIndex = 14;
            this.lblFechaEstreno.Text = "Fecha Estreno:";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(387, 41);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEstreno.TabIndex = 13;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(83, 75);
            this.txtDirector.MaxLength = 250;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(194, 20);
            this.txtDirector.TabIndex = 12;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(29, 78);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(47, 13);
            this.lblDirector.TabIndex = 18;
            this.lblDirector.Text = "Director:";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(14, 61);
            this.txtParametro.MaxLength = 100;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(680, 20);
            this.txtParametro.TabIndex = 16;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(14, 42);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(92, 13);
            this.lblParametro.TabIndex = 15;
            this.lblParametro.Text = "Buscar por Título:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 31);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Series";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 21);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(783, 150);
            this.dgvLista.TabIndex = 0;
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(14, 89);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(795, 179);
            this.gbxLista.TabIndex = 18;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Series";
            // 
            // nudEpisodios
            // 
            this.nudEpisodios.Location = new System.Drawing.Point(387, 13);
            this.nudEpisodios.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEpisodios.Name = "nudEpisodios";
            this.nudEpisodios.Size = new System.Drawing.Size(120, 20);
            this.nudEpisodios.TabIndex = 8;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(83, 41);
            this.txtSinopsis.MaxLength = 250;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(194, 20);
            this.txtSinopsis.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(83, 13);
            this.txtTitulo.MaxLength = 20;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(194, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblDirector);
            this.gbxDatos.Controls.Add(this.lblEpisodios);
            this.gbxDatos.Controls.Add(this.lblSinopsis);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
            this.gbxDatos.Controls.Add(this.txtDirector);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.nudEpisodios);
            this.gbxDatos.Controls.Add(this.txtSinopsis);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Location = new System.Drawing.Point(14, 323);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(795, 115);
            this.gbxDatos.TabIndex = 20;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CpParcial2Bss.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(678, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Size = new System.Drawing.Size(111, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CpParcial2Bss.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(567, 71);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // erpSinopsis
            // 
            this.erpSinopsis.ContainerControl = this;
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpDirector
            // 
            this.erpDirector.ContainerControl = this;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(14, 274);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(795, 47);
            this.pnlAcciones.TabIndex = 19;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CpParcial2Bss.Properties.Resources.close;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(495, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCerrar.Size = new System.Drawing.Size(96, 40);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpParcial2Bss.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(387, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpParcial2Bss.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(283, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEditar.Size = new System.Drawing.Size(98, 40);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpParcial2Bss.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(179, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNuevo.Size = new System.Drawing.Size(98, 40);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // erpEpisodios
            // 
            this.erpEpisodios.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpParcial2Bss.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(711, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSerie";
            this.Load += new System.EventHandler(this.FrmSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erpFechaEstreno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblEpisodios;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudEpisodios;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider erpSinopsis;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpDirector;
        private System.Windows.Forms.ErrorProvider erpEpisodios;
    }
}

