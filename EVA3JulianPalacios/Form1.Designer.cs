namespace EVA3JulianPalacios
{
    partial class frmIngresoDatos
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
            this.txtIngRut = new System.Windows.Forms.TextBox();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.txtIngEmail = new System.Windows.Forms.TextBox();
            this.lbIngRut = new System.Windows.Forms.Label();
            this.lbIngNombre = new System.Windows.Forms.Label();
            this.lbIngEmail = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.dtpFechaNota = new System.Windows.Forms.DateTimePicker();
            this.lbIngNota = new System.Windows.Forms.Label();
            this.lbIngFechaNota = new System.Windows.Forms.Label();
            this.txtIngCodAsignatura = new System.Windows.Forms.TextBox();
            this.txtIngDescAsignatura = new System.Windows.Forms.TextBox();
            this.lbCodAsignatura = new System.Windows.Forms.Label();
            this.lbDescAsignatura = new System.Windows.Forms.Label();
            this.btnMostrarAlumnosDG = new System.Windows.Forms.Button();
            this.btnMostrarAsignatura = new System.Windows.Forms.Button();
            this.btnMostrarNotas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgregarAsignatura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgregarNota = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarAsignatura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarRutAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarNombreAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarEmailAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarNota1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarNota2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarNota3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarAsignatura = new System.Windows.Forms.ToolStripMenuItem();
            this.rbAsignatura = new System.Windows.Forms.RadioButton();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.rbNota = new System.Windows.Forms.RadioButton();
            this.txtIngNota2 = new System.Windows.Forms.TextBox();
            this.txtIngNota3 = new System.Windows.Forms.TextBox();
            this.lbIngNota2 = new System.Windows.Forms.Label();
            this.lbIngNota3 = new System.Windows.Forms.Label();
            this.txtIngNuevoRut = new System.Windows.Forms.TextBox();
            this.lbIngNuevoRut = new System.Windows.Forms.Label();
            this.lbIngNCodAsignatura = new System.Windows.Forms.Label();
            this.cbIngNotas = new System.Windows.Forms.ComboBox();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESDataSet = new EVA3JulianPalacios.LEONESDataSet();
            this.asignaturasTableAdapter = new EVA3JulianPalacios.LEONESDataSetTableAdapters.AsignaturasTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngRut
            // 
            this.txtIngRut.Location = new System.Drawing.Point(113, 195);
            this.txtIngRut.Name = "txtIngRut";
            this.txtIngRut.Size = new System.Drawing.Size(100, 20);
            this.txtIngRut.TabIndex = 0;
            this.txtIngRut.Visible = false;
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Location = new System.Drawing.Point(285, 195);
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(185, 20);
            this.txtIngNombre.TabIndex = 1;
            this.txtIngNombre.Visible = false;
            // 
            // txtIngEmail
            // 
            this.txtIngEmail.Location = new System.Drawing.Point(551, 195);
            this.txtIngEmail.Name = "txtIngEmail";
            this.txtIngEmail.Size = new System.Drawing.Size(100, 20);
            this.txtIngEmail.TabIndex = 2;
            this.txtIngEmail.Visible = false;
            // 
            // lbIngRut
            // 
            this.lbIngRut.AutoSize = true;
            this.lbIngRut.Location = new System.Drawing.Point(110, 179);
            this.lbIngRut.Name = "lbIngRut";
            this.lbIngRut.Size = new System.Drawing.Size(62, 13);
            this.lbIngRut.TabIndex = 3;
            this.lbIngRut.Text = "Ingrese Rut";
            this.lbIngRut.Visible = false;
            // 
            // lbIngNombre
            // 
            this.lbIngNombre.AutoSize = true;
            this.lbIngNombre.Location = new System.Drawing.Point(282, 179);
            this.lbIngNombre.Name = "lbIngNombre";
            this.lbIngNombre.Size = new System.Drawing.Size(85, 13);
            this.lbIngNombre.TabIndex = 4;
            this.lbIngNombre.Text = "Ingresar Nombre";
            this.lbIngNombre.Visible = false;
            // 
            // lbIngEmail
            // 
            this.lbIngEmail.AutoSize = true;
            this.lbIngEmail.Location = new System.Drawing.Point(548, 179);
            this.lbIngEmail.Name = "lbIngEmail";
            this.lbIngEmail.Size = new System.Drawing.Size(73, 13);
            this.lbIngEmail.TabIndex = 5;
            this.lbIngEmail.Text = "Ingresar Email";
            this.lbIngEmail.Visible = false;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(113, 294);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 6;
            this.txtNota.Visible = false;
            // 
            // dtpFechaNota
            // 
            this.dtpFechaNota.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaNota.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNota.Location = new System.Drawing.Point(651, 291);
            this.dtpFechaNota.Name = "dtpFechaNota";
            this.dtpFechaNota.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNota.TabIndex = 8;
            this.dtpFechaNota.Value = new System.DateTime(2017, 11, 27, 1, 25, 0, 0);
            this.dtpFechaNota.Visible = false;
            this.dtpFechaNota.ValueChanged += new System.EventHandler(this.dtpFechaNota_ValueChanged);
            // 
            // lbIngNota
            // 
            this.lbIngNota.AutoSize = true;
            this.lbIngNota.Location = new System.Drawing.Point(110, 278);
            this.lbIngNota.Name = "lbIngNota";
            this.lbIngNota.Size = new System.Drawing.Size(77, 13);
            this.lbIngNota.TabIndex = 9;
            this.lbIngNota.Text = "Ingrese Nota 1";
            this.lbIngNota.Visible = false;
            // 
            // lbIngFechaNota
            // 
            this.lbIngFechaNota.AutoSize = true;
            this.lbIngFechaNota.Location = new System.Drawing.Point(648, 275);
            this.lbIngFechaNota.Name = "lbIngFechaNota";
            this.lbIngFechaNota.Size = new System.Drawing.Size(101, 13);
            this.lbIngFechaNota.TabIndex = 10;
            this.lbIngFechaNota.Text = "Ingrese Fecha Nota";
            this.lbIngFechaNota.Visible = false;
            // 
            // txtIngCodAsignatura
            // 
            this.txtIngCodAsignatura.Location = new System.Drawing.Point(285, 116);
            this.txtIngCodAsignatura.Name = "txtIngCodAsignatura";
            this.txtIngCodAsignatura.Size = new System.Drawing.Size(128, 20);
            this.txtIngCodAsignatura.TabIndex = 11;
            this.txtIngCodAsignatura.Visible = false;
            // 
            // txtIngDescAsignatura
            // 
            this.txtIngDescAsignatura.Location = new System.Drawing.Point(476, 117);
            this.txtIngDescAsignatura.Multiline = true;
            this.txtIngDescAsignatura.Name = "txtIngDescAsignatura";
            this.txtIngDescAsignatura.Size = new System.Drawing.Size(347, 20);
            this.txtIngDescAsignatura.TabIndex = 12;
            this.txtIngDescAsignatura.Visible = false;
            // 
            // lbCodAsignatura
            // 
            this.lbCodAsignatura.AutoSize = true;
            this.lbCodAsignatura.Location = new System.Drawing.Point(109, 100);
            this.lbCodAsignatura.Name = "lbCodAsignatura";
            this.lbCodAsignatura.Size = new System.Drawing.Size(93, 13);
            this.lbCodAsignatura.TabIndex = 13;
            this.lbCodAsignatura.Text = "Codigo Asignatura";
            this.lbCodAsignatura.Visible = false;
            // 
            // lbDescAsignatura
            // 
            this.lbDescAsignatura.AutoSize = true;
            this.lbDescAsignatura.Location = new System.Drawing.Point(473, 101);
            this.lbDescAsignatura.Name = "lbDescAsignatura";
            this.lbDescAsignatura.Size = new System.Drawing.Size(154, 13);
            this.lbDescAsignatura.TabIndex = 14;
            this.lbDescAsignatura.Text = "Ingrese Descripcion Asignatura";
            this.lbDescAsignatura.Visible = false;
            // 
            // btnMostrarAlumnosDG
            // 
            this.btnMostrarAlumnosDG.Location = new System.Drawing.Point(112, 453);
            this.btnMostrarAlumnosDG.Name = "btnMostrarAlumnosDG";
            this.btnMostrarAlumnosDG.Size = new System.Drawing.Size(111, 23);
            this.btnMostrarAlumnosDG.TabIndex = 16;
            this.btnMostrarAlumnosDG.Text = "Mostrar Alumnos";
            this.btnMostrarAlumnosDG.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnosDG.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarAsignatura
            // 
            this.btnMostrarAsignatura.Location = new System.Drawing.Point(285, 453);
            this.btnMostrarAsignatura.Name = "btnMostrarAsignatura";
            this.btnMostrarAsignatura.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarAsignatura.TabIndex = 17;
            this.btnMostrarAsignatura.Text = "Mostrar Asignaturas";
            this.btnMostrarAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnMostrarNotas
            // 
            this.btnMostrarNotas.Location = new System.Drawing.Point(476, 453);
            this.btnMostrarNotas.Name = "btnMostrarNotas";
            this.btnMostrarNotas.Size = new System.Drawing.Size(116, 23);
            this.btnMostrarNotas.TabIndex = 18;
            this.btnMostrarNotas.Text = "Mostrar Notas";
            this.btnMostrarNotas.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgregar,
            this.mnEliminar,
            this.mnModificar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnAgregar
            // 
            this.mnAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgregarAlumno,
            this.mnAgregarAsignatura,
            this.mnAgregarNota});
            this.mnAgregar.Name = "mnAgregar";
            this.mnAgregar.Size = new System.Drawing.Size(61, 20);
            this.mnAgregar.Text = "Agregar";
            // 
            // mnAgregarAlumno
            // 
            this.mnAgregarAlumno.Name = "mnAgregarAlumno";
            this.mnAgregarAlumno.Size = new System.Drawing.Size(131, 22);
            this.mnAgregarAlumno.Text = "Alumno";
            this.mnAgregarAlumno.Click += new System.EventHandler(this.mnAgregarAlumno_Click);
            // 
            // mnAgregarAsignatura
            // 
            this.mnAgregarAsignatura.Name = "mnAgregarAsignatura";
            this.mnAgregarAsignatura.Size = new System.Drawing.Size(131, 22);
            this.mnAgregarAsignatura.Text = "Asignatura";
            this.mnAgregarAsignatura.Click += new System.EventHandler(this.mnAgregarAsignatura_Click);
            // 
            // mnAgregarNota
            // 
            this.mnAgregarNota.Name = "mnAgregarNota";
            this.mnAgregarNota.Size = new System.Drawing.Size(131, 22);
            this.mnAgregarNota.Text = "Nota";
            this.mnAgregarNota.Click += new System.EventHandler(this.mnAgregarNota_Click);
            // 
            // mnEliminar
            // 
            this.mnEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEliminarAlumno,
            this.mnEliminarNotas,
            this.mnEliminarAsignatura});
            this.mnEliminar.Name = "mnEliminar";
            this.mnEliminar.Size = new System.Drawing.Size(62, 20);
            this.mnEliminar.Text = "Eliminar";
            // 
            // mnEliminarAlumno
            // 
            this.mnEliminarAlumno.Name = "mnEliminarAlumno";
            this.mnEliminarAlumno.Size = new System.Drawing.Size(131, 22);
            this.mnEliminarAlumno.Text = "Alumno";
            this.mnEliminarAlumno.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // mnEliminarNotas
            // 
            this.mnEliminarNotas.Name = "mnEliminarNotas";
            this.mnEliminarNotas.Size = new System.Drawing.Size(131, 22);
            this.mnEliminarNotas.Text = "Notas";
            this.mnEliminarNotas.Click += new System.EventHandler(this.mnEliminarNotas_Click);
            // 
            // mnEliminarAsignatura
            // 
            this.mnEliminarAsignatura.Name = "mnEliminarAsignatura";
            this.mnEliminarAsignatura.Size = new System.Drawing.Size(131, 22);
            this.mnEliminarAsignatura.Text = "Asignatura";
            this.mnEliminarAsignatura.Click += new System.EventHandler(this.mnEliminarAsignatura_Click);
            // 
            // mnModificar
            // 
            this.mnModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnModificarAlumno,
            this.mnModificarNotas,
            this.mnModificarAsignatura});
            this.mnModificar.Name = "mnModificar";
            this.mnModificar.Size = new System.Drawing.Size(70, 20);
            this.mnModificar.Text = "Modificar";
            // 
            // mnModificarAlumno
            // 
            this.mnModificarAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnModificarRutAlumno,
            this.mnModificarNombreAlumno,
            this.mnModificarEmailAlumno,
            this.mnModificarTodo});
            this.mnModificarAlumno.Name = "mnModificarAlumno";
            this.mnModificarAlumno.Size = new System.Drawing.Size(131, 22);
            this.mnModificarAlumno.Text = "Alumno";
            this.mnModificarAlumno.Click += new System.EventHandler(this.mnModificarAlumno_Click);
            // 
            // mnModificarRutAlumno
            // 
            this.mnModificarRutAlumno.Name = "mnModificarRutAlumno";
            this.mnModificarRutAlumno.Size = new System.Drawing.Size(118, 22);
            this.mnModificarRutAlumno.Text = "Rut";
            this.mnModificarRutAlumno.Click += new System.EventHandler(this.mnModificarRutAlumno_Click);
            // 
            // mnModificarNombreAlumno
            // 
            this.mnModificarNombreAlumno.Name = "mnModificarNombreAlumno";
            this.mnModificarNombreAlumno.Size = new System.Drawing.Size(118, 22);
            this.mnModificarNombreAlumno.Text = "Nombre";
            this.mnModificarNombreAlumno.Click += new System.EventHandler(this.mnModificarNombreAlumno_Click);
            // 
            // mnModificarEmailAlumno
            // 
            this.mnModificarEmailAlumno.Name = "mnModificarEmailAlumno";
            this.mnModificarEmailAlumno.Size = new System.Drawing.Size(118, 22);
            this.mnModificarEmailAlumno.Text = "Email";
            this.mnModificarEmailAlumno.Click += new System.EventHandler(this.mnModificarEmailAlumno_Click);
            // 
            // mnModificarTodo
            // 
            this.mnModificarTodo.Name = "mnModificarTodo";
            this.mnModificarTodo.Size = new System.Drawing.Size(118, 22);
            this.mnModificarTodo.Text = "Todo";
            this.mnModificarTodo.Click += new System.EventHandler(this.mnModificarTodo_Click);
            // 
            // mnModificarNotas
            // 
            this.mnModificarNotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnModificarNota1,
            this.mnModificarNota2,
            this.mnModificarNota3});
            this.mnModificarNotas.Name = "mnModificarNotas";
            this.mnModificarNotas.Size = new System.Drawing.Size(131, 22);
            this.mnModificarNotas.Text = "Notas";
            // 
            // mnModificarNota1
            // 
            this.mnModificarNota1.Name = "mnModificarNota1";
            this.mnModificarNota1.Size = new System.Drawing.Size(109, 22);
            this.mnModificarNota1.Text = "Nota 1";
            this.mnModificarNota1.Click += new System.EventHandler(this.mnModificarNota1_Click);
            // 
            // mnModificarNota2
            // 
            this.mnModificarNota2.Name = "mnModificarNota2";
            this.mnModificarNota2.Size = new System.Drawing.Size(109, 22);
            this.mnModificarNota2.Text = "Nota 2";
            this.mnModificarNota2.Click += new System.EventHandler(this.mnModificarNota2_Click);
            // 
            // mnModificarNota3
            // 
            this.mnModificarNota3.Name = "mnModificarNota3";
            this.mnModificarNota3.Size = new System.Drawing.Size(109, 22);
            this.mnModificarNota3.Text = "Nota 3";
            this.mnModificarNota3.Click += new System.EventHandler(this.mnModificarNota3_Click);
            // 
            // mnModificarAsignatura
            // 
            this.mnModificarAsignatura.Name = "mnModificarAsignatura";
            this.mnModificarAsignatura.Size = new System.Drawing.Size(131, 22);
            this.mnModificarAsignatura.Text = "Asignatura";
            this.mnModificarAsignatura.Click += new System.EventHandler(this.mnModificarAsignatura_Click);
            // 
            // rbAsignatura
            // 
            this.rbAsignatura.AutoSize = true;
            this.rbAsignatura.Location = new System.Drawing.Point(140, 47);
            this.rbAsignatura.Name = "rbAsignatura";
            this.rbAsignatura.Size = new System.Drawing.Size(75, 17);
            this.rbAsignatura.TabIndex = 22;
            this.rbAsignatura.TabStop = true;
            this.rbAsignatura.Text = "Asignatura";
            this.rbAsignatura.UseVisualStyleBackColor = true;
            this.rbAsignatura.CheckedChanged += new System.EventHandler(this.rbAsignatura_CheckedChanged);
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.Location = new System.Drawing.Point(370, 47);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbAlumno.TabIndex = 23;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            this.rbAlumno.CheckedChanged += new System.EventHandler(this.rbAlumno_CheckedChanged);
            // 
            // rbNota
            // 
            this.rbNota.AutoSize = true;
            this.rbNota.Location = new System.Drawing.Point(588, 47);
            this.rbNota.Name = "rbNota";
            this.rbNota.Size = new System.Drawing.Size(48, 17);
            this.rbNota.TabIndex = 24;
            this.rbNota.TabStop = true;
            this.rbNota.Text = "Nota";
            this.rbNota.UseVisualStyleBackColor = true;
            this.rbNota.CheckedChanged += new System.EventHandler(this.rbNota_CheckedChanged);
            // 
            // txtIngNota2
            // 
            this.txtIngNota2.Location = new System.Drawing.Point(285, 294);
            this.txtIngNota2.Name = "txtIngNota2";
            this.txtIngNota2.Size = new System.Drawing.Size(100, 20);
            this.txtIngNota2.TabIndex = 25;
            this.txtIngNota2.Visible = false;
            // 
            // txtIngNota3
            // 
            this.txtIngNota3.Location = new System.Drawing.Point(476, 291);
            this.txtIngNota3.Name = "txtIngNota3";
            this.txtIngNota3.Size = new System.Drawing.Size(100, 20);
            this.txtIngNota3.TabIndex = 26;
            this.txtIngNota3.Visible = false;
            // 
            // lbIngNota2
            // 
            this.lbIngNota2.AutoSize = true;
            this.lbIngNota2.Location = new System.Drawing.Point(282, 278);
            this.lbIngNota2.Name = "lbIngNota2";
            this.lbIngNota2.Size = new System.Drawing.Size(77, 13);
            this.lbIngNota2.TabIndex = 27;
            this.lbIngNota2.Text = "Ingrese Nota 2";
            this.lbIngNota2.Visible = false;
            // 
            // lbIngNota3
            // 
            this.lbIngNota3.AutoSize = true;
            this.lbIngNota3.Location = new System.Drawing.Point(473, 275);
            this.lbIngNota3.Name = "lbIngNota3";
            this.lbIngNota3.Size = new System.Drawing.Size(77, 13);
            this.lbIngNota3.TabIndex = 28;
            this.lbIngNota3.Text = "Ingreso Nota 3";
            this.lbIngNota3.Visible = false;
            // 
            // txtIngNuevoRut
            // 
            this.txtIngNuevoRut.Location = new System.Drawing.Point(719, 195);
            this.txtIngNuevoRut.Name = "txtIngNuevoRut";
            this.txtIngNuevoRut.Size = new System.Drawing.Size(100, 20);
            this.txtIngNuevoRut.TabIndex = 29;
            this.txtIngNuevoRut.Visible = false;
            // 
            // lbIngNuevoRut
            // 
            this.lbIngNuevoRut.AutoSize = true;
            this.lbIngNuevoRut.Location = new System.Drawing.Point(716, 179);
            this.lbIngNuevoRut.Name = "lbIngNuevoRut";
            this.lbIngNuevoRut.Size = new System.Drawing.Size(100, 13);
            this.lbIngNuevoRut.TabIndex = 30;
            this.lbIngNuevoRut.Text = "Ingresar Nuevo Rut";
            this.lbIngNuevoRut.Visible = false;
            // 
            // lbIngNCodAsignatura
            // 
            this.lbIngNCodAsignatura.AutoSize = true;
            this.lbIngNCodAsignatura.Location = new System.Drawing.Point(282, 100);
            this.lbIngNCodAsignatura.Name = "lbIngNCodAsignatura";
            this.lbIngNCodAsignatura.Size = new System.Drawing.Size(166, 13);
            this.lbIngNCodAsignatura.TabIndex = 32;
            this.lbIngNCodAsignatura.Text = "Ingrese Nuevo Codigo Asignatura";
            this.lbIngNCodAsignatura.Visible = false;
            // 
            // cbIngNotas
            // 
            this.cbIngNotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbIngNotas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.asignaturasBindingSource, "CodAsignatura", true));
            this.cbIngNotas.DataSource = this.asignaturasBindingSource;
            this.cbIngNotas.DisplayMember = "CodAsignatura";
            this.cbIngNotas.FormattingEnabled = true;
            this.cbIngNotas.Location = new System.Drawing.Point(112, 116);
            this.cbIngNotas.MaxDropDownItems = 100;
            this.cbIngNotas.Name = "cbIngNotas";
            this.cbIngNotas.Size = new System.Drawing.Size(121, 21);
            this.cbIngNotas.TabIndex = 33;
            this.cbIngNotas.Visible = false;
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
            // frmIngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 533);
            this.Controls.Add(this.cbIngNotas);
            this.Controls.Add(this.lbIngNCodAsignatura);
            this.Controls.Add(this.lbIngNuevoRut);
            this.Controls.Add(this.txtIngNuevoRut);
            this.Controls.Add(this.lbIngNota3);
            this.Controls.Add(this.lbIngNota2);
            this.Controls.Add(this.txtIngNota3);
            this.Controls.Add(this.txtIngNota2);
            this.Controls.Add(this.rbNota);
            this.Controls.Add(this.rbAlumno);
            this.Controls.Add(this.rbAsignatura);
            this.Controls.Add(this.btnMostrarNotas);
            this.Controls.Add(this.btnMostrarAsignatura);
            this.Controls.Add(this.btnMostrarAlumnosDG);
            this.Controls.Add(this.lbDescAsignatura);
            this.Controls.Add(this.lbCodAsignatura);
            this.Controls.Add(this.txtIngDescAsignatura);
            this.Controls.Add(this.txtIngCodAsignatura);
            this.Controls.Add(this.lbIngFechaNota);
            this.Controls.Add(this.lbIngNota);
            this.Controls.Add(this.dtpFechaNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lbIngEmail);
            this.Controls.Add(this.lbIngNombre);
            this.Controls.Add(this.lbIngRut);
            this.Controls.Add(this.txtIngEmail);
            this.Controls.Add(this.txtIngNombre);
            this.Controls.Add(this.txtIngRut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIngresoDatos";
            this.Text = "Ingreso Datos";
            this.Load += new System.EventHandler(this.frmIngresoDatos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngRut;
        private System.Windows.Forms.TextBox txtIngNombre;
        private System.Windows.Forms.TextBox txtIngEmail;
        private System.Windows.Forms.Label lbIngRut;
        private System.Windows.Forms.Label lbIngNombre;
        private System.Windows.Forms.Label lbIngEmail;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.DateTimePicker dtpFechaNota;
        private System.Windows.Forms.Label lbIngNota;
        private System.Windows.Forms.Label lbIngFechaNota;
        private System.Windows.Forms.TextBox txtIngCodAsignatura;
        private System.Windows.Forms.TextBox txtIngDescAsignatura;
        private System.Windows.Forms.Label lbCodAsignatura;
        private System.Windows.Forms.Label lbDescAsignatura;
        private System.Windows.Forms.Button btnMostrarAlumnosDG;
        private System.Windows.Forms.Button btnMostrarAsignatura;
        private System.Windows.Forms.Button btnMostrarNotas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnAgregar;
        private System.Windows.Forms.ToolStripMenuItem mnAgregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnAgregarAsignatura;
        private System.Windows.Forms.ToolStripMenuItem mnAgregarNota;
        private System.Windows.Forms.RadioButton rbAsignatura;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.RadioButton rbNota;
        private System.Windows.Forms.TextBox txtIngNota2;
        private System.Windows.Forms.TextBox txtIngNota3;
        private System.Windows.Forms.Label lbIngNota2;
        private System.Windows.Forms.Label lbIngNota3;
        private System.Windows.Forms.ToolStripMenuItem mnEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarNotas;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarAsignatura;
        private System.Windows.Forms.ToolStripMenuItem mnModificar;
        private System.Windows.Forms.ToolStripMenuItem mnModificarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnModificarRutAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnModificarNombreAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnModificarEmailAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnModificarTodo;
        private System.Windows.Forms.TextBox txtIngNuevoRut;
        private System.Windows.Forms.Label lbIngNuevoRut;
        private System.Windows.Forms.ToolStripMenuItem mnModificarNotas;
        private System.Windows.Forms.ToolStripMenuItem mnModificarNota1;
        private System.Windows.Forms.ToolStripMenuItem mnModificarNota2;
        private System.Windows.Forms.ToolStripMenuItem mnModificarNota3;
        private System.Windows.Forms.ToolStripMenuItem mnModificarAsignatura;
        private System.Windows.Forms.Label lbIngNCodAsignatura;
        private System.Windows.Forms.ComboBox cbIngNotas;
        private LEONESDataSet lEONESDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private LEONESDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
    }
}

