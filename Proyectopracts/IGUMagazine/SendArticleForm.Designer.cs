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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoAuthorTextBox1 = new System.Windows.Forms.TextBox();
            this.CoAuthorTextBox2 = new System.Windows.Forms.TextBox();
            this.CoAutorTextBox3 = new System.Windows.Forms.TextBox();
            this.CoAutorTextBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Subbutton = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
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
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(62, 265);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.titulo_txt_TextChanged);
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
            // CoAuthorTextBox1
            // 
            this.CoAuthorTextBox1.Location = new System.Drawing.Point(271, 213);
            this.CoAuthorTextBox1.Name = "CoAuthorTextBox1";
            this.CoAuthorTextBox1.Size = new System.Drawing.Size(100, 20);
            this.CoAuthorTextBox1.TabIndex = 4;
            this.CoAuthorTextBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CoAuthorTextBox2
            // 
            this.CoAuthorTextBox2.Location = new System.Drawing.Point(271, 239);
            this.CoAuthorTextBox2.Name = "CoAuthorTextBox2";
            this.CoAuthorTextBox2.Size = new System.Drawing.Size(100, 20);
            this.CoAuthorTextBox2.TabIndex = 5;
            this.CoAuthorTextBox2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CoAutorTextBox3
            // 
            this.CoAutorTextBox3.Location = new System.Drawing.Point(271, 265);
            this.CoAutorTextBox3.Name = "CoAutorTextBox3";
            this.CoAutorTextBox3.Size = new System.Drawing.Size(100, 20);
            this.CoAutorTextBox3.TabIndex = 6;
            this.CoAutorTextBox3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CoAutorTextBox4
            // 
            this.CoAutorTextBox4.Location = new System.Drawing.Point(271, 291);
            this.CoAutorTextBox4.Name = "CoAutorTextBox4";
            this.CoAutorTextBox4.Size = new System.Drawing.Size(100, 20);
            this.CoAutorTextBox4.TabIndex = 7;
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
            // Subbutton
            // 
            this.Subbutton.Location = new System.Drawing.Point(376, 187);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(20, 20);
            this.Subbutton.TabIndex = 10;
            this.Subbutton.Text = "-";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Enabled = false;
            this.Send_Button.Location = new System.Drawing.Point(274, 347);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 11;
            this.Send_Button.Text = "Enviar ";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(63, 213);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextBox.TabIndex = 1;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.Area_txt_TextChanged);
            this.AreaTextBox.DoubleClick += new System.EventHandler(this.EditAreaDoubleClick);
            this.AreaTextBox.Enter += new System.EventHandler(this.AreaTextBoxLeave);
            this.AreaTextBox.Leave += new System.EventHandler(this.AreaTextBoxLeave);
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
            // MagazineUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Subbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CoAutorTextBox4);
            this.Controls.Add(this.CoAutorTextBox3);
            this.Controls.Add(this.CoAuthorTextBox2);
            this.Controls.Add(this.CoAuthorTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MagazineUserForm";
            this.Text = "+";
            this.Load += new System.EventHandler(this.MagazineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CoAuthorTextBox1;
        private System.Windows.Forms.TextBox CoAuthorTextBox2;
        private System.Windows.Forms.TextBox CoAutorTextBox3;
        private System.Windows.Forms.TextBox CoAutorTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label label5;
    }
}