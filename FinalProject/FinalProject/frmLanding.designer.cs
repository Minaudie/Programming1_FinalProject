
namespace Programming1_FinalProject
{
    partial class Landing
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
            this.txtLandingUsername = new System.Windows.Forms.TextBox();
            this.txtLandingPassword = new System.Windows.Forms.TextBox();
            this.lblLandingUsername = new System.Windows.Forms.Label();
            this.lblLandingPassword = new System.Windows.Forms.Label();
            this.lblLandingWelcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkLandingNewClient = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtLandingUsername
            // 
            this.txtLandingUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandingUsername.Location = new System.Drawing.Point(117, 89);
            this.txtLandingUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtLandingUsername.Name = "txtLandingUsername";
            this.txtLandingUsername.Size = new System.Drawing.Size(210, 23);
            this.txtLandingUsername.TabIndex = 0;
            // 
            // txtLandingPassword
            // 
            this.txtLandingPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandingPassword.Location = new System.Drawing.Point(117, 132);
            this.txtLandingPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtLandingPassword.Name = "txtLandingPassword";
            this.txtLandingPassword.Size = new System.Drawing.Size(210, 23);
            this.txtLandingPassword.TabIndex = 1;
            // 
            // lblLandingUsername
            // 
            this.lblLandingUsername.AutoSize = true;
            this.lblLandingUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingUsername.Location = new System.Drawing.Point(35, 92);
            this.lblLandingUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLandingUsername.Name = "lblLandingUsername";
            this.lblLandingUsername.Size = new System.Drawing.Size(77, 17);
            this.lblLandingUsername.TabIndex = 2;
            this.lblLandingUsername.Text = "Username:";
            // 
            // lblLandingPassword
            // 
            this.lblLandingPassword.AutoSize = true;
            this.lblLandingPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingPassword.Location = new System.Drawing.Point(39, 135);
            this.lblLandingPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLandingPassword.Name = "lblLandingPassword";
            this.lblLandingPassword.Size = new System.Drawing.Size(73, 17);
            this.lblLandingPassword.TabIndex = 3;
            this.lblLandingPassword.Text = "Password:";
            // 
            // lblLandingWelcome
            // 
            this.lblLandingWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingWelcome.Location = new System.Drawing.Point(11, 19);
            this.lblLandingWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLandingWelcome.Name = "lblLandingWelcome";
            this.lblLandingWelcome.Size = new System.Drawing.Size(399, 48);
            this.lblLandingWelcome.TabIndex = 4;
            this.lblLandingWelcome.Text = "Welcome";
            this.lblLandingWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(179, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lnkLandingNewClient
            // 
            this.lnkLandingNewClient.AutoSize = true;
            this.lnkLandingNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLandingNewClient.Location = new System.Drawing.Point(114, 158);
            this.lnkLandingNewClient.Name = "lnkLandingNewClient";
            this.lnkLandingNewClient.Size = new System.Drawing.Size(135, 15);
            this.lnkLandingNewClient.TabIndex = 6;
            this.lnkLandingNewClient.TabStop = true;
            this.lnkLandingNewClient.Text = "New Client Registration";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 247);
            this.Controls.Add(this.lnkLandingNewClient);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLandingWelcome);
            this.Controls.Add(this.lblLandingPassword);
            this.Controls.Add(this.lblLandingUsername);
            this.Controls.Add(this.txtLandingPassword);
            this.Controls.Add(this.txtLandingUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Landing";
            this.Text = "Landing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLandingUsername;
        private System.Windows.Forms.TextBox txtLandingPassword;
        private System.Windows.Forms.Label lblLandingUsername;
        private System.Windows.Forms.Label lblLandingPassword;
        private System.Windows.Forms.Label lblLandingWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkLandingNewClient;
    }
}