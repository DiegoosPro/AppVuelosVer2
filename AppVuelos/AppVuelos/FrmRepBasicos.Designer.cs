namespace AppVuelos
{
    partial class FrmRepBasicos
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
            this.btnPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPais
            // 
            this.btnPais.Location = new System.Drawing.Point(45, 27);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(75, 23);
            this.btnPais.TabIndex = 0;
            this.btnPais.Text = "Paises";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // FrmRepBasicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 282);
            this.Controls.Add(this.btnPais);
            this.Name = "FrmRepBasicos";
            this.Text = "Reportes Basicos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPais;
    }
}