
using System;

namespace FinalProject
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRefill = new System.Windows.Forms.DataGridView();
            this.refillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPrescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySupplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRefill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuRefill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuRefillUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuRefillDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuRefillBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.clientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuClientUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuClientSearchPre = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuClientSearchRefill = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPre = new System.Windows.Forms.DataGridView();
            this.prescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refillCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuPrescription = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuPrescriptionUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuPrescriptionBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNewRefill = new System.Windows.Forms.TabPage();
            this.txtRefPaymentType = new System.Windows.Forms.Label();
            this.cboRefPaymentType = new System.Windows.Forms.ComboBox();
            this.btnRefSave = new System.Windows.Forms.Button();
            this.btnRefClear = new System.Windows.Forms.Button();
            this.txtRefPrescriptionID = new System.Windows.Forms.TextBox();
            this.txtRefDosage = new System.Windows.Forms.TextBox();
            this.txtRefFrequency = new System.Windows.Forms.TextBox();
            this.txtRefSupplyDays = new System.Windows.Forms.TextBox();
            this.txtRefQuantitySupplied = new System.Windows.Forms.TextBox();
            this.txtRefPrice = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabNewPrescription = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnPreSave = new System.Windows.Forms.Button();
            this.btnPreClear = new System.Windows.Forms.Button();
            this.dtpPreExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPreNumOfRefills = new System.Windows.Forms.TextBox();
            this.txtPreMedicationID = new System.Windows.Forms.TextBox();
            this.txtPrePhysicanID = new System.Windows.Forms.TextBox();
            this.txtPreClientID = new System.Windows.Forms.TextBox();
            this.tabNewPhysician = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnPhySave = new System.Windows.Forms.Button();
            this.btnPhyClear = new System.Windows.Forms.Button();
            this.txtPhyEmail = new System.Windows.Forms.TextBox();
            this.txtPhyPhone = new System.Windows.Forms.TextBox();
            this.txtPhyLName = new System.Windows.Forms.TextBox();
            this.txtPhyMidInt = new System.Windows.Forms.TextBox();
            this.txtPhyFName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabNewClient = new System.Windows.Forms.TabPage();
            this.cmboClientGender = new System.Windows.Forms.ComboBox();
            this.txtClientAdd2 = new System.Windows.Forms.TextBox();
            this.txtClientMidInt = new System.Windows.Forms.TextBox();
            this.btnClientSave = new System.Windows.Forms.Button();
            this.btnClientClear = new System.Windows.Forms.Button();
            this.txtClientDOB = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientZip = new System.Windows.Forms.TextBox();
            this.txtClientState = new System.Windows.Forms.TextBox();
            this.txtClientCity = new System.Windows.Forms.TextBox();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientLName = new System.Windows.Forms.TextBox();
            this.txtClientFName = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.erpEmployee = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefill)).BeginInit();
            this.cmuRefill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.cmuClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPre)).BeginInit();
            this.cmuPrescription.SuspendLayout();
            this.tabNewRefill.SuspendLayout();
            this.tabNewPrescription.SuspendLayout();
            this.tabNewPhysician.SuspendLayout();
            this.tabNewClient.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.dgvRefill);
            this.tabSearch.Controls.Add(this.txtSearch);
            this.tabSearch.Controls.Add(this.label25);
            this.tabSearch.Controls.Add(this.dgvClient);
            this.tabSearch.Controls.Add(this.dgvPre);
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(2);
            this.tabSearch.Size = new System.Drawing.Size(794, 441);
            this.tabSearch.TabIndex = 4;
            this.tabSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(473, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRefill
            // 
            this.dgvRefill.AllowUserToAddRows = false;
            this.dgvRefill.AllowUserToDeleteRows = false;
            this.dgvRefill.AllowUserToResizeColumns = false;
            this.dgvRefill.AllowUserToResizeRows = false;
            this.dgvRefill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refillID,
            this.rPrescriptionID,
            this.dosage,
            this.frequency,
            this.supplyDays,
            this.quantitySupplied,
            this.amountDue,
            this.dateOfRefill});
            this.dgvRefill.ContextMenuStrip = this.cmuRefill;
            this.dgvRefill.Location = new System.Drawing.Point(8, 83);
            this.dgvRefill.Name = "dgvRefill";
            this.dgvRefill.ReadOnly = true;
            this.dgvRefill.RowHeadersWidth = 82;
            this.dgvRefill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefill.Size = new System.Drawing.Size(775, 353);
            this.dgvRefill.TabIndex = 5;
            this.dgvRefill.Visible = false;
            // 
            // refillID
            // 
            this.refillID.DataPropertyName = "refillID";
            this.refillID.HeaderText = "Refill ID";
            this.refillID.MinimumWidth = 10;
            this.refillID.Name = "refillID";
            this.refillID.ReadOnly = true;
            // 
            // rPrescriptionID
            // 
            this.rPrescriptionID.DataPropertyName = "prescriptionID";
            this.rPrescriptionID.HeaderText = "Prescription ID";
            this.rPrescriptionID.MinimumWidth = 10;
            this.rPrescriptionID.Name = "rPrescriptionID";
            this.rPrescriptionID.ReadOnly = true;
            // 
            // dosage
            // 
            this.dosage.DataPropertyName = "dosage";
            this.dosage.HeaderText = "Dosage";
            this.dosage.MinimumWidth = 10;
            this.dosage.Name = "dosage";
            this.dosage.ReadOnly = true;
            // 
            // frequency
            // 
            this.frequency.DataPropertyName = "frequency";
            this.frequency.HeaderText = "Frequency";
            this.frequency.MinimumWidth = 10;
            this.frequency.Name = "frequency";
            this.frequency.ReadOnly = true;
            // 
            // supplyDays
            // 
            this.supplyDays.DataPropertyName = "supplyDays";
            this.supplyDays.HeaderText = "Supply Days";
            this.supplyDays.MinimumWidth = 10;
            this.supplyDays.Name = "supplyDays";
            this.supplyDays.ReadOnly = true;
            // 
            // quantitySupplied
            // 
            this.quantitySupplied.DataPropertyName = "quantitySupplied";
            this.quantitySupplied.HeaderText = "Quantity";
            this.quantitySupplied.MinimumWidth = 10;
            this.quantitySupplied.Name = "quantitySupplied";
            this.quantitySupplied.ReadOnly = true;
            // 
            // amountDue
            // 
            this.amountDue.DataPropertyName = "amountDue";
            this.amountDue.HeaderText = "Amount Due";
            this.amountDue.MinimumWidth = 10;
            this.amountDue.Name = "amountDue";
            this.amountDue.ReadOnly = true;
            // 
            // dateOfRefill
            // 
            this.dateOfRefill.DataPropertyName = "dateOfRefill";
            this.dateOfRefill.HeaderText = "Date";
            this.dateOfRefill.MinimumWidth = 10;
            this.dateOfRefill.Name = "dateOfRefill";
            this.dateOfRefill.ReadOnly = true;
            // 
            // cmuRefill
            // 
            this.cmuRefill.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmuRefill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuRefillUpdate,
            this.cmuRefillDelete,
            this.cmuRefillBack});
            this.cmuRefill.Name = "contextMenuRefill";
            this.cmuRefill.Size = new System.Drawing.Size(150, 70);
            // 
            // cmuRefillUpdate
            // 
            this.cmuRefillUpdate.Name = "cmuRefillUpdate";
            this.cmuRefillUpdate.Size = new System.Drawing.Size(149, 22);
            this.cmuRefillUpdate.Text = "Update";
            this.cmuRefillUpdate.Click += new System.EventHandler(this.cmuRefillUpdate_Click);
            // 
            // cmuRefillDelete
            // 
            this.cmuRefillDelete.Name = "cmuRefillDelete";
            this.cmuRefillDelete.Size = new System.Drawing.Size(149, 22);
            this.cmuRefillDelete.Text = "Delete";
            this.cmuRefillDelete.Click += new System.EventHandler(this.cmuRefillDelete_Click);
            // 
            // cmuRefillBack
            // 
            this.cmuRefillBack.Name = "cmuRefillBack";
            this.cmuRefillBack.Size = new System.Drawing.Size(149, 22);
            this.cmuRefillBack.Text = "Back To Client";
            this.cmuRefillBack.Click += new System.EventHandler(this.cmuRefillBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(283, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(202, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Enter ClientID:";
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AllowUserToResizeColumns = false;
            this.dgvClient.AllowUserToResizeRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientID,
            this.fName,
            this.mInitial,
            this.lName,
            this.dateOfBirth,
            this.gender,
            this.phone,
            this.email,
            this.street1,
            this.street2,
            this.city,
            this.addr_state,
            this.zip});
            this.dgvClient.ContextMenuStrip = this.cmuClient;
            this.dgvClient.Location = new System.Drawing.Point(8, 83);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersWidth = 82;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(775, 353);
            this.dgvClient.TabIndex = 7;
            this.dgvClient.Visible = false;
            // 
            // clientID
            // 
            this.clientID.DataPropertyName = "clientID";
            this.clientID.HeaderText = "Client ID";
            this.clientID.MinimumWidth = 10;
            this.clientID.Name = "clientID";
            this.clientID.ReadOnly = true;
            this.clientID.Width = 72;
            // 
            // fName
            // 
            this.fName.DataPropertyName = "fName";
            this.fName.HeaderText = "First Name";
            this.fName.MinimumWidth = 10;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            this.fName.Width = 82;
            // 
            // mInitial
            // 
            this.mInitial.DataPropertyName = "mInitial";
            this.mInitial.HeaderText = "Mid. Init.";
            this.mInitial.MinimumWidth = 10;
            this.mInitial.Name = "mInitial";
            this.mInitial.ReadOnly = true;
            this.mInitial.Width = 72;
            // 
            // lName
            // 
            this.lName.DataPropertyName = "lName";
            this.lName.HeaderText = "Last Name";
            this.lName.MinimumWidth = 10;
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            this.lName.Width = 83;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "dateOfBirth";
            this.dateOfBirth.HeaderText = "Date of Birth";
            this.dateOfBirth.MinimumWidth = 10;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            this.dateOfBirth.Width = 91;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 10;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 67;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 10;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 63;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 10;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 57;
            // 
            // street1
            // 
            this.street1.DataPropertyName = "street1";
            this.street1.HeaderText = "Street 1";
            this.street1.MinimumWidth = 10;
            this.street1.Name = "street1";
            this.street1.ReadOnly = true;
            this.street1.Width = 69;
            // 
            // street2
            // 
            this.street2.DataPropertyName = "street2";
            this.street2.HeaderText = "Street 2";
            this.street2.MinimumWidth = 10;
            this.street2.Name = "street2";
            this.street2.ReadOnly = true;
            this.street2.Width = 69;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 10;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 49;
            // 
            // addr_state
            // 
            this.addr_state.DataPropertyName = "addr_state";
            this.addr_state.HeaderText = "State";
            this.addr_state.MinimumWidth = 10;
            this.addr_state.Name = "addr_state";
            this.addr_state.ReadOnly = true;
            this.addr_state.Width = 57;
            // 
            // zip
            // 
            this.zip.DataPropertyName = "zip";
            this.zip.HeaderText = "Zip";
            this.zip.MinimumWidth = 10;
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            this.zip.Width = 47;
            // 
            // cmuClient
            // 
            this.cmuClient.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmuClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuClientUpdate,
            this.cmuClientSearchPre,
            this.cmuClientSearchRefill});
            this.cmuClient.Name = "contextMenuClient";
            this.cmuClient.Size = new System.Drawing.Size(176, 70);
            // 
            // cmuClientUpdate
            // 
            this.cmuClientUpdate.Name = "cmuClientUpdate";
            this.cmuClientUpdate.Size = new System.Drawing.Size(175, 22);
            this.cmuClientUpdate.Text = "Update";
            this.cmuClientUpdate.Click += new System.EventHandler(this.cmuClientUpdate_Click);
            // 
            // cmuClientSearchPre
            // 
            this.cmuClientSearchPre.Name = "cmuClientSearchPre";
            this.cmuClientSearchPre.Size = new System.Drawing.Size(175, 22);
            this.cmuClientSearchPre.Text = "Search Prescription";
            this.cmuClientSearchPre.Click += new System.EventHandler(this.cmuClientSearchPre_Click);
            // 
            // cmuClientSearchRefill
            // 
            this.cmuClientSearchRefill.Name = "cmuClientSearchRefill";
            this.cmuClientSearchRefill.Size = new System.Drawing.Size(175, 22);
            this.cmuClientSearchRefill.Text = "Search Refill";
            this.cmuClientSearchRefill.Click += new System.EventHandler(this.cmuClientSearchRefill_Click);
            // 
            // dgvPre
            // 
            this.dgvPre.AllowUserToAddRows = false;
            this.dgvPre.AllowUserToDeleteRows = false;
            this.dgvPre.AllowUserToResizeColumns = false;
            this.dgvPre.AllowUserToResizeRows = false;
            this.dgvPre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionID,
            this.pClientID,
            this.physicianID,
            this.medicineID,
            this.startDate,
            this.expiryDate,
            this.refillCounter,
            this.price});
            this.dgvPre.ContextMenuStrip = this.cmuPrescription;
            this.dgvPre.Location = new System.Drawing.Point(8, 83);
            this.dgvPre.Name = "dgvPre";
            this.dgvPre.ReadOnly = true;
            this.dgvPre.RowHeadersWidth = 82;
            this.dgvPre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPre.Size = new System.Drawing.Size(775, 353);
            this.dgvPre.TabIndex = 6;
            this.dgvPre.Visible = false;
            // 
            // prescriptionID
            // 
            this.prescriptionID.DataPropertyName = "prescriptionID";
            this.prescriptionID.HeaderText = "PrescriptionID";
            this.prescriptionID.MinimumWidth = 10;
            this.prescriptionID.Name = "prescriptionID";
            this.prescriptionID.ReadOnly = true;
            // 
            // pClientID
            // 
            this.pClientID.DataPropertyName = "clientID";
            this.pClientID.HeaderText = "Client ID";
            this.pClientID.MinimumWidth = 10;
            this.pClientID.Name = "pClientID";
            this.pClientID.ReadOnly = true;
            // 
            // physicianID
            // 
            this.physicianID.DataPropertyName = "physicianID";
            this.physicianID.HeaderText = "Physician ID";
            this.physicianID.MinimumWidth = 10;
            this.physicianID.Name = "physicianID";
            this.physicianID.ReadOnly = true;
            // 
            // medicineID
            // 
            this.medicineID.DataPropertyName = "medicineID";
            this.medicineID.HeaderText = "Medicine ID";
            this.medicineID.MinimumWidth = 10;
            this.medicineID.Name = "medicineID";
            this.medicineID.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "startDate";
            this.startDate.HeaderText = "Start Date";
            this.startDate.MinimumWidth = 10;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // expiryDate
            // 
            this.expiryDate.DataPropertyName = "expiryDate";
            this.expiryDate.HeaderText = "Expiry Date";
            this.expiryDate.MinimumWidth = 10;
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ReadOnly = true;
            // 
            // refillCounter
            // 
            this.refillCounter.DataPropertyName = "refillCounter";
            this.refillCounter.HeaderText = "Refills Left";
            this.refillCounter.MinimumWidth = 10;
            this.refillCounter.Name = "refillCounter";
            this.refillCounter.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // cmuPrescription
            // 
            this.cmuPrescription.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmuPrescription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuPrescriptionUpdate,
            this.cmuPrescriptionBack});
            this.cmuPrescription.Name = "contextMenuPre";
            this.cmuPrescription.Size = new System.Drawing.Size(181, 70);
            // 
            // cmuPrescriptionUpdate
            // 
            this.cmuPrescriptionUpdate.Name = "cmuPrescriptionUpdate";
            this.cmuPrescriptionUpdate.Size = new System.Drawing.Size(180, 22);
            this.cmuPrescriptionUpdate.Text = "Update";
            this.cmuPrescriptionUpdate.Click += new System.EventHandler(this.cmuPrescriptionUpdate_Click);
            // 
            // cmuPrescriptionBack
            // 
            this.cmuPrescriptionBack.Name = "cmuPrescriptionBack";
            this.cmuPrescriptionBack.Size = new System.Drawing.Size(180, 22);
            this.cmuPrescriptionBack.Text = "Back To Client";
            this.cmuPrescriptionBack.Click += new System.EventHandler(this.cmuPrescriptionBack_Click);
            // 
            // tabNewRefill
            // 
            this.tabNewRefill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabNewRefill.Controls.Add(this.txtRefPaymentType);
            this.tabNewRefill.Controls.Add(this.cboRefPaymentType);
            this.tabNewRefill.Controls.Add(this.btnRefSave);
            this.tabNewRefill.Controls.Add(this.btnRefClear);
            this.tabNewRefill.Controls.Add(this.txtRefPrescriptionID);
            this.tabNewRefill.Controls.Add(this.txtRefDosage);
            this.tabNewRefill.Controls.Add(this.txtRefFrequency);
            this.tabNewRefill.Controls.Add(this.txtRefSupplyDays);
            this.tabNewRefill.Controls.Add(this.txtRefQuantitySupplied);
            this.tabNewRefill.Controls.Add(this.txtRefPrice);
            this.tabNewRefill.Controls.Add(this.label32);
            this.tabNewRefill.Controls.Add(this.label31);
            this.tabNewRefill.Controls.Add(this.label30);
            this.tabNewRefill.Controls.Add(this.label29);
            this.tabNewRefill.Controls.Add(this.label28);
            this.tabNewRefill.Controls.Add(this.label27);
            this.tabNewRefill.Location = new System.Drawing.Point(4, 25);
            this.tabNewRefill.Name = "tabNewRefill";
            this.tabNewRefill.Padding = new System.Windows.Forms.Padding(2);
            this.tabNewRefill.Size = new System.Drawing.Size(794, 441);
            this.tabNewRefill.TabIndex = 3;
            this.tabNewRefill.Text = "New Refill";
            // 
            // txtRefPaymentType
            // 
            this.txtRefPaymentType.AutoSize = true;
            this.txtRefPaymentType.Location = new System.Drawing.Point(225, 192);
            this.txtRefPaymentType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtRefPaymentType.Name = "txtRefPaymentType";
            this.txtRefPaymentType.Size = new System.Drawing.Size(75, 13);
            this.txtRefPaymentType.TabIndex = 10;
            this.txtRefPaymentType.Text = "Payment Type";
            // 
            // cboRefPaymentType
            // 
            this.cboRefPaymentType.FormattingEnabled = true;
            this.cboRefPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Check"});
            this.cboRefPaymentType.Location = new System.Drawing.Point(308, 190);
            this.cboRefPaymentType.Margin = new System.Windows.Forms.Padding(2);
            this.cboRefPaymentType.Name = "cboRefPaymentType";
            this.cboRefPaymentType.Size = new System.Drawing.Size(100, 21);
            this.cboRefPaymentType.TabIndex = 6;
            this.cboRefPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboRefPayment_SelectedIndexChanged);
            // 
            // btnRefSave
            // 
            this.btnRefSave.Location = new System.Drawing.Point(228, 248);
            this.btnRefSave.Name = "btnRefSave";
            this.btnRefSave.Size = new System.Drawing.Size(75, 23);
            this.btnRefSave.TabIndex = 7;
            this.btnRefSave.Text = "&Save";
            this.btnRefSave.UseVisualStyleBackColor = true;
            this.btnRefSave.Click += new System.EventHandler(this.btnRefSave_Click);
            // 
            // btnRefClear
            // 
            this.btnRefClear.Location = new System.Drawing.Point(408, 248);
            this.btnRefClear.Name = "btnRefClear";
            this.btnRefClear.Size = new System.Drawing.Size(75, 23);
            this.btnRefClear.TabIndex = 8;
            this.btnRefClear.Text = "&Clear";
            this.btnRefClear.UseVisualStyleBackColor = true;
            this.btnRefClear.Click += new System.EventHandler(this.btnRefClear_Click);
            // 
            // txtRefPrescriptionID
            // 
            this.txtRefPrescriptionID.Location = new System.Drawing.Point(308, 33);
            this.txtRefPrescriptionID.Name = "txtRefPrescriptionID";
            this.txtRefPrescriptionID.Size = new System.Drawing.Size(100, 20);
            this.txtRefPrescriptionID.TabIndex = 0;
            this.txtRefPrescriptionID.TextChanged += new System.EventHandler(this.txtRefPrescriptionID_TextChanged);
            // 
            // txtRefDosage
            // 
            this.txtRefDosage.Location = new System.Drawing.Point(308, 58);
            this.txtRefDosage.Name = "txtRefDosage";
            this.txtRefDosage.Size = new System.Drawing.Size(100, 20);
            this.txtRefDosage.TabIndex = 1;
            this.txtRefDosage.TextChanged += new System.EventHandler(this.txtRefDosage_TextChanged);
            // 
            // txtRefFrequency
            // 
            this.txtRefFrequency.Location = new System.Drawing.Point(308, 84);
            this.txtRefFrequency.Name = "txtRefFrequency";
            this.txtRefFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtRefFrequency.TabIndex = 2;
            this.txtRefFrequency.TextChanged += new System.EventHandler(this.txtRefFrequency_TextChanged);
            // 
            // txtRefSupplyDays
            // 
            this.txtRefSupplyDays.Location = new System.Drawing.Point(308, 110);
            this.txtRefSupplyDays.Name = "txtRefSupplyDays";
            this.txtRefSupplyDays.Size = new System.Drawing.Size(100, 20);
            this.txtRefSupplyDays.TabIndex = 3;
            this.txtRefSupplyDays.TextChanged += new System.EventHandler(this.txtRefSupplyDays_TextChanged);
            // 
            // txtRefQuantitySupplied
            // 
            this.txtRefQuantitySupplied.Location = new System.Drawing.Point(308, 136);
            this.txtRefQuantitySupplied.Name = "txtRefQuantitySupplied";
            this.txtRefQuantitySupplied.Size = new System.Drawing.Size(100, 20);
            this.txtRefQuantitySupplied.TabIndex = 4;
            this.txtRefQuantitySupplied.TextChanged += new System.EventHandler(this.txtRefQuantitySupplied_TextChanged);
            // 
            // txtRefPrice
            // 
            this.txtRefPrice.Enabled = false;
            this.txtRefPrice.Location = new System.Drawing.Point(308, 162);
            this.txtRefPrice.Name = "txtRefPrice";
            this.txtRefPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRefPrice.TabIndex = 5;
            this.txtRefPrice.TextChanged += new System.EventHandler(this.txtRefPrice_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(271, 165);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(31, 13);
            this.label32.TabIndex = 7;
            this.label32.Text = "Price";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(212, 140);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "Qauntity Supplied";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(225, 114);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 13);
            this.label30.TabIndex = 5;
            this.label30.Text = "Supply in Days";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(245, 87);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Frequency";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(258, 63);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "Dosage";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(226, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Perscription ID";
            // 
            // tabNewPrescription
            // 
            this.tabNewPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabNewPrescription.Controls.Add(this.label39);
            this.tabNewPrescription.Controls.Add(this.label38);
            this.tabNewPrescription.Controls.Add(this.label37);
            this.tabNewPrescription.Controls.Add(this.btnPreSave);
            this.tabNewPrescription.Controls.Add(this.btnPreClear);
            this.tabNewPrescription.Controls.Add(this.dtpPreExpirationDate);
            this.tabNewPrescription.Controls.Add(this.label24);
            this.tabNewPrescription.Controls.Add(this.label23);
            this.tabNewPrescription.Controls.Add(this.label21);
            this.tabNewPrescription.Controls.Add(this.label20);
            this.tabNewPrescription.Controls.Add(this.label19);
            this.tabNewPrescription.Controls.Add(this.txtPreNumOfRefills);
            this.tabNewPrescription.Controls.Add(this.txtPreMedicationID);
            this.tabNewPrescription.Controls.Add(this.txtPrePhysicanID);
            this.tabNewPrescription.Controls.Add(this.txtPreClientID);
            this.tabNewPrescription.Location = new System.Drawing.Point(4, 25);
            this.tabNewPrescription.Name = "tabNewPrescription";
            this.tabNewPrescription.Padding = new System.Windows.Forms.Padding(2);
            this.tabNewPrescription.Size = new System.Drawing.Size(794, 441);
            this.tabNewPrescription.TabIndex = 2;
            this.tabNewPrescription.Text = "New Prescription";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Red;
            this.label39.Location = new System.Drawing.Point(347, 122);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 16);
            this.label39.TabIndex = 32;
            this.label39.Text = "*";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Red;
            this.label38.Location = new System.Drawing.Point(347, 70);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 16);
            this.label38.TabIndex = 31;
            this.label38.Text = "*";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(347, 96);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(13, 16);
            this.label37.TabIndex = 30;
            this.label37.Text = "*";
            // 
            // btnPreSave
            // 
            this.btnPreSave.Location = new System.Drawing.Point(273, 249);
            this.btnPreSave.Name = "btnPreSave";
            this.btnPreSave.Size = new System.Drawing.Size(75, 23);
            this.btnPreSave.TabIndex = 6;
            this.btnPreSave.Text = "&Save";
            this.btnPreSave.UseVisualStyleBackColor = true;
            this.btnPreSave.Click += new System.EventHandler(this.btnPreSave_Click);
            // 
            // btnPreClear
            // 
            this.btnPreClear.Location = new System.Drawing.Point(467, 249);
            this.btnPreClear.Name = "btnPreClear";
            this.btnPreClear.Size = new System.Drawing.Size(75, 23);
            this.btnPreClear.TabIndex = 7;
            this.btnPreClear.Text = "&Clear";
            this.btnPreClear.UseVisualStyleBackColor = true;
            this.btnPreClear.Click += new System.EventHandler(this.btnPreClear_Click);
            // 
            // dtpPreExpirationDate
            // 
            this.dtpPreExpirationDate.Location = new System.Drawing.Point(363, 175);
            this.dtpPreExpirationDate.Name = "dtpPreExpirationDate";
            this.dtpPreExpirationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPreExpirationDate.TabIndex = 4;
            this.dtpPreExpirationDate.ValueChanged += new System.EventHandler(this.dtpPreExpirationDate_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(261, 203);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Number of Refills";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(269, 177);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Expiration Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(275, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Medication ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(284, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Physican ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(301, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Client ID";
            // 
            // txtPreNumOfRefills
            // 
            this.txtPreNumOfRefills.Location = new System.Drawing.Point(363, 200);
            this.txtPreNumOfRefills.Name = "txtPreNumOfRefills";
            this.txtPreNumOfRefills.Size = new System.Drawing.Size(100, 20);
            this.txtPreNumOfRefills.TabIndex = 5;
            this.txtPreNumOfRefills.TextChanged += new System.EventHandler(this.txtPreNumOfRefills_TextChanged);
            // 
            // txtPreMedicationID
            // 
            this.txtPreMedicationID.Location = new System.Drawing.Point(363, 122);
            this.txtPreMedicationID.Name = "txtPreMedicationID";
            this.txtPreMedicationID.Size = new System.Drawing.Size(100, 20);
            this.txtPreMedicationID.TabIndex = 2;
            this.txtPreMedicationID.TextChanged += new System.EventHandler(this.txtPreMedicationID_TextChanged);
            // 
            // txtPrePhysicanID
            // 
            this.txtPrePhysicanID.Location = new System.Drawing.Point(363, 96);
            this.txtPrePhysicanID.Name = "txtPrePhysicanID";
            this.txtPrePhysicanID.Size = new System.Drawing.Size(100, 20);
            this.txtPrePhysicanID.TabIndex = 1;
            this.txtPrePhysicanID.TextChanged += new System.EventHandler(this.txtPrePhysicanID_TextChanged);
            // 
            // txtPreClientID
            // 
            this.txtPreClientID.Location = new System.Drawing.Point(363, 69);
            this.txtPreClientID.Name = "txtPreClientID";
            this.txtPreClientID.Size = new System.Drawing.Size(100, 20);
            this.txtPreClientID.TabIndex = 0;
            this.txtPreClientID.TextChanged += new System.EventHandler(this.txtPreClientID_TextChanged);
            // 
            // tabNewPhysician
            // 
            this.tabNewPhysician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabNewPhysician.Controls.Add(this.label36);
            this.tabNewPhysician.Controls.Add(this.label34);
            this.tabNewPhysician.Controls.Add(this.btnPhySave);
            this.tabNewPhysician.Controls.Add(this.btnPhyClear);
            this.tabNewPhysician.Controls.Add(this.txtPhyEmail);
            this.tabNewPhysician.Controls.Add(this.txtPhyPhone);
            this.tabNewPhysician.Controls.Add(this.txtPhyLName);
            this.tabNewPhysician.Controls.Add(this.txtPhyMidInt);
            this.tabNewPhysician.Controls.Add(this.txtPhyFName);
            this.tabNewPhysician.Controls.Add(this.label18);
            this.tabNewPhysician.Controls.Add(this.label17);
            this.tabNewPhysician.Controls.Add(this.label16);
            this.tabNewPhysician.Controls.Add(this.label15);
            this.tabNewPhysician.Controls.Add(this.label14);
            this.tabNewPhysician.Location = new System.Drawing.Point(4, 25);
            this.tabNewPhysician.Name = "tabNewPhysician";
            this.tabNewPhysician.Padding = new System.Windows.Forms.Padding(2);
            this.tabNewPhysician.Size = new System.Drawing.Size(794, 441);
            this.tabNewPhysician.TabIndex = 1;
            this.tabNewPhysician.Text = "New Physician";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Red;
            this.label36.Location = new System.Drawing.Point(300, 114);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(13, 16);
            this.label36.TabIndex = 31;
            this.label36.Text = "*";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.Location = new System.Drawing.Point(300, 62);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(13, 16);
            this.label34.TabIndex = 30;
            this.label34.Text = "*";
            // 
            // btnPhySave
            // 
            this.btnPhySave.Location = new System.Drawing.Point(223, 215);
            this.btnPhySave.Name = "btnPhySave";
            this.btnPhySave.Size = new System.Drawing.Size(75, 23);
            this.btnPhySave.TabIndex = 5;
            this.btnPhySave.Text = "&Save";
            this.btnPhySave.UseVisualStyleBackColor = true;
            this.btnPhySave.Click += new System.EventHandler(this.btnPhySave_Click);
            // 
            // btnPhyClear
            // 
            this.btnPhyClear.Location = new System.Drawing.Point(417, 215);
            this.btnPhyClear.Name = "btnPhyClear";
            this.btnPhyClear.Size = new System.Drawing.Size(75, 23);
            this.btnPhyClear.TabIndex = 6;
            this.btnPhyClear.Text = "&Clear";
            this.btnPhyClear.UseVisualStyleBackColor = true;
            this.btnPhyClear.Click += new System.EventHandler(this.btnPhyClear_Click);
            // 
            // txtPhyEmail
            // 
            this.txtPhyEmail.Location = new System.Drawing.Point(313, 168);
            this.txtPhyEmail.Name = "txtPhyEmail";
            this.txtPhyEmail.Size = new System.Drawing.Size(100, 20);
            this.txtPhyEmail.TabIndex = 4;
            // 
            // txtPhyPhone
            // 
            this.txtPhyPhone.Location = new System.Drawing.Point(313, 142);
            this.txtPhyPhone.Name = "txtPhyPhone";
            this.txtPhyPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhyPhone.TabIndex = 3;
            // 
            // txtPhyLName
            // 
            this.txtPhyLName.Location = new System.Drawing.Point(313, 116);
            this.txtPhyLName.Name = "txtPhyLName";
            this.txtPhyLName.Size = new System.Drawing.Size(100, 20);
            this.txtPhyLName.TabIndex = 2;
            this.txtPhyLName.TextChanged += new System.EventHandler(this.txtPhyLName_TextChanged);
            // 
            // txtPhyMidInt
            // 
            this.txtPhyMidInt.Location = new System.Drawing.Point(313, 90);
            this.txtPhyMidInt.Name = "txtPhyMidInt";
            this.txtPhyMidInt.Size = new System.Drawing.Size(100, 20);
            this.txtPhyMidInt.TabIndex = 1;
            // 
            // txtPhyFName
            // 
            this.txtPhyFName.Location = new System.Drawing.Point(313, 64);
            this.txtPhyFName.Name = "txtPhyFName";
            this.txtPhyFName.Size = new System.Drawing.Size(100, 20);
            this.txtPhyFName.TabIndex = 0;
            this.txtPhyFName.TextChanged += new System.EventHandler(this.txtPhyFName_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(273, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Phone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(246, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(262, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Mid Int.";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(243, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "First Name";
            // 
            // tabNewClient
            // 
            this.tabNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabNewClient.Controls.Add(this.cmboClientGender);
            this.tabNewClient.Controls.Add(this.txtClientAdd2);
            this.tabNewClient.Controls.Add(this.txtClientMidInt);
            this.tabNewClient.Controls.Add(this.btnClientSave);
            this.tabNewClient.Controls.Add(this.btnClientClear);
            this.tabNewClient.Controls.Add(this.txtClientDOB);
            this.tabNewClient.Controls.Add(this.txtClientEmail);
            this.tabNewClient.Controls.Add(this.txtClientPhone);
            this.tabNewClient.Controls.Add(this.txtClientZip);
            this.tabNewClient.Controls.Add(this.txtClientState);
            this.tabNewClient.Controls.Add(this.txtClientCity);
            this.tabNewClient.Controls.Add(this.txtClientAddress);
            this.tabNewClient.Controls.Add(this.txtClientLName);
            this.tabNewClient.Controls.Add(this.txtClientFName);
            this.tabNewClient.Controls.Add(this.label35);
            this.tabNewClient.Controls.Add(this.label41);
            this.tabNewClient.Controls.Add(this.label40);
            this.tabNewClient.Controls.Add(this.label33);
            this.tabNewClient.Controls.Add(this.label22);
            this.tabNewClient.Controls.Add(this.label12);
            this.tabNewClient.Controls.Add(this.label11);
            this.tabNewClient.Controls.Add(this.label10);
            this.tabNewClient.Controls.Add(this.label9);
            this.tabNewClient.Controls.Add(this.label8);
            this.tabNewClient.Controls.Add(this.label7);
            this.tabNewClient.Controls.Add(this.label6);
            this.tabNewClient.Controls.Add(this.label5);
            this.tabNewClient.Controls.Add(this.label4);
            this.tabNewClient.Controls.Add(this.label3);
            this.tabNewClient.Controls.Add(this.label2);
            this.tabNewClient.Controls.Add(this.label1);
            this.tabNewClient.Location = new System.Drawing.Point(4, 25);
            this.tabNewClient.Name = "tabNewClient";
            this.tabNewClient.Padding = new System.Windows.Forms.Padding(2);
            this.tabNewClient.Size = new System.Drawing.Size(794, 441);
            this.tabNewClient.TabIndex = 0;
            this.tabNewClient.Text = "New Client";
            // 
            // cmboClientGender
            // 
            this.cmboClientGender.FormattingEnabled = true;
            this.cmboClientGender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cmboClientGender.Location = new System.Drawing.Point(349, 296);
            this.cmboClientGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmboClientGender.Name = "cmboClientGender";
            this.cmboClientGender.Size = new System.Drawing.Size(100, 21);
            this.cmboClientGender.TabIndex = 36;
            // 
            // txtClientAdd2
            // 
            this.txtClientAdd2.Location = new System.Drawing.Point(349, 139);
            this.txtClientAdd2.Name = "txtClientAdd2";
            this.txtClientAdd2.Size = new System.Drawing.Size(100, 20);
            this.txtClientAdd2.TabIndex = 4;
            // 
            // txtClientMidInt
            // 
            this.txtClientMidInt.Location = new System.Drawing.Point(349, 59);
            this.txtClientMidInt.Name = "txtClientMidInt";
            this.txtClientMidInt.Size = new System.Drawing.Size(100, 20);
            this.txtClientMidInt.TabIndex = 1;
            // 
            // btnClientSave
            // 
            this.btnClientSave.Location = new System.Drawing.Point(265, 368);
            this.btnClientSave.Name = "btnClientSave";
            this.btnClientSave.Size = new System.Drawing.Size(75, 23);
            this.btnClientSave.TabIndex = 14;
            this.btnClientSave.Text = "&Save";
            this.btnClientSave.UseVisualStyleBackColor = true;
            this.btnClientSave.Click += new System.EventHandler(this.btnClientSave_Click);
            // 
            // btnClientClear
            // 
            this.btnClientClear.Location = new System.Drawing.Point(448, 368);
            this.btnClientClear.Name = "btnClientClear";
            this.btnClientClear.Size = new System.Drawing.Size(75, 23);
            this.btnClientClear.TabIndex = 15;
            this.btnClientClear.Text = "&Clear";
            this.btnClientClear.UseVisualStyleBackColor = true;
            this.btnClientClear.Click += new System.EventHandler(this.btnClientClear_Click);
            // 
            // txtClientDOB
            // 
            this.txtClientDOB.Location = new System.Drawing.Point(349, 323);
            this.txtClientDOB.Name = "txtClientDOB";
            this.txtClientDOB.Size = new System.Drawing.Size(100, 20);
            this.txtClientDOB.TabIndex = 11;
            this.txtClientDOB.TextChanged += new System.EventHandler(this.txtClientDOB_TextChanged);
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(349, 271);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(100, 20);
            this.txtClientEmail.TabIndex = 9;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(349, 246);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(100, 20);
            this.txtClientPhone.TabIndex = 8;
            // 
            // txtClientZip
            // 
            this.txtClientZip.Location = new System.Drawing.Point(349, 220);
            this.txtClientZip.Name = "txtClientZip";
            this.txtClientZip.Size = new System.Drawing.Size(100, 20);
            this.txtClientZip.TabIndex = 7;
            // 
            // txtClientState
            // 
            this.txtClientState.Location = new System.Drawing.Point(349, 194);
            this.txtClientState.Name = "txtClientState";
            this.txtClientState.Size = new System.Drawing.Size(100, 20);
            this.txtClientState.TabIndex = 6;
            // 
            // txtClientCity
            // 
            this.txtClientCity.Location = new System.Drawing.Point(349, 165);
            this.txtClientCity.Name = "txtClientCity";
            this.txtClientCity.Size = new System.Drawing.Size(100, 20);
            this.txtClientCity.TabIndex = 5;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(349, 111);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(100, 20);
            this.txtClientAddress.TabIndex = 3;
            // 
            // txtClientLName
            // 
            this.txtClientLName.Location = new System.Drawing.Point(349, 84);
            this.txtClientLName.Name = "txtClientLName";
            this.txtClientLName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLName.TabIndex = 2;
            this.txtClientLName.TextChanged += new System.EventHandler(this.txtClientLName_TextChanged);
            // 
            // txtClientFName
            // 
            this.txtClientFName.Location = new System.Drawing.Point(349, 33);
            this.txtClientFName.Name = "txtClientFName";
            this.txtClientFName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFName.TabIndex = 0;
            this.txtClientFName.TextChanged += new System.EventHandler(this.txtClientFName_TextChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Red;
            this.label35.Location = new System.Drawing.Point(337, 323);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 16);
            this.label35.TabIndex = 35;
            this.label35.Text = "*";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(289, 142);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(51, 13);
            this.label41.TabIndex = 34;
            this.label41.Text = "Address2";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(298, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(42, 13);
            this.label40.TabIndex = 33;
            this.label40.Text = "Mid Int.";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(337, 296);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 16);
            this.label33.TabIndex = 31;
            this.label33.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(337, 79);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 16);
            this.label22.TabIndex = 29;
            this.label22.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(337, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(307, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "DOB ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(298, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(308, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(302, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(290, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(308, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(316, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(295, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(282, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(280, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name ";
            // 
            // tabEmployee
            // 
            this.tabEmployee.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabEmployee.Controls.Add(this.tabNewClient);
            this.tabEmployee.Controls.Add(this.tabNewPhysician);
            this.tabEmployee.Controls.Add(this.tabNewPrescription);
            this.tabEmployee.Controls.Add(this.tabNewRefill);
            this.tabEmployee.Controls.Add(this.tabSearch);
            this.tabEmployee.Location = new System.Drawing.Point(0, 0);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.SelectedIndex = 0;
            this.tabEmployee.Size = new System.Drawing.Size(802, 470);
            this.tabEmployee.TabIndex = 0;
            // 
            // erpEmployee
            // 
            this.erpEmployee.ContainerControl = this;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 420);
            this.Controls.Add(this.tabEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefill)).EndInit();
            this.cmuRefill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.cmuClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPre)).EndInit();
            this.cmuPrescription.ResumeLayout(false);
            this.tabNewRefill.ResumeLayout(false);
            this.tabNewRefill.PerformLayout();
            this.tabNewPrescription.ResumeLayout(false);
            this.tabNewPrescription.PerformLayout();
            this.tabNewPhysician.ResumeLayout(false);
            this.tabNewPhysician.PerformLayout();
            this.tabNewClient.ResumeLayout(false);
            this.tabNewClient.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpEmployee)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabNewRefill;
        private System.Windows.Forms.Button btnRefSave;
        private System.Windows.Forms.Button btnRefClear;
        private System.Windows.Forms.TextBox txtRefPrescriptionID;
        private System.Windows.Forms.TextBox txtRefDosage;
        private System.Windows.Forms.TextBox txtRefFrequency;
        private System.Windows.Forms.TextBox txtRefSupplyDays;
        private System.Windows.Forms.TextBox txtRefQuantitySupplied;
        private System.Windows.Forms.TextBox txtRefPrice;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabNewPrescription;
        private System.Windows.Forms.Button btnPreSave;
        private System.Windows.Forms.Button btnPreClear;
        private System.Windows.Forms.DateTimePicker dtpPreExpirationDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPreNumOfRefills;
        private System.Windows.Forms.TextBox txtPreMedicationID;
        private System.Windows.Forms.TextBox txtPrePhysicanID;
        private System.Windows.Forms.TextBox txtPreClientID;
        private System.Windows.Forms.TabPage tabNewPhysician;
        private System.Windows.Forms.Button btnPhySave;
        private System.Windows.Forms.Button btnPhyClear;
        private System.Windows.Forms.TextBox txtPhyEmail;
        private System.Windows.Forms.TextBox txtPhyPhone;
        private System.Windows.Forms.TextBox txtPhyLName;
        private System.Windows.Forms.TextBox txtPhyMidInt;
        private System.Windows.Forms.TextBox txtPhyFName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabNewClient;
        private System.Windows.Forms.Button btnClientSave;
        private System.Windows.Forms.Button btnClientClear;
        private System.Windows.Forms.TextBox txtClientDOB;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientZip;
        private System.Windows.Forms.TextBox txtClientState;
        private System.Windows.Forms.TextBox txtClientCity;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtClientLName;
        private System.Windows.Forms.TextBox txtClientFName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtClientMidInt;
        private System.Windows.Forms.TextBox txtClientAdd2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label txtRefPaymentType;
        private System.Windows.Forms.ComboBox cboRefPaymentType;
        private System.Windows.Forms.ContextMenuStrip cmuClient;
        private System.Windows.Forms.ContextMenuStrip cmuPrescription;
        private System.Windows.Forms.ContextMenuStrip cmuRefill;
        private System.Windows.Forms.ToolStripMenuItem cmuClientUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmuClientSearchPre;
        private System.Windows.Forms.ToolStripMenuItem cmuClientSearchRefill;
        private System.Windows.Forms.ToolStripMenuItem cmuPrescriptionUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmuRefillUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmuRefillDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn refillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPrescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitySupplied;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRefill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn street1;
        private System.Windows.Forms.DataGridViewTextBoxColumn street2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn refillCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        public System.Windows.Forms.DataGridView dgvClient;
        public System.Windows.Forms.DataGridView dgvPre;
        public System.Windows.Forms.DataGridView dgvRefill;
        private System.Windows.Forms.ErrorProvider erpEmployee;
        private System.Windows.Forms.ComboBox cmboClientGender;
        private System.Windows.Forms.ToolStripMenuItem cmuRefillBack;
        private System.Windows.Forms.ToolStripMenuItem cmuPrescriptionBack;
    }
}