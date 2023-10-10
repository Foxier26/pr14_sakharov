namespace pr14_sakharov.ModelEF
{
    partial class CaptchForm
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
            this.components = new System.ComponentModel.Container();
            this.updateBtn = new System.Windows.Forms.Button();
            this.captchLabel = new System.Windows.Forms.Label();
            this.captchTxtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.Location = new System.Drawing.Point(275, 209);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(225, 35);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Обновить код";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // captchLabel
            // 
            this.captchLabel.AutoSize = true;
            this.captchLabel.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchLabel.Location = new System.Drawing.Point(315, 107);
            this.captchLabel.Name = "captchLabel";
            this.captchLabel.Size = new System.Drawing.Size(152, 76);
            this.captchLabel.TabIndex = 1;
            this.captchLabel.Text = "label1";
            // 
            // captchTxtBox
            // 
            this.captchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchTxtBox.Location = new System.Drawing.Point(275, 273);
            this.captchTxtBox.Name = "captchTxtBox";
            this.captchTxtBox.Size = new System.Drawing.Size(225, 35);
            this.captchTxtBox.TabIndex = 2;
            this.captchTxtBox.TextChanged += new System.EventHandler(this.captchTxtBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.captchTxtBox);
            this.Controls.Add(this.captchLabel);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CaptchForm";
            this.Load += new System.EventHandler(this.CaptchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label captchLabel;
        private System.Windows.Forms.TextBox captchTxtBox;
        private System.Windows.Forms.Timer timer1;
    }
}