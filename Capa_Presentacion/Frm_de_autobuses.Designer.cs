namespace Capa_Presentacion
{
    partial class Frm_de_autobuses
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
            this.labelColorAutobus = new System.Windows.Forms.Label();
            this.textBoxColorAutobus = new System.Windows.Forms.TextBox();
            this.labelMatriculaAutobus = new System.Windows.Forms.Label();
            this.labelModeloAutobus = new System.Windows.Forms.Label();
            this.labelMarcaAutobus = new System.Windows.Forms.Label();
            this.labelIdAutobus = new System.Windows.Forms.Label();
            this.textBoxMatriculaAutobus = new System.Windows.Forms.TextBox();
            this.textBoxModeloAutobus = new System.Windows.Forms.TextBox();
            this.textBoxMarcaAutobus = new System.Windows.Forms.TextBox();
            this.textBoxIdAutobus = new System.Windows.Forms.TextBox();
            this.buttonEliminarAutobuses = new System.Windows.Forms.Button();
            this.buttonEditarAutobuses = new System.Windows.Forms.Button();
            this.buttonInsertarAutobuses = new System.Windows.Forms.Button();
            this.buttonBuscarAutobuses = new System.Windows.Forms.Button();
            this.labelTituloAutobus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAnoAutobus = new System.Windows.Forms.Label();
            this.textBoxAnoAutobus = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDAUTOBUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCAAUTOBUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELOAUTOBUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLORAUTOBUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOAUTOBUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTOBUSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMA_AUTOBUSESDataSet1 = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSet1();
            this.sISTEMA_AUTOBUSESDataSet = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSet();
            this.sISTEMAAUTOBUSESDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOBUSESTableAdapter = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSet1TableAdapters.AUTOBUSESTableAdapter();
            this.buttonRegresarMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBUSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAAUTOBUSESDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColorAutobus
            // 
            this.labelColorAutobus.AutoSize = true;
            this.labelColorAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelColorAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelColorAutobus.Location = new System.Drawing.Point(53, 350);
            this.labelColorAutobus.Name = "labelColorAutobus";
            this.labelColorAutobus.Size = new System.Drawing.Size(96, 56);
            this.labelColorAutobus.TabIndex = 36;
            this.labelColorAutobus.Text = "Color";
            // 
            // textBoxColorAutobus
            // 
            this.textBoxColorAutobus.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColorAutobus.Location = new System.Drawing.Point(236, 350);
            this.textBoxColorAutobus.Name = "textBoxColorAutobus";
            this.textBoxColorAutobus.Size = new System.Drawing.Size(301, 47);
            this.textBoxColorAutobus.TabIndex = 35;
            // 
            // labelMatriculaAutobus
            // 
            this.labelMatriculaAutobus.AutoSize = true;
            this.labelMatriculaAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelMatriculaAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatriculaAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelMatriculaAutobus.Location = new System.Drawing.Point(42, 288);
            this.labelMatriculaAutobus.Name = "labelMatriculaAutobus";
            this.labelMatriculaAutobus.Size = new System.Drawing.Size(180, 56);
            this.labelMatriculaAutobus.TabIndex = 34;
            this.labelMatriculaAutobus.Text = "Enrollment";
            // 
            // labelModeloAutobus
            // 
            this.labelModeloAutobus.AutoSize = true;
            this.labelModeloAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelModeloAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModeloAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelModeloAutobus.Location = new System.Drawing.Point(53, 232);
            this.labelModeloAutobus.Name = "labelModeloAutobus";
            this.labelModeloAutobus.Size = new System.Drawing.Size(117, 56);
            this.labelModeloAutobus.TabIndex = 33;
            this.labelModeloAutobus.Text = "Model";
            // 
            // labelMarcaAutobus
            // 
            this.labelMarcaAutobus.AutoSize = true;
            this.labelMarcaAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelMarcaAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelMarcaAutobus.Location = new System.Drawing.Point(53, 176);
            this.labelMarcaAutobus.Name = "labelMarcaAutobus";
            this.labelMarcaAutobus.Size = new System.Drawing.Size(130, 56);
            this.labelMarcaAutobus.TabIndex = 32;
            this.labelMarcaAutobus.Text = "Brand";
            // 
            // labelIdAutobus
            // 
            this.labelIdAutobus.AutoSize = true;
            this.labelIdAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelIdAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelIdAutobus.Location = new System.Drawing.Point(589, 82);
            this.labelIdAutobus.Name = "labelIdAutobus";
            this.labelIdAutobus.Size = new System.Drawing.Size(93, 56);
            this.labelIdAutobus.TabIndex = 31;
            this.labelIdAutobus.Text = "ID";
            // 
            // textBoxMatriculaAutobus
            // 
            this.textBoxMatriculaAutobus.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatriculaAutobus.Location = new System.Drawing.Point(236, 297);
            this.textBoxMatriculaAutobus.Name = "textBoxMatriculaAutobus";
            this.textBoxMatriculaAutobus.Size = new System.Drawing.Size(301, 47);
            this.textBoxMatriculaAutobus.TabIndex = 30;
            // 
            // textBoxModeloAutobus
            // 
            this.textBoxModeloAutobus.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModeloAutobus.Location = new System.Drawing.Point(236, 241);
            this.textBoxModeloAutobus.Name = "textBoxModeloAutobus";
            this.textBoxModeloAutobus.Size = new System.Drawing.Size(301, 47);
            this.textBoxModeloAutobus.TabIndex = 29;
            // 
            // textBoxMarcaAutobus
            // 
            this.textBoxMarcaAutobus.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarcaAutobus.Location = new System.Drawing.Point(236, 188);
            this.textBoxMarcaAutobus.Name = "textBoxMarcaAutobus";
            this.textBoxMarcaAutobus.Size = new System.Drawing.Size(301, 47);
            this.textBoxMarcaAutobus.TabIndex = 28;
            // 
            // textBoxIdAutobus
            // 
            this.textBoxIdAutobus.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdAutobus.Location = new System.Drawing.Point(706, 87);
            this.textBoxIdAutobus.Name = "textBoxIdAutobus";
            this.textBoxIdAutobus.Size = new System.Drawing.Size(48, 47);
            this.textBoxIdAutobus.TabIndex = 27;
            // 
            // buttonEliminarAutobuses
            // 
            this.buttonEliminarAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEliminarAutobuses.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarAutobuses.ForeColor = System.Drawing.Color.Blue;
            this.buttonEliminarAutobuses.Location = new System.Drawing.Point(52, 493);
            this.buttonEliminarAutobuses.Name = "buttonEliminarAutobuses";
            this.buttonEliminarAutobuses.Size = new System.Drawing.Size(219, 58);
            this.buttonEliminarAutobuses.TabIndex = 26;
            this.buttonEliminarAutobuses.Text = "Delete";
            this.buttonEliminarAutobuses.UseVisualStyleBackColor = false;
            this.buttonEliminarAutobuses.Click += new System.EventHandler(this.buttonEliminarAutobuses_Click);
            // 
            // buttonEditarAutobuses
            // 
            this.buttonEditarAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditarAutobuses.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarAutobuses.ForeColor = System.Drawing.Color.Blue;
            this.buttonEditarAutobuses.Location = new System.Drawing.Point(393, 493);
            this.buttonEditarAutobuses.Name = "buttonEditarAutobuses";
            this.buttonEditarAutobuses.Size = new System.Drawing.Size(219, 58);
            this.buttonEditarAutobuses.TabIndex = 25;
            this.buttonEditarAutobuses.Text = "Edit";
            this.buttonEditarAutobuses.UseVisualStyleBackColor = false;
           
            // 
            // buttonInsertarAutobuses
            // 
            this.buttonInsertarAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInsertarAutobuses.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarAutobuses.ForeColor = System.Drawing.Color.Blue;
            this.buttonInsertarAutobuses.Location = new System.Drawing.Point(706, 493);
            this.buttonInsertarAutobuses.Name = "buttonInsertarAutobuses";
            this.buttonInsertarAutobuses.Size = new System.Drawing.Size(219, 58);
            this.buttonInsertarAutobuses.TabIndex = 24;
            this.buttonInsertarAutobuses.Text = "New";
            this.buttonInsertarAutobuses.UseVisualStyleBackColor = false;
            this.buttonInsertarAutobuses.Click += new System.EventHandler(this.buttonInsertarAutobuses_Click);
            // 
            // buttonBuscarAutobuses
            // 
            this.buttonBuscarAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBuscarAutobuses.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAutobuses.ForeColor = System.Drawing.Color.Blue;
            this.buttonBuscarAutobuses.Location = new System.Drawing.Point(760, 80);
            this.buttonBuscarAutobuses.Name = "buttonBuscarAutobuses";
            this.buttonBuscarAutobuses.Size = new System.Drawing.Size(219, 58);
            this.buttonBuscarAutobuses.TabIndex = 23;
            this.buttonBuscarAutobuses.Text = "Search";
            this.buttonBuscarAutobuses.UseVisualStyleBackColor = false;
            this.buttonBuscarAutobuses.Click += new System.EventHandler(this.buttonBuscarAutobuses_Click);
            // 
            // labelTituloAutobus
            // 
            this.labelTituloAutobus.AutoSize = true;
            this.labelTituloAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloAutobus.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelTituloAutobus.Location = new System.Drawing.Point(3, -1);
            this.labelTituloAutobus.Name = "labelTituloAutobus";
            this.labelTituloAutobus.Size = new System.Drawing.Size(507, 74);
            this.labelTituloAutobus.TabIndex = 3;
            this.labelTituloAutobus.Text = "Optimain: Bus manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelTituloAutobus);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 73);
            this.panel1.TabIndex = 37;
            // 
            // labelAnoAutobus
            // 
            this.labelAnoAutobus.AutoSize = true;
            this.labelAnoAutobus.BackColor = System.Drawing.Color.Transparent;
            this.labelAnoAutobus.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnoAutobus.ForeColor = System.Drawing.Color.Blue;
            this.labelAnoAutobus.Location = new System.Drawing.Point(53, 408);
            this.labelAnoAutobus.Name = "labelAnoAutobus";
            this.labelAnoAutobus.Size = new System.Drawing.Size(91, 56);
            this.labelAnoAutobus.TabIndex = 39;
            this.labelAnoAutobus.Text = "Year";
            // 
            // textBoxAnoAutobus
            // 
            this.textBoxAnoAutobus.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnoAutobus.Location = new System.Drawing.Point(236, 408);
            this.textBoxAnoAutobus.Name = "textBoxAnoAutobus";
            this.textBoxAnoAutobus.Size = new System.Drawing.Size(301, 47);
            this.textBoxAnoAutobus.TabIndex = 38;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSalir.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.Blue;
            this.buttonSalir.Location = new System.Drawing.Point(3, 84);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(219, 58);
            this.buttonSalir.TabIndex = 40;
            this.buttonSalir.Text = "Exit";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAUTOBUSDataGridViewTextBoxColumn,
            this.mARCAAUTOBUSDataGridViewTextBoxColumn,
            this.mODELOAUTOBUSDataGridViewTextBoxColumn,
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn,
            this.cOLORAUTOBUSDataGridViewTextBoxColumn,
            this.aNOAUTOBUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aUTOBUSESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(588, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(391, 291);
            this.dataGridView1.TabIndex = 41;
            // 
            // iDAUTOBUSDataGridViewTextBoxColumn
            // 
            this.iDAUTOBUSDataGridViewTextBoxColumn.DataPropertyName = "ID_AUTOBUS";
            this.iDAUTOBUSDataGridViewTextBoxColumn.HeaderText = "ID_AUTOBUS";
            this.iDAUTOBUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDAUTOBUSDataGridViewTextBoxColumn.Name = "iDAUTOBUSDataGridViewTextBoxColumn";
            this.iDAUTOBUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAUTOBUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // mARCAAUTOBUSDataGridViewTextBoxColumn
            // 
            this.mARCAAUTOBUSDataGridViewTextBoxColumn.DataPropertyName = "MARCA_AUTOBUS";
            this.mARCAAUTOBUSDataGridViewTextBoxColumn.HeaderText = "MARCA_AUTOBUS";
            this.mARCAAUTOBUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mARCAAUTOBUSDataGridViewTextBoxColumn.Name = "mARCAAUTOBUSDataGridViewTextBoxColumn";
            this.mARCAAUTOBUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // mODELOAUTOBUSDataGridViewTextBoxColumn
            // 
            this.mODELOAUTOBUSDataGridViewTextBoxColumn.DataPropertyName = "MODELO_AUTOBUS";
            this.mODELOAUTOBUSDataGridViewTextBoxColumn.HeaderText = "MODELO_AUTOBUS";
            this.mODELOAUTOBUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mODELOAUTOBUSDataGridViewTextBoxColumn.Name = "mODELOAUTOBUSDataGridViewTextBoxColumn";
            this.mODELOAUTOBUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // mATRICULAAUTOBUSDataGridViewTextBoxColumn
            // 
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn.DataPropertyName = "MATRICULA_AUTOBUS";
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn.HeaderText = "MATRICULA_AUTOBUS";
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn.Name = "mATRICULAAUTOBUSDataGridViewTextBoxColumn";
            this.mATRICULAAUTOBUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // cOLORAUTOBUSDataGridViewTextBoxColumn
            // 
            this.cOLORAUTOBUSDataGridViewTextBoxColumn.DataPropertyName = "COLOR_AUTOBUS";
            this.cOLORAUTOBUSDataGridViewTextBoxColumn.HeaderText = "COLOR_AUTOBUS";
            this.cOLORAUTOBUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOLORAUTOBUSDataGridViewTextBoxColumn.Name = "cOLORAUTOBUSDataGridViewTextBoxColumn";
            this.cOLORAUTOBUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // aNOAUTOBUSDataGridViewTextBoxColumn
            // 
            this.aNOAUTOBUSDataGridViewTextBoxColumn.DataPropertyName = "ANO_AUTOBUS";
            this.aNOAUTOBUSDataGridViewTextBoxColumn.HeaderText = "ANO_AUTOBUS";
            this.aNOAUTOBUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aNOAUTOBUSDataGridViewTextBoxColumn.Name = "aNOAUTOBUSDataGridViewTextBoxColumn";
            this.aNOAUTOBUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // aUTOBUSESBindingSource
            // 
            this.aUTOBUSESBindingSource.DataMember = "AUTOBUSES";
            this.aUTOBUSESBindingSource.DataSource = this.sISTEMA_AUTOBUSESDataSet1;
            // 
            // sISTEMA_AUTOBUSESDataSet1
            // 
            this.sISTEMA_AUTOBUSESDataSet1.DataSetName = "SISTEMA_AUTOBUSESDataSet1";
            this.sISTEMA_AUTOBUSESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sISTEMA_AUTOBUSESDataSet
            // 
            this.sISTEMA_AUTOBUSESDataSet.DataSetName = "SISTEMA_AUTOBUSESDataSet";
            this.sISTEMA_AUTOBUSESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sISTEMAAUTOBUSESDataSetBindingSource
            // 
            this.sISTEMAAUTOBUSESDataSetBindingSource.DataSource = this.sISTEMA_AUTOBUSESDataSet;
            this.sISTEMAAUTOBUSESDataSetBindingSource.Position = 0;
            // 
            // aUTOBUSESTableAdapter
            // 
            this.aUTOBUSESTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRegresarMenu
            // 
            this.buttonRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRegresarMenu.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenu.ForeColor = System.Drawing.Color.Blue;
            this.buttonRegresarMenu.Location = new System.Drawing.Point(270, 87);
            this.buttonRegresarMenu.Name = "buttonRegresarMenu";
            this.buttonRegresarMenu.Size = new System.Drawing.Size(219, 58);
            this.buttonRegresarMenu.TabIndex = 58;
            this.buttonRegresarMenu.Text = "Go Back";
            this.buttonRegresarMenu.UseVisualStyleBackColor = false;
            this.buttonRegresarMenu.Click += new System.EventHandler(this.buttonRegresarMenu_Click);
            // 
            // Frm_de_autobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.buttonRegresarMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelAnoAutobus);
            this.Controls.Add(this.textBoxAnoAutobus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelColorAutobus);
            this.Controls.Add(this.textBoxColorAutobus);
            this.Controls.Add(this.labelMatriculaAutobus);
            this.Controls.Add(this.labelModeloAutobus);
            this.Controls.Add(this.labelMarcaAutobus);
            this.Controls.Add(this.labelIdAutobus);
            this.Controls.Add(this.textBoxMatriculaAutobus);
            this.Controls.Add(this.textBoxModeloAutobus);
            this.Controls.Add(this.textBoxMarcaAutobus);
            this.Controls.Add(this.textBoxIdAutobus);
            this.Controls.Add(this.buttonEliminarAutobuses);
            this.Controls.Add(this.buttonEditarAutobuses);
            this.Controls.Add(this.buttonInsertarAutobuses);
            this.Controls.Add(this.buttonBuscarAutobuses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_de_autobuses";
            this.Text = "Frm_de_autobuses";
            this.Load += new System.EventHandler(this.Frm_de_autobuses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBUSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAAUTOBUSESDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColorAutobus;
        private System.Windows.Forms.TextBox textBoxColorAutobus;
        private System.Windows.Forms.Label labelMatriculaAutobus;
        private System.Windows.Forms.Label labelModeloAutobus;
        private System.Windows.Forms.Label labelMarcaAutobus;
        private System.Windows.Forms.Label labelIdAutobus;
        private System.Windows.Forms.TextBox textBoxMatriculaAutobus;
        private System.Windows.Forms.TextBox textBoxModeloAutobus;
        private System.Windows.Forms.TextBox textBoxMarcaAutobus;
        private System.Windows.Forms.TextBox textBoxIdAutobus;
        private System.Windows.Forms.Button buttonEliminarAutobuses;
        private System.Windows.Forms.Button buttonEditarAutobuses;
        private System.Windows.Forms.Button buttonInsertarAutobuses;
        private System.Windows.Forms.Button buttonBuscarAutobuses;
        private System.Windows.Forms.Label labelTituloAutobus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAnoAutobus;
        private System.Windows.Forms.TextBox textBoxAnoAutobus;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sISTEMAAUTOBUSESDataSetBindingSource;
        private SISTEMA_AUTOBUSESDataSet sISTEMA_AUTOBUSESDataSet;
        private SISTEMA_AUTOBUSESDataSet1 sISTEMA_AUTOBUSESDataSet1;
        private System.Windows.Forms.BindingSource aUTOBUSESBindingSource;
        private SISTEMA_AUTOBUSESDataSet1TableAdapters.AUTOBUSESTableAdapter aUTOBUSESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAUTOBUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCAAUTOBUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELOAUTOBUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATRICULAAUTOBUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLORAUTOBUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOAUTOBUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRegresarMenu;
    }
}