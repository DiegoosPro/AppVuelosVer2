namespace AppVuelos
{
    partial class FrmRepPersonalizados
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
            this.btnAeropuerto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAeropuerto
            // 
            this.btnAeropuerto.Location = new System.Drawing.Point(12, 27);
            this.btnAeropuerto.Name = "btnAeropuerto";
            this.btnAeropuerto.Size = new System.Drawing.Size(136, 32);
            this.btnAeropuerto.TabIndex = 0;
            this.btnAeropuerto.Text = "Aeropuertos";
            this.btnAeropuerto.UseVisualStyleBackColor = true;
            this.btnAeropuerto.Click += new System.EventHandler(this.btnAeropuerto_Click);
            // 
            // FrmRepPersonalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 296);
            this.Controls.Add(this.btnAeropuerto);
            this.Name = "FrmRepPersonalizados";
            this.Text = "FrmPersonalizados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAeropuerto;
    }
}