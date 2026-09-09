namespace EContact
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblContactID = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblLogo);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1067, 74);
            this.panelHeader.TabIndex = 0;

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.Teal;
            this.lblLogo.Location = new System.Drawing.Point(16, 15);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(243, 46);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "e CONTACT";

            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1013, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.panelLeft.Controls.Add(this.lblContactID);
            this.panelLeft.Controls.Add(this.txtContactID);
            this.panelLeft.Controls.Add(this.lblFirstName);
            this.panelLeft.Controls.Add(this.txtFirstName);
            this.panelLeft.Controls.Add(this.lblLastName);
            this.panelLeft.Controls.Add(this.txtLastName);
            this.panelLeft.Controls.Add(this.lblContactNo);
            this.panelLeft.Controls.Add(this.txtContactNo);
            this.panelLeft.Controls.Add(this.lblAddress);
            this.panelLeft.Controls.Add(this.txtAddress);
            this.panelLeft.Controls.Add(this.lblGender);
            this.panelLeft.Controls.Add(this.cmbGender);
            this.panelLeft.Location = new System.Drawing.Point(13, 86);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 492);
            this.panelLeft.TabIndex = 1;

            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Arial", 10F);
            this.lblContactID.Location = new System.Drawing.Point(13, 25);
            this.lblContactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(91, 19);
            this.lblContactID.TabIndex = 0;
            this.lblContactID.Text = "Контакт ID";

            this.txtContactID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContactID.Location = new System.Drawing.Point(133, 21);
            this.txtContactID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(239, 27);
            this.txtContactID.TabIndex = 1;

            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(13, 68);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(41, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Имя";

            this.txtFirstName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(133, 64);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(239, 27);
            this.txtFirstName.TabIndex = 3;

            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblLastName.Location = new System.Drawing.Point(13, 111);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Фамилия";

            this.txtLastName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtLastName.Location = new System.Drawing.Point(133, 107);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 27);
            this.txtLastName.TabIndex = 5;

            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblContactNo.Location = new System.Drawing.Point(13, 154);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(94, 19);
            this.lblContactNo.TabIndex = 6;
            this.lblContactNo.Text = "Номер тел.";

            this.txtContactNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContactNo.Location = new System.Drawing.Point(133, 150);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(239, 27);
            this.txtContactNo.TabIndex = 7;

            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAddress.Location = new System.Drawing.Point(13, 197);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 19);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Адрес";

            this.txtAddress.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAddress.Location = new System.Drawing.Point(133, 193);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 98);
            this.txtAddress.TabIndex = 9;

            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 10F);
            this.lblGender.Location = new System.Drawing.Point(13, 314);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(39, 19);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Пол";

            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cmbGender.Location = new System.Drawing.Point(133, 310);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(239, 27);
            this.cmbGender.TabIndex = 11;

            this.panelRight.Controls.Add(this.lblSearch);
            this.panelRight.Controls.Add(this.txtSearch);
            this.panelRight.Controls.Add(this.dgvContacts);
            this.panelRight.Location = new System.Drawing.Point(427, 86);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(627, 492);
            this.panelRight.TabIndex = 2;

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSearch.Location = new System.Drawing.Point(13, 25);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Поиск";

            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearch.Location = new System.Drawing.Point(93, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(505, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(13, 62);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(600, 418);
            this.dgvContacts.TabIndex = 2;
            this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellClick);

            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnUpdate);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 591);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1067, 74);
            this.panelButtons.TabIndex = 3;

            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(40, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(227, 15);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 43);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(413, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(600, 15);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 665);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eCONTACT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}