namespace IGUMagazine
{
    partial class MagazineResponsableForm
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
            this.bienvenido_tag = new System.Windows.Forms.Label();
            this.evaluar_boton = new System.Windows.Forms.Button();
            this.enviar_boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bienvenido_tag
            // 
            this.bienvenido_tag.AutoSize = true;
            this.bienvenido_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bienvenido_tag.Location = new System.Drawing.Point(71, 38);
            this.bienvenido_tag.Name = "bienvenido_tag";
            this.bienvenido_tag.Size = new System.Drawing.Size(91, 17);
            this.bienvenido_tag.TabIndex = 0;
            this.bienvenido_tag.Text = "BIENVENIDO";
            // 
            // evaluar_boton
            // 
            this.evaluar_boton.Location = new System.Drawing.Point(74, 198);
            this.evaluar_boton.Name = "evaluar_boton";
            this.evaluar_boton.Size = new System.Drawing.Size(88, 33);
            this.evaluar_boton.TabIndex = 1;
            this.evaluar_boton.Text = "Evaluar árticulo";
            this.evaluar_boton.UseVisualStyleBackColor = true;
            this.evaluar_boton.Click += new System.EventHandler(this.evaluar_boton_Click);
            // 
            // enviar_boton
            // 
            this.enviar_boton.Location = new System.Drawing.Point(211, 198);
            this.enviar_boton.Name = "enviar_boton";
            this.enviar_boton.Size = new System.Drawing.Size(88, 33);
            this.enviar_boton.TabIndex = 2;
            this.enviar_boton.Text = "Enviar árticulo";
            this.enviar_boton.UseVisualStyleBackColor = true;
            this.enviar_boton.Click += new System.EventHandler(this.enviar_boton_Click);
            // 
            // MagazineResponsableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.enviar_boton);
            this.Controls.Add(this.evaluar_boton);
            this.Controls.Add(this.bienvenido_tag);
            this.Name = "MagazineResponsableForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MagazineResponsableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenido_tag;
        private System.Windows.Forms.Button evaluar_boton;
        private System.Windows.Forms.Button enviar_boton;
    }
}