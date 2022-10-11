namespace Zoologico
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnRegistroAnimal = new System.Windows.Forms.Button();
            this.btnInformacióndeAnimales = new System.Windows.Forms.Button();
            this.btnRegistroEnfermería = new System.Windows.Forms.Button();
            this.btnInformaciónEnfermería = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroAnimal
            // 
            this.btnRegistroAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroAnimal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroAnimal.Location = new System.Drawing.Point(238, 38);
            this.btnRegistroAnimal.Name = "btnRegistroAnimal";
            this.btnRegistroAnimal.Size = new System.Drawing.Size(359, 82);
            this.btnRegistroAnimal.TabIndex = 0;
            this.btnRegistroAnimal.Text = "Registrar animal";
            this.btnRegistroAnimal.UseVisualStyleBackColor = true;
            this.btnRegistroAnimal.Click += new System.EventHandler(this.btnRegistroAnimal_Click);
            // 
            // btnInformacióndeAnimales
            // 
            this.btnInformacióndeAnimales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInformacióndeAnimales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacióndeAnimales.Location = new System.Drawing.Point(238, 126);
            this.btnInformacióndeAnimales.Name = "btnInformacióndeAnimales";
            this.btnInformacióndeAnimales.Size = new System.Drawing.Size(359, 82);
            this.btnInformacióndeAnimales.TabIndex = 1;
            this.btnInformacióndeAnimales.Text = "Información de los animales en el zoologico";
            this.btnInformacióndeAnimales.UseVisualStyleBackColor = true;
            // 
            // btnRegistroEnfermería
            // 
            this.btnRegistroEnfermería.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroEnfermería.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroEnfermería.Location = new System.Drawing.Point(238, 214);
            this.btnRegistroEnfermería.Name = "btnRegistroEnfermería";
            this.btnRegistroEnfermería.Size = new System.Drawing.Size(359, 82);
            this.btnRegistroEnfermería.TabIndex = 2;
            this.btnRegistroEnfermería.Text = "Registrar animal en la enfermería";
            this.btnRegistroEnfermería.UseVisualStyleBackColor = true;
            this.btnRegistroEnfermería.Click += new System.EventHandler(this.btnRegistroEnfermería_Click);
            // 
            // btnInformaciónEnfermería
            // 
            this.btnInformaciónEnfermería.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInformaciónEnfermería.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformaciónEnfermería.Location = new System.Drawing.Point(238, 302);
            this.btnInformaciónEnfermería.Name = "btnInformaciónEnfermería";
            this.btnInformaciónEnfermería.Size = new System.Drawing.Size(359, 82);
            this.btnInformaciónEnfermería.TabIndex = 3;
            this.btnInformaciónEnfermería.Text = "Información de los animales en la enfermería";
            this.btnInformaciónEnfermería.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(365, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInformaciónEnfermería);
            this.Controls.Add(this.btnRegistroEnfermería);
            this.Controls.Add(this.btnInformacióndeAnimales);
            this.Controls.Add(this.btnRegistroAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroAnimal;
        private System.Windows.Forms.Button btnInformacióndeAnimales;
        private System.Windows.Forms.Button btnRegistroEnfermería;
        private System.Windows.Forms.Button btnInformaciónEnfermería;
        private System.Windows.Forms.Button btnSalir;
    }
}