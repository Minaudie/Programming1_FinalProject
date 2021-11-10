
namespace Programming1_FinalProject
{
    partial class Client
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
            this.txtClientUsername = new System.Windows.Forms.TextBox();
            this.txtClientPassword = new System.Windows.Forms.TextBox();
            this.lblClientUsername = new System.Windows.Forms.Label();
            this.lblClientPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClientUsername
            // 
            this.txtClientUsername.Location = new System.Drawing.Point(98, 81);
            this.txtClientUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientUsername.Name = "txtClientUsername";
            this.txtClientUsername.Size = new System.Drawing.Size(172, 20);
            this.txtClientUsername.TabIndex = 0;
            // 
            // txtClientPassword
            // 
            this.txtClientPassword.Location = new System.Drawing.Point(98, 134);
            this.txtClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientPassword.Name = "txtClientPassword";
            this.txtClientPassword.Size = new System.Drawing.Size(172, 20);
            this.txtClientPassword.TabIndex = 1;
            // 
            // lblClientUsername
            // 
            this.lblClientUsername.Location = new System.Drawing.Point(150, 50);
            this.lblClientUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientUsername.Name = "lblClientUsername";
            this.lblClientUsername.Size = new System.Drawing.Size(111, 12);
            this.lblClientUsername.TabIndex = 2;
            this.lblClientUsername.Text = "Change Username:";
            // 
            // lblClientPassword
            // 
            this.lblClientPassword.Location = new System.Drawing.Point(150, 111);
            this.lblClientPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPassword.Name = "lblClientPassword";
            this.lblClientPassword.Size = new System.Drawing.Size(104, 12);
            this.lblClientPassword.TabIndex = 3;
            this.lblClientPassword.Text = "Change Password:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.lblClientPassword);
            this.Controls.Add(this.lblClientUsername);
            this.Controls.Add(this.txtClientPassword);
            this.Controls.Add(this.txtClientUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientUsername;
        private System.Windows.Forms.TextBox txtClientPassword;
        private System.Windows.Forms.Label lblClientUsername;
        private System.Windows.Forms.Label lblClientPassword;
    }
}