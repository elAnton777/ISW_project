namespace IGUMagazine
{
    partial class MagazineUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.autor1 = new System.Windows.Forms.TextBox();
            this.autor2 = new System.Windows.Forms.TextBox();
            this.autor3 = new System.Windows.Forms.TextBox();
            this.autor4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Subbutton2 = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Area_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Contribucíon";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titulo_txt
            // 
            this.titulo_txt.Location = new System.Drawing.Point(62, 265);
            this.titulo_txt.Name = "titulo_txt";
            this.titulo_txt.Size = new System.Drawing.Size(100, 20);
            this.titulo_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Título";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // autor1
            // 
            this.autor1.Location = new System.Drawing.Point(271, 213);
            this.autor1.Name = "autor1";
            this.autor1.Size = new System.Drawing.Size(100, 20);
            this.autor1.TabIndex = 4;
            this.autor1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // autor2
            // 
            this.autor2.Location = new System.Drawing.Point(271, 239);
            this.autor2.Name = "autor2";
            this.autor2.Size = new System.Drawing.Size(100, 20);
            this.autor2.TabIndex = 5;
            this.autor2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // autor3
            // 
            this.autor3.Location = new System.Drawing.Point(271, 265);
            this.autor3.Name = "autor3";
            this.autor3.Size = new System.Drawing.Size(100, 20);
            this.autor3.TabIndex = 6;
            this.autor3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // autor4
            // 
            this.autor4.Location = new System.Drawing.Point(271, 291);
            this.autor4.Name = "autor4";
            this.autor4.Size = new System.Drawing.Size(100, 20);
            this.autor4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Colaboradores";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(350, 187);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(20, 20);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subbutton2
            // 
            this.Subbutton2.Location = new System.Drawing.Point(376, 187);
            this.Subbutton2.Name = "Subbutton2";
            this.Subbutton2.Size = new System.Drawing.Size(20, 20);
            this.Subbutton2.TabIndex = 10;
            this.Subbutton2.Text = "-";
            this.Subbutton2.UseVisualStyleBackColor = true;
            this.Subbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(274, 347);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 11;
            this.Send_Button.Text = "Enviar ";
            this.Send_Button.UseVisualStyleBackColor = true;
            // 
            // Area_txt
            // 
            this.Area_txt.Location = new System.Drawing.Point(63, 213);
            this.Area_txt.Name = "Area_txt";
            this.Area_txt.Size = new System.Drawing.Size(100, 20);
            this.Area_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Área";
            // 
            // MagazineUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Area_txt);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Subbutton2);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.autor4);
            this.Controls.Add(this.autor3);
            this.Controls.Add(this.autor2);
            this.Controls.Add(this.autor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titulo_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MagazineUForm";
            this.Text = "+";
            this.Load += new System.EventHandler(this.MagazineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titulo_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox autor1;
        private System.Windows.Forms.TextBox autor2;
        private System.Windows.Forms.TextBox autor3;
        private System.Windows.Forms.TextBox autor4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Subbutton2;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox Area_txt;
        private System.Windows.Forms.Label label5;
    }
}