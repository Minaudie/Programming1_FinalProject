﻿
namespace FinalProject
{
    partial class frmUpdateRefill
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
            this.txtUpdateRefPrescriptionID = new System.Windows.Forms.TextBox();
            this.txtUpdateRefDosage = new System.Windows.Forms.TextBox();
            this.txtUpdateRefFrequency = new System.Windows.Forms.TextBox();
            this.txtUpdateRefSupplyDays = new System.Windows.Forms.TextBox();
            this.txtUpdateRefQuantitySupplied = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateRefillID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUpdateRefPrescriptionID
            // 
            this.txtUpdateRefPrescriptionID.Location = new System.Drawing.Point(250, 61);
            this.txtUpdateRefPrescriptionID.Name = "txtUpdateRefPrescriptionID";
            this.txtUpdateRefPrescriptionID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRefPrescriptionID.TabIndex = 0;
            // 
            // txtUpdateRefDosage
            // 
            this.txtUpdateRefDosage.Location = new System.Drawing.Point(250, 87);
            this.txtUpdateRefDosage.Name = "txtUpdateRefDosage";
            this.txtUpdateRefDosage.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRefDosage.TabIndex = 1;
            // 
            // txtUpdateRefFrequency
            // 
            this.txtUpdateRefFrequency.Location = new System.Drawing.Point(250, 113);
            this.txtUpdateRefFrequency.Name = "txtUpdateRefFrequency";
            this.txtUpdateRefFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRefFrequency.TabIndex = 2;
            // 
            // txtUpdateRefSupplyDays
            // 
            this.txtUpdateRefSupplyDays.Location = new System.Drawing.Point(250, 139);
            this.txtUpdateRefSupplyDays.Name = "txtUpdateRefSupplyDays";
            this.txtUpdateRefSupplyDays.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRefSupplyDays.TabIndex = 3;
            // 
            // txtUpdateRefQuantitySupplied
            // 
            this.txtUpdateRefQuantitySupplied.Location = new System.Drawing.Point(250, 165);
            this.txtUpdateRefQuantitySupplied.Name = "txtUpdateRefQuantitySupplied";
            this.txtUpdateRefQuantitySupplied.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRefQuantitySupplied.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(154, 168);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 13);
            this.label31.TabIndex = 34;
            this.label31.Text = "Qauntity Supplied";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(167, 142);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "Supply in Days";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(187, 115);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Frequency";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(200, 92);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Dosage";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(168, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 30;
            this.label27.Text = "Perscription ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Refill ID";
            // 
            // txtUpdateRefillID
            // 
            this.txtUpdateRefillID.Location = new System.Drawing.Point(250, 35);
            this.txtUpdateRefillID.Name = "txtUpdateRefillID";
            this.txtUpdateRefillID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRefillID.TabIndex = 37;
            // 
            // frmUpdateRefill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 334);
            this.Controls.Add(this.txtUpdateRefillID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateRefPrescriptionID);
            this.Controls.Add(this.txtUpdateRefDosage);
            this.Controls.Add(this.txtUpdateRefFrequency);
            this.Controls.Add(this.txtUpdateRefSupplyDays);
            this.Controls.Add(this.txtUpdateRefQuantitySupplied);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpdateRefill";
            this.Text = "Update Refill";
            this.Load += new System.EventHandler(this.frmUpdateRefill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUpdateRefPrescriptionID;
        private System.Windows.Forms.TextBox txtUpdateRefDosage;
        private System.Windows.Forms.TextBox txtUpdateRefFrequency;
        private System.Windows.Forms.TextBox txtUpdateRefSupplyDays;
        private System.Windows.Forms.TextBox txtUpdateRefQuantitySupplied;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateRefillID;
    }
}