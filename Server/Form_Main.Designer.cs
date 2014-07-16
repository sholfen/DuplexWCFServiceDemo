namespace Server
{
    partial class Form_Main
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
            this.Button_StartService = new System.Windows.Forms.Button();
            this.Button_StopService = new System.Windows.Forms.Button();
            this.Button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_StartService
            // 
            this.Button_StartService.Location = new System.Drawing.Point(66, 39);
            this.Button_StartService.Name = "Button_StartService";
            this.Button_StartService.Size = new System.Drawing.Size(75, 23);
            this.Button_StartService.TabIndex = 0;
            this.Button_StartService.Text = "Start";
            this.Button_StartService.UseVisualStyleBackColor = true;
            this.Button_StartService.Click += new System.EventHandler(this.Button_StartService_Click);
            // 
            // Button_StopService
            // 
            this.Button_StopService.Location = new System.Drawing.Point(66, 89);
            this.Button_StopService.Name = "Button_StopService";
            this.Button_StopService.Size = new System.Drawing.Size(75, 23);
            this.Button_StopService.TabIndex = 1;
            this.Button_StopService.Text = "Stop";
            this.Button_StopService.UseVisualStyleBackColor = true;
            this.Button_StopService.Click += new System.EventHandler(this.Button_StopService_Click);
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(66, 138);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Button_Send.TabIndex = 2;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 185);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Button_StopService);
            this.Controls.Add(this.Button_StartService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Main";
            this.Text = "WCF Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_StartService;
        private System.Windows.Forms.Button Button_StopService;
        private System.Windows.Forms.Button Button_Send;
    }
}

