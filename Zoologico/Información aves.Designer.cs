namespace Zoologico
{
    partial class Información_aves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Información_aves));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCaracterísticasdelAve = new System.Windows.Forms.Label();
            this.cmbTipodeVuelo = new System.Windows.Forms.ComboBox();
            this.lblTipodeVuelo = new System.Windows.Forms.Label();
            this.cmbVisitas = new System.Windows.Forms.ComboBox();
            this.lblVisitas = new System.Windows.Forms.Label();
            this.cmbTipodeLocalización = new System.Windows.Forms.ComboBox();
            this.lblTamañodelHabitat = new System.Windows.Forms.Label();
            this.lblLocalizacióndelAnimal = new System.Windows.Forms.Label();
            this.lblTipodeLocalización = new System.Windows.Forms.Label();
            this.txtTamañodelHabitat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(376, 409);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 41);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(376, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCaracterísticasdelAve
            // 
            this.lblCaracterísticasdelAve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaracterísticasdelAve.AutoSize = true;
            this.lblCaracterísticasdelAve.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracterísticasdelAve.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterísticasdelAve.Location = new System.Drawing.Point(66, 53);
            this.lblCaracterísticasdelAve.Name = "lblCaracterísticasdelAve";
            this.lblCaracterísticasdelAve.Size = new System.Drawing.Size(281, 31);
            this.lblCaracterísticasdelAve.TabIndex = 9;
            this.lblCaracterísticasdelAve.Text = "Características del ave";
            // 
            // cmbTipodeVuelo
            // 
            this.cmbTipodeVuelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipodeVuelo.FormattingEnabled = true;
            this.cmbTipodeVuelo.Items.AddRange(new object[] {
            "Planeo",
            "Paracaidismo",
            "Remonte",
            "Vuelo de aleteo",
            "Vuelo en suspensión"});
            this.cmbTipodeVuelo.Location = new System.Drawing.Point(137, 203);
            this.cmbTipodeVuelo.Name = "cmbTipodeVuelo";
            this.cmbTipodeVuelo.Size = new System.Drawing.Size(200, 21);
            this.cmbTipodeVuelo.TabIndex = 12;
            // 
            // lblTipodeVuelo
            // 
            this.lblTipodeVuelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipodeVuelo.AutoSize = true;
            this.lblTipodeVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipodeVuelo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeVuelo.Location = new System.Drawing.Point(32, 202);
            this.lblTipodeVuelo.Name = "lblTipodeVuelo";
            this.lblTipodeVuelo.Size = new System.Drawing.Size(99, 19);
            this.lblTipodeVuelo.TabIndex = 13;
            this.lblTipodeVuelo.Text = "Tipo de vuelo";
            // 
            // cmbVisitas
            // 
            this.cmbVisitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbVisitas.FormattingEnabled = true;
            this.cmbVisitas.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbVisitas.Location = new System.Drawing.Point(549, 276);
            this.cmbVisitas.Name = "cmbVisitas";
            this.cmbVisitas.Size = new System.Drawing.Size(200, 21);
            this.cmbVisitas.TabIndex = 23;
            // 
            // lblVisitas
            // 
            this.lblVisitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisitas.AutoSize = true;
            this.lblVisitas.BackColor = System.Drawing.Color.Transparent;
            this.lblVisitas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitas.Location = new System.Drawing.Point(441, 278);
            this.lblVisitas.Name = "lblVisitas";
            this.lblVisitas.Size = new System.Drawing.Size(102, 19);
            this.lblVisitas.TabIndex = 22;
            this.lblVisitas.Text = "¿Es visitable?";
            // 
            // cmbTipodeLocalización
            // 
            this.cmbTipodeLocalización.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipodeLocalización.FormattingEnabled = true;
            this.cmbTipodeLocalización.Items.AddRange(new object[] {
            "Terrestre",
            "Aérea",
            "Acuática"});
            this.cmbTipodeLocalización.Location = new System.Drawing.Point(549, 205);
            this.cmbTipodeLocalización.Name = "cmbTipodeLocalización";
            this.cmbTipodeLocalización.Size = new System.Drawing.Size(200, 21);
            this.cmbTipodeLocalización.TabIndex = 21;
            // 
            // lblTamañodelHabitat
            // 
            this.lblTamañodelHabitat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTamañodelHabitat.AutoSize = true;
            this.lblTamañodelHabitat.BackColor = System.Drawing.Color.Transparent;
            this.lblTamañodelHabitat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamañodelHabitat.Location = new System.Drawing.Point(407, 238);
            this.lblTamañodelHabitat.Name = "lblTamañodelHabitat";
            this.lblTamañodelHabitat.Size = new System.Drawing.Size(136, 19);
            this.lblTamañodelHabitat.TabIndex = 20;
            this.lblTamañodelHabitat.Text = "Tamaño del hábitat";
            // 
            // lblLocalizacióndelAnimal
            // 
            this.lblLocalizacióndelAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalizacióndelAnimal.AutoSize = true;
            this.lblLocalizacióndelAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalizacióndelAnimal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacióndelAnimal.Location = new System.Drawing.Point(477, 142);
            this.lblLocalizacióndelAnimal.Name = "lblLocalizacióndelAnimal";
            this.lblLocalizacióndelAnimal.Size = new System.Drawing.Size(219, 24);
            this.lblLocalizacióndelAnimal.TabIndex = 19;
            this.lblLocalizacióndelAnimal.Text = "Localización del animal";
            // 
            // lblTipodeLocalización
            // 
            this.lblTipodeLocalización.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipodeLocalización.AutoSize = true;
            this.lblTipodeLocalización.BackColor = System.Drawing.Color.Transparent;
            this.lblTipodeLocalización.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeLocalización.Location = new System.Drawing.Point(404, 204);
            this.lblTipodeLocalización.Name = "lblTipodeLocalización";
            this.lblTipodeLocalización.Size = new System.Drawing.Size(139, 19);
            this.lblTipodeLocalización.TabIndex = 18;
            this.lblTipodeLocalización.Text = "Tipo de localización";
            // 
            // txtTamañodelHabitat
            // 
            this.txtTamañodelHabitat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTamañodelHabitat.Location = new System.Drawing.Point(549, 239);
            this.txtTamañodelHabitat.Name = "txtTamañodelHabitat";
            this.txtTamañodelHabitat.Size = new System.Drawing.Size(200, 20);
            this.txtTamañodelHabitat.TabIndex = 17;
            this.txtTamañodelHabitat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamañodelHabitat_Keypress);
            // 
            // Información_aves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 476);
            this.Controls.Add(this.cmbVisitas);
            this.Controls.Add(this.lblVisitas);
            this.Controls.Add(this.cmbTipodeLocalización);
            this.Controls.Add(this.lblTamañodelHabitat);
            this.Controls.Add(this.lblLocalizacióndelAnimal);
            this.Controls.Add(this.lblTipodeLocalización);
            this.Controls.Add(this.txtTamañodelHabitat);
            this.Controls.Add(this.lblTipodeVuelo);
            this.Controls.Add(this.cmbTipodeVuelo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCaracterísticasdelAve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Información_aves";
            this.Text = "Información_aves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCaracterísticasdelAve;
        private System.Windows.Forms.ComboBox cmbTipodeVuelo;
        private System.Windows.Forms.Label lblTipodeVuelo;
        private System.Windows.Forms.ComboBox cmbVisitas;
        private System.Windows.Forms.Label lblVisitas;
        private System.Windows.Forms.ComboBox cmbTipodeLocalización;
        private System.Windows.Forms.Label lblTamañodelHabitat;
        private System.Windows.Forms.Label lblLocalizacióndelAnimal;
        private System.Windows.Forms.Label lblTipodeLocalización;
        private System.Windows.Forms.TextBox txtTamañodelHabitat;
    }
}