namespace CarWorkshop
{
    partial class CarWorkshopApp
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.deleteUser_button = new System.Windows.Forms.Button();
            this.allUsers_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createUsr_button = new System.Windows.Forms.Button();
            this.usrCountry_textBox = new System.Windows.Forms.TextBox();
            this.usrCountry_label = new System.Windows.Forms.Label();
            this.usrPostal_textBox = new System.Windows.Forms.TextBox();
            this.usrPostal_label = new System.Windows.Forms.Label();
            this.usrCity_textBox = new System.Windows.Forms.TextBox();
            this.usrCity_label = new System.Windows.Forms.Label();
            this.usrEmail_textBox = new System.Windows.Forms.TextBox();
            this.usrName_textBox = new System.Windows.Forms.TextBox();
            this.usrEmaol_label = new System.Windows.Forms.Label();
            this.usrName_label = new System.Windows.Forms.Label();
            this.workshopsTab = new System.Windows.Forms.TabPage();
            this.deleteWshop_button = new System.Windows.Forms.Button();
            this.createWorksop_button = new System.Windows.Forms.Button();
            this.wshopCountry_label = new System.Windows.Forms.Label();
            this.wshopPostal_label = new System.Windows.Forms.Label();
            this.wshopTrademark_label = new System.Windows.Forms.Label();
            this.wshopCity_label = new System.Windows.Forms.Label();
            this.wshopCountry_textBox = new System.Windows.Forms.TextBox();
            this.wshopPostal_textBox = new System.Windows.Forms.TextBox();
            this.wshopCity_textBox = new System.Windows.Forms.TextBox();
            this.wshopTrademark_textBox = new System.Windows.Forms.TextBox();
            this.wshopName_textBox = new System.Windows.Forms.TextBox();
            this.wshopName_label = new System.Windows.Forms.Label();
            this.appoitmentTab = new System.Windows.Forms.TabPage();
            this.createApp_button = new System.Windows.Forms.Button();
            this.appCompany_comboBox = new System.Windows.Forms.ComboBox();
            this.appCar_comboBox = new System.Windows.Forms.ComboBox();
            this.appUsr_comboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDate = new System.Windows.Forms.DateTimePicker();
            this.appDate_label = new System.Windows.Forms.Label();
            this.appCompany_label = new System.Windows.Forms.Label();
            this.appCar_label = new System.Windows.Forms.Label();
            this.appUser_label = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.usersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.workshopsTab.SuspendLayout();
            this.appoitmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.usersTab);
            this.tabControl.Controls.Add(this.workshopsTab);
            this.tabControl.Controls.Add(this.appoitmentTab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(976, 479);
            this.tabControl.TabIndex = 0;
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.deleteUser_button);
            this.usersTab.Controls.Add(this.allUsers_label);
            this.usersTab.Controls.Add(this.dataGridView1);
            this.usersTab.Controls.Add(this.createUsr_button);
            this.usersTab.Controls.Add(this.usrCountry_textBox);
            this.usersTab.Controls.Add(this.usrCountry_label);
            this.usersTab.Controls.Add(this.usrPostal_textBox);
            this.usersTab.Controls.Add(this.usrPostal_label);
            this.usersTab.Controls.Add(this.usrCity_textBox);
            this.usersTab.Controls.Add(this.usrCity_label);
            this.usersTab.Controls.Add(this.usrEmail_textBox);
            this.usersTab.Controls.Add(this.usrName_textBox);
            this.usersTab.Controls.Add(this.usrEmaol_label);
            this.usersTab.Controls.Add(this.usrName_label);
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(968, 453);
            this.usersTab.TabIndex = 0;
            this.usersTab.Text = "Users";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // deleteUser_button
            // 
            this.deleteUser_button.Location = new System.Drawing.Point(152, 181);
            this.deleteUser_button.Name = "deleteUser_button";
            this.deleteUser_button.Size = new System.Drawing.Size(100, 23);
            this.deleteUser_button.TabIndex = 12;
            this.deleteUser_button.Text = "Delete User";
            this.deleteUser_button.UseVisualStyleBackColor = true;
            this.deleteUser_button.Click += new System.EventHandler(this.deleteUser_button_Click);
            // 
            // allUsers_label
            // 
            this.allUsers_label.AutoSize = true;
            this.allUsers_label.Location = new System.Drawing.Point(354, 34);
            this.allUsers_label.Name = "allUsers_label";
            this.allUsers_label.Size = new System.Drawing.Size(49, 13);
            this.allUsers_label.TabIndex = 11;
            this.allUsers_label.Text = "All users:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 384);
            this.dataGridView1.TabIndex = 10;
            // 
            // createUsr_button
            // 
            this.createUsr_button.Location = new System.Drawing.Point(25, 181);
            this.createUsr_button.Name = "createUsr_button";
            this.createUsr_button.Size = new System.Drawing.Size(100, 23);
            this.createUsr_button.TabIndex = 9;
            this.createUsr_button.Text = "Create User";
            this.createUsr_button.UseVisualStyleBackColor = true;
            this.createUsr_button.Click += new System.EventHandler(this.createUsr_button_Click);
            // 
            // usrCountry_textBox
            // 
            this.usrCountry_textBox.Location = new System.Drawing.Point(141, 138);
            this.usrCountry_textBox.Name = "usrCountry_textBox";
            this.usrCountry_textBox.Size = new System.Drawing.Size(100, 20);
            this.usrCountry_textBox.TabIndex = 8;
            // 
            // usrCountry_label
            // 
            this.usrCountry_label.AutoSize = true;
            this.usrCountry_label.Location = new System.Drawing.Point(22, 141);
            this.usrCountry_label.Name = "usrCountry_label";
            this.usrCountry_label.Size = new System.Drawing.Size(46, 13);
            this.usrCountry_label.TabIndex = 7;
            this.usrCountry_label.Text = "Country:";
            // 
            // usrPostal_textBox
            // 
            this.usrPostal_textBox.Location = new System.Drawing.Point(141, 112);
            this.usrPostal_textBox.Name = "usrPostal_textBox";
            this.usrPostal_textBox.Size = new System.Drawing.Size(100, 20);
            this.usrPostal_textBox.TabIndex = 6;
            // 
            // usrPostal_label
            // 
            this.usrPostal_label.AutoSize = true;
            this.usrPostal_label.Location = new System.Drawing.Point(22, 115);
            this.usrPostal_label.Name = "usrPostal_label";
            this.usrPostal_label.Size = new System.Drawing.Size(66, 13);
            this.usrPostal_label.TabIndex = 5;
            this.usrPostal_label.Text = "Postal code:";
            // 
            // usrCity_textBox
            // 
            this.usrCity_textBox.Location = new System.Drawing.Point(141, 86);
            this.usrCity_textBox.Name = "usrCity_textBox";
            this.usrCity_textBox.Size = new System.Drawing.Size(100, 20);
            this.usrCity_textBox.TabIndex = 4;
            // 
            // usrCity_label
            // 
            this.usrCity_label.AutoSize = true;
            this.usrCity_label.Location = new System.Drawing.Point(22, 89);
            this.usrCity_label.Name = "usrCity_label";
            this.usrCity_label.Size = new System.Drawing.Size(27, 13);
            this.usrCity_label.TabIndex = 3;
            this.usrCity_label.Text = "City:";
            // 
            // usrEmail_textBox
            // 
            this.usrEmail_textBox.Location = new System.Drawing.Point(141, 60);
            this.usrEmail_textBox.Name = "usrEmail_textBox";
            this.usrEmail_textBox.Size = new System.Drawing.Size(100, 20);
            this.usrEmail_textBox.TabIndex = 2;
            // 
            // usrName_textBox
            // 
            this.usrName_textBox.Location = new System.Drawing.Point(141, 34);
            this.usrName_textBox.Name = "usrName_textBox";
            this.usrName_textBox.Size = new System.Drawing.Size(100, 20);
            this.usrName_textBox.TabIndex = 1;
            // 
            // usrEmaol_label
            // 
            this.usrEmaol_label.AutoSize = true;
            this.usrEmaol_label.Location = new System.Drawing.Point(22, 63);
            this.usrEmaol_label.Name = "usrEmaol_label";
            this.usrEmaol_label.Size = new System.Drawing.Size(35, 13);
            this.usrEmaol_label.TabIndex = 0;
            this.usrEmaol_label.Text = "Email:";
            // 
            // usrName_label
            // 
            this.usrName_label.AutoSize = true;
            this.usrName_label.Location = new System.Drawing.Point(22, 37);
            this.usrName_label.Name = "usrName_label";
            this.usrName_label.Size = new System.Drawing.Size(38, 13);
            this.usrName_label.TabIndex = 0;
            this.usrName_label.Text = "Name:";
            // 
            // workshopsTab
            // 
            this.workshopsTab.Controls.Add(this.deleteWshop_button);
            this.workshopsTab.Controls.Add(this.createWorksop_button);
            this.workshopsTab.Controls.Add(this.wshopCountry_label);
            this.workshopsTab.Controls.Add(this.wshopPostal_label);
            this.workshopsTab.Controls.Add(this.wshopTrademark_label);
            this.workshopsTab.Controls.Add(this.wshopCity_label);
            this.workshopsTab.Controls.Add(this.wshopCountry_textBox);
            this.workshopsTab.Controls.Add(this.wshopPostal_textBox);
            this.workshopsTab.Controls.Add(this.wshopCity_textBox);
            this.workshopsTab.Controls.Add(this.wshopTrademark_textBox);
            this.workshopsTab.Controls.Add(this.wshopName_textBox);
            this.workshopsTab.Controls.Add(this.wshopName_label);
            this.workshopsTab.Location = new System.Drawing.Point(4, 22);
            this.workshopsTab.Name = "workshopsTab";
            this.workshopsTab.Padding = new System.Windows.Forms.Padding(3);
            this.workshopsTab.Size = new System.Drawing.Size(968, 453);
            this.workshopsTab.TabIndex = 1;
            this.workshopsTab.Text = "Workshops";
            this.workshopsTab.UseVisualStyleBackColor = true;
            // 
            // deleteWshop_button
            // 
            this.deleteWshop_button.Location = new System.Drawing.Point(168, 189);
            this.deleteWshop_button.Name = "deleteWshop_button";
            this.deleteWshop_button.Size = new System.Drawing.Size(101, 23);
            this.deleteWshop_button.TabIndex = 12;
            this.deleteWshop_button.Text = "Delete Worksop";
            this.deleteWshop_button.UseVisualStyleBackColor = true;
            // 
            // createWorksop_button
            // 
            this.createWorksop_button.Location = new System.Drawing.Point(28, 189);
            this.createWorksop_button.Name = "createWorksop_button";
            this.createWorksop_button.Size = new System.Drawing.Size(101, 23);
            this.createWorksop_button.TabIndex = 11;
            this.createWorksop_button.Text = "Create Worksop";
            this.createWorksop_button.UseVisualStyleBackColor = true;
            this.createWorksop_button.Click += new System.EventHandler(this.createWorksop_button_Click);
            // 
            // wshopCountry_label
            // 
            this.wshopCountry_label.AutoSize = true;
            this.wshopCountry_label.Location = new System.Drawing.Point(25, 136);
            this.wshopCountry_label.Name = "wshopCountry_label";
            this.wshopCountry_label.Size = new System.Drawing.Size(46, 13);
            this.wshopCountry_label.TabIndex = 10;
            this.wshopCountry_label.Text = "Country:";
            // 
            // wshopPostal_label
            // 
            this.wshopPostal_label.AutoSize = true;
            this.wshopPostal_label.Location = new System.Drawing.Point(25, 110);
            this.wshopPostal_label.Name = "wshopPostal_label";
            this.wshopPostal_label.Size = new System.Drawing.Size(67, 13);
            this.wshopPostal_label.TabIndex = 9;
            this.wshopPostal_label.Text = "Postal Code:";
            // 
            // wshopTrademark_label
            // 
            this.wshopTrademark_label.AutoSize = true;
            this.wshopTrademark_label.Location = new System.Drawing.Point(25, 58);
            this.wshopTrademark_label.Name = "wshopTrademark_label";
            this.wshopTrademark_label.Size = new System.Drawing.Size(80, 13);
            this.wshopTrademark_label.TabIndex = 8;
            this.wshopTrademark_label.Text = "Car Trademark:";
            // 
            // wshopCity_label
            // 
            this.wshopCity_label.AutoSize = true;
            this.wshopCity_label.Location = new System.Drawing.Point(25, 84);
            this.wshopCity_label.Name = "wshopCity_label";
            this.wshopCity_label.Size = new System.Drawing.Size(27, 13);
            this.wshopCity_label.TabIndex = 7;
            this.wshopCity_label.Text = "City:";
            // 
            // wshopCountry_textBox
            // 
            this.wshopCountry_textBox.Location = new System.Drawing.Point(118, 133);
            this.wshopCountry_textBox.Name = "wshopCountry_textBox";
            this.wshopCountry_textBox.Size = new System.Drawing.Size(100, 20);
            this.wshopCountry_textBox.TabIndex = 6;
            // 
            // wshopPostal_textBox
            // 
            this.wshopPostal_textBox.Location = new System.Drawing.Point(118, 107);
            this.wshopPostal_textBox.Name = "wshopPostal_textBox";
            this.wshopPostal_textBox.Size = new System.Drawing.Size(100, 20);
            this.wshopPostal_textBox.TabIndex = 5;
            // 
            // wshopCity_textBox
            // 
            this.wshopCity_textBox.Location = new System.Drawing.Point(118, 81);
            this.wshopCity_textBox.Name = "wshopCity_textBox";
            this.wshopCity_textBox.Size = new System.Drawing.Size(100, 20);
            this.wshopCity_textBox.TabIndex = 4;
            // 
            // wshopTrademark_textBox
            // 
            this.wshopTrademark_textBox.Location = new System.Drawing.Point(118, 55);
            this.wshopTrademark_textBox.Name = "wshopTrademark_textBox";
            this.wshopTrademark_textBox.Size = new System.Drawing.Size(100, 20);
            this.wshopTrademark_textBox.TabIndex = 3;
            // 
            // wshopName_textBox
            // 
            this.wshopName_textBox.Location = new System.Drawing.Point(118, 29);
            this.wshopName_textBox.Name = "wshopName_textBox";
            this.wshopName_textBox.Size = new System.Drawing.Size(100, 20);
            this.wshopName_textBox.TabIndex = 2;
            // 
            // wshopName_label
            // 
            this.wshopName_label.AutoSize = true;
            this.wshopName_label.Location = new System.Drawing.Point(25, 32);
            this.wshopName_label.Name = "wshopName_label";
            this.wshopName_label.Size = new System.Drawing.Size(38, 13);
            this.wshopName_label.TabIndex = 1;
            this.wshopName_label.Text = "Name:";
            // 
            // appoitmentTab
            // 
            this.appoitmentTab.Controls.Add(this.createApp_button);
            this.appoitmentTab.Controls.Add(this.appCompany_comboBox);
            this.appoitmentTab.Controls.Add(this.appCar_comboBox);
            this.appoitmentTab.Controls.Add(this.appUsr_comboBox);
            this.appoitmentTab.Controls.Add(this.appDate);
            this.appoitmentTab.Controls.Add(this.appDate_label);
            this.appoitmentTab.Controls.Add(this.appCompany_label);
            this.appoitmentTab.Controls.Add(this.appCar_label);
            this.appoitmentTab.Controls.Add(this.appUser_label);
            this.appoitmentTab.Location = new System.Drawing.Point(4, 22);
            this.appoitmentTab.Name = "appoitmentTab";
            this.appoitmentTab.Size = new System.Drawing.Size(968, 453);
            this.appoitmentTab.TabIndex = 2;
            this.appoitmentTab.Text = "Appoitments";
            this.appoitmentTab.UseVisualStyleBackColor = true;
            // 
            // createApp_button
            // 
            this.createApp_button.Location = new System.Drawing.Point(29, 92);
            this.createApp_button.Name = "createApp_button";
            this.createApp_button.Size = new System.Drawing.Size(121, 23);
            this.createApp_button.TabIndex = 8;
            this.createApp_button.Text = "Create Appoitment";
            this.createApp_button.UseVisualStyleBackColor = true;
            this.createApp_button.Click += new System.EventHandler(this.createApp_button_Click);
            // 
            // appCompany_comboBox
            // 
            this.appCompany_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appCompany_comboBox.FormattingEnabled = true;
            this.appCompany_comboBox.Location = new System.Drawing.Point(350, 50);
            this.appCompany_comboBox.Name = "appCompany_comboBox";
            this.appCompany_comboBox.Size = new System.Drawing.Size(121, 21);
            this.appCompany_comboBox.TabIndex = 7;
            // 
            // appCar_comboBox
            // 
            this.appCar_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appCar_comboBox.FormattingEnabled = true;
            this.appCar_comboBox.Location = new System.Drawing.Point(191, 50);
            this.appCar_comboBox.Name = "appCar_comboBox";
            this.appCar_comboBox.Size = new System.Drawing.Size(121, 21);
            this.appCar_comboBox.TabIndex = 6;
            // 
            // appUsr_comboBox
            // 
            this.appUsr_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appUsr_comboBox.FormattingEnabled = true;
            this.appUsr_comboBox.Location = new System.Drawing.Point(29, 50);
            this.appUsr_comboBox.Name = "appUsr_comboBox";
            this.appUsr_comboBox.Size = new System.Drawing.Size(121, 21);
            this.appUsr_comboBox.TabIndex = 5;
            // 
            // appDate
            // 
            this.appDate.Location = new System.Drawing.Point(508, 50);
            this.appDate.Name = "appDate";
            this.appDate.Size = new System.Drawing.Size(200, 20);
            this.appDate.TabIndex = 4;
            // 
            // appDate_label
            // 
            this.appDate_label.AutoSize = true;
            this.appDate_label.Location = new System.Drawing.Point(505, 24);
            this.appDate_label.Name = "appDate_label";
            this.appDate_label.Size = new System.Drawing.Size(33, 13);
            this.appDate_label.TabIndex = 3;
            this.appDate_label.Text = "Date:";
            // 
            // appCompany_label
            // 
            this.appCompany_label.AutoSize = true;
            this.appCompany_label.Location = new System.Drawing.Point(347, 24);
            this.appCompany_label.Name = "appCompany_label";
            this.appCompany_label.Size = new System.Drawing.Size(54, 13);
            this.appCompany_label.TabIndex = 2;
            this.appCompany_label.Text = "Company:";
            // 
            // appCar_label
            // 
            this.appCar_label.AutoSize = true;
            this.appCar_label.Location = new System.Drawing.Point(188, 24);
            this.appCar_label.Name = "appCar_label";
            this.appCar_label.Size = new System.Drawing.Size(80, 13);
            this.appCar_label.TabIndex = 1;
            this.appCar_label.Text = "Car Trademark:";
            // 
            // appUser_label
            // 
            this.appUser_label.AutoSize = true;
            this.appUser_label.Location = new System.Drawing.Point(26, 24);
            this.appUser_label.Name = "appUser_label";
            this.appUser_label.Size = new System.Drawing.Size(63, 13);
            this.appUser_label.TabIndex = 0;
            this.appUser_label.Text = "User Name:";
            // 
            // CarWorkshopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 478);
            this.Controls.Add(this.tabControl);
            this.Name = "CarWorkshopApp";
            this.Text = "CarWorkshop";
            this.tabControl.ResumeLayout(false);
            this.usersTab.ResumeLayout(false);
            this.usersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.workshopsTab.ResumeLayout(false);
            this.workshopsTab.PerformLayout();
            this.appoitmentTab.ResumeLayout(false);
            this.appoitmentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.Label usrCity_label;
        private System.Windows.Forms.TextBox usrEmail_textBox;
        private System.Windows.Forms.TextBox usrName_textBox;
        private System.Windows.Forms.Label usrEmaol_label;
        private System.Windows.Forms.Label usrName_label;
        private System.Windows.Forms.TabPage workshopsTab;
        private System.Windows.Forms.TextBox usrCity_textBox;
        private System.Windows.Forms.Label usrCountry_label;
        private System.Windows.Forms.TextBox usrPostal_textBox;
        private System.Windows.Forms.Label usrPostal_label;
        private System.Windows.Forms.Button createUsr_button;
        private System.Windows.Forms.TextBox usrCountry_textBox;
        private System.Windows.Forms.Label allUsers_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox wshopName_textBox;
        private System.Windows.Forms.Label wshopName_label;
        private System.Windows.Forms.Label wshopTrademark_label;
        private System.Windows.Forms.Label wshopCity_label;
        private System.Windows.Forms.TextBox wshopCountry_textBox;
        private System.Windows.Forms.TextBox wshopPostal_textBox;
        private System.Windows.Forms.TextBox wshopCity_textBox;
        private System.Windows.Forms.TextBox wshopTrademark_textBox;
        private System.Windows.Forms.Label wshopPostal_label;
        private System.Windows.Forms.Label wshopCountry_label;
        private System.Windows.Forms.Button createWorksop_button;
        private System.Windows.Forms.Button deleteUser_button;
        private System.Windows.Forms.Button deleteWshop_button;
        private System.Windows.Forms.TabPage appoitmentTab;
        private System.Windows.Forms.Label appCompany_label;
        private System.Windows.Forms.Label appCar_label;
        private System.Windows.Forms.Label appUser_label;
        private System.Windows.Forms.Label appDate_label;
        private System.Windows.Forms.Button createApp_button;
        private System.Windows.Forms.ComboBox appCompany_comboBox;
        private System.Windows.Forms.ComboBox appCar_comboBox;
        private System.Windows.Forms.ComboBox appUsr_comboBox;
        private System.Windows.Forms.DateTimePicker appDate;
        private System.Windows.Forms.BindingSource userBindingSource1;
    }
}

