
using System;

namespace Final_Project_Work_Space
{
    partial class Employee
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
            this.tbWhole = new System.Windows.Forms.TabControl();
            this.tbEmployee = new System.Windows.Forms.TabPage();
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.btnCliClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCliInsurance = new System.Windows.Forms.TextBox();
            this.txtEmployeeDOB = new System.Windows.Forms.TextBox();
            this.txtEmployeeGender = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeZip = new System.Windows.Forms.TextBox();
            this.txtEmployeeState = new System.Windows.Forms.TextBox();
            this.txtEmployeeCity = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeLname = new System.Windows.Forms.TextBox();
            this.txtEmployeeFname = new System.Windows.Forms.TextBox();
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
            this.tbNewPhysican = new System.Windows.Forms.TabPage();
            this.btnPhySave = new System.Windows.Forms.Button();
            this.btnPhyClear = new System.Windows.Forms.Button();
            this.txtPhyEmail = new System.Windows.Forms.TextBox();
            this.txtPhyPhone = new System.Windows.Forms.TextBox();
            this.txtPhyLname = new System.Windows.Forms.TextBox();
            this.txtPhyMidInt = new System.Windows.Forms.TextBox();
            this.txtPhyFname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNewPerscription = new System.Windows.Forms.TabPage();
            this.btnPerSave = new System.Windows.Forms.Button();
            this.btnPerClear = new System.Windows.Forms.Button();
            this.dtpPerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtptxtPerExperationDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPerNumOfRefills = new System.Windows.Forms.TextBox();
            this.txtPerMedicationID = new System.Windows.Forms.TextBox();
            this.txtPerPhysicanID = new System.Windows.Forms.TextBox();
            this.txtPerClientID = new System.Windows.Forms.TextBox();
            this.tbNewRefill = new System.Windows.Forms.TabPage();
            this.btnRefSave = new System.Windows.Forms.Button();
            this.btnRefCle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRefRefillID = new System.Windows.Forms.TextBox();
            this.txtRefPaymentType = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtRefPerscriptionID = new System.Windows.Forms.TextBox();
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
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSeaDelete = new System.Windows.Forms.Button();
            this.btnSeaUpdate = new System.Windows.Forms.Button();
            this.tbWhole.SuspendLayout();
            this.tbEmployee.SuspendLayout();
            this.tbNewPhysican.SuspendLayout();
            this.tbNewPerscription.SuspendLayout();
            this.tbNewRefill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWhole
            // 
            this.tbWhole.Controls.Add(this.tbEmployee);
            this.tbWhole.Controls.Add(this.tbNewPhysican);
            this.tbWhole.Controls.Add(this.tbNewPerscription);
            this.tbWhole.Controls.Add(this.tbNewRefill);
            this.tbWhole.Controls.Add(this.tbSearch);
            this.tbWhole.Location = new System.Drawing.Point(0, 0);
            this.tbWhole.Margin = new System.Windows.Forms.Padding(6);
            this.tbWhole.Name = "tbWhole";
            this.tbWhole.SelectedIndex = 0;
            this.tbWhole.Size = new System.Drawing.Size(1576, 810);
            this.tbWhole.TabIndex = 0;
            // 
            // tbEmployee
            // 
            this.tbEmployee.Controls.Add(this.btnEmployeeSave);
            this.tbEmployee.Controls.Add(this.btnCliClear);
            this.tbEmployee.Controls.Add(this.label13);
            this.tbEmployee.Controls.Add(this.txtCliInsurance);
            this.tbEmployee.Controls.Add(this.txtEmployeeDOB);
            this.tbEmployee.Controls.Add(this.txtEmployeeGender);
            this.tbEmployee.Controls.Add(this.txtEmployeeEmail);
            this.tbEmployee.Controls.Add(this.txtEmployeePhone);
            this.tbEmployee.Controls.Add(this.txtEmployeeZip);
            this.tbEmployee.Controls.Add(this.txtEmployeeState);
            this.tbEmployee.Controls.Add(this.txtEmployeeCity);
            this.tbEmployee.Controls.Add(this.txtEmployeeAddress);
            this.tbEmployee.Controls.Add(this.txtEmployeeLname);
            this.tbEmployee.Controls.Add(this.txtEmployeeFname);
            this.tbEmployee.Controls.Add(this.label11);
            this.tbEmployee.Controls.Add(this.label10);
            this.tbEmployee.Controls.Add(this.label9);
            this.tbEmployee.Controls.Add(this.label8);
            this.tbEmployee.Controls.Add(this.label7);
            this.tbEmployee.Controls.Add(this.label6);
            this.tbEmployee.Controls.Add(this.label5);
            this.tbEmployee.Controls.Add(this.label4);
            this.tbEmployee.Controls.Add(this.label3);
            this.tbEmployee.Controls.Add(this.label2);
            this.tbEmployee.Controls.Add(this.label1);
            this.tbEmployee.Location = new System.Drawing.Point(8, 39);
            this.tbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Padding = new System.Windows.Forms.Padding(6);
            this.tbEmployee.Size = new System.Drawing.Size(1560, 763);
            this.tbEmployee.TabIndex = 0;
            this.tbEmployee.UseVisualStyleBackColor = true;
            this.tbEmployee.Click += new System.EventHandler(this.tbNewClient_Click);
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.Location = new System.Drawing.Point(504, 663);
            this.btnEmployeeSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(150, 44);
            this.btnEmployeeSave.TabIndex = 27;
            this.btnEmployeeSave.Text = "&Save";
            this.btnEmployeeSave.UseVisualStyleBackColor = true;
            // 
            // btnCliClear
            // 
            this.btnCliClear.Location = new System.Drawing.Point(892, 663);
            this.btnCliClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnCliClear.Name = "btnCliClear";
            this.btnCliClear.Size = new System.Drawing.Size(150, 44);
            this.btnCliClear.TabIndex = 26;
            this.btnCliClear.Text = "&Clear";
            this.btnCliClear.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 571);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Insurance";
            // 
            // txtCliInsurance
            // 
            this.txtCliInsurance.Location = new System.Drawing.Point(704, 571);
            this.txtCliInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.txtCliInsurance.Name = "txtCliInsurance";
            this.txtCliInsurance.Size = new System.Drawing.Size(196, 31);
            this.txtCliInsurance.TabIndex = 24;
            // 
            // txtEmployeeDOB
            // 
            this.txtEmployeeDOB.Location = new System.Drawing.Point(704, 513);
            this.txtEmployeeDOB.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeDOB.Name = "txtEmployeeDOB";
            this.txtEmployeeDOB.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeDOB.TabIndex = 22;
            this.txtEmployeeDOB.TextChanged += new System.EventHandler(this.txtEmployeeDOB_TextChanged);
            // 
            // txtEmployeeGender
            // 
            this.txtEmployeeGender.Location = new System.Drawing.Point(704, 463);
            this.txtEmployeeGender.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeGender.Name = "txtEmployeeGender";
            this.txtEmployeeGender.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeGender.TabIndex = 21;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(704, 413);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeEmail.TabIndex = 20;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(704, 363);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeePhone.TabIndex = 19;
            // 
            // txtEmployeeZip
            // 
            this.txtEmployeeZip.Location = new System.Drawing.Point(704, 313);
            this.txtEmployeeZip.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeZip.Name = "txtEmployeeZip";
            this.txtEmployeeZip.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeZip.TabIndex = 17;
            // 
            // txtEmployeeState
            // 
            this.txtEmployeeState.Location = new System.Drawing.Point(704, 263);
            this.txtEmployeeState.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeState.Name = "txtEmployeeState";
            this.txtEmployeeState.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeState.TabIndex = 16;
            // 
            // txtEmployeeCity
            // 
            this.txtEmployeeCity.Location = new System.Drawing.Point(704, 208);
            this.txtEmployeeCity.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeCity.Name = "txtEmployeeCity";
            this.txtEmployeeCity.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeCity.TabIndex = 15;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(704, 158);
            this.txtEmployeeAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeAddress.TabIndex = 14;
            this.txtEmployeeAddress.TextChanged += new System.EventHandler(this.txtEmployeeAddress_TextChanged);
            // 
            // txtEmployeeLname
            // 
            this.txtEmployeeLname.Location = new System.Drawing.Point(704, 108);
            this.txtEmployeeLname.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeLname.Name = "txtEmployeeLname";
            this.txtEmployeeLname.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeLname.TabIndex = 13;
            this.txtEmployeeLname.TextChanged += new System.EventHandler(this.txtEmployeeLname_TextChanged);
            // 
            // txtEmployeeFname
            // 
            this.txtEmployeeFname.Location = new System.Drawing.Point(704, 63);
            this.txtEmployeeFname.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeFname.Name = "txtEmployeeFname";
            this.txtEmployeeFname.Size = new System.Drawing.Size(196, 31);
            this.txtEmployeeFname.TabIndex = 12;
            this.txtEmployeeFname.TextChanged += new System.EventHandler(this.txtEmployeeFname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 527);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "DOB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 477);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gender";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 427);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 419);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNewPhysican
            // 
            this.tbNewPhysican.Controls.Add(this.btnPhySave);
            this.tbNewPhysican.Controls.Add(this.btnPhyClear);
            this.tbNewPhysican.Controls.Add(this.txtPhyEmail);
            this.tbNewPhysican.Controls.Add(this.txtPhyPhone);
            this.tbNewPhysican.Controls.Add(this.txtPhyLname);
            this.tbNewPhysican.Controls.Add(this.txtPhyMidInt);
            this.tbNewPhysican.Controls.Add(this.txtPhyFname);
            this.tbNewPhysican.Controls.Add(this.label18);
            this.tbNewPhysican.Controls.Add(this.label17);
            this.tbNewPhysican.Controls.Add(this.label16);
            this.tbNewPhysican.Controls.Add(this.label15);
            this.tbNewPhysican.Controls.Add(this.label14);
            this.tbNewPhysican.Location = new System.Drawing.Point(8, 39);
            this.tbNewPhysican.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewPhysican.Name = "tbNewPhysican";
            this.tbNewPhysican.Padding = new System.Windows.Forms.Padding(6);
            this.tbNewPhysican.Size = new System.Drawing.Size(1560, 763);
            this.tbNewPhysican.TabIndex = 1;
            this.tbNewPhysican.Text = "New Physican";
            this.tbNewPhysican.UseVisualStyleBackColor = true;
            // 
            // btnPhySave
            // 
            this.btnPhySave.Location = new System.Drawing.Point(446, 413);
            this.btnPhySave.Margin = new System.Windows.Forms.Padding(6);
            this.btnPhySave.Name = "btnPhySave";
            this.btnPhySave.Size = new System.Drawing.Size(150, 44);
            this.btnPhySave.TabIndex = 29;
            this.btnPhySave.Text = "&Save";
            this.btnPhySave.UseVisualStyleBackColor = true;
            // 
            // btnPhyClear
            // 
            this.btnPhyClear.Location = new System.Drawing.Point(834, 413);
            this.btnPhyClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnPhyClear.Name = "btnPhyClear";
            this.btnPhyClear.Size = new System.Drawing.Size(150, 44);
            this.btnPhyClear.TabIndex = 28;
            this.btnPhyClear.Text = "&Clear";
            this.btnPhyClear.UseVisualStyleBackColor = true;
            // 
            // txtPhyEmail
            // 
            this.txtPhyEmail.Location = new System.Drawing.Point(626, 323);
            this.txtPhyEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhyEmail.Name = "txtPhyEmail";
            this.txtPhyEmail.Size = new System.Drawing.Size(196, 31);
            this.txtPhyEmail.TabIndex = 9;
            // 
            // txtPhyPhone
            // 
            this.txtPhyPhone.Location = new System.Drawing.Point(626, 273);
            this.txtPhyPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhyPhone.Name = "txtPhyPhone";
            this.txtPhyPhone.Size = new System.Drawing.Size(196, 31);
            this.txtPhyPhone.TabIndex = 8;
            // 
            // txtPhyLname
            // 
            this.txtPhyLname.Location = new System.Drawing.Point(626, 223);
            this.txtPhyLname.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhyLname.Name = "txtPhyLname";
            this.txtPhyLname.Size = new System.Drawing.Size(196, 31);
            this.txtPhyLname.TabIndex = 7;
            // 
            // txtPhyMidInt
            // 
            this.txtPhyMidInt.Location = new System.Drawing.Point(626, 173);
            this.txtPhyMidInt.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhyMidInt.Name = "txtPhyMidInt";
            this.txtPhyMidInt.Size = new System.Drawing.Size(196, 31);
            this.txtPhyMidInt.TabIndex = 6;
            // 
            // txtPhyFname
            // 
            this.txtPhyFname.Location = new System.Drawing.Point(626, 123);
            this.txtPhyFname.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhyFname.Name = "txtPhyFname";
            this.txtPhyFname.Size = new System.Drawing.Size(196, 31);
            this.txtPhyFname.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(552, 329);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 25);
            this.label18.TabIndex = 4;
            this.label18.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(540, 273);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Phone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(500, 223);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(538, 179);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Mid Int";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(502, 123);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "First Name";
            // 
            // tbNewPerscription
            // 
            this.tbNewPerscription.Controls.Add(this.btnPerSave);
            this.tbNewPerscription.Controls.Add(this.btnPerClear);
            this.tbNewPerscription.Controls.Add(this.dtpPerStartDate);
            this.tbNewPerscription.Controls.Add(this.dtptxtPerExperationDate);
            this.tbNewPerscription.Controls.Add(this.label24);
            this.tbNewPerscription.Controls.Add(this.label23);
            this.tbNewPerscription.Controls.Add(this.label22);
            this.tbNewPerscription.Controls.Add(this.label21);
            this.tbNewPerscription.Controls.Add(this.label20);
            this.tbNewPerscription.Controls.Add(this.label19);
            this.tbNewPerscription.Controls.Add(this.txtPerNumOfRefills);
            this.tbNewPerscription.Controls.Add(this.txtPerMedicationID);
            this.tbNewPerscription.Controls.Add(this.txtPerPhysicanID);
            this.tbNewPerscription.Controls.Add(this.txtPerClientID);
            this.tbNewPerscription.Location = new System.Drawing.Point(8, 39);
            this.tbNewPerscription.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewPerscription.Name = "tbNewPerscription";
            this.tbNewPerscription.Padding = new System.Windows.Forms.Padding(6);
            this.tbNewPerscription.Size = new System.Drawing.Size(1560, 763);
            this.tbNewPerscription.TabIndex = 2;
            this.tbNewPerscription.Text = "New Perscription";
            this.tbNewPerscription.UseVisualStyleBackColor = true;
            // 
            // btnPerSave
            // 
            this.btnPerSave.Location = new System.Drawing.Point(546, 479);
            this.btnPerSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnPerSave.Name = "btnPerSave";
            this.btnPerSave.Size = new System.Drawing.Size(150, 44);
            this.btnPerSave.TabIndex = 29;
            this.btnPerSave.Text = "&Save";
            this.btnPerSave.UseVisualStyleBackColor = true;
            // 
            // btnPerClear
            // 
            this.btnPerClear.Location = new System.Drawing.Point(934, 479);
            this.btnPerClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnPerClear.Name = "btnPerClear";
            this.btnPerClear.Size = new System.Drawing.Size(150, 44);
            this.btnPerClear.TabIndex = 28;
            this.btnPerClear.Text = "&Clear";
            this.btnPerClear.UseVisualStyleBackColor = true;
            // 
            // dtpPerStartDate
            // 
            this.dtpPerStartDate.Location = new System.Drawing.Point(726, 287);
            this.dtpPerStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpPerStartDate.Name = "dtpPerStartDate";
            this.dtpPerStartDate.Size = new System.Drawing.Size(396, 31);
            this.dtpPerStartDate.TabIndex = 13;
            // 
            // dtptxtPerExperationDate
            // 
            this.dtptxtPerExperationDate.Location = new System.Drawing.Point(726, 337);
            this.dtptxtPerExperationDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtptxtPerExperationDate.Name = "dtptxtPerExperationDate";
            this.dtptxtPerExperationDate.Size = new System.Drawing.Size(396, 31);
            this.dtptxtPerExperationDate.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(540, 390);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(176, 25);
            this.label24.TabIndex = 11;
            this.label24.Text = "Number of Refills";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(548, 340);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(166, 25);
            this.label23.TabIndex = 10;
            this.label23.Text = "Experation Date";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(604, 298);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 25);
            this.label22.TabIndex = 9;
            this.label22.Text = "Start Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(568, 240);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "Medication ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(586, 190);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "Physican ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(620, 138);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 25);
            this.label19.TabIndex = 6;
            this.label19.Text = "Client ID";
            // 
            // txtPerNumOfRefills
            // 
            this.txtPerNumOfRefills.Location = new System.Drawing.Point(726, 385);
            this.txtPerNumOfRefills.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerNumOfRefills.Name = "txtPerNumOfRefills";
            this.txtPerNumOfRefills.Size = new System.Drawing.Size(196, 31);
            this.txtPerNumOfRefills.TabIndex = 5;
            // 
            // txtPerMedicationID
            // 
            this.txtPerMedicationID.Location = new System.Drawing.Point(726, 235);
            this.txtPerMedicationID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerMedicationID.Name = "txtPerMedicationID";
            this.txtPerMedicationID.Size = new System.Drawing.Size(196, 31);
            this.txtPerMedicationID.TabIndex = 2;
            // 
            // txtPerPhysicanID
            // 
            this.txtPerPhysicanID.Location = new System.Drawing.Point(726, 185);
            this.txtPerPhysicanID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerPhysicanID.Name = "txtPerPhysicanID";
            this.txtPerPhysicanID.Size = new System.Drawing.Size(196, 31);
            this.txtPerPhysicanID.TabIndex = 1;
            // 
            // txtPerClientID
            // 
            this.txtPerClientID.Location = new System.Drawing.Point(726, 133);
            this.txtPerClientID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerClientID.Name = "txtPerClientID";
            this.txtPerClientID.Size = new System.Drawing.Size(196, 31);
            this.txtPerClientID.TabIndex = 0;
            // 
            // tbNewRefill
            // 
            this.tbNewRefill.Controls.Add(this.btnRefSave);
            this.tbNewRefill.Controls.Add(this.btnRefCle);
            this.tbNewRefill.Controls.Add(this.groupBox1);
            this.tbNewRefill.Controls.Add(this.txtRefPerscriptionID);
            this.tbNewRefill.Controls.Add(this.txtRefDosage);
            this.tbNewRefill.Controls.Add(this.txtRefFrequency);
            this.tbNewRefill.Controls.Add(this.txtRefSupplyDays);
            this.tbNewRefill.Controls.Add(this.txtRefQuantitySupplied);
            this.tbNewRefill.Controls.Add(this.txtRefPrice);
            this.tbNewRefill.Controls.Add(this.label32);
            this.tbNewRefill.Controls.Add(this.label31);
            this.tbNewRefill.Controls.Add(this.label30);
            this.tbNewRefill.Controls.Add(this.label29);
            this.tbNewRefill.Controls.Add(this.label28);
            this.tbNewRefill.Controls.Add(this.label27);
            this.tbNewRefill.Location = new System.Drawing.Point(8, 39);
            this.tbNewRefill.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewRefill.Name = "tbNewRefill";
            this.tbNewRefill.Padding = new System.Windows.Forms.Padding(6);
            this.tbNewRefill.Size = new System.Drawing.Size(1560, 763);
            this.tbNewRefill.TabIndex = 3;
            this.tbNewRefill.Text = "New Refill";
            this.tbNewRefill.UseVisualStyleBackColor = true;
            this.tbNewRefill.Click += new System.EventHandler(this.tbNewRefill_Click);
            // 
            // btnRefSave
            // 
            this.btnRefSave.Location = new System.Drawing.Point(428, 633);
            this.btnRefSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefSave.Name = "btnRefSave";
            this.btnRefSave.Size = new System.Drawing.Size(150, 44);
            this.btnRefSave.TabIndex = 29;
            this.btnRefSave.Text = "&Save";
            this.btnRefSave.UseVisualStyleBackColor = true;
            // 
            // btnRefCle
            // 
            this.btnRefCle.Location = new System.Drawing.Point(816, 633);
            this.btnRefCle.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefCle.Name = "btnRefCle";
            this.btnRefCle.Size = new System.Drawing.Size(150, 44);
            this.btnRefCle.TabIndex = 28;
            this.btnRefCle.Text = "&Clear";
            this.btnRefCle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRefRefillID);
            this.groupBox1.Controls.Add(this.txtRefPaymentType);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Location = new System.Drawing.Point(362, 362);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(698, 240);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // txtRefRefillID
            // 
            this.txtRefRefillID.Location = new System.Drawing.Point(260, 37);
            this.txtRefRefillID.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefRefillID.Name = "txtRefRefillID";
            this.txtRefRefillID.Size = new System.Drawing.Size(196, 31);
            this.txtRefRefillID.TabIndex = 14;
            // 
            // txtRefPaymentType
            // 
            this.txtRefPaymentType.FormattingEnabled = true;
            this.txtRefPaymentType.Location = new System.Drawing.Point(260, 96);
            this.txtRefPaymentType.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefPaymentType.Name = "txtRefPaymentType";
            this.txtRefPaymentType.Size = new System.Drawing.Size(238, 33);
            this.txtRefPaymentType.TabIndex = 23;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(148, 42);
            this.label34.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(86, 25);
            this.label34.TabIndex = 9;
            this.label34.Text = "Refill ID";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(86, 102);
            this.label35.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(150, 25);
            this.label35.TabIndex = 10;
            this.label35.Text = "Payment Type";
            // 
            // txtRefPerscriptionID
            // 
            this.txtRefPerscriptionID.Location = new System.Drawing.Point(616, 63);
            this.txtRefPerscriptionID.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefPerscriptionID.Name = "txtRefPerscriptionID";
            this.txtRefPerscriptionID.Size = new System.Drawing.Size(196, 31);
            this.txtRefPerscriptionID.TabIndex = 21;
            // 
            // txtRefDosage
            // 
            this.txtRefDosage.Location = new System.Drawing.Point(616, 112);
            this.txtRefDosage.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefDosage.Name = "txtRefDosage";
            this.txtRefDosage.Size = new System.Drawing.Size(196, 31);
            this.txtRefDosage.TabIndex = 20;
            // 
            // txtRefFrequency
            // 
            this.txtRefFrequency.Location = new System.Drawing.Point(616, 162);
            this.txtRefFrequency.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefFrequency.Name = "txtRefFrequency";
            this.txtRefFrequency.Size = new System.Drawing.Size(196, 31);
            this.txtRefFrequency.TabIndex = 19;
            this.txtRefFrequency.TextChanged += new System.EventHandler(this.txtRefFrequency_TextChanged);
            // 
            // txtRefSupplyDays
            // 
            this.txtRefSupplyDays.Location = new System.Drawing.Point(616, 212);
            this.txtRefSupplyDays.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefSupplyDays.Name = "txtRefSupplyDays";
            this.txtRefSupplyDays.Size = new System.Drawing.Size(196, 31);
            this.txtRefSupplyDays.TabIndex = 18;
            // 
            // txtRefQuantitySupplied
            // 
            this.txtRefQuantitySupplied.Location = new System.Drawing.Point(616, 262);
            this.txtRefQuantitySupplied.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefQuantitySupplied.Name = "txtRefQuantitySupplied";
            this.txtRefQuantitySupplied.Size = new System.Drawing.Size(196, 31);
            this.txtRefQuantitySupplied.TabIndex = 17;
            // 
            // txtRefPrice
            // 
            this.txtRefPrice.Location = new System.Drawing.Point(616, 312);
            this.txtRefPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtRefPrice.Name = "txtRefPrice";
            this.txtRefPrice.Size = new System.Drawing.Size(196, 31);
            this.txtRefPrice.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(542, 317);
            this.label32.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 25);
            this.label32.TabIndex = 7;
            this.label32.Text = "Price";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(424, 269);
            this.label31.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(182, 25);
            this.label31.TabIndex = 6;
            this.label31.Text = "Qauntity Supplied";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(450, 219);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(156, 25);
            this.label30.TabIndex = 5;
            this.label30.Text = "Supply in Days";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(490, 167);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 25);
            this.label29.TabIndex = 4;
            this.label29.Text = "Frequency";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(516, 121);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 25);
            this.label28.TabIndex = 3;
            this.label28.Text = "Dosage";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(452, 69);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(152, 25);
            this.label27.TabIndex = 2;
            this.label27.Text = "Perscription ID";
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.txtSearch);
            this.tbSearch.Controls.Add(this.label25);
            this.tbSearch.Controls.Add(this.btnSeaDelete);
            this.tbSearch.Controls.Add(this.btnSeaUpdate);
            this.tbSearch.Location = new System.Drawing.Point(8, 39);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(6);
            this.tbSearch.Size = new System.Drawing.Size(1560, 763);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Search";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(684, 179);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 31);
            this.txtSearch.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(574, 185);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 25);
            this.label25.TabIndex = 3;
            this.label25.Text = "Select:";
            // 
            // btnSeaDelete
            // 
            this.btnSeaDelete.Location = new System.Drawing.Point(890, 300);
            this.btnSeaDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeaDelete.Name = "btnSeaDelete";
            this.btnSeaDelete.Size = new System.Drawing.Size(150, 44);
            this.btnSeaDelete.TabIndex = 1;
            this.btnSeaDelete.Text = "Delete";
            this.btnSeaDelete.UseVisualStyleBackColor = true;
            // 
            // btnSeaUpdate
            // 
            this.btnSeaUpdate.Location = new System.Drawing.Point(534, 300);
            this.btnSeaUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeaUpdate.Name = "btnSeaUpdate";
            this.btnSeaUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnSeaUpdate.TabIndex = 0;
            this.btnSeaUpdate.Text = "Update";
            this.btnSeaUpdate.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tbWhole);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tbWhole.ResumeLayout(false);
            this.tbEmployee.ResumeLayout(false);
            this.tbEmployee.PerformLayout();
            this.tbNewPhysican.ResumeLayout(false);
            this.tbNewPhysican.PerformLayout();
            this.tbNewPerscription.ResumeLayout(false);
            this.tbNewPerscription.PerformLayout();
            this.tbNewRefill.ResumeLayout(false);
            this.tbNewRefill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbSearch.ResumeLayout(false);
            this.tbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

      
     

        #endregion

        private System.Windows.Forms.TabControl tbWhole;
        private System.Windows.Forms.TabPage tbEmployee;
        private System.Windows.Forms.TabPage tbNewPhysican;
        private System.Windows.Forms.TabPage tbNewPerscription;
        private System.Windows.Forms.TabPage tbNewRefill;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.TextBox txtCliInsurance;
        private System.Windows.Forms.TextBox txtEmployeeDOB;
        private System.Windows.Forms.TextBox txtEmployeeGender;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeZip;
        private System.Windows.Forms.TextBox txtEmployeeState;
        private System.Windows.Forms.TextBox txtEmployeeCity;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeLname;
        private System.Windows.Forms.TextBox txtEmployeeFname;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhyEmail;
        private System.Windows.Forms.TextBox txtPhyPhone;
        private System.Windows.Forms.TextBox txtPhyLname;
        private System.Windows.Forms.TextBox txtPhyMidInt;
        private System.Windows.Forms.TextBox txtPhyFname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPerNumOfRefills;
        private System.Windows.Forms.TextBox txtPerMedicationID;
        private System.Windows.Forms.TextBox txtPerPhysicanID;
        private System.Windows.Forms.TextBox txtPerClientID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRefRefillID;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox txtRefPaymentType;
        private System.Windows.Forms.TextBox txtRefPerscriptionID;
        private System.Windows.Forms.TextBox txtRefDosage;
        private System.Windows.Forms.TextBox txtRefFrequency;
        private System.Windows.Forms.TextBox txtRefSupplyDays;
        private System.Windows.Forms.TextBox txtRefQuantitySupplied;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSeaDelete;
        private System.Windows.Forms.Button btnSeaUpdate;
        private System.Windows.Forms.DateTimePicker dtpPerStartDate;
        private System.Windows.Forms.DateTimePicker dtptxtPerExperationDate;
        private System.Windows.Forms.TextBox txtRefPrice;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEmployeeSave;
        private System.Windows.Forms.Button btnCliClear;
        private System.Windows.Forms.Button btnPhySave;
        private System.Windows.Forms.Button btnPhyClear;
        private System.Windows.Forms.Button btnPerSave;
        private System.Windows.Forms.Button btnPerClear;
        private System.Windows.Forms.Button btnRefSave;
        private System.Windows.Forms.Button btnRefCle;
    }
}