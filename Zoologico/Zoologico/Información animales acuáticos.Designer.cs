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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMamifero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVisitas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipodeLocalización = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamañodelHabitat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Características del animal acuático";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "¿Es mamífero?";
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "¿Es visitable?";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tamaño del hábitat";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Localización del animal";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo de localización";
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipodeLocalización);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTamañodelHabitat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMamifero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Información_animales_acuanticos";
            this.Text = "Información_animales_acuáticos";
            this.Load += new System.EventHandler(this.Información_animales_acuanticos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMamifero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVisitas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipodeLocalización;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamañodelHabitat;
    }
}