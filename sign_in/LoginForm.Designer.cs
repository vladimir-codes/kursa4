namespace sign_in
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.LoginButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 329);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Продолжить без авторизации";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PasswordLabel);
            this.panel2.Controls.Add(this.PassBox);
            this.panel2.Controls.Add(this.LoginBox);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Location = new System.Drawing.Point(55, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 115);
            this.panel2.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(0, 58);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(196, 32);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PassBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.ForeColor = System.Drawing.Color.White;
            this.PassBox.Location = new System.Drawing.Point(0, 90);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(196, 25);
            this.PassBox.TabIndex = 3;
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassBox_KeyDown);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.ForeColor = System.Drawing.Color.White;
            this.LoginBox.Location = new System.Drawing.Point(0, 32);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(196, 25);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(0, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(196, 32);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login:";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LoginLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(55, 208);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(196, 35);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Join";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorisation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelClose.ForeColor = System.Drawing.Color.White;
            this.LabelClose.Location = new System.Drawing.Point(298, 0);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(20, 20);
            this.LabelClose.TabIndex = 1;
            this.LabelClose.Text = "X";
            this.LabelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 49);
            this.panel1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(318, 378);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button button1;
    }
}

