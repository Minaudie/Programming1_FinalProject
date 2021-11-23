
namespace FinalProject
{
    partial class frmUpdatePrescription
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePrescription));
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnUpdatePreUpdate = new System.Windows.Forms.Button();
            this.btnUpdatePreCancel = new System.Windows.Forms.Button();
            this.dtpUpdatePreExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUpdatePreNumOfRefills = new System.Windows.Forms.TextBox();
            this.txtUpdatePreMedicationID = new System.Windows.Forms.TextBox();
            this.txtUpdatePrePhysicanID = new System.Windows.Forms.TextBox();
            this.txtUpdatePreClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatePrescriptionID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erpUpdatePrescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUpdatePrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Red;
            this.label39.Location = new System.Drawing.Point(214, 122);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 16);
            this.label39.TabIndex = 49;
            this.label39.Text = "*";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Red;
            this.label38.Location = new System.Drawing.Point(214, 70);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 16);
            this.label38.TabIndex = 48;
            this.label38.Text = "*";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(214, 96);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(13, 16);
            this.label37.TabIndex = 47;
            this.label37.Text = "*";
            // 
            // btnUpdatePreUpdate
            // 
            this.btnUpdatePreUpdate.Location = new System.Drawing.Point(165, 225);
            this.btnUpdatePreUpdate.Name = "btnUpdatePreUpdate";
            this.btnUpdatePreUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePreUpdate.TabIndex = 6;
            this.btnUpdatePreUpdate.Text = "&Update";
            this.btnUpdatePreUpdate.UseVisualStyleBackColor = true;
            this.btnUpdatePreUpdate.Click += new System.EventHandler(this.btnUpdatePreUpdate_Click);
            // 
            // btnUpdatePreCancel
            // 
            this.btnUpdatePreCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdatePreCancel.Location = new System.Drawing.Point(322, 225);
            this.btnUpdatePreCancel.Name = "btnUpdatePreCancel";
            this.btnUpdatePreCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePreCancel.TabIndex = 7;
            this.btnUpdatePreCancel.Text = "&Cancel";
            this.btnUpdatePreCancel.UseVisualStyleBackColor = true;
            this.btnUpdatePreCancel.Click += new System.EventHandler(this.btnUpdatePreCancel_Click);
            // 
            // dtpUpdatePreExpirationDate
            // 
            this.dtpUpdatePreExpirationDate.Location = new System.Drawing.Point(230, 152);
            this.dtpUpdatePreExpirationDate.Name = "dtpUpdatePreExpirationDate";
            this.dtpUpdatePreExpirationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdatePreExpirationDate.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(122, 179);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Number of Refills";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(130, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Expiration Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(136, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Medication ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(145, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Physican ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(162, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Client ID";
            // 
            // txtUpdatePreNumOfRefills
            // 
            this.txtUpdatePreNumOfRefills.Location = new System.Drawing.Point(230, 177);
            this.txtUpdatePreNumOfRefills.Name = "txtUpdatePreNumOfRefills";
            this.txtUpdatePreNumOfRefills.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePreNumOfRefills.TabIndex = 5;
            // 
            // txtUpdatePreMedicationID
            // 
            this.txtUpdatePreMedicationID.Location = new System.Drawing.Point(230, 122);
            this.txtUpdatePreMedicationID.Name = "txtUpdatePreMedicationID";
            this.txtUpdatePreMedicationID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePreMedicationID.TabIndex = 2;
            // 
            // txtUpdatePrePhysicanID
            // 
            this.txtUpdatePrePhysicanID.Location = new System.Drawing.Point(230, 96);
            this.txtUpdatePrePhysicanID.Name = "txtUpdatePrePhysicanID";
            this.txtUpdatePrePhysicanID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePrePhysicanID.TabIndex = 1;
            // 
            // txtUpdatePreClientID
            // 
            this.txtUpdatePreClientID.Location = new System.Drawing.Point(230, 69);
            this.txtUpdatePreClientID.Name = "txtUpdatePreClientID";
            this.txtUpdatePreClientID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePreClientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Prescription ID";
            // 
            // txtUpdatePrescriptionID
            // 
            this.txtUpdatePrescriptionID.Location = new System.Drawing.Point(230, 43);
            this.txtUpdatePrescriptionID.Name = "txtUpdatePrescriptionID";
            this.txtUpdatePrescriptionID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePrescriptionID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(213, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "*";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.updateToolStripMenuItem.Text = "update";
            // 
            // erpUpdatePrescription
            // 
            this.erpUpdatePrescription.ContainerControl = this;
            // 
            // frmUpdatePrescription
            // 
            this.AcceptButton = this.btnUpdatePreUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnUpdatePreCancel;
            this.ClientSize = new System.Drawing.Size(556, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpdatePrescriptionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.btnUpdatePreUpdate);
            this.Controls.Add(this.btnUpdatePreCancel);
            this.Controls.Add(this.dtpUpdatePreExpirationDate);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtUpdatePreNumOfRefills);
            this.Controls.Add(this.txtUpdatePreMedicationID);
            this.Controls.Add(this.txtUpdatePrePhysicanID);
            this.Controls.Add(this.txtUpdatePreClientID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdatePrescription";
            this.Text = "Update Prescription";
            this.Load += new System.EventHandler(this.frmUpdatePrescription_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpUpdatePrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnUpdatePreUpdate;
        private System.Windows.Forms.Button btnUpdatePreCancel;
        private System.Windows.Forms.DateTimePicker dtpUpdatePreExpirationDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUpdatePreNumOfRefills;
        private System.Windows.Forms.TextBox txtUpdatePreMedicationID;
        private System.Windows.Forms.TextBox txtUpdatePrePhysicanID;
        private System.Windows.Forms.TextBox txtUpdatePreClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdatePrescriptionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider erpUpdatePrescription;
    }
}