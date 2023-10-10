namespace pr14_sakharov
{
    partial class MainForm
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
            this.loginTxtBox = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginLab = new System.Windows.Forms.Label();
            this.passwordLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTxtBox
            // 
            this.loginTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTxtBox.Location = new System.Drawing.Point(288, 148);
            this.loginTxtBox.Name = "loginTxtBox";
            this.loginTxtBox.Size = new System.Drawing.Size(225, 35);
            this.loginTxtBox.TabIndex = 4;
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(288, 297);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(225, 35);
            this.enter.TabIndex = 3;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTxtBox.Location = new System.Drawing.Point(288, 189);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(225, 35);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // loginLab
            // 
            this.loginLab.AutoSize = true;
            this.loginLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLab.Location = new System.Drawing.Point(155, 155);
            this.loginLab.Name = "loginLab";
            this.loginLab.Size = new System.Drawing.Size(64, 24);
            this.loginLab.TabIndex = 5;
            this.loginLab.Text = "Логин";
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLab.Location = new System.Drawing.Point(155, 196);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(76, 24);
            this.passwordLab.TabIndex = 5;
            this.passwordLab.Text = "Пароль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLab);
            this.Controls.Add(this.loginLab);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.loginTxtBox);
            this.Controls.Add(this.enter);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxtBox;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label loginLab;
        private System.Windows.Forms.Label passwordLab;
    }
}

