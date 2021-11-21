
namespace FinalProject
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.txtClientUsername = new System.Windows.Forms.TextBox();
            this.txtClientPassword = new System.Windows.Forms.TextBox();
            this.lblClientUsername = new System.Windows.Forms.Label();
            this.lblClientPassword = new System.Windows.Forms.Label();
            this.lblLandingWelcome = new System.Windows.Forms.Label();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnClientCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientUsername
            // 
            this.txtClientUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientUsername.Location = new System.Drawing.Point(162, 212);
            this.txtClientUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientUsername.Name = "txtClientUsername";
            this.txtClientUsername.Size = new System.Drawing.Size(432, 38);
            this.txtClientUsername.TabIndex = 0;
            this.txtClientUsername.TextChanged += new System.EventHandler(this.txtClientUsername_TextChanged);
            // 
            // txtClientPassword
            // 
            this.txtClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPassword.Location = new System.Drawing.Point(162, 335);
            this.txtClientPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientPassword.Name = "txtClientPassword";
            this.txtClientPassword.PasswordChar = '*';
            this.txtClientPassword.Size = new System.Drawing.Size(432, 38);
            this.txtClientPassword.TabIndex = 1;
            this.txtClientPassword.TextChanged += new System.EventHandler(this.txtClientPassword_TextChanged);
            // 
            // lblClientUsername
            // 
            this.lblClientUsername.AutoSize = true;
            this.lblClientUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientUsername.Location = new System.Drawing.Point(156, 175);
            this.lblClientUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientUsername.Name = "lblClientUsername";
            this.lblClientUsername.Size = new System.Drawing.Size(249, 31);
            this.lblClientUsername.TabIndex = 2;
            this.lblClientUsername.Text = "Change Username:";
            // 
            // lblClientPassword
            // 
            this.lblClientPassword.AutoSize = true;
            this.lblClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPassword.Location = new System.Drawing.Point(156, 298);
            this.lblClientPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientPassword.Name = "lblClientPassword";
            this.lblClientPassword.Size = new System.Drawing.Size(244, 31);
            this.lblClientPassword.TabIndex = 3;
            this.lblClientPassword.Text = "Change Password:";
            // 
            // lblLandingWelcome
            // 
            this.lblLandingWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingWelcome.Location = new System.Drawing.Point(22, 31);
            this.lblLandingWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLandingWelcome.Name = "lblLandingWelcome";
            this.lblLandingWelcome.Size = new System.Drawing.Size(714, 92);
            this.lblLandingWelcome.TabIndex = 5;
            this.lblLandingWelcome.Text = "Welcome";
            this.lblLandingWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUpdate.Location = new System.Drawing.Point(212, 431);
            this.btnClientUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(152, 60);
            this.btnClientUpdate.TabIndex = 6;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // btnClientCancel
            // 
            this.btnClientCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClientCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCancel.Location = new System.Drawing.Point(376, 431);
            this.btnClientCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClientCancel.Name = "btnClientCancel";
            this.btnClientCancel.Size = new System.Drawing.Size(152, 60);
            this.btnClientCancel.TabIndex = 6;
            this.btnClientCancel.Text = "Cancel";
            this.btnClientCancel.UseVisualStyleBackColor = true;
            this.btnClientCancel.Click += new System.EventHandler(this.btnClientCancel_Click);
            // 
            // frmClient
            // 
            this.AcceptButton = this.btnClientUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClientCancel;
            this.ClientSize = new System.Drawing.Size(758, 565);
            this.Controls.Add(this.btnClientCancel);
            this.Controls.Add(this.btnClientUpdate);
            this.Controls.Add(this.lblLandingWelcome);
            this.Controls.Add(this.lblClientPassword);
            this.Controls.Add(this.lblClientUsername);
            this.Controls.Add(this.txtClientPassword);
            this.Controls.Add(this.txtClientUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientUsername;
        private System.Windows.Forms.TextBox txtClientPassword;
        private System.Windows.Forms.Label lblClientUsername;
        private System.Windows.Forms.Label lblClientPassword;
        private System.Windows.Forms.Label lblLandingWelcome;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Button btnClientCancel;
    }
}