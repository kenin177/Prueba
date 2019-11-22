namespace RRHHPlanilla
{
    partial class FrmConfirmarConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmarConf));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboprivil = new System.Windows.Forms.ComboBox();
            this.listaSeguridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPrivilegiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listaSeguridadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaSeguridadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.lblcamb = new System.Windows.Forms.LinkLabel();
            this.lblcamb1 = new System.Windows.Forms.LinkLabel();
            this.lblcamb2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrivilegiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingNavigator)).BeginInit();
            this.listaSeguridadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RRHHPlanilla.Properties.Resources.salir;
            this.pictureBox1.Location = new System.Drawing.Point(1038, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboprivil
            // 
            this.comboprivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboprivil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaSeguridadBindingSource, "PrivilegioId", true));
            this.comboprivil.DataSource = this.listaPrivilegiosBindingSource;
            this.comboprivil.DisplayMember = "Descripcion";
            this.comboprivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboprivil.FormattingEnabled = true;
            this.comboprivil.Location = new System.Drawing.Point(529, 481);
            this.comboprivil.Name = "comboprivil";
            this.comboprivil.Size = new System.Drawing.Size(121, 21);
            this.comboprivil.TabIndex = 10;
            this.comboprivil.ValueMember = "Id";
            // 
            // listaSeguridadBindingSource
            // 
            this.listaSeguridadBindingSource.DataSource = typeof(RRHH.BL.Usuario);
            // 
            // listaPrivilegiosBindingSource
            // 
            this.listaPrivilegiosBindingSource.DataSource = typeof(RRHH.BL.Privilegio);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Privilegio:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "Nombre de Usuario:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Cedula:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Confirmación de Contraseña:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre:";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(122, 34);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(518, 49);
            this.lblhora.TabIndex = 53;
            this.lblhora.Text = "Configuración de Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(796, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(197, 142);
            this.dataGridView1.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(817, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 18);
            this.label10.TabIndex = 74;
            this.label10.Text = "Seleccionar Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fotoPictureBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(228, 255);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FOTO";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaSeguridadBindingNavigator
            // 
            this.listaSeguridadBindingNavigator.AddNewItem = null;
            this.listaSeguridadBindingNavigator.BindingSource = this.listaSeguridadBindingSource;
            this.listaSeguridadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaSeguridadBindingNavigator.DeleteItem = null;
            this.listaSeguridadBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.listaSeguridadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaSeguridadBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.listaSeguridadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaSeguridadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaSeguridadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaSeguridadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaSeguridadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaSeguridadBindingNavigator.Name = "listaSeguridadBindingNavigator";
            this.listaSeguridadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaSeguridadBindingNavigator.Size = new System.Drawing.Size(339, 25);
            this.listaSeguridadBindingNavigator.TabIndex = 76;
            this.listaSeguridadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaSeguridadBindingNavigatorSaveItem
            // 
            this.listaSeguridadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaSeguridadBindingNavigatorSaveItem.Enabled = false;
            this.listaSeguridadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaSeguridadBindingNavigatorSaveItem.Image")));
            this.listaSeguridadBindingNavigatorSaveItem.Name = "listaSeguridadBindingNavigatorSaveItem";
            this.listaSeguridadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaSeguridadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaSeguridadBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaSeguridadBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Cancelar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(529, 233);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(164, 20);
            this.apellidoTextBox.TabIndex = 3;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(529, 453);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(164, 20);
            this.cedulaTextBox.TabIndex = 9;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contrasenaTextBox.BackColor = System.Drawing.Color.Silver;
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Location = new System.Drawing.Point(529, 263);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.ReadOnly = true;
            this.contrasenaTextBox.Size = new System.Drawing.Size(164, 20);
            this.contrasenaTextBox.TabIndex = 4;
            this.contrasenaTextBox.UseSystemPasswordChar = true;
            this.contrasenaTextBox.TextChanged += new System.EventHandler(this.contrasenaTextBox_TextChanged);
            this.contrasenaTextBox.Leave += new System.EventHandler(this.contrasenaTextBox_Leave);
            // 
            // correoTextBox
            // 
            this.correoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(529, 387);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(164, 20);
            this.correoTextBox.TabIndex = 7;
            // 
            // edadTextBox
            // 
            this.edadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(529, 419);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(164, 20);
            this.edadTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(529, 141);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(164, 20);
            this.idTextBox.TabIndex = 87;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(529, 202);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(164, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // nombUsuarioTextBox
            // 
            this.nombUsuarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nombUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "NombUsuario", true));
            this.nombUsuarioTextBox.Location = new System.Drawing.Point(529, 171);
            this.nombUsuarioTextBox.Name = "nombUsuarioTextBox";
            this.nombUsuarioTextBox.Size = new System.Drawing.Size(164, 20);
            this.nombUsuarioTextBox.TabIndex = 1;
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtconfirmar.Location = new System.Drawing.Point(529, 345);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(164, 20);
            this.txtconfirmar.TabIndex = 6;
            this.txtconfirmar.UseSystemPasswordChar = true;
            this.txtconfirmar.TextChanged += new System.EventHandler(this.txtconfirmar_TextChanged);
            this.txtconfirmar.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 18);
            this.label11.TabIndex = 93;
            this.label11.Text = "Id";
            // 
            // txtnueva
            // 
            this.txtnueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnueva.Location = new System.Drawing.Point(529, 305);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(164, 20);
            this.txtnueva.TabIndex = 5;
            this.txtnueva.UseSystemPasswordChar = true;
            this.txtnueva.TextChanged += new System.EventHandler(this.txtnueva_TextChanged);
            this.txtnueva.Leave += new System.EventHandler(this.txtnueva_Leave);
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrasena.Location = new System.Drawing.Point(323, 262);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(140, 18);
            this.lblcontrasena.TabIndex = 96;
            this.lblcontrasena.Text = "Antigua Contraseña:";
            // 
            // lblcamb
            // 
            this.lblcamb.AutoSize = true;
            this.lblcamb.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcamb.LinkColor = System.Drawing.Color.Red;
            this.lblcamb.Location = new System.Drawing.Point(517, 286);
            this.lblcamb.Name = "lblcamb";
            this.lblcamb.Size = new System.Drawing.Size(49, 12);
            this.lblcamb.TabIndex = 98;
            this.lblcamb.TabStop = true;
            this.lblcamb.Text = "linkLabel1";
            this.lblcamb.Visible = false;
            // 
            // lblcamb1
            // 
            this.lblcamb1.AutoSize = true;
            this.lblcamb1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcamb1.LinkColor = System.Drawing.Color.Red;
            this.lblcamb1.Location = new System.Drawing.Point(517, 328);
            this.lblcamb1.Name = "lblcamb1";
            this.lblcamb1.Size = new System.Drawing.Size(49, 12);
            this.lblcamb1.TabIndex = 99;
            this.lblcamb1.TabStop = true;
            this.lblcamb1.Text = "linkLabel1";
            this.lblcamb1.Visible = false;
            // 
            // lblcamb2
            // 
            this.lblcamb2.AutoSize = true;
            this.lblcamb2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcamb2.LinkColor = System.Drawing.Color.Red;
            this.lblcamb2.Location = new System.Drawing.Point(517, 368);
            this.lblcamb2.Name = "lblcamb2";
            this.lblcamb2.Size = new System.Drawing.Size(49, 12);
            this.lblcamb2.TabIndex = 100;
            this.lblcamb2.TabStop = true;
            this.lblcamb2.Text = "linkLabel1";
            this.lblcamb2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RRHHPlanilla.Properties.Resources.ojo3;
            this.pictureBox2.Location = new System.Drawing.Point(686, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaSeguridadBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(20, 27);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(190, 173);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 101;
            this.fotoPictureBox.TabStop = false;
            // 
            // FrmConfirmarConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1080, 588);
            this.Controls.Add(this.lblcamb2);
            this.Controls.Add(this.lblcamb1);
            this.Controls.Add(this.lblcamb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombUsuarioTextBox);
            this.Controls.Add(this.listaSeguridadBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboprivil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfirmarConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmarConf";
            this.Load += new System.EventHandler(this.FrmConfirmarConf_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConfirmarConf_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrivilegiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingNavigator)).EndInit();
            this.listaSeguridadBindingNavigator.ResumeLayout(false);
            this.listaSeguridadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboprivil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource listaSeguridadBindingSource;
        private System.Windows.Forms.BindingNavigator listaSeguridadBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaSeguridadBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombUsuarioTextBox;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource listaPrivilegiosBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.LinkLabel lblcamb;
        private System.Windows.Forms.LinkLabel lblcamb1;
        private System.Windows.Forms.LinkLabel lblcamb2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox fotoPictureBox;
    }
}