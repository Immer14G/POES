namespace AdministradorDeUsuarios
{
    partial class AdministracionDeUsuarios
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
            this.Modificacionlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.UsuarioslistBox = new System.Windows.Forms.ListBox();
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.AgregarGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).BeginInit();
            this.AgregarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Modificacionlabel
            // 
            this.Modificacionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificacionlabel.Location = new System.Drawing.Point(487, 266);
            this.Modificacionlabel.Name = "Modificacionlabel";
            this.Modificacionlabel.Size = new System.Drawing.Size(338, 45);
            this.Modificacionlabel.TabIndex = 0;
            this.Modificacionlabel.Text = "Modificaciones de Usuarios";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Usuario";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemover.Location = new System.Drawing.Point(529, 371);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(199, 50);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Eliminar";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(529, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(199, 53);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // UsuarioslistBox
            // 
            this.UsuarioslistBox.FormattingEnabled = true;
            this.UsuarioslistBox.ItemHeight = 16;
            this.UsuarioslistBox.Location = new System.Drawing.Point(417, 30);
            this.UsuarioslistBox.Name = "UsuarioslistBox";
            this.UsuarioslistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsuarioslistBox.Size = new System.Drawing.Size(588, 196);
            this.UsuarioslistBox.TabIndex = 18;
            this.UsuarioslistBox.SelectedIndexChanged += new System.EventHandler(this.UsuarioslistBox_SelectedIndexChanged);
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            // 
            // errorEstado
            // 
            this.errorEstado.ContainerControl = this;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(18, 49);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(105, 22);
            this.IdtextBox.TabIndex = 5;
            this.IdtextBox.TextChanged += new System.EventHandler(this.IdtextBox_TextChanged);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(176, 49);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(108, 22);
            this.NombretextBox.TabIndex = 6;
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(15, 125);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(108, 22);
            this.TelefonotextBox.TabIndex = 7;
            this.TelefonotextBox.Validated += new System.EventHandler(this.TelefonotextBox_Validated);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(176, 125);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(108, 22);
            this.EmailtextBox.TabIndex = 8;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(18, 202);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(108, 22);
            this.ContraseñatextBox.TabIndex = 9;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.EstadoComboBox.Location = new System.Drawing.Point(176, 200);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(108, 24);
            this.EstadoComboBox.TabIndex = 10;
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(27, 16);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(18, 16);
            this.Idlabel.TabIndex = 11;
            this.Idlabel.Text = "Id";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Location = new System.Drawing.Point(27, 92);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(61, 16);
            this.Telefonolabel.TabIndex = 12;
            this.Telefonolabel.Text = "Telefono";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(173, 92);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(41, 16);
            this.Emaillabel.TabIndex = 13;
            this.Emaillabel.Text = "Email";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(173, 16);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(56, 16);
            this.Nombrelabel.TabIndex = 14;
            this.Nombrelabel.Text = "Nombre";
            // 
            // ContraseñaLabel
            // 
            this.ContraseñaLabel.AutoSize = true;
            this.ContraseñaLabel.Location = new System.Drawing.Point(15, 177);
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            this.ContraseñaLabel.Size = new System.Drawing.Size(76, 16);
            this.ContraseñaLabel.TabIndex = 15;
            this.ContraseñaLabel.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(64, 251);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarGroupBox
            // 
            this.AgregarGroupBox.Controls.Add(this.btnAgregar);
            this.AgregarGroupBox.Controls.Add(this.Idlabel);
            this.AgregarGroupBox.Controls.Add(this.Nombrelabel);
            this.AgregarGroupBox.Controls.Add(this.IdtextBox);
            this.AgregarGroupBox.Controls.Add(this.label7);
            this.AgregarGroupBox.Controls.Add(this.Telefonolabel);
            this.AgregarGroupBox.Controls.Add(this.NombretextBox);
            this.AgregarGroupBox.Controls.Add(this.Emaillabel);
            this.AgregarGroupBox.Controls.Add(this.TelefonotextBox);
            this.AgregarGroupBox.Controls.Add(this.ContraseñaLabel);
            this.AgregarGroupBox.Controls.Add(this.EmailtextBox);
            this.AgregarGroupBox.Controls.Add(this.EstadoComboBox);
            this.AgregarGroupBox.Controls.Add(this.ContraseñatextBox);
            this.AgregarGroupBox.Location = new System.Drawing.Point(4, 58);
            this.AgregarGroupBox.Name = "AgregarGroupBox";
            this.AgregarGroupBox.Size = new System.Drawing.Size(369, 334);
            this.AgregarGroupBox.TabIndex = 19;
            this.AgregarGroupBox.TabStop = false;
            // 
            // AdministracionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1017, 486);
            this.Controls.Add(this.AgregarGroupBox);
            this.Controls.Add(this.UsuarioslistBox);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Modificacionlabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdministracionDeUsuarios";
            this.Text = "AdministracionDeUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).EndInit();
            this.AgregarGroupBox.ResumeLayout(false);
            this.AgregarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Modificacionlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListBox UsuarioslistBox;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorTelefono;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.ErrorProvider errorEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.Label ContraseñaLabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.GroupBox AgregarGroupBox;

        public System.ComponentModel.IContainer Components { get => components; set => components = value; }
    }
}