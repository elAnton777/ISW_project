namespace IGUMagazine
{
    partial class Form1
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
            this.Lista = new System.Windows.Forms.ListView();
            this.Etiqueta_Titulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(12, 74);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(397, 130);
            this.Lista.TabIndex = 0;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Etiqueta_Titulo
            // 
            this.Etiqueta_Titulo.AutoSize = true;
            this.Etiqueta_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Etiqueta_Titulo.Location = new System.Drawing.Point(26, 27);
            this.Etiqueta_Titulo.Name = "Etiqueta_Titulo";
            this.Etiqueta_Titulo.Size = new System.Drawing.Size(126, 17);
            this.Etiqueta_Titulo.TabIndex = 1;
            this.Etiqueta_Titulo.Text = "Árticulos a Evaluar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Área1",
            "Área2",
            "Área3",
            "Área4"});
            this.comboBox1.Location = new System.Drawing.Point(576, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Áreas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Etiqueta_Titulo);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.Label Etiqueta_Titulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}