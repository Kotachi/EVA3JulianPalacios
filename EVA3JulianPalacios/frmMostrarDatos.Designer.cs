namespace EVA3JulianPalacios
{
    partial class frmMostrarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarDatos));
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.rutAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESDataSet = new EVA3JulianPalacios.LEONESDataSet();
            this.btnAtras = new System.Windows.Forms.Button();
            this.alumnosTableAdapter = new EVA3JulianPalacios.LEONESDataSetTableAdapters.AlumnosTableAdapter();
            this.buscarAlumnoToolStrip = new System.Windows.Forms.ToolStrip();
            this.rutAlumnoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rutAlumnoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.buscarAlumnoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mnLlenarTabla = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).BeginInit();
            this.buscarAlumnoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutAlumnoDataGridViewTextBoxColumn,
            this.nombreAlumnoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvAlumnos.DataSource = this.alumnosBindingSource;
            this.dgvAlumnos.Location = new System.Drawing.Point(31, 40);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(864, 409);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // rutAlumnoDataGridViewTextBoxColumn
            // 
            this.rutAlumnoDataGridViewTextBoxColumn.DataPropertyName = "rutAlumno";
            this.rutAlumnoDataGridViewTextBoxColumn.HeaderText = "rutAlumno";
            this.rutAlumnoDataGridViewTextBoxColumn.Name = "rutAlumnoDataGridViewTextBoxColumn";
            // 
            // nombreAlumnoDataGridViewTextBoxColumn
            // 
            this.nombreAlumnoDataGridViewTextBoxColumn.DataPropertyName = "nombreAlumno";
            this.nombreAlumnoDataGridViewTextBoxColumn.HeaderText = "nombreAlumno";
            this.nombreAlumnoDataGridViewTextBoxColumn.Name = "nombreAlumnoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.lEONESDataSetBindingSource;
            // 
            // lEONESDataSetBindingSource
            // 
            this.lEONESDataSetBindingSource.DataSource = this.lEONESDataSet;
            this.lEONESDataSetBindingSource.Position = 0;
            // 
            // lEONESDataSet
            // 
            this.lEONESDataSet.DataSetName = "LEONESDataSet";
            this.lEONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(948, 25);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // buscarAlumnoToolStrip
            // 
            this.buscarAlumnoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutAlumnoToolStripLabel,
            this.rutAlumnoToolStripTextBox,
            this.buscarAlumnoToolStripButton,
            this.mnLlenarTabla});
            this.buscarAlumnoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.buscarAlumnoToolStrip.Name = "buscarAlumnoToolStrip";
            this.buscarAlumnoToolStrip.Size = new System.Drawing.Size(1043, 25);
            this.buscarAlumnoToolStrip.TabIndex = 2;
            this.buscarAlumnoToolStrip.Text = "buscarAlumnoToolStrip";
            // 
            // rutAlumnoToolStripLabel
            // 
            this.rutAlumnoToolStripLabel.Name = "rutAlumnoToolStripLabel";
            this.rutAlumnoToolStripLabel.Size = new System.Drawing.Size(68, 22);
            this.rutAlumnoToolStripLabel.Text = "rutAlumno:";
            // 
            // rutAlumnoToolStripTextBox
            // 
            this.rutAlumnoToolStripTextBox.Name = "rutAlumnoToolStripTextBox";
            this.rutAlumnoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // buscarAlumnoToolStripButton
            // 
            this.buscarAlumnoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buscarAlumnoToolStripButton.Name = "buscarAlumnoToolStripButton";
            this.buscarAlumnoToolStripButton.Size = new System.Drawing.Size(92, 22);
            this.buscarAlumnoToolStripButton.Text = "Buscar Alumno";
            this.buscarAlumnoToolStripButton.Click += new System.EventHandler(this.buscarAlumnoToolStripButton_Click);
            // 
            // mnLlenarTabla
            // 
            this.mnLlenarTabla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnLlenarTabla.Image = ((System.Drawing.Image)(resources.GetObject("mnLlenarTabla.Image")));
            this.mnLlenarTabla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnLlenarTabla.Name = "mnLlenarTabla";
            this.mnLlenarTabla.Size = new System.Drawing.Size(43, 22);
            this.mnLlenarTabla.Text = "Llenar";
            this.mnLlenarTabla.Click += new System.EventHandler(this.mnLlenarTabla_Click);
            // 
            // frmMostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 529);
            this.Controls.Add(this.buscarAlumnoToolStrip);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "frmMostrarDatos";
            this.Text = "Mostrar Datos";
            this.Load += new System.EventHandler(this.frmMostrarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).EndInit();
            this.buscarAlumnoToolStrip.ResumeLayout(false);
            this.buscarAlumnoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource lEONESDataSetBindingSource;
        private LEONESDataSet lEONESDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private LEONESDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip buscarAlumnoToolStrip;
        private System.Windows.Forms.ToolStripLabel rutAlumnoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rutAlumnoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton buscarAlumnoToolStripButton;
        private System.Windows.Forms.ToolStripButton mnLlenarTabla;
    }
}