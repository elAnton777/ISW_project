namespace IGUMagazine
{
    partial class Login
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
            System.Windows.Forms.Label LoginLabel;
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BotonInicio = new System.Windows.Forms.Button();
            this.UserError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.CausesValidation = false;
            LoginLabel.Enabled = false;
            LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            LoginLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            LoginLabel.Location = new System.Drawing.Point(73, 54);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(61, 20);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "LOGIN";
            LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(80, 167);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(129, 22);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.TextChanged += new System.EventHandler(this.UserTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(80, 308);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(129, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(77, 128);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(54, 16);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Usuario";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(77, 258);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // BotonInicio
            // 
            this.BotonInicio.Location = new System.Drawing.Point(364, 372);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(124, 34);
            this.BotonInicio.TabIndex = 5;
            this.BotonInicio.Text = "Iniciar Sesión";
            this.BotonInicio.UseVisualStyleBackColor = true;
            this.BotonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // UserError
            // 
            this.UserError.AutoSize = true;
            this.UserError.BackColor = System.Drawing.SystemColors.Control;
            this.UserError.ForeColor = System.Drawing.Color.Firebrick;
            this.UserError.Location = new System.Drawing.Point(80, 215);
            this.UserError.Name = "UserError";
            this.UserError.Size = new System.Drawing.Size(102, 16);
            this.UserError.TabIndex = 6;
            this.UserError.Text = "Error de usuario";
            this.UserError.Visible = false;
            this.UserError.Click += new System.EventHandler(this.UserError_Click);
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordError.ForeColor = System.Drawing.Color.Firebrick;
            this.PasswordError.Location = new System.Drawing.Point(77, 349);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(125, 16);
            this.PasswordError.TabIndex = 7;
            this.PasswordError.Text = "Error de contraseña";
            this.PasswordError.Visible = false;
            this.PasswordError.Click += new System.EventHandler(this.PasswordError_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.UserError);
            this.Controls.Add(this.BotonInicio);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(LoginLabel);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Label UserError;
        private System.Windows.Forms.Label PasswordError;
    }
}

