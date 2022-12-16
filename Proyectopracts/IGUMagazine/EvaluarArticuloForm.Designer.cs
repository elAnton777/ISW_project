namespace IGUMagazine
{
    partial class EvaluarArticuloForm
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
            this.titulo_tag = new System.Windows.Forms.Label();
            this.AreasComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista_Articulos = new System.Windows.Forms.DataGridView();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_envío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulos = new System.Windows.Forms.Label();
            this.ArticulosComboBox = new System.Windows.Forms.ComboBox();
            this.AcceptArticleCheckBox = new System.Windows.Forms.CheckBox();
            this.CommentsTextBox = new System.Windows.Forms.RichTextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_tag
            // 
            this.titulo_tag.AutoSize = true;
            this.titulo_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.titulo_tag.Location = new System.Drawing.Point(26, 27);
            this.titulo_tag.Name = "titulo_tag";
            this.titulo_tag.Size = new System.Drawing.Size(126, 17);
            this.titulo_tag.TabIndex = 1;
            this.titulo_tag.Text = "Artículos a Evaluar";
            // 
            // AreasComboBox
            // 
            this.AreasComboBox.FormattingEnabled = true;
            this.AreasComboBox.Location = new System.Drawing.Point(576, 74);
            this.AreasComboBox.Name = "AreasComboBox";
            this.AreasComboBox.Size = new System.Drawing.Size(121, 21);
            this.AreasComboBox.TabIndex = 2;
            this.AreasComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
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
            // Lista_Articulos
            // 
            this.Lista_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Autor,
            this.Fecha_de_envío});
            this.Lista_Articulos.Location = new System.Drawing.Point(12, 74);
            this.Lista_Articulos.Name = "Lista_Articulos";
            this.Lista_Articulos.RowHeadersWidth = 51;
            this.Lista_Articulos.Size = new System.Drawing.Size(406, 150);
            this.Lista_Articulos.TabIndex = 4;
            this.Lista_Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.MinimumWidth = 6;
            this.Título.Name = "Título";
            this.Título.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // Fecha_de_envío
            // 
            this.Fecha_de_envío.HeaderText = "Fecha de Envío";
            this.Fecha_de_envío.MinimumWidth = 6;
            this.Fecha_de_envío.Name = "Fecha_de_envío";
            this.Fecha_de_envío.Width = 125;
            // 
            // Articulos
            // 
            this.Articulos.AutoSize = true;
            this.Articulos.Location = new System.Drawing.Point(573, 111);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(49, 13);
            this.Articulos.TabIndex = 5;
            this.Articulos.Text = "Artículos";
            this.Articulos.Click += new System.EventHandler(this.label2_Click);
            // 
            // ArticulosComboBox
            // 
            this.ArticulosComboBox.FormattingEnabled = true;
            this.ArticulosComboBox.Location = new System.Drawing.Point(576, 137);
            this.ArticulosComboBox.Name = "ArticulosComboBox";
            this.ArticulosComboBox.Size = new System.Drawing.Size(121, 21);
            this.ArticulosComboBox.TabIndex = 6;
            this.ArticulosComboBox.SelectedIndexChanged += new System.EventHandler(this.ArticulosComboBox_SelectedIndexChanged);
            // 
            // AcceptArticleCheckBox
            // 
            this.AcceptArticleCheckBox.AutoSize = true;
            this.AcceptArticleCheckBox.Location = new System.Drawing.Point(576, 180);
            this.AcceptArticleCheckBox.Name = "AcceptArticleCheckBox";
            this.AcceptArticleCheckBox.Size = new System.Drawing.Size(158, 17);
            this.AcceptArticleCheckBox.TabIndex = 7;
            this.AcceptArticleCheckBox.Text = "¿Quiere aceptar el artículo?";
            this.AcceptArticleCheckBox.UseVisualStyleBackColor = true;
            this.AcceptArticleCheckBox.CheckedChanged += new System.EventHandler(this.AcceptArticleCheckBox_CheckedChanged);
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.Location = new System.Drawing.Point(576, 232);
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(193, 96);
            this.CommentsTextBox.TabIndex = 8;
            this.CommentsTextBox.Text = "";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(576, 352);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 9;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelEvaluation_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(694, 352);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 10;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Comentarios:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // EvaluarArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.CommentsTextBox);
            this.Controls.Add(this.AcceptArticleCheckBox);
            this.Controls.Add(this.ArticulosComboBox);
            this.Controls.Add(this.Articulos);
            this.Controls.Add(this.Lista_Articulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreasComboBox);
            this.Controls.Add(this.titulo_tag);
            this.Name = "EvaluarArticuloForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo_tag;
        private System.Windows.Forms.ComboBox AreasComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Lista_Articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_envío;
        private System.Windows.Forms.Label Articulos;
        private System.Windows.Forms.ComboBox ArticulosComboBox;
        private System.Windows.Forms.CheckBox AcceptArticleCheckBox;
        private System.Windows.Forms.RichTextBox CommentsTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Label label2;
    }
}