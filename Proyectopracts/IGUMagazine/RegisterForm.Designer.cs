namespace IGUMagazine
{
    partial class RegisterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.AlertedTickBox = new System.Windows.Forms.CheckBox();
            this.AreaOfInterestTextBox = new System.Windows.Forms.TextBox();
            this.AreaOfInterestLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.Label();
            this.AreaError = new System.Windows.Forms.Label();
            this.NameError = new System.Windows.Forms.Label();
            this.SurnameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.back_button_click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(261, 73);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(436, 73);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(132, 22);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(261, 145);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(132, 22);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(261, 209);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(307, 22);
            this.EmailTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(261, 49);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(56, 16);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Nombre";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(432, 49);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(57, 16);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "Apellido";
            this.SurnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(261, 126);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(54, 16);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Usuario";
            this.UsernameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(261, 190);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(118, 16);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Correo Electrónico";
            this.EmailLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(432, 126);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Contraseña";
            this.PasswordLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(265, 386);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(100, 28);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Registrarse";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // AlertedTickBox
            // 
            this.AlertedTickBox.AutoSize = true;
            this.AlertedTickBox.Location = new System.Drawing.Point(591, 212);
            this.AlertedTickBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlertedTickBox.Name = "AlertedTickBox";
            this.AlertedTickBox.Size = new System.Drawing.Size(72, 20);
            this.AlertedTickBox.TabIndex = 6;
            this.AlertedTickBox.Text = "Alerted";
            this.AlertedTickBox.UseVisualStyleBackColor = true;
            this.AlertedTickBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AreaOfInterestTextBox
            // 
            this.AreaOfInterestTextBox.Location = new System.Drawing.Point(436, 145);
            this.AreaOfInterestTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AreaOfInterestTextBox.Name = "AreaOfInterestTextBox";
            this.AreaOfInterestTextBox.Size = new System.Drawing.Size(132, 22);
            this.AreaOfInterestTextBox.TabIndex = 4;
            this.AreaOfInterestTextBox.TextChanged += new System.EventHandler(this.AreaOfInterestTextBox_TextChanged);
            // 
            // AreaOfInterestLabel
            // 
            this.AreaOfInterestLabel.AutoSize = true;
            this.AreaOfInterestLabel.Location = new System.Drawing.Point(433, 126);
            this.AreaOfInterestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaOfInterestLabel.Name = "AreaOfInterestLabel";
            this.AreaOfInterestLabel.Size = new System.Drawing.Size(105, 16);
            this.AreaOfInterestLabel.TabIndex = 14;
            this.AreaOfInterestLabel.Text = "Areas de Interés";
            this.AreaOfInterestLabel.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(261, 273);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(132, 22);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // UserError
            // 
            this.UserError.AutoSize = true;
            this.UserError.ForeColor = System.Drawing.Color.Firebrick;
            this.UserError.Location = new System.Drawing.Point(261, 171);
            this.UserError.Name = "UserError";
            this.UserError.Size = new System.Drawing.Size(102, 16);
            this.UserError.TabIndex = 17;
            this.UserError.Text = "Error de usuario";
            this.UserError.Visible = false;
            this.UserError.Click += new System.EventHandler(this.UserError_Click);
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Firebrick;
            this.PasswordError.Location = new System.Drawing.Point(260, 303);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(132, 16);
            this.PasswordError.TabIndex = 18;
            this.PasswordError.Text = "Error de constraseña";
            this.PasswordError.Visible = false;
            this.PasswordError.Click += new System.EventHandler(this.PasswordError_Click);
            // 
            // EmailError
            // 
            this.EmailError.AutoSize = true;
            this.EmailError.ForeColor = System.Drawing.Color.Firebrick;
            this.EmailError.Location = new System.Drawing.Point(261, 235);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(97, 16);
            this.EmailError.TabIndex = 19;
            this.EmailError.Text = "Error de correo";
            this.EmailError.Visible = false;
            this.EmailError.Click += new System.EventHandler(this.EmailError_Click);
            // 
            // AreaError
            // 
            this.AreaError.AutoSize = true;
            this.AreaError.ForeColor = System.Drawing.Color.Firebrick;
            this.AreaError.Location = new System.Drawing.Point(436, 175);
            this.AreaError.Name = "AreaError";
            this.AreaError.Size = new System.Drawing.Size(86, 16);
            this.AreaError.TabIndex = 20;
            this.AreaError.Text = "Error de area";
            this.AreaError.Visible = false;
            this.AreaError.Click += new System.EventHandler(this.AreaError_Click);
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.ForeColor = System.Drawing.Color.Firebrick;
            this.NameError.Location = new System.Drawing.Point(261, 103);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(104, 16);
            this.NameError.TabIndex = 21;
            this.NameError.Text = "Error de nombre";
            this.NameError.Visible = false;
            this.NameError.Click += new System.EventHandler(this.NameError_Click);
            // 
            // SurnameError
            // 
            this.SurnameError.AutoSize = true;
            this.SurnameError.ForeColor = System.Drawing.Color.Firebrick;
            this.SurnameError.Location = new System.Drawing.Point(435, 102);
            this.SurnameError.Name = "SurnameError";
            this.SurnameError.Size = new System.Drawing.Size(107, 16);
            this.SurnameError.TabIndex = 22;
            this.SurnameError.Text = "Error de apellido";
            this.SurnameError.Visible = false;
            this.SurnameError.Click += new System.EventHandler(this.SurnameError_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SurnameError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.AreaError);
            this.Controls.Add(this.EmailError);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.UserError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AreaOfInterestLabel);
            this.Controls.Add(this.AreaOfInterestTextBox);
            this.Controls.Add(this.AlertedTickBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.CheckBox AlertedTickBox;
        private System.Windows.Forms.TextBox AreaOfInterestTextBox;
        private System.Windows.Forms.Label AreaOfInterestLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserError;
        private System.Windows.Forms.Label PasswordError;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label AreaError;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label SurnameError;
    }
}