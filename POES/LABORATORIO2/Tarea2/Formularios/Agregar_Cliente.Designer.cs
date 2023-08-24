namespace ProyectoGym.Formularios
{
    partial class Agregar_Cliente
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
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.MembresiaLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grupo = new System.Windows.Forms.Label();
            this.coach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coachtextBox = new System.Windows.Forms.TextBox();
            this.MembresiascomboBox = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pagoListBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtvgDatos = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(49, 50);
            this.Nombrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(56, 16);
            this.Nombrelabel.TabIndex = 0;
            this.Nombrelabel.Text = "Nombre";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(8, 78);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(155, 22);
            this.NombretextBox.TabIndex = 1;
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(136, 179);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(72, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // MembresiaLabel
            // 
            this.MembresiaLabel.AutoSize = true;
            this.MembresiaLabel.Location = new System.Drawing.Point(209, 50);
            this.MembresiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MembresiaLabel.Name = "MembresiaLabel";
            this.MembresiaLabel.Size = new System.Drawing.Size(75, 16);
            this.MembresiaLabel.TabIndex = 4;
            this.MembresiaLabel.Text = "Membresia";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.grupo);
            this.groupBox1.Controls.Add(this.coach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.coachtextBox);
            this.groupBox1.Controls.Add(this.MembresiascomboBox);
            this.groupBox1.Controls.Add(this.MembresiaLabel);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.NombretextBox);
            this.groupBox1.Controls.Add(this.Nombrelabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(375, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sin acceso",
            "Acceso a mitad de Grupos",
            "Acceso Total de Grupos"});
            this.comboBox1.Location = new System.Drawing.Point(212, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // grupo
            // 
            this.grupo.AutoSize = true;
            this.grupo.Location = new System.Drawing.Point(228, 129);
            this.grupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(42, 16);
            this.grupo.TabIndex = 9;
            this.grupo.Text = "grupo";
            // 
            // coach
            // 
            this.coach.AutoSize = true;
            this.coach.Location = new System.Drawing.Point(49, 129);
            this.coach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coach.Name = "coach";
            this.coach.Size = new System.Drawing.Size(73, 16);
            this.coach.TabIndex = 8;
            this.coach.Text = "Entrenador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agregar Cliente";
            // 
            // coachtextBox
            // 
            this.coachtextBox.Location = new System.Drawing.Point(10, 149);
            this.coachtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.coachtextBox.Name = "coachtextBox";
            this.coachtextBox.Size = new System.Drawing.Size(155, 22);
            this.coachtextBox.TabIndex = 6;
            // 
            // MembresiascomboBox
            // 
            this.MembresiascomboBox.FormattingEnabled = true;
            this.MembresiascomboBox.Location = new System.Drawing.Point(212, 75);
            this.MembresiascomboBox.Name = "MembresiascomboBox";
            this.MembresiascomboBox.Size = new System.Drawing.Size(121, 24);
            this.MembresiascomboBox.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(51, 71);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(51, 143);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(396, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(213, 224);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // pagoListBox
            // 
            this.pagoListBox.FormattingEnabled = true;
            this.pagoListBox.ItemHeight = 16;
            this.pagoListBox.Location = new System.Drawing.Point(433, -16);
            this.pagoListBox.Margin = new System.Windows.Forms.Padding(4);
            this.pagoListBox.Name = "pagoListBox";
            this.pagoListBox.Size = new System.Drawing.Size(12, 4);
            this.pagoListBox.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // dtvgDatos
            // 
            this.dtvgDatos.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clientes,
            this.membresia,
            this.Entrenador,
            this.Grupos});
            this.dtvgDatos.GridColor = System.Drawing.Color.IndianRed;
            this.dtvgDatos.Location = new System.Drawing.Point(12, 298);
            this.dtvgDatos.Name = "dtvgDatos";
            this.dtvgDatos.RowHeadersWidth = 51;
            this.dtvgDatos.RowTemplate.Height = 24;
            this.dtvgDatos.Size = new System.Drawing.Size(760, 173);
            this.dtvgDatos.TabIndex = 13;
            // 
            // Clientes
            // 
            this.Clientes.HeaderText = "clientes gym";
            this.Clientes.MinimumWidth = 6;
            this.Clientes.Name = "Clientes";
            this.Clientes.Width = 125;
            // 
            // membresia
            // 
            this.membresia.HeaderText = "membresia Gym";
            this.membresia.MinimumWidth = 6;
            this.membresia.Name = "membresia";
            this.membresia.Width = 125;
            // 
            // Entrenador
            // 
            this.Entrenador.HeaderText = "Entrenador Gym";
            this.Entrenador.MinimumWidth = 6;
            this.Entrenador.Name = "Entrenador";
            this.Entrenador.Width = 125;
            // 
            // Grupos
            // 
            this.Grupos.HeaderText = "Grupos Gym";
            this.Grupos.MinimumWidth = 6;
            this.Grupos.Name = "Grupos";
            this.Grupos.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Informacion";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 237);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sí puedes imaginarlo puedes programarlo";
            // 
            // Agregar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtvgDatos);
            this.Controls.Add(this.pagoListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Agregar_Cliente";
            this.Text = "Agregar_Cliente";
            this.Load += new System.EventHandler(this.Agregar_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label MembresiaLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox pagoListBox;
        private System.Windows.Forms.ComboBox MembresiascomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label grupo;
        private System.Windows.Forms.Label coach;
        private System.Windows.Forms.TextBox coachtextBox;
        private System.Windows.Forms.DataGridView dtvgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}