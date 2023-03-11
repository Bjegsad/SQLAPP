namespace SQLAPP
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
            this.login_field = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pass_field = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sureNameField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_field
            // 
            this.login_field.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_field.Location = new System.Drawing.Point(125, 207);
            this.login_field.Multiline = true;
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(244, 65);
            this.login_field.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(83)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sureNameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.pass_field);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.login_field);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 487);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(125, 114);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(244, 65);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(259, 331);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(260, 75);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // pass_field
            // 
            this.pass_field.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_field.Location = new System.Drawing.Point(509, 207);
            this.pass_field.Name = "pass_field";
            this.pass_field.Size = new System.Drawing.Size(244, 48);
            this.pass_field.TabIndex = 4;
            this.pass_field.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(108)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 75);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(108)))), ((int)(((byte)(65)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(108)))), ((int)(((byte)(65)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(758, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sureNameField
            // 
            this.sureNameField.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sureNameField.Location = new System.Drawing.Point(509, 114);
            this.sureNameField.Multiline = true;
            this.sureNameField.Name = "sureNameField";
            this.sureNameField.Size = new System.Drawing.Size(244, 65);
            this.sureNameField.TabIndex = 7;
            this.sureNameField.Enter += new System.EventHandler(this.sureNameField_Enter);
            this.sureNameField.Leave += new System.EventHandler(this.sureNameField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLAPP.Properties.Resources._352523_lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(440, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLAPP.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(55, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(300, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Уже есть аккаунт?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox pass_field;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox sureNameField;
        private System.Windows.Forms.Label label2;
    }
}