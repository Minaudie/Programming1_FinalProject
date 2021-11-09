
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
            this.txtUsernameClient = new System.Windows.Forms.TextBox();
            this.txtPasswordClient = new System.Windows.Forms.TextBox();
            this.lblUsernameClient = new System.Windows.Forms.Label();
            this.lblPasswordClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsernameClient
            // 
            this.txtUsernameClient.Location = new System.Drawing.Point(197, 156);
            this.txtUsernameClient.Name = "txtUsernameClient";
            this.txtUsernameClient.Size = new System.Drawing.Size(340, 31);
            this.txtUsernameClient.TabIndex = 0;
            // 
            // txtPasswordClient
            // 
            this.txtPasswordClient.Location = new System.Drawing.Point(197, 258);
            this.txtPasswordClient.Name = "txtPasswordClient";
            this.txtPasswordClient.Size = new System.Drawing.Size(340, 31);
            this.txtPasswordClient.TabIndex = 1;
            // 
            // lblUsernameClient
            // 
            this.lblUsernameClient.Location = new System.Drawing.Point(299, 96);
            this.lblUsernameClient.Name = "lblUsernameClient";
            this.lblUsernameClient.Size = new System.Drawing.Size(222, 23);
            this.lblUsernameClient.TabIndex = 2;
            this.lblUsernameClient.Text = "Change Username:";
            // 
            // lblPasswordClient
            // 
            this.lblPasswordClient.Location = new System.Drawing.Point(299, 214);
            this.lblPasswordClient.Name = "lblPasswordClient";
            this.lblPasswordClient.Size = new System.Drawing.Size(208, 23);
            this.lblPasswordClient.TabIndex = 3;
            this.lblPasswordClient.Text = "Change Password:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPasswordClient);
            this.Controls.Add(this.lblUsernameClient);
            this.Controls.Add(this.txtPasswordClient);
            this.Controls.Add(this.txtUsernameClient);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernameClient;
        private System.Windows.Forms.TextBox txtPasswordClient;
        private System.Windows.Forms.Label lblUsernameClient;
        private System.Windows.Forms.Label lblPasswordClient;
    }
}