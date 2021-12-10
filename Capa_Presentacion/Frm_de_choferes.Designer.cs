namespace Capa_Presentacion
{
    partial class Frm_de_choferes
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
            this.labelTituloChofer = new System.Windows.Forms.Label();
            this.buttonEliminarChofer = new System.Windows.Forms.Button();
            this.buttonEditarChoferes = new System.Windows.Forms.Button();
            this.buttonInsertarChoferes = new System.Windows.Forms.Button();
            this.buttonBuscarChoferes = new System.Windows.Forms.Button();
            this.textBoxIdChofer = new System.Windows.Forms.TextBox();
            this.textBoxNombreChofer = new System.Windows.Forms.TextBox();
            this.textBoxApellidoChofer = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelIdChofer = new System.Windows.Forms.Label();
            this.labelNombreChofer = new System.Windows.Forms.Label();
            this.labelApellidoChofer = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCHOFERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECHOFERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDULACHOFERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHOFERESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMA_AUTOBUSESDataSet = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSet();
            this.cHOFERESTableAdapter = new Capa_Presentacion.SISTEMA_AUTOBUSESDataSetTableAdapters.CHOFERESTableAdapter();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRegresarMenu = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOFERESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloChofer
            // 
            this.labelTituloChofer.AutoSize = true;
            this.labelTituloChofer.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloChofer.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloChofer.ForeColor = System.Drawing.Color.Blue;
            this.labelTituloChofer.Location = new System.Drawing.Point(14, 2);
            this.labelTituloChofer.Name = "labelTituloChofer";
            this.labelTituloChofer.Size = new System.Drawing.Size(543, 74);
            this.labelTituloChofer.TabIndex = 3;
            this.labelTituloChofer.Text = "Optimain: Driver manager";
            // 
            // buttonEliminarChofer
            // 
            this.buttonEliminarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEliminarChofer.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarChofer.ForeColor = System.Drawing.Color.Blue;
            this.buttonEliminarChofer.Location = new System.Drawing.Point(1326, 465);
            this.buttonEliminarChofer.Name = "buttonEliminarChofer";
            this.buttonEliminarChofer.Size = new System.Drawing.Size(219, 58);
            this.buttonEliminarChofer.TabIndex = 10;
            this.buttonEliminarChofer.Text = "Delete";
            this.buttonEliminarChofer.UseVisualStyleBackColor = false;
            this.buttonEliminarChofer.Click += new System.EventHandler(this.buttonEliminarChofer_Click);
            // 
            // buttonEditarChoferes
            // 
            this.buttonEditarChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditarChoferes.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarChoferes.ForeColor = System.Drawing.Color.Blue;
            this.buttonEditarChoferes.Location = new System.Drawing.Point(1326, 386);
            this.buttonEditarChoferes.Name = "buttonEditarChoferes";
            this.buttonEditarChoferes.Size = new System.Drawing.Size(219, 58);
            this.buttonEditarChoferes.TabIndex = 9;
            this.buttonEditarChoferes.Text = "Edit";
            this.buttonEditarChoferes.UseVisualStyleBackColor = false;
           
            // 
            // buttonInsertarChoferes
            // 
            this.buttonInsertarChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInsertarChoferes.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarChoferes.ForeColor = System.Drawing.Color.Blue;
            this.buttonInsertarChoferes.Location = new System.Drawing.Point(1326, 306);
            this.buttonInsertarChoferes.Name = "buttonInsertarChoferes";
            this.buttonInsertarChoferes.Size = new System.Drawing.Size(219, 58);
            this.buttonInsertarChoferes.TabIndex = 8;
            this.buttonInsertarChoferes.Text = "New";
            this.buttonInsertarChoferes.UseVisualStyleBackColor = false;
            this.buttonInsertarChoferes.Click += new System.EventHandler(this.buttonInsertarChoferes_Click);
            // 
            // buttonBuscarChoferes
            // 
            this.buttonBuscarChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBuscarChoferes.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarChoferes.ForeColor = System.Drawing.Color.Blue;
            this.buttonBuscarChoferes.Location = new System.Drawing.Point(1326, 212);
            this.buttonBuscarChoferes.Name = "buttonBuscarChoferes";
            this.buttonBuscarChoferes.Size = new System.Drawing.Size(219, 58);
            this.buttonBuscarChoferes.TabIndex = 7;
            this.buttonBuscarChoferes.Text = "Search";
            this.buttonBuscarChoferes.UseVisualStyleBackColor = false;
            this.buttonBuscarChoferes.Click += new System.EventHandler(this.buttonBuscarChoferes_Click);
            // 
            // textBoxIdChofer
            // 
            this.textBoxIdChofer.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdChofer.Location = new System.Drawing.Point(1241, 219);
            this.textBoxIdChofer.Name = "textBoxIdChofer";
            this.textBoxIdChofer.Size = new System.Drawing.Size(48, 47);
            this.textBoxIdChofer.TabIndex = 11;
            // 
            // textBoxNombreChofer
            // 
            this.textBoxNombreChofer.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreChofer.Location = new System.Drawing.Point(988, 306);
            this.textBoxNombreChofer.Name = "textBoxNombreChofer";
            this.textBoxNombreChofer.Size = new System.Drawing.Size(301, 47);
            this.textBoxNombreChofer.TabIndex = 12;
            // 
            // textBoxApellidoChofer
            // 
            this.textBoxApellidoChofer.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoChofer.Location = new System.Drawing.Point(988, 365);
            this.textBoxApellidoChofer.Name = "textBoxApellidoChofer";
            this.textBoxApellidoChofer.Size = new System.Drawing.Size(301, 47);
            this.textBoxApellidoChofer.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(988, 432);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 47);
            this.textBox3.TabIndex = 14;
            // 
            // labelIdChofer
            // 
            this.labelIdChofer.AutoSize = true;
            this.labelIdChofer.BackColor = System.Drawing.Color.Transparent;
            this.labelIdChofer.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdChofer.ForeColor = System.Drawing.Color.Blue;
            this.labelIdChofer.Location = new System.Drawing.Point(1127, 219);
            this.labelIdChofer.Name = "labelIdChofer";
            this.labelIdChofer.Size = new System.Drawing.Size(93, 56);
            this.labelIdChofer.TabIndex = 15;
            this.labelIdChofer.Text = "ID";
            // 
            // labelNombreChofer
            // 
            this.labelNombreChofer.AutoSize = true;
            this.labelNombreChofer.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreChofer.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreChofer.ForeColor = System.Drawing.Color.Blue;
            this.labelNombreChofer.Location = new System.Drawing.Point(756, 297);
            this.labelNombreChofer.Name = "labelNombreChofer";
            this.labelNombreChofer.Size = new System.Drawing.Size(201, 56);
            this.labelNombreChofer.TabIndex = 16;
            this.labelNombreChofer.Text = "First Name";
            // 
            // labelApellidoChofer
            // 
            this.labelApellidoChofer.AutoSize = true;
            this.labelApellidoChofer.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidoChofer.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoChofer.ForeColor = System.Drawing.Color.Blue;
            this.labelApellidoChofer.Location = new System.Drawing.Point(758, 356);
            this.labelApellidoChofer.Name = "labelApellidoChofer";
            this.labelApellidoChofer.Size = new System.Drawing.Size(199, 56);
            this.labelApellidoChofer.TabIndex = 17;
            this.labelApellidoChofer.Text = "Last Name";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.ForeColor = System.Drawing.Color.Blue;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(779, 423);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(169, 56);
            this.labelFechaNacimiento.TabIndex = 18;
            this.labelFechaNacimiento.Text = "Birthday";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.BackColor = System.Drawing.Color.Transparent;
            this.labelCedula.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedula.ForeColor = System.Drawing.Color.Blue;
            this.labelCedula.Location = new System.Drawing.Point(779, 485);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(129, 56);
            this.labelCedula.TabIndex = 20;
            this.labelCedula.Text = "NID";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCedula.Location = new System.Drawing.Point(988, 494);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(301, 47);
            this.textBoxCedula.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 74);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelTituloChofer);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1557, 73);
            this.panel2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCHOFERDataGridViewTextBoxColumn,
            this.nOMBRECHOFERDataGridViewTextBoxColumn,
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn,
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn,
            this.cEDULACHOFERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cHOFERESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 546);
            this.dataGridView1.TabIndex = 23;
            // 
            // iDCHOFERDataGridViewTextBoxColumn
            // 
            this.iDCHOFERDataGridViewTextBoxColumn.DataPropertyName = "ID_CHOFER";
            this.iDCHOFERDataGridViewTextBoxColumn.HeaderText = "ID_CHOFER";
            this.iDCHOFERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCHOFERDataGridViewTextBoxColumn.Name = "iDCHOFERDataGridViewTextBoxColumn";
            this.iDCHOFERDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCHOFERDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMBRECHOFERDataGridViewTextBoxColumn
            // 
            this.nOMBRECHOFERDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CHOFER";
            this.nOMBRECHOFERDataGridViewTextBoxColumn.HeaderText = "NOMBRE_CHOFER";
            this.nOMBRECHOFERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBRECHOFERDataGridViewTextBoxColumn.Name = "nOMBRECHOFERDataGridViewTextBoxColumn";
            this.nOMBRECHOFERDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPELLIDOCHOFERDataGridViewTextBoxColumn
            // 
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn.DataPropertyName = "APELLIDO_CHOFER";
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn.HeaderText = "APELLIDO_CHOFER";
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn.Name = "aPELLIDOCHOFERDataGridViewTextBoxColumn";
            this.aPELLIDOCHOFERDataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn
            // 
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn.DataPropertyName = "FECHA_NACIMIENTO_CHOFER";
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn.HeaderText = "FECHA_NACIMIENTO_CHOFER";
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn.Name = "fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn";
            this.fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEDULACHOFERDataGridViewTextBoxColumn
            // 
            this.cEDULACHOFERDataGridViewTextBoxColumn.DataPropertyName = "CEDULA_CHOFER";
            this.cEDULACHOFERDataGridViewTextBoxColumn.HeaderText = "CEDULA_CHOFER";
            this.cEDULACHOFERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEDULACHOFERDataGridViewTextBoxColumn.Name = "cEDULACHOFERDataGridViewTextBoxColumn";
            this.cEDULACHOFERDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHOFERESBindingSource
            // 
            this.cHOFERESBindingSource.DataMember = "CHOFERES";
            this.cHOFERESBindingSource.DataSource = this.sISTEMA_AUTOBUSESDataSet;
            // 
            // sISTEMA_AUTOBUSESDataSet
            // 
            this.sISTEMA_AUTOBUSESDataSet.DataSetName = "SISTEMA_AUTOBUSESDataSet";
            this.sISTEMA_AUTOBUSESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHOFERESTableAdapter
            // 
            this.cHOFERESTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSalir.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.Blue;
            this.buttonSalir.Location = new System.Drawing.Point(1327, 85);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(219, 58);
            this.buttonSalir.TabIndex = 24;
            this.buttonSalir.Text = "Exit";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonRegresarMenu
            // 
            this.buttonRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRegresarMenu.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenu.ForeColor = System.Drawing.Color.Blue;
            this.buttonRegresarMenu.Location = new System.Drawing.Point(1055, 85);
            this.buttonRegresarMenu.Name = "buttonRegresarMenu";
            this.buttonRegresarMenu.Size = new System.Drawing.Size(219, 58);
            this.buttonRegresarMenu.TabIndex = 58;
            this.buttonRegresarMenu.Text = "Go Back";
            this.buttonRegresarMenu.UseVisualStyleBackColor = false;
            this.buttonRegresarMenu.Click += new System.EventHandler(this.buttonRegresarMenu_Click);
            // 
            // Frm_de_choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 703);
            this.Controls.Add(this.buttonRegresarMenu);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelApellidoChofer);
            this.Controls.Add(this.labelNombreChofer);
            this.Controls.Add(this.labelIdChofer);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxApellidoChofer);
            this.Controls.Add(this.textBoxNombreChofer);
            this.Controls.Add(this.textBoxIdChofer);
            this.Controls.Add(this.buttonEliminarChofer);
            this.Controls.Add(this.buttonEditarChoferes);
            this.Controls.Add(this.buttonInsertarChoferes);
            this.Controls.Add(this.buttonBuscarChoferes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_de_choferes";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Frm_de_choferes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOFERESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_AUTOBUSESDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloChofer;
        private System.Windows.Forms.Button buttonEliminarChofer;
        private System.Windows.Forms.Button buttonEditarChoferes;
        private System.Windows.Forms.Button buttonInsertarChoferes;
        private System.Windows.Forms.Button buttonBuscarChoferes;
        private System.Windows.Forms.TextBox textBoxIdChofer;
        private System.Windows.Forms.TextBox textBoxNombreChofer;
        private System.Windows.Forms.TextBox textBoxApellidoChofer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelIdChofer;
        private System.Windows.Forms.Label labelNombreChofer;
        private System.Windows.Forms.Label labelApellidoChofer;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SISTEMA_AUTOBUSESDataSet sISTEMA_AUTOBUSESDataSet;
        private System.Windows.Forms.BindingSource cHOFERESBindingSource;
        private SISTEMA_AUTOBUSESDataSetTableAdapters.CHOFERESTableAdapter cHOFERESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCHOFERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECHOFERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOCHOFERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHANACIMIENTOCHOFERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEDULACHOFERDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRegresarMenu;
    }
}