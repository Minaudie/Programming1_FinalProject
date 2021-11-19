
namespace FinalProject
{
    partial class frmRegister
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
            this.btnRegisterRegister = new System.Windows.Forms.Button();
            this.btnRegisterCancel = new System.Windows.Forms.Button();
            this.txtRegisterClientID = new System.Windows.Forms.TextBox();
            this.lblRegisterClientID = new System.Windows.Forms.Label();
            this.btnEmployeeCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(91, 163);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(213, 23);
            this.txtRegisterUsername.TabIndex = 1;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(91, 228);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(213, 23);
            this.txtRegisterPassword.TabIndex = 2;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUsername.Location = new System.Drawing.Point(91, 143);
            this.lblRegisterUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(123, 17);
            this.lblRegisterUsername.TabIndex = 2;
            this.lblRegisterUsername.Text = "Create Username:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(91, 208);
            this.lblRegisterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(119, 17);
            this.lblRegisterPassword.TabIndex = 3;
            this.lblRegisterPassword.Text = "Create Password:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Client Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegisterRegister
            // 
            this.btnRegisterRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRegister.Location = new System.Drawing.Point(113, 279);
            this.btnRegisterRegister.Name = "btnRegisterRegister";
            this.btnRegisterRegister.Size = new System.Drawing.Size(78, 33);
            this.btnRegisterRegister.TabIndex = 3;
            this.btnRegisterRegister.Text = "Register";
            this.btnRegisterRegister.UseVisualStyleBackColor = true;
            this.btnRegisterRegister.Click += new System.EventHandler(this.btnRegisterRegister_Click);
            // 
            // btnRegisterCancel
            // 
            this.btnRegisterCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCancel.Location = new System.Drawing.Point(197, 279);
            this.btnRegisterCancel.Name = "btnRegisterCancel";
            this.btnRegisterCancel.Size = new System.Drawing.Size(78, 33);
            this.btnRegisterCancel.TabIndex = 4;
            this.btnRegisterCancel.Text = "Cancel";
            this.btnRegisterCancel.UseVisualStyleBackColor = true;
            this.btnRegisterCancel.Click += new System.EventHandler(this.btnRegisterCancel_Click);
            // 
            // txtRegisterClientID
            // 
            this.txtRegisterClientID.Location = new System.Drawing.Point(91, 100);
            this.txtRegisterClientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegisterClientID.Name = "txtRegisterClientID";
            this.txtRegisterClientID.Size = new System.Drawing.Size(213, 20);
            this.txtRegisterClientID.TabIndex = 0;
            this.txtRegisterClientID.TextChanged += new System.EventHandler(this.txtRegisterClientID_TextChanged);
            // 
            // lblRegisterClientID
            // 
            this.lblRegisterClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterClientID.Location = new System.Drawing.Point(92, 75);
            this.lblRegisterClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterClientID.Name = "lblRegisterClientID";
            this.lblRegisterClientID.Size = new System.Drawing.Size(87, 18);
            this.lblRegisterClientID.TabIndex = 7;
            this.lblRegisterClientID.Text = "Client ID: ";
            // 
            // btnEmployeeCreate
            // 
            this.btnEmployeeCreate.Location = new System.Drawing.Point(107, 333);
            this.btnEmployeeCreate.Name = "btnEmployeeCreate";
            this.btnEmployeeCreate.Size = new System.Drawing.Size(168, 23);
            this.btnEmployeeCreate.TabIndex = 8;
            this.btnEmployeeCreate.Text = "temp employee creation";
            this.btnEmployeeCreate.UseVisualStyleBackColor = true;
            this.btnEmployeeCreate.Click += new System.EventHandler(this.btnEmployeeCreate_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(393, 378);
            this.Controls.Add(this.btnEmployeeCreate);
            this.Controls.Add(this.lblRegisterClientID);
            this.Controls.Add(this.txtRegisterClientID);
            this.Controls.Add(this.btnRegisterCancel);
            this.Controls.Add(this.btnRegisterRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUsername);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnRegisterRegister;
        private System.Windows.Forms.Button btnRegisterCancel;
        private System.Windows.Forms.TextBox txtRegisterClientID;
        private System.Windows.Forms.Label lblRegisterClientID;
        private System.Windows.Forms.Button btnEmployeeCreate;
    }
}