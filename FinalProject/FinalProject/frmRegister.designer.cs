
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrationRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(182, 202);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(422, 38);
            this.txtRegisterUsername.TabIndex = 0;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(182, 327);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(422, 38);
            this.txtRegisterPassword.TabIndex = 1;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUsername.Location = new System.Drawing.Point(182, 163);
            this.lblRegisterUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(236, 31);
            this.lblRegisterUsername.TabIndex = 2;
            this.lblRegisterUsername.Text = "Create Username:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(182, 288);
            this.lblRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(231, 31);
            this.lblRegisterPassword.TabIndex = 3;
            this.lblRegisterPassword.Text = "Create Password:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 121);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Client Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrationRegister
            // 
            this.btnRegistrationRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationRegister.Location = new System.Drawing.Point(226, 425);
            this.btnRegistrationRegister.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegistrationRegister.Name = "btnRegistrationRegister";
            this.btnRegistrationRegister.Size = new System.Drawing.Size(156, 63);
            this.btnRegistrationRegister.TabIndex = 5;
            this.btnRegistrationRegister.Text = "Register";
            this.btnRegistrationRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(394, 425);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 63);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 556);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegistrationRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUsername);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrationRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}