namespace IGUMagazine
{
    partial class ConfeccionarEjemplar
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
            this.NumeroRevista = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AreaPicker = new System.Windows.Forms.ComboBox();
            this.ListaArticulos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NumeroRevista
            // 
            this.NumeroRevista.AutoSize = true;
            this.NumeroRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumeroRevista.Location = new System.Drawing.Point(29, 61);
            this.NumeroRevista.Name = "NumeroRevista";
            this.NumeroRevista.Size = new System.Drawing.Size(210, 29);
            this.NumeroRevista.TabIndex = 0;
            this.NumeroRevista.Text = "Número de revista";
            this.NumeroRevista.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(34, 140);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // AreaPicker
            // 
            this.AreaPicker.FormattingEnabled = true;
            this.AreaPicker.Location = new System.Drawing.Point(34, 205);
            this.AreaPicker.Name = "AreaPicker";
            this.AreaPicker.Size = new System.Drawing.Size(121, 24);
            this.AreaPicker.TabIndex = 2;
            // 
            // ListaArticulos
            // 
            this.ListaArticulos.HideSelection = false;
            this.ListaArticulos.Location = new System.Drawing.Point(428, 91);
            this.ListaArticulos.Name = "ListaArticulos";
            this.ListaArticulos.Size = new System.Drawing.Size(121, 97);
            this.ListaArticulos.TabIndex = 3;
            this.ListaArticulos.UseCompatibleStateImageBehavior = false;
            // 
            // ConfeccionarEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaArticulos);
            this.Controls.Add(this.AreaPicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.NumeroRevista);
            this.Name = "ConfeccionarEjemplar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroRevista;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox AreaPicker;
        private System.Windows.Forms.ListView ListaArticulos;
    }
}