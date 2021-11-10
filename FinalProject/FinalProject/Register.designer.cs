
namespace Programming1_FinalProject
{
    partial class Register
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
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(84, 87);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(194, 20);
            this.txtRegisterUsername.TabIndex = 0;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(84, 153);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(194, 20);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.Location = new System.Drawing.Point(136, 58);
            this.lblRegisterUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(112, 18);
            this.lblRegisterUsername.TabIndex = 2;
            this.lblRegisterUsername.Text = "Create Username:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.Location = new System.Drawing.Point(136, 122);
            this.lblRegisterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(112, 18);
            this.lblRegisterPassword.TabIndex = 3;
            this.lblRegisterPassword.Text = "Create Password:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUsername);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
    }
}