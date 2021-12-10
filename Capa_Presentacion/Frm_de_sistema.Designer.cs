namespace Capa_Presentacion
{
    partial class Frm_de_sistema
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoferes = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAutobuses = new System.Windows.Forms.Button();
            this.buttonRutas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Optimain: Transport Manager";
            // 
            // buttonChoferes
            // 
            this.buttonChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChoferes.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferes.ForeColor = System.Drawing.Color.Blue;
            this.buttonChoferes.Location = new System.Drawing.Point(355, 168);
            this.buttonChoferes.Name = "buttonChoferes";
            this.buttonChoferes.Size = new System.Drawing.Size(219, 58);
            this.buttonChoferes.TabIndex = 2;
            this.buttonChoferes.Text = "Drivers";
            this.buttonChoferes.UseVisualStyleBackColor = false;
            this.buttonChoferes.Click += new System.EventHandler(this.buttonChoferes_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSalir.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.Blue;
            this.buttonSalir.Location = new System.Drawing.Point(16, 466);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(219, 58);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Exit";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonAutobuses
            // 
            this.buttonAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAutobuses.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutobuses.ForeColor = System.Drawing.Color.Blue;
            this.buttonAutobuses.Location = new System.Drawing.Point(355, 256);
            this.buttonAutobuses.Name = "buttonAutobuses";
            this.buttonAutobuses.Size = new System.Drawing.Size(219, 58);
            this.buttonAutobuses.TabIndex = 3;
            this.buttonAutobuses.Text = "Bus";
            this.buttonAutobuses.UseVisualStyleBackColor = false;
            this.buttonAutobuses.Click += new System.EventHandler(this.buttonAutobuses_Click);
            // 
            // buttonRutas
            // 
            this.buttonRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRutas.Font = new System.Drawing.Font("Palace Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutas.ForeColor = System.Drawing.Color.Blue;
            this.buttonRutas.Location = new System.Drawing.Point(355, 344);
            this.buttonRutas.Name = "buttonRutas";
            this.buttonRutas.Size = new System.Drawing.Size(219, 58);
            this.buttonRutas.TabIndex = 4;
            this.buttonRutas.Text = "Roads";
            this.buttonRutas.UseVisualStyleBackColor = false;
            this.buttonRutas.Click += new System.EventHandler(this.buttonRutas_Click);
            // 
            // Frm_de_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 536);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRutas);
            this.Controls.Add(this.buttonAutobuses);
            this.Controls.Add(this.buttonChoferes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_de_sistema";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoferes;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAutobuses;
        private System.Windows.Forms.Button buttonRutas;
    }
}