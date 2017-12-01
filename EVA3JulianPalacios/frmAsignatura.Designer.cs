namespace EVA3JulianPalacios
{
    partial class frmAsignatura
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
            this.dgvAsignatura = new System.Windows.Forms.DataGridView();
            this.codAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESDataSet = new EVA3JulianPalacios.LEONESDataSet();
            this.asignaturasTableAdapter = new EVA3JulianPalacios.LEONESDataSetTableAdapters.AsignaturasTableAdapter();
            this.btnMostrarIngresoDatos = new System.Windows.Forms.Button();
            this.btnMostrarNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsignatura
            // 
            this.dgvAsignatura.AutoGenerateColumns = false;
            this.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAsignaturaDataGridViewTextBoxColumn,
            this.descAsignaturaDataGridViewTextBoxColumn});
            this.dgvAsignatura.DataSource = this.asignaturasBindingSource;
            this.dgvAsignatura.Location = new System.Drawing.Point(119, 31);
            this.dgvAsignatura.Name = "dgvAsignatura";
            this.dgvAsignatura.Size = new System.Drawing.Size(263, 150);
            this.dgvAsignatura.TabIndex = 0;
            // 
            // codAsignaturaDataGridViewTextBoxColumn
            // 
            this.codAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "CodAsignatura";
            this.codAsignaturaDataGridViewTextBoxColumn.HeaderText = "CodAsignatura";
            this.codAsignaturaDataGridViewTextBoxColumn.Name = "codAsignaturaDataGridViewTextBoxColumn";
            // 
            // descAsignaturaDataGridViewTextBoxColumn
            // 
            this.descAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "DescAsignatura";
            this.descAsignaturaDataGridViewTextBoxColumn.HeaderText = "DescAsignatura";
            this.descAsignaturaDataGridViewTextBoxColumn.Name = "descAsignaturaDataGridViewTextBoxColumn";
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.lEONESDataSet;
            // 
            // lEONESDataSet
            // 
            this.lEONESDataSet.DataSetName = "LEONESDataSet";
            this.lEONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // btnMostrarIngresoDatos
            // 
            this.btnMostrarIngresoDatos.Location = new System.Drawing.Point(323, 332);
            this.btnMostrarIngresoDatos.Name = "btnMostrarIngresoDatos";
            this.btnMostrarIngresoDatos.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarIngresoDatos.TabIndex = 1;
            this.btnMostrarIngresoDatos.Text = "Ingreso Datos";
            this.btnMostrarIngresoDatos.UseVisualStyleBackColor = true;
            this.btnMostrarIngresoDatos.Click += new System.EventHandler(this.btnMostrarIngresoDatos_Click);
            // 
            // btnMostrarNotas
            // 
            this.btnMostrarNotas.Location = new System.Drawing.Point(323, 397);
            this.btnMostrarNotas.Name = "btnMostrarNotas";
            this.btnMostrarNotas.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarNotas.TabIndex = 2;
            this.btnMostrarNotas.Text = "Mostrar Notas";
            this.btnMostrarNotas.UseVisualStyleBackColor = true;
            this.btnMostrarNotas.Click += new System.EventHandler(this.btnMostrarNotas_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 458);
            this.Controls.Add(this.btnMostrarNotas);
            this.Controls.Add(this.btnMostrarIngresoDatos);
            this.Controls.Add(this.dgvAsignatura);
            this.Name = "frmAsignatura";
            this.Text = "frmAsignatura";
            this.Load += new System.EventHandler(this.frmAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsignatura;
        private LEONESDataSet lEONESDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private LEONESDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMostrarIngresoDatos;
        private System.Windows.Forms.Button btnMostrarNotas;
    }
}