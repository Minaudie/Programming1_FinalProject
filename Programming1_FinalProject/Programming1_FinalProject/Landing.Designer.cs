
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
            this.txtUsernameLanding = new System.Windows.Forms.TextBox();
            this.txtPasswordLanding = new System.Windows.Forms.TextBox();
            this.lblUsernameLanding = new System.Windows.Forms.Label();
            this.lblPasswordLanding = new System.Windows.Forms.Label();
            this.lblWelcomeLanding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsernameLanding
            // 
            this.txtUsernameLanding.Location = new System.Drawing.Point(263, 202);
            this.txtUsernameLanding.Name = "txtUsernameLanding";
            this.txtUsernameLanding.Size = new System.Drawing.Size(416, 31);
            this.txtUsernameLanding.TabIndex = 0;
            // 
            // txtPasswordLanding
            // 
            this.txtPasswordLanding.Location = new System.Drawing.Point(263, 290);
            this.txtPasswordLanding.Name = "txtPasswordLanding";
            this.txtPasswordLanding.Size = new System.Drawing.Size(416, 31);
            this.txtPasswordLanding.TabIndex = 1;
            // 
            // lblUsernameLanding
            // 
            this.lblUsernameLanding.AutoSize = true;
            this.lblUsernameLanding.Location = new System.Drawing.Point(63, 207);
            this.lblUsernameLanding.Name = "lblUsernameLanding";
            this.lblUsernameLanding.Size = new System.Drawing.Size(116, 25);
            this.lblUsernameLanding.TabIndex = 2;
            this.lblUsernameLanding.Text = "Username:";
            // 
            // lblPasswordLanding
            // 
            this.lblPasswordLanding.AutoSize = true;
            this.lblPasswordLanding.Location = new System.Drawing.Point(63, 290);
            this.lblPasswordLanding.Name = "lblPasswordLanding";
            this.lblPasswordLanding.Size = new System.Drawing.Size(112, 25);
            this.lblPasswordLanding.TabIndex = 3;
            this.lblPasswordLanding.Text = "Password:";
            // 
            // lblWelcomeLanding
            // 
            this.lblWelcomeLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeLanding.Location = new System.Drawing.Point(311, 68);
            this.lblWelcomeLanding.Name = "lblWelcomeLanding";
            this.lblWelcomeLanding.Size = new System.Drawing.Size(416, 92);
            this.lblWelcomeLanding.TabIndex = 4;
            this.lblWelcomeLanding.Text = "Welcome";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 440);
            this.Controls.Add(this.lblWelcomeLanding);
            this.Controls.Add(this.lblPasswordLanding);
            this.Controls.Add(this.lblUsernameLanding);
            this.Controls.Add(this.txtPasswordLanding);
            this.Controls.Add(this.txtUsernameLanding);
            this.Name = "Landing";
            this.Text = "Landing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernameLanding;
        private System.Windows.Forms.TextBox txtPasswordLanding;
        private System.Windows.Forms.Label lblUsernameLanding;
        private System.Windows.Forms.Label lblPasswordLanding;
        private System.Windows.Forms.Label lblWelcomeLanding;
    }
}