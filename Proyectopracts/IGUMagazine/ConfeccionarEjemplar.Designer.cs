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
            this.MagazineComboBox = new System.Windows.Forms.ComboBox();
            this.PublicationPendingListBox = new System.Windows.Forms.ListBox();
            this.CurrentAreaIssueListBox = new System.Windows.Forms.ListBox();
            this.AddToIssueButton = new System.Windows.Forms.Button();
            this.RemoveFromIssueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroRevista
            // 
            this.NumeroRevista.AutoSize = true;
            this.NumeroRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumeroRevista.Location = new System.Drawing.Point(22, 50);
            this.NumeroRevista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumeroRevista.Name = "NumeroRevista";
            this.NumeroRevista.Size = new System.Drawing.Size(164, 24);
            this.NumeroRevista.TabIndex = 0;
            this.NumeroRevista.Text = "Número de revista";
            this.NumeroRevista.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(26, 134);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // AreaPicker
            // 
            this.AreaPicker.FormattingEnabled = true;
            this.AreaPicker.Location = new System.Drawing.Point(26, 167);
            this.AreaPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AreaPicker.Name = "AreaPicker";
            this.AreaPicker.Size = new System.Drawing.Size(92, 21);
            this.AreaPicker.TabIndex = 2;
            this.AreaPicker.SelectedIndexChanged += new System.EventHandler(this.AreaPicker_SelectedIndexChanged);
            // 
            // ListaArticulos
            // 
            this.ListaArticulos.HideSelection = false;
            this.ListaArticulos.Location = new System.Drawing.Point(321, 74);
            this.ListaArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaArticulos.Name = "ListaArticulos";
            this.ListaArticulos.Size = new System.Drawing.Size(92, 80);
            this.ListaArticulos.TabIndex = 3;
            this.ListaArticulos.UseCompatibleStateImageBehavior = false;
            this.ListaArticulos.SelectedIndexChanged += new System.EventHandler(this.ListaArticulos_SelectedIndexChanged);
            // 
            // MagazineComboBox
            // 
            this.MagazineComboBox.FormattingEnabled = true;
            this.MagazineComboBox.Location = new System.Drawing.Point(26, 98);
            this.MagazineComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MagazineComboBox.Name = "MagazineComboBox";
            this.MagazineComboBox.Size = new System.Drawing.Size(92, 21);
            this.MagazineComboBox.TabIndex = 4;
            this.MagazineComboBox.SelectedIndexChanged += new System.EventHandler(this.MagazineComboBox_SelectedIndexChanged);
            // 
            // PublicationPendingListBox
            // 
            this.PublicationPendingListBox.FormattingEnabled = true;
            this.PublicationPendingListBox.Location = new System.Drawing.Point(26, 211);
            this.PublicationPendingListBox.Name = "PublicationPendingListBox";
            this.PublicationPendingListBox.Size = new System.Drawing.Size(120, 95);
            this.PublicationPendingListBox.TabIndex = 5;
            // 
            // CurrentAreaIssueListBox
            // 
            this.CurrentAreaIssueListBox.FormattingEnabled = true;
            this.CurrentAreaIssueListBox.Location = new System.Drawing.Point(186, 211);
            this.CurrentAreaIssueListBox.Name = "CurrentAreaIssueListBox";
            this.CurrentAreaIssueListBox.Size = new System.Drawing.Size(120, 95);
            this.CurrentAreaIssueListBox.TabIndex = 6;
            // 
            // AddToIssueButton
            // 
            this.AddToIssueButton.Location = new System.Drawing.Point(153, 232);
            this.AddToIssueButton.Name = "AddToIssueButton";
            this.AddToIssueButton.Size = new System.Drawing.Size(24, 23);
            this.AddToIssueButton.TabIndex = 7;
            this.AddToIssueButton.Text = "►";
            this.AddToIssueButton.UseVisualStyleBackColor = true;
            this.AddToIssueButton.Click += new System.EventHandler(this.AddToIssueButton_Click);
            // 
            // RemoveFromIssueButton
            // 
            this.RemoveFromIssueButton.Location = new System.Drawing.Point(152, 261);
            this.RemoveFromIssueButton.Name = "RemoveFromIssueButton";
            this.RemoveFromIssueButton.Size = new System.Drawing.Size(25, 23);
            this.RemoveFromIssueButton.TabIndex = 8;
            this.RemoveFromIssueButton.Text = "◄";
            this.RemoveFromIssueButton.UseVisualStyleBackColor = true;
            this.RemoveFromIssueButton.Click += new System.EventHandler(this.RemoveFromIssueButton_Click);
            // 
            // ConfeccionarEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.RemoveFromIssueButton);
            this.Controls.Add(this.AddToIssueButton);
            this.Controls.Add(this.CurrentAreaIssueListBox);
            this.Controls.Add(this.PublicationPendingListBox);
            this.Controls.Add(this.MagazineComboBox);
            this.Controls.Add(this.ListaArticulos);
            this.Controls.Add(this.AreaPicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.NumeroRevista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox MagazineComboBox;
        private System.Windows.Forms.ListBox PublicationPendingListBox;
        private System.Windows.Forms.ListBox CurrentAreaIssueListBox;
        private System.Windows.Forms.Button AddToIssueButton;
        private System.Windows.Forms.Button RemoveFromIssueButton;
    }
}