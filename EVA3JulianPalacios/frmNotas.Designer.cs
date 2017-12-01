namespace EVA3JulianPalacios
{
    partial class frmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.dgvMostrarNotas = new System.Windows.Forms.DataGridView();
            this.rutAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESDataSet = new EVA3JulianPalacios.LEONESDataSet();
            this.btnMostrarIngreso = new System.Windows.Forms.Button();
            this.btnMostrarAsignatura = new System.Windows.Forms.Button();
            this.mostrarDatosToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnMostrarDatos = new System.Windows.Forms.ToolStripButton();
            this.btnMostrarPromedio = new System.Windows.Forms.ToolStripButton();
            this.notasTableAdapter = new EVA3JulianPalacios.LEONESDataSetTableAdapters.NotasTableAdapter();
            this.cbMostrarAsignatura = new System.Windows.Forms.ComboBox();
            this.cbMostrarRut = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).BeginInit();
            this.mostrarDatosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarNotas
            // 
            this.dgvMostrarNotas.AllowUserToOrderColumns = true;
            this.dgvMostrarNotas.AutoGenerateColumns = false;
            this.dgvMostrarNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMostrarNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutAlumnoDataGridViewTextBoxColumn,
            this.codAsignaturaDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn,
            this.fechaNotaDataGridViewTextBoxColumn});
            this.dgvMostrarNotas.DataSource = this.notasBindingSource;
            this.dgvMostrarNotas.Location = new System.Drawing.Point(12, 61);
            this.dgvMostrarNotas.MultiSelect = false;
            this.dgvMostrarNotas.Name = "dgvMostrarNotas";
            this.dgvMostrarNotas.ReadOnly = true;
            this.dgvMostrarNotas.Size = new System.Drawing.Size(699, 168);
            this.dgvMostrarNotas.TabIndex = 0;
            // 
            // rutAlumnoDataGridViewTextBoxColumn
            // 
            this.rutAlumnoDataGridViewTextBoxColumn.DataPropertyName = "rutAlumno";
            this.rutAlumnoDataGridViewTextBoxColumn.HeaderText = "rutAlumno";
            this.rutAlumnoDataGridViewTextBoxColumn.Name = "rutAlumnoDataGridViewTextBoxColumn";
            this.rutAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codAsignaturaDataGridViewTextBoxColumn
            // 
            this.codAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "CodAsignatura";
            this.codAsignaturaDataGridViewTextBoxColumn.HeaderText = "CodAsignatura";
            this.codAsignaturaDataGridViewTextBoxColumn.Name = "codAsignaturaDataGridViewTextBoxColumn";
            this.codAsignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "Nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "Nota3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            this.nota3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNotaDataGridViewTextBoxColumn
            // 
            this.fechaNotaDataGridViewTextBoxColumn.DataPropertyName = "FechaNota";
            this.fechaNotaDataGridViewTextBoxColumn.HeaderText = "FechaNota";
            this.fechaNotaDataGridViewTextBoxColumn.Name = "fechaNotaDataGridViewTextBoxColumn";
            this.fechaNotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.lEONESDataSet;
            // 
            // lEONESDataSet
            // 
            this.lEONESDataSet.DataSetName = "LEONESDataSet";
            this.lEONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMostrarIngreso
            // 
            this.btnMostrarIngreso.Location = new System.Drawing.Point(728, 318);
            this.btnMostrarIngreso.Name = "btnMostrarIngreso";
            this.btnMostrarIngreso.Size = new System.Drawing.Size(129, 23);
            this.btnMostrarIngreso.TabIndex = 1;
            this.btnMostrarIngreso.Text = "Mostrar Ingreso";
            this.btnMostrarIngreso.UseVisualStyleBackColor = true;
            this.btnMostrarIngreso.Click += new System.EventHandler(this.btnMostrarIngreso_Click);
            // 
            // btnMostrarAsignatura
            // 
            this.btnMostrarAsignatura.Location = new System.Drawing.Point(728, 386);
            this.btnMostrarAsignatura.Name = "btnMostrarAsignatura";
            this.btnMostrarAsignatura.Size = new System.Drawing.Size(129, 23);
            this.btnMostrarAsignatura.TabIndex = 2;
            this.btnMostrarAsignatura.Text = "Mostrar Asignaturas";
            this.btnMostrarAsignatura.UseVisualStyleBackColor = true;
            this.btnMostrarAsignatura.Click += new System.EventHandler(this.btnMostrarAsignatura_Click);
            // 
            // mostrarDatosToolStrip
            // 
            this.mostrarDatosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMostrarDatos,
            this.btnMostrarPromedio});
            this.mostrarDatosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mostrarDatosToolStrip.Name = "mostrarDatosToolStrip";
            this.mostrarDatosToolStrip.Size = new System.Drawing.Size(915, 25);
            this.mostrarDatosToolStrip.TabIndex = 3;
            this.mostrarDatosToolStrip.Text = "mostrarDatosToolStrip";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(82, 22);
            this.btnMostrarDatos.Text = "MostrarDatos";
            this.btnMostrarDatos.Click += new System.EventHandler(this.mostrarDatosToolStripButton_Click);
            // 
            // btnMostrarPromedio
            // 
            this.btnMostrarPromedio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrarPromedio.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarPromedio.Image")));
            this.btnMostrarPromedio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarPromedio.Name = "btnMostrarPromedio";
            this.btnMostrarPromedio.Size = new System.Drawing.Size(63, 22);
            this.btnMostrarPromedio.Text = "Promedio";
            this.btnMostrarPromedio.Click += new System.EventHandler(this.btnMostrarPromedio_Click);
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // cbMostrarAsignatura
            // 
            this.cbMostrarAsignatura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMostrarAsignatura.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasBindingSource, "CodAsignatura", true));
            this.cbMostrarAsignatura.DataSource = this.notasBindingSource;
            this.cbMostrarAsignatura.DisplayMember = "CodAsignatura";
            this.cbMostrarAsignatura.FormattingEnabled = true;
            this.cbMostrarAsignatura.Location = new System.Drawing.Point(290, 279);
            this.cbMostrarAsignatura.Name = "cbMostrarAsignatura";
            this.cbMostrarAsignatura.Size = new System.Drawing.Size(121, 21);
            this.cbMostrarAsignatura.TabIndex = 4;
            // 
            // cbMostrarRut
            // 
            this.cbMostrarRut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMostrarRut.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasBindingSource, "rutAlumno", true));
            this.cbMostrarRut.DataSource = this.notasBindingSource;
            this.cbMostrarRut.DisplayMember = "rutAlumno";
            this.cbMostrarRut.FormattingEnabled = true;
            this.cbMostrarRut.Location = new System.Drawing.Point(60, 279);
            this.cbMostrarRut.Name = "cbMostrarRut";
            this.cbMostrarRut.Size = new System.Drawing.Size(121, 21);
            this.cbMostrarRut.TabIndex = 5;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 449);
            this.Controls.Add(this.cbMostrarRut);
            this.Controls.Add(this.cbMostrarAsignatura);
            this.Controls.Add(this.mostrarDatosToolStrip);
            this.Controls.Add(this.btnMostrarAsignatura);
            this.Controls.Add(this.btnMostrarIngreso);
            this.Controls.Add(this.dgvMostrarNotas);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).EndInit();
            this.mostrarDatosToolStrip.ResumeLayout(false);
            this.mostrarDatosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarNotas;
        private LEONESDataSet lEONESDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private LEONESDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMostrarIngreso;
        private System.Windows.Forms.Button btnMostrarAsignatura;
        private System.Windows.Forms.ToolStrip mostrarDatosToolStrip;
        private System.Windows.Forms.ToolStripButton btnMostrarDatos;
        private System.Windows.Forms.ToolStripButton btnMostrarPromedio;
        private System.Windows.Forms.ComboBox cbMostrarAsignatura;
        private System.Windows.Forms.ComboBox cbMostrarRut;
    }
}