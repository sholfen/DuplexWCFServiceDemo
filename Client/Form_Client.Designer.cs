namespace Client
{
    partial class Form_Client
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
            this.Button_Login = new System.Windows.Forms.Button();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.TextBox_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(225, 12);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(75, 23);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.Location = new System.Drawing.Point(12, 12);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(207, 22);
            this.TextBox_UserName.TabIndex = 1;
            // 
            // TextBox_Message
            // 
            this.TextBox_Message.Location = new System.Drawing.Point(12, 53);
            this.TextBox_Message.Multiline = true;
            this.TextBox_Message.Name = "TextBox_Message";
            this.TextBox_Message.Size = new System.Drawing.Size(301, 204);
            this.TextBox_Message.TabIndex = 2;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 269);
            this.Controls.Add(this.TextBox_Message);
            this.Controls.Add(this.TextBox_UserName);
            this.Controls.Add(this.Button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.TextBox TextBox_Message;
    }
}

