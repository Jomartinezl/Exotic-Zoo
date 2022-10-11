namespace Zoologico
{
    partial class Información_del_animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Información_del_animal));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaís = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtSubespecie = new System.Windows.Forms.TextBox();
            this.txtCostumbres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechadeNacimiento = new System.Windows.Forms.Label();
            this.lblPaísdeOrigen = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblSubespecie = new System.Windows.Forms.Label();
            this.lblCostumbresAlimenticias = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblInformacióndelAnimal = new System.Windows.Forms.Label();
            this.tipodeanimal = new System.Windows.Forms.ComboBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.dttFechadeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(206, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPaís
            // 
            this.txtPaís.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaís.Location = new System.Drawing.Point(206, 186);
            this.txtPaís.Name = "txtPaís";
            this.txtPaís.Size = new System.Drawing.Size(200, 20);
            this.txtPaís.TabIndex = 2;
            this.txtPaís.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaís_keypress);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEspecie.Location = new System.Drawing.Point(206, 212);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(200, 20);
            this.txtEspecie.TabIndex = 3;
            this.txtEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspecie_Keypress);
            // 
            // txtSubespecie
            // 
            this.txtSubespecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubespecie.Location = new System.Drawing.Point(206, 238);
            this.txtSubespecie.Name = "txtSubespecie";
            this.txtSubespecie.Size = new System.Drawing.Size(200, 20);
            this.txtSubespecie.TabIndex = 4;
            // 
            // txtCostumbres
            // 
            this.txtCostumbres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostumbres.Location = new System.Drawing.Point(206, 264);
            this.txtCostumbres.Name = "txtCostumbres";
            this.txtCostumbres.Size = new System.Drawing.Size(200, 20);
            this.txtCostumbres.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(126, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechadeNacimiento
            // 
            this.lblFechadeNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechadeNacimiento.AutoSize = true;
            this.lblFechadeNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechadeNacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeNacimiento.Location = new System.Drawing.Point(44, 162);
            this.lblFechadeNacimiento.Name = "lblFechadeNacimiento";
            this.lblFechadeNacimiento.Size = new System.Drawing.Size(145, 19);
            this.lblFechadeNacimiento.TabIndex = 7;
            this.lblFechadeNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblPaísdeOrigen
            // 
            this.lblPaísdeOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaísdeOrigen.AutoSize = true;
            this.lblPaísdeOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblPaísdeOrigen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaísdeOrigen.Location = new System.Drawing.Point(86, 185);
            this.lblPaísdeOrigen.Name = "lblPaísdeOrigen";
            this.lblPaísdeOrigen.Size = new System.Drawing.Size(103, 19);
            this.lblPaísdeOrigen.TabIndex = 8;
            this.lblPaísdeOrigen.Text = "País de origen";
            // 
            // lblEspecie
            // 
            this.lblEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(128, 211);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(61, 19);
            this.lblEspecie.TabIndex = 9;
            this.lblEspecie.Text = "Especie";
            // 
            // lblSubespecie
            // 
            this.lblSubespecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubespecie.AutoSize = true;
            this.lblSubespecie.BackColor = System.Drawing.Color.Transparent;
            this.lblSubespecie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubespecie.Location = new System.Drawing.Point(105, 237);
            this.lblSubespecie.Name = "lblSubespecie";
            this.lblSubespecie.Size = new System.Drawing.Size(84, 19);
            this.lblSubespecie.TabIndex = 10;
            this.lblSubespecie.Text = "Subespecie";
            // 
            // lblCostumbresAlimenticias
            // 
            this.lblCostumbresAlimenticias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCostumbresAlimenticias.AutoSize = true;
            this.lblCostumbresAlimenticias.BackColor = System.Drawing.Color.Transparent;
            this.lblCostumbresAlimenticias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostumbresAlimenticias.Location = new System.Drawing.Point(17, 265);
            this.lblCostumbresAlimenticias.Name = "lblCostumbresAlimenticias";
            this.lblCostumbresAlimenticias.Size = new System.Drawing.Size(172, 19);
            this.lblCostumbresAlimenticias.TabIndex = 11;
            this.lblCostumbresAlimenticias.Text = "Costumbres alimenticias";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(178, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(178, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblInformacióndelAnimal
            // 
            this.lblInformacióndelAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacióndelAnimal.AutoSize = true;
            this.lblInformacióndelAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacióndelAnimal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacióndelAnimal.Location = new System.Drawing.Point(124, 64);
            this.lblInformacióndelAnimal.Name = "lblInformacióndelAnimal";
            this.lblInformacióndelAnimal.Size = new System.Drawing.Size(289, 31);
            this.lblInformacióndelAnimal.TabIndex = 14;
            this.lblInformacióndelAnimal.Text = "Información del animal";
            // 
            // tipodeanimal
            // 
            this.tipodeanimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipodeanimal.FormattingEnabled = true;
            this.tipodeanimal.Items.AddRange(new object[] {
            "Mamífero terrestre",
            "Ave",
            "Animal acuático"});
            this.tipodeanimal.Location = new System.Drawing.Point(206, 295);
            this.tipodeanimal.Name = "tipodeanimal";
            this.tipodeanimal.Size = new System.Drawing.Size(200, 21);
            this.tipodeanimal.TabIndex = 15;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnimal.Location = new System.Drawing.Point(82, 294);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(107, 19);
            this.lblTipoAnimal.TabIndex = 16;
            this.lblTipoAnimal.Text = "Tipo de animal";
            // 
            // dttFechadeNacimiento
            // 
            this.dttFechadeNacimiento.Location = new System.Drawing.Point(206, 160);
            this.dttFechadeNacimiento.Name = "dttFechadeNacimiento";
            this.dttFechadeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dttFechadeNacimiento.TabIndex = 17;
            this.dttFechadeNacimiento.ValueChanged += new System.EventHandler(this.dttFechadeNacimiento_ValueChanged);
            // 
            // Información_del_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 476);
            this.Controls.Add(this.dttFechadeNacimiento);
            this.Controls.Add(this.lblTipoAnimal);
            this.Controls.Add(this.tipodeanimal);
            this.Controls.Add(this.lblInformacióndelAnimal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCostumbresAlimenticias);
            this.Controls.Add(this.lblSubespecie);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblPaísdeOrigen);
            this.Controls.Add(this.lblFechadeNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCostumbres);
            this.Controls.Add(this.txtSubespecie);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtPaís);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Información_del_animal";
            this.Text = "Información_del_animal";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaís;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtSubespecie;
        private System.Windows.Forms.TextBox txtCostumbres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechadeNacimiento;
        private System.Windows.Forms.Label lblPaísdeOrigen;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblSubespecie;
        private System.Windows.Forms.Label lblCostumbresAlimenticias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblInformacióndelAnimal;
        private System.Windows.Forms.ComboBox tipodeanimal;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.DateTimePicker dttFechadeNacimiento;
    }
}