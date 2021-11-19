
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
            this.lblLandingWelcome = new System.Windows.Forms.Label();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnClientCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientUsername
            // 
            this.txtClientUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientUsername.Location = new System.Drawing.Point(81, 110);
            this.txtClientUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientUsername.Name = "txtClientUsername";
            this.txtClientUsername.Size = new System.Drawing.Size(218, 23);
            this.txtClientUsername.TabIndex = 0;
            this.txtClientUsername.TextChanged += new System.EventHandler(this.txtClientUsername_TextChanged);
            // 
            // txtClientPassword
            // 
            this.txtClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPassword.Location = new System.Drawing.Point(81, 174);
            this.txtClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientPassword.Name = "txtClientPassword";
            this.txtClientPassword.Size = new System.Drawing.Size(218, 23);
            this.txtClientPassword.TabIndex = 1;
            this.txtClientPassword.TextChanged += new System.EventHandler(this.txtClientPassword_TextChanged);
            // 
            // lblClientUsername
            // 
            this.lblClientUsername.AutoSize = true;
            this.lblClientUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientUsername.Location = new System.Drawing.Point(78, 91);
            this.lblClientUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientUsername.Name = "lblClientUsername";
            this.lblClientUsername.Size = new System.Drawing.Size(130, 17);
            this.lblClientUsername.TabIndex = 2;
            this.lblClientUsername.Text = "Change Username:";
            // 
            // lblClientPassword
            // 
            this.lblClientPassword.AutoSize = true;
            this.lblClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPassword.Location = new System.Drawing.Point(78, 155);
            this.lblClientPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPassword.Name = "lblClientPassword";
            this.lblClientPassword.Size = new System.Drawing.Size(126, 17);
            this.lblClientPassword.TabIndex = 3;
            this.lblClientPassword.Text = "Change Password:";
            // 
            // lblLandingWelcome
            // 
            this.lblLandingWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingWelcome.Location = new System.Drawing.Point(11, 16);
            this.lblLandingWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLandingWelcome.Name = "lblLandingWelcome";
            this.lblLandingWelcome.Size = new System.Drawing.Size(357, 48);
            this.lblLandingWelcome.TabIndex = 5;
            this.lblLandingWelcome.Text = "Welcome";
            this.lblLandingWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUpdate.Location = new System.Drawing.Point(106, 224);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(76, 31);
            this.btnClientUpdate.TabIndex = 6;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // btnClientCancel
            // 
            this.btnClientCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCancel.Location = new System.Drawing.Point(188, 224);
            this.btnClientCancel.Name = "btnClientCancel";
            this.btnClientCancel.Size = new System.Drawing.Size(76, 31);
            this.btnClientCancel.TabIndex = 6;
            this.btnClientCancel.Text = "Cancel";
            this.btnClientCancel.UseVisualStyleBackColor = true;
            this.btnClientCancel.Click += new System.EventHandler(this.btnClientCancel_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(379, 294);
            this.Controls.Add(this.btnClientCancel);
            this.Controls.Add(this.btnClientUpdate);
            this.Controls.Add(this.lblLandingWelcome);
            this.Controls.Add(this.lblClientPassword);
            this.Controls.Add(this.lblClientUsername);
            this.Controls.Add(this.txtClientPassword);
            this.Controls.Add(this.txtClientUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
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