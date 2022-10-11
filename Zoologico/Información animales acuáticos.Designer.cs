namespace Zoologico
{
    partial class Información_animales_acuanticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Información_animales_acuanticos));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.cmbMamifero = new System.Windows.Forms.ComboBox();
            this.lblMamifero = new System.Windows.Forms.Label();
            this.cmbVisitas = new System.Windows.Forms.ComboBox();
            this.lblVisita = new System.Windows.Forms.Label();
            this.cmbTipodeLocalización = new System.Windows.Forms.ComboBox();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.lblTipoDeLocalizacion = new System.Windows.Forms.Label();
            this.txtTamañodelHabitat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(374, 413);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 41);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(374, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracteristicas.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristicas.Location = new System.Drawing.Point(213, 45);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(427, 31);
            this.lblCaracteristicas.TabIndex = 7;
            this.lblCaracteristicas.Text = "Características del animal acuático";
            // 
            // cmbMamifero
            // 
            this.cmbMamifero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMamifero.FormattingEnabled = true;
            this.cmbMamifero.Items.AddRange(new object[] {
            "Sí ",
            "No"});
            this.cmbMamifero.Location = new System.Drawing.Point(609, 206);
            this.cmbMamifero.Name = "cmbMamifero";
            this.cmbMamifero.Size = new System.Drawing.Size(121, 21);
            this.cmbMamifero.TabIndex = 13;
            // 
            // lblMamifero
            // 
            this.lblMamifero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMamifero.AutoSize = true;
            this.lblMamifero.BackColor = System.Drawing.Color.Transparent;
            this.lblMamifero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamifero.Location = new System.Drawing.Point(494, 208);
            this.lblMamifero.Name = "lblMamifero";
            this.lblMamifero.Size = new System.Drawing.Size(109, 19);
            this.lblMamifero.TabIndex = 14;
            this.lblMamifero.Text = "¿Es mamífero?";
            // 
            // cmbVisitas
            // 
            this.cmbVisitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbVisitas.FormattingEnabled = true;
            this.cmbVisitas.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbVisitas.Location = new System.Drawing.Point(177, 280);
            this.cmbVisitas.Name = "cmbVisitas";
            this.cmbVisitas.Size = new System.Drawing.Size(200, 21);
            this.cmbVisitas.TabIndex = 30;
            // 
            // lblVisita
            // 
            this.lblVisita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisita.AutoSize = true;
            this.lblVisita.BackColor = System.Drawing.Color.Transparent;
            this.lblVisita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisita.Location = new System.Drawing.Point(69, 282);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(102, 19);
            this.lblVisita.TabIndex = 29;
            this.lblVisita.Text = "¿Es visitable?";
            // 
            // cmbTipodeLocalización
            // 
            this.cmbTipodeLocalización.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipodeLocalización.FormattingEnabled = true;
            this.cmbTipodeLocalización.Items.AddRange(new object[] {
            "Terrestre",
            "Aérea",
            "Acuática"});
            this.cmbTipodeLocalización.Location = new System.Drawing.Point(177, 209);
            this.cmbTipodeLocalización.Name = "cmbTipodeLocalización";
            this.cmbTipodeLocalización.Size = new System.Drawing.Size(200, 21);
            this.cmbTipodeLocalización.TabIndex = 28;
            // 
            // lblTamaño
            // 
            this.lblTamaño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.BackColor = System.Drawing.Color.Transparent;
            this.lblTamaño.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamaño.Location = new System.Drawing.Point(35, 242);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(136, 19);
            this.lblTamaño.TabIndex = 27;
            this.lblTamaño.Text = "Tamaño del hábitat";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalizacion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.Location = new System.Drawing.Point(82, 151);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(219, 24);
            this.lblLocalizacion.TabIndex = 26;
            this.lblLocalizacion.Text = "Localización del animal";
            // 
            // lblTipoDeLocalizacion
            // 
            this.lblTipoDeLocalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoDeLocalizacion.AutoSize = true;
            this.lblTipoDeLocalizacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDeLocalizacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeLocalizacion.Location = new System.Drawing.Point(32, 208);
            this.lblTipoDeLocalizacion.Name = "lblTipoDeLocalizacion";
            this.lblTipoDeLocalizacion.Size = new System.Drawing.Size(139, 19);
            this.lblTipoDeLocalizacion.TabIndex = 25;
            this.lblTipoDeLocalizacion.Text = "Tipo de localización";
            // 
            // txtTamañodelHabitat
            // 
            this.txtTamañodelHabitat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTamañodelHabitat.Location = new System.Drawing.Point(177, 243);
            this.txtTamañodelHabitat.Name = "txtTamañodelHabitat";
            this.txtTamañodelHabitat.Size = new System.Drawing.Size(200, 20);
            this.txtTamañodelHabitat.TabIndex = 24;
            this.txtTamañodelHabitat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamañodelHabitat_Keypress);
            // 
            // Información_animales_acuanticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 475);
            this.Controls.Add(this.cmbVisitas);
            this.Controls.Add(this.lblVisita);
            this.Controls.Add(this.cmbTipodeLocalización);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblLocalizacion);
            this.Controls.Add(this.lblTipoDeLocalizacion);
            this.Controls.Add(this.txtTamañodelHabitat);
            this.Controls.Add(this.lblMamifero);
            this.Controls.Add(this.cmbMamifero);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCaracteristicas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Información_animales_acuanticos";
            this.Text = "Información_animales_acuáticos";
            this.Load += new System.EventHandler(this.Información_animales_acuanticos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.ComboBox cmbMamifero;
        private System.Windows.Forms.Label lblMamifero;
        private System.Windows.Forms.ComboBox cmbVisitas;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.ComboBox cmbTipodeLocalización;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Label lblLocalizacion;
        private System.Windows.Forms.Label lblTipoDeLocalizacion;
        private System.Windows.Forms.TextBox txtTamañodelHabitat;
    }
}