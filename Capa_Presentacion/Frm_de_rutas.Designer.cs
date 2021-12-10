namespace Capa_Presentacion
{
    partial class Frm_de_rutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloRuta = new System.Windows.Forms.Label();
            this.labelFinRuta = new System.Windows.Forms.Label();
            this.labelComienzoRuta = new System.Windows.Forms.Label();
            this.labelMarcaAutobus = new System.Windows.Forms.Label();
            this.labelIdAutobus = new System.Windows.Forms.Label();
            this.textBoxFinRuta = new System.Windows.Forms.TextBox();
            this.textBoxComienzoRuta = new System.Windows.Forms.TextBox();
            this.textBoxNombreRuta = new System.Windows.Forms.TextBox();
            this.textBoxIdRuta = new System.Windows.Forms.TextBox();
            this.buttonEliminarRutas = new System.Windows.Forms.Button();
            this.buttonEditarRutas = new System.Windows.Forms.Button();
            this.buttonInsertarRutas = new System.Windows.Forms.Button();
            this.buttonBuscarRutas = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.rUTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMA_AUTOBUSESDataSet2 = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSet2();
            this.rUTASTableAdapter = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSet2TableAdapters.RUTASTableAdapter();
            this.buttonRegresarMenu = new System.Windows.Forms.Button();
            this.TablaRutas = new System.Windows.Forms.DataGridView();
            this.iDRUTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRERUTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMIENZORUTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINRUTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rUTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelTituloRuta);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 73);
            this.panel1.TabIndex = 54;
            // 
            // labelTituloRuta
            // 
            this.labelTituloRuta.AutoSize = true;
            this.labelTituloRuta.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloRuta.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloRuta.ForeColor = System.Drawing.Color.Blue;
            this.labelTituloRuta.Location = new System.Drawing.Point(3, -1);
            this.labelTituloRuta.Name = "labelTituloRuta";
            this.labelTituloRuta.Size = new System.Drawing.Size(541, 74);
            this.labelTituloRuta.TabIndex = 3;
            this.labelTituloRuta.Text = "Optimain: Roads manager";
            // 
            // labelFinRuta
            // 
            this.labelFinRuta.AutoSize = true;
            this.labelFinRuta.BackColor = System.Drawing.Color.Transparent;
            this.labelFinRuta.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinRuta.ForeColor = System.Drawing.Color.Blue;
            this.labelFinRuta.Location = new System.Drawing.Point(44, 320);
            this.labelFinRuta.Name = "labelFinRuta";
            this.labelFinRuta.Size = new System.Drawing.Size(180, 56);
            this.labelFinRuta.TabIndex = 51;
            this.labelFinRuta.Text = "Road End";
            // 
            // labelComienzoRuta
            // 
            this.labelComienzoRuta.AutoSize = true;
            this.labelComienzoRuta.BackColor = System.Drawing.Color.Transparent;
            this.labelComienzoRuta.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComienzoRuta.ForeColor = System.Drawing.Color.Blue;
            this.labelComienzoRuta.Location = new System.Drawing.Point(58, 250);
            this.labelComienzoRuta.Name = "labelComienzoRuta";
            this.labelComienzoRuta.Size = new System.Drawing.Size(202, 56);
            this.labelComienzoRuta.TabIndex = 50;
            this.labelComienzoRuta.Text = "Road Start";
            // 
            // labelMarcaAutobus
            // 
            this.labelMarcaAutobus.AutoSize = true;
            this.labelMarcaAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelMarcaAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelMarcaAutobus.Location = new System.Drawing.Point(58, 180);
            this.labelMarcaAutobus.Name = "labelMarcaAutobus";
            this.labelMarcaAutobus.Size = new System.Drawing.Size(210, 56);
            this.labelMarcaAutobus.TabIndex = 49;
            this.labelMarcaAutobus.Text = "Road Name";
            // 
            // labelIdAutobus
            // 
            this.labelIdAutobus.AutoSize = true;
            this.labelIdAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelIdAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelIdAutobus.Location = new System.Drawing.Point(664, 81);
            this.labelIdAutobus.Name = "labelIdAutobus";
            this.labelIdAutobus.Size = new System.Drawing.Size(93, 56);
            this.labelIdAutobus.TabIndex = 48;
            this.labelIdAutobus.Text = "ID";
            // 
            // textBoxFinRuta
            // 
            this.textBoxFinRuta.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFinRuta.Location = new System.Drawing.Point(287, 331);
            this.textBoxFinRuta.Name = "textBoxFinRuta";
            this.textBoxFinRuta.Size = new System.Drawing.Size(301, 47);
            this.textBoxFinRuta.TabIndex = 47;
            // 
            // textBoxComienzoRuta
            // 
            this.textBoxComienzoRuta.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComienzoRuta.Location = new System.Drawing.Point(287, 261);
            this.textBoxComienzoRuta.Name = "textBoxComienzoRuta";
            this.textBoxComienzoRuta.Size = new System.Drawing.Size(301, 47);
            this.textBoxComienzoRuta.TabIndex = 46;
            // 
            // textBoxNombreRuta
            // 
            this.textBoxNombreRuta.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreRuta.Location = new System.Drawing.Point(287, 189);
            this.textBoxNombreRuta.Name = "textBoxNombreRuta";
            this.textBoxNombreRuta.Size = new System.Drawing.Size(301, 47);
            this.textBoxNombreRuta.TabIndex = 45;
            // 
            // textBoxIdRuta
            // 
            this.textBoxIdRuta.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdRuta.Location = new System.Drawing.Point(767, 86);
            this.textBoxIdRuta.Name = "textBoxIdRuta";
            this.textBoxIdRuta.Size = new System.Drawing.Size(48, 47);
            this.textBoxIdRuta.TabIndex = 44;
            // 
            // buttonEliminarRutas
            // 
            this.buttonEliminarRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEliminarRutas.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarRutas.ForeColor = System.Drawing.Color.Blue;
            this.buttonEliminarRutas.Location = new System.Drawing.Point(49, 455);
            this.buttonEliminarRutas.Name = "buttonEliminarRutas";
            this.buttonEliminarRutas.Size = new System.Drawing.Size(219, 58);
            this.buttonEliminarRutas.TabIndex = 43;
            this.buttonEliminarRutas.Text = "Delete";
            this.buttonEliminarRutas.UseVisualStyleBackColor = false;
            this.buttonEliminarRutas.Click += new System.EventHandler(this.buttonEliminarRutas_Click);
            // 
            // buttonEditarRutas
            // 
            this.buttonEditarRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditarRutas.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarRutas.ForeColor = System.Drawing.Color.Blue;
            this.buttonEditarRutas.Location = new System.Drawing.Point(432, 455);
            this.buttonEditarRutas.Name = "buttonEditarRutas";
            this.buttonEditarRutas.Size = new System.Drawing.Size(219, 58);
            this.buttonEditarRutas.TabIndex = 42;
            this.buttonEditarRutas.Text = "Edit";
            this.buttonEditarRutas.UseVisualStyleBackColor = false;
            
            // 
            // buttonInsertarRutas
            // 
            this.buttonInsertarRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInsertarRutas.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarRutas.ForeColor = System.Drawing.Color.Blue;
            this.buttonInsertarRutas.Location = new System.Drawing.Point(767, 455);
            this.buttonInsertarRutas.Name = "buttonInsertarRutas";
            this.buttonInsertarRutas.Size = new System.Drawing.Size(219, 58);
            this.buttonInsertarRutas.TabIndex = 41;
            this.buttonInsertarRutas.Text = "New";
            this.buttonInsertarRutas.UseVisualStyleBackColor = false;
            this.buttonInsertarRutas.Click += new System.EventHandler(this.buttonInsertarRutas_Click);
            // 
            // buttonBuscarRutas
            // 
            this.buttonBuscarRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBuscarRutas.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarRutas.ForeColor = System.Drawing.Color.Blue;
            this.buttonBuscarRutas.Location = new System.Drawing.Point(840, 79);
            this.buttonBuscarRutas.Name = "buttonBuscarRutas";
            this.buttonBuscarRutas.Size = new System.Drawing.Size(219, 58);
            this.buttonBuscarRutas.TabIndex = 40;
            this.buttonBuscarRutas.Text = "Search";
            this.buttonBuscarRutas.UseVisualStyleBackColor = false;
            this.buttonBuscarRutas.Click += new System.EventHandler(this.buttonBuscarRutas_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSalir.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.Blue;
            this.buttonSalir.Location = new System.Drawing.Point(15, 79);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(219, 58);
            this.buttonSalir.TabIndex = 55;
            this.buttonSalir.Text = "Exit";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // rUTASBindingSource
            // 
            this.rUTASBindingSource.DataMember = "RUTAS";
            this.rUTASBindingSource.DataSource = this.sISTEMA_AUTOBUSESDataSet2;
            // 
            // sISTEMA_AUTOBUSESDataSet2
            // 
            this.sISTEMA_AUTOBUSESDataSet2.DataSetName = "SISTEMA_AUTOBUSESDataSet2";
            this.sISTEMA_AUTOBUSESDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rUTASTableAdapter
            // 
            this.rUTASTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRegresarMenu
            // 
            this.buttonRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRegresarMenu.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenu.ForeColor = System.Drawing.Color.Blue;
            this.buttonRegresarMenu.Location = new System.Drawing.Point(287, 83);
            this.buttonRegresarMenu.Name = "buttonRegresarMenu";
            this.buttonRegresarMenu.Size = new System.Drawing.Size(219, 58);
            this.buttonRegresarMenu.TabIndex = 57;
            this.buttonRegresarMenu.Text = "  Go Back";
            this.buttonRegresarMenu.UseVisualStyleBackColor = false;
            this.buttonRegresarMenu.Click += new System.EventHandler(this.buttonRegresarMenu_Click);
            // 
            // TablaRutas
            // 
            this.TablaRutas.AutoGenerateColumns = false;
            this.TablaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRUTADataGridViewTextBoxColumn,
            this.nOMBRERUTADataGridViewTextBoxColumn,
            this.cOMIENZORUTADataGridViewTextBoxColumn,
            this.fINRUTADataGridViewTextBoxColumn});
            this.TablaRutas.DataSource = this.rUTASBindingSource;
            this.TablaRutas.Location = new System.Drawing.Point(650, 180);
            this.TablaRutas.Name = "TablaRutas";
            this.TablaRutas.RowHeadersWidth = 51;
            this.TablaRutas.RowTemplate.Height = 24;
            this.TablaRutas.Size = new System.Drawing.Size(371, 252);
            this.TablaRutas.TabIndex = 58;
            // 
            // iDRUTADataGridViewTextBoxColumn
            // 
            this.iDRUTADataGridViewTextBoxColumn.DataPropertyName = "ID_RUTA";
            this.iDRUTADataGridViewTextBoxColumn.HeaderText = "ID_RUTA";
            this.iDRUTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRUTADataGridViewTextBoxColumn.Name = "iDRUTADataGridViewTextBoxColumn";
            this.iDRUTADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRUTADataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMBRERUTADataGridViewTextBoxColumn
            // 
            this.nOMBRERUTADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_RUTA";
            this.nOMBRERUTADataGridViewTextBoxColumn.HeaderText = "NOMBRE_RUTA";
            this.nOMBRERUTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBRERUTADataGridViewTextBoxColumn.Name = "nOMBRERUTADataGridViewTextBoxColumn";
            this.nOMBRERUTADataGridViewTextBoxColumn.Width = 125;
            // 
            // cOMIENZORUTADataGridViewTextBoxColumn
            // 
            this.cOMIENZORUTADataGridViewTextBoxColumn.DataPropertyName = "COMIENZO_RUTA";
            this.cOMIENZORUTADataGridViewTextBoxColumn.HeaderText = "COMIENZO_RUTA";
            this.cOMIENZORUTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOMIENZORUTADataGridViewTextBoxColumn.Name = "cOMIENZORUTADataGridViewTextBoxColumn";
            this.cOMIENZORUTADataGridViewTextBoxColumn.Width = 125;
            // 
            // fINRUTADataGridViewTextBoxColumn
            // 
            this.fINRUTADataGridViewTextBoxColumn.DataPropertyName = "FIN_RUTA";
            this.fINRUTADataGridViewTextBoxColumn.HeaderText = "FIN_RUTA";
            this.fINRUTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fINRUTADataGridViewTextBoxColumn.Name = "fINRUTADataGridViewTextBoxColumn";
            this.fINRUTADataGridViewTextBoxColumn.Width = 125;
            // 
            // Frm_de_rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.TablaRutas);
            this.Controls.Add(this.buttonRegresarMenu);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFinRuta);
            this.Controls.Add(this.labelComienzoRuta);
            this.Controls.Add(this.labelMarcaAutobus);
            this.Controls.Add(this.labelIdAutobus);
            this.Controls.Add(this.textBoxFinRuta);
            this.Controls.Add(this.textBoxComienzoRuta);
            this.Controls.Add(this.textBoxNombreRuta);
            this.Controls.Add(this.textBoxIdRuta);
            this.Controls.Add(this.buttonEliminarRutas);
            this.Controls.Add(this.buttonEditarRutas);
            this.Controls.Add(this.buttonInsertarRutas);
            this.Controls.Add(this.buttonBuscarRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_de_rutas";
            this.Text = "Frm_de_rutas";
            this.Load += new System.EventHandler(this.Frm_de_rutas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rUTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloRuta;
        private System.Windows.Forms.Label labelFinRuta;
        private System.Windows.Forms.Label labelComienzoRuta;
        private System.Windows.Forms.Label labelMarcaAutobus;
        private System.Windows.Forms.Label labelIdAutobus;
        private System.Windows.Forms.TextBox textBoxFinRuta;
        private System.Windows.Forms.TextBox textBoxComienzoRuta;
        private System.Windows.Forms.TextBox textBoxNombreRuta;
        private System.Windows.Forms.TextBox textBoxIdRuta;
        private System.Windows.Forms.Button buttonEliminarRutas;
        private System.Windows.Forms.Button buttonEditarRutas;
        private System.Windows.Forms.Button buttonInsertarRutas;
        private System.Windows.Forms.Button buttonBuscarRutas;
        private System.Windows.Forms.Button buttonSalir;
        private SISTEMA_AUTOBUSESDataSet2 sISTEMA_AUTOBUSESDataSet2;
        private System.Windows.Forms.BindingSource rUTASBindingSource;
        private SISTEMA_AUTOBUSESDataSet2TableAdapters.RUTASTableAdapter rUTASTableAdapter;
        private System.Windows.Forms.Button buttonRegresarMenu;
        private System.Windows.Forms.DataGridView TablaRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRUTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRERUTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMIENZORUTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINRUTADataGridViewTextBoxColumn;
    }
}