namespace Zoologico
{
    partial class Información_mamiferos_terrestres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Información_mamiferos_terrestres));
            this.txtNumerodepatas = new System.Windows.Forms.TextBox();
            this.grpPreferenciaAlimenticia = new System.Windows.Forms.GroupBox();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.rdbVegetariano = new System.Windows.Forms.RadioButton();
            this.rdbCarnivoro = new System.Windows.Forms.RadioButton();
            this.lblNúmerodePatas = new System.Windows.Forms.Label();
            this.lblCaracterísticasdelMamíferoTerrestre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cmbVisita = new System.Windows.Forms.ComboBox();
            this.lblVisitas = new System.Windows.Forms.Label();
            this.cmbTipolocalización = new System.Windows.Forms.ComboBox();
            this.lblTamañodeHabitat = new System.Windows.Forms.Label();
            this.lblLocalizacióndelAnimal = new System.Windows.Forms.Label();
            this.lblTipodeLocalización = new System.Windows.Forms.Label();
            this.txtTamañohabitat = new System.Windows.Forms.TextBox();
            this.grpPreferenciaAlimenticia.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumerodepatas
            // 
            this.txtNumerodepatas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumerodepatas.Location = new System.Drawing.Point(193, 134);
            this.txtNumerodepatas.Name = "txtNumerodepatas";
            this.txtNumerodepatas.Size = new System.Drawing.Size(200, 20);
            this.txtNumerodepatas.TabIndex = 0;
            // 
            // grpPreferenciaAlimenticia
            // 
            this.grpPreferenciaAlimenticia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPreferenciaAlimenticia.BackColor = System.Drawing.Color.Transparent;
            this.grpPreferenciaAlimenticia.Controls.Add(this.rdbOtro);
            this.grpPreferenciaAlimenticia.Controls.Add(this.rdbVegetariano);
            this.grpPreferenciaAlimenticia.Controls.Add(this.rdbCarnivoro);
            this.grpPreferenciaAlimenticia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPreferenciaAlimenticia.Location = new System.Drawing.Point(176, 177);
            this.grpPreferenciaAlimenticia.Name = "grpPreferenciaAlimenticia";
            this.grpPreferenciaAlimenticia.Size = new System.Drawing.Size(217, 123);
            this.grpPreferenciaAlimenticia.TabIndex = 1;
            this.grpPreferenciaAlimenticia.TabStop = false;
            this.grpPreferenciaAlimenticia.Text = "Preferencia alimentaria";
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Location = new System.Drawing.Point(6, 75);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(56, 23);
            this.rdbOtro.TabIndex = 2;
            this.rdbOtro.TabStop = true;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbVegetariano
            // 
            this.rdbVegetariano.AutoSize = true;
            this.rdbVegetariano.Location = new System.Drawing.Point(6, 52);
            this.rdbVegetariano.Name = "rdbVegetariano";
            this.rdbVegetariano.Size = new System.Drawing.Size(98, 23);
            this.rdbVegetariano.TabIndex = 1;
            this.rdbVegetariano.TabStop = true;
            this.rdbVegetariano.Text = "Vegetariano";
            this.rdbVegetariano.UseVisualStyleBackColor = true;
            // 
            // rdbCarnivoro
            // 
            this.rdbCarnivoro.AutoSize = true;
            this.rdbCarnivoro.Location = new System.Drawing.Point(6, 29);
            this.rdbCarnivoro.Name = "rdbCarnivoro";
            this.rdbCarnivoro.Size = new System.Drawing.Size(88, 23);
            this.rdbCarnivoro.TabIndex = 0;
            this.rdbCarnivoro.TabStop = true;
            this.rdbCarnivoro.Text = "Carnivoro";
            this.rdbCarnivoro.UseVisualStyleBackColor = true;
            this.rdbCarnivoro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblNúmerodePatas
            // 
            this.lblNúmerodePatas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNúmerodePatas.AutoSize = true;
            this.lblNúmerodePatas.BackColor = System.Drawing.Color.Transparent;
            this.lblNúmerodePatas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmerodePatas.Location = new System.Drawing.Point(12, 129);
            this.lblNúmerodePatas.Name = "lblNúmerodePatas";
            this.lblNúmerodePatas.Size = new System.Drawing.Size(161, 24);
            this.lblNúmerodePatas.TabIndex = 2;
            this.lblNúmerodePatas.Text = "Número de patas";
            // 
            // lblCaracterísticasdelMamíferoTerrestre
            // 
            this.lblCaracterísticasdelMamíferoTerrestre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaracterísticasdelMamíferoTerrestre.AutoSize = true;
            this.lblCaracterísticasdelMamíferoTerrestre.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracterísticasdelMamíferoTerrestre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterísticasdelMamíferoTerrestre.Location = new System.Drawing.Point(197, 38);
            this.lblCaracterísticasdelMamíferoTerrestre.Name = "lblCaracterísticasdelMamíferoTerrestre";
            this.lblCaracterísticasdelMamíferoTerrestre.Size = new System.Drawing.Size(462, 31);
            this.lblCaracterísticasdelMamíferoTerrestre.TabIndex = 3;
            this.lblCaracterísticasdelMamíferoTerrestre.Text = "Características del mamífero terrestre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(352, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(352, 396);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 41);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbVisita
            // 
            this.cmbVisita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbVisita.FormattingEnabled = true;
            this.cmbVisita.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbVisita.Location = new System.Drawing.Point(559, 256);
            this.cmbVisita.Name = "cmbVisita";
            this.cmbVisita.Size = new System.Drawing.Size(200, 21);
            this.cmbVisita.TabIndex = 30;
            // 
            // lblVisitas
            // 
            this.lblVisitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisitas.AutoSize = true;
            this.lblVisitas.BackColor = System.Drawing.Color.Transparent;
            this.lblVisitas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitas.Location = new System.Drawing.Point(451, 258);
            this.lblVisitas.Name = "lblVisitas";
            this.lblVisitas.Size = new System.Drawing.Size(102, 19);
            this.lblVisitas.TabIndex = 29;
            this.lblVisitas.Text = "¿Es visitable?";
            // 
            // cmbTipolocalización
            // 
            this.cmbTipolocalización.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipolocalización.FormattingEnabled = true;
            this.cmbTipolocalización.Items.AddRange(new object[] {
            "Terrestre",
            "Aérea",
            "Acuática"});
            this.cmbTipolocalización.Location = new System.Drawing.Point(559, 185);
            this.cmbTipolocalización.Name = "cmbTipolocalización";
            this.cmbTipolocalización.Size = new System.Drawing.Size(200, 21);
            this.cmbTipolocalización.TabIndex = 28;
            // 
            // lblTamañodeHabitat
            // 
            this.lblTamañodeHabitat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTamañodeHabitat.AutoSize = true;
            this.lblTamañodeHabitat.BackColor = System.Drawing.Color.Transparent;
            this.lblTamañodeHabitat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamañodeHabitat.Location = new System.Drawing.Point(417, 218);
            this.lblTamañodeHabitat.Name = "lblTamañodeHabitat";
            this.lblTamañodeHabitat.Size = new System.Drawing.Size(136, 19);
            this.lblTamañodeHabitat.TabIndex = 27;
            this.lblTamañodeHabitat.Text = "Tamaño del hábitat";
            // 
            // lblLocalizacióndelAnimal
            // 
            this.lblLocalizacióndelAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalizacióndelAnimal.AutoSize = true;
            this.lblLocalizacióndelAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalizacióndelAnimal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacióndelAnimal.Location = new System.Drawing.Point(490, 118);
            this.lblLocalizacióndelAnimal.Name = "lblLocalizacióndelAnimal";
            this.lblLocalizacióndelAnimal.Size = new System.Drawing.Size(219, 24);
            this.lblLocalizacióndelAnimal.TabIndex = 26;
            this.lblLocalizacióndelAnimal.Text = "Localización del animal";
            // 
            // lblTipodeLocalización
            // 
            this.lblTipodeLocalización.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipodeLocalización.AutoSize = true;
            this.lblTipodeLocalización.BackColor = System.Drawing.Color.Transparent;
            this.lblTipodeLocalización.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeLocalización.Location = new System.Drawing.Point(414, 184);
            this.lblTipodeLocalización.Name = "lblTipodeLocalización";
            this.lblTipodeLocalización.Size = new System.Drawing.Size(139, 19);
            this.lblTipodeLocalización.TabIndex = 25;
            this.lblTipodeLocalización.Text = "Tipo de localización";
            // 
            // txtTamañohabitat
            // 
            this.txtTamañohabitat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTamañohabitat.Location = new System.Drawing.Point(559, 219);
            this.txtTamañohabitat.Name = "txtTamañohabitat";
            this.txtTamañohabitat.Size = new System.Drawing.Size(200, 20);
            this.txtTamañohabitat.TabIndex = 24;
            // 
            // Información_mamiferos_terrestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(846, 480);
            this.Controls.Add(this.cmbVisita);
            this.Controls.Add(this.lblVisitas);
            this.Controls.Add(this.cmbTipolocalización);
            this.Controls.Add(this.lblTamañodeHabitat);
            this.Controls.Add(this.lblLocalizacióndelAnimal);
            this.Controls.Add(this.lblTipodeLocalización);
            this.Controls.Add(this.txtTamañohabitat);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCaracterísticasdelMamíferoTerrestre);
            this.Controls.Add(this.lblNúmerodePatas);
            this.Controls.Add(this.grpPreferenciaAlimenticia);
            this.Controls.Add(this.txtNumerodepatas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Información_mamiferos_terrestres";
            this.Text = "Información_mamiferos_terrestres";
            this.Load += new System.EventHandler(this.Información_mamiferos_terrestres_Load);
            this.grpPreferenciaAlimenticia.ResumeLayout(false);
            this.grpPreferenciaAlimenticia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumerodepatas;
        private System.Windows.Forms.GroupBox grpPreferenciaAlimenticia;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rdbVegetariano;
        private System.Windows.Forms.RadioButton rdbCarnivoro;
        private System.Windows.Forms.Label lblNúmerodePatas;
        private System.Windows.Forms.Label lblCaracterísticasdelMamíferoTerrestre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cmbVisita;
        private System.Windows.Forms.Label lblVisitas;
        private System.Windows.Forms.ComboBox cmbTipolocalización;
        private System.Windows.Forms.Label lblTamañodeHabitat;
        private System.Windows.Forms.Label lblLocalizacióndelAnimal;
        private System.Windows.Forms.Label lblTipodeLocalización;
        private System.Windows.Forms.TextBox txtTamañohabitat;
    }
}