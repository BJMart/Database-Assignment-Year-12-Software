namespace Vigils_book
{
    partial class Form1
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
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.btnChangeCustomerInformation = new System.Windows.Forms.Button();
            this.dgvCustomerInformation = new System.Windows.Forms.DataGridView();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnChangeBook = new System.Windows.Forms.Button();
            this.txtReplaceCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtReplaceCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtReplaceCustomerName = new System.Windows.Forms.TextBox();
            this.txtReplaceBookISBN = new System.Windows.Forms.TextBox();
            this.txtReplaceBookAuthor = new System.Windows.Forms.TextBox();
            this.txtReplaceBookTitle = new System.Windows.Forms.TextBox();
            this.txtReplaceBookYearOfPublication = new System.Windows.Forms.TextBox();
            this.txtReplaceBookStock = new System.Windows.Forms.TextBox();
            this.txtReplaceBookPublisher = new System.Windows.Forms.TextBox();
            this.txtReplaceBookPrice = new System.Windows.Forms.TextBox();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.cmbSearchCatCustomer = new System.Windows.Forms.ComboBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnResetCustomerSearch = new System.Windows.Forms.Button();
            this.txtLabelYearOfPub = new System.Windows.Forms.TextBox();
            this.txtLabelTitle = new System.Windows.Forms.TextBox();
            this.txtLabelISBN = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtLabelBookPublisher = new System.Windows.Forms.TextBox();
            this.txtLabelBookStock = new System.Windows.Forms.TextBox();
            this.txtLabelBookPrice = new System.Windows.Forms.TextBox();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.txtLabelAddReplaceCustomerName = new System.Windows.Forms.TextBox();
            this.txtLabelCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtLabelAddReplaceCustomePhone = new System.Windows.Forms.TextBox();
            this.txtLabelSearchCustomer = new System.Windows.Forms.TextBox();
            this.txtLabelCustomerSearchType = new System.Windows.Forms.TextBox();
            this.btnResetBookSearch = new System.Windows.Forms.Button();
            this.cmbSearchCatBook = new System.Windows.Forms.ComboBox();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.txtBookStockCustomerWants = new System.Windows.Forms.TextBox();
            this.btnSellBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchBook
            // 
            this.btnSearch.Location = new System.Drawing.Point(443, 556);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Book";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(248, 228);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.Size = new System.Drawing.Size(577, 256);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.SelectionChanged += new System.EventHandler(this.dgvBookList_SelectionChanged);
            // 
            // btnChangeCustomerInformation
            // 
            this.btnChangeCustomerInformation.AutoSize = true;
            this.btnChangeCustomerInformation.Location = new System.Drawing.Point(647, 168);
            this.btnChangeCustomerInformation.Name = "btnChangeCustomerInformation";
            this.btnChangeCustomerInformation.Size = new System.Drawing.Size(183, 44);
            this.btnChangeCustomerInformation.TabIndex = 2;
            this.btnChangeCustomerInformation.Text = "Add/Replace Customer Information";
            this.btnChangeCustomerInformation.UseVisualStyleBackColor = true;
            this.btnChangeCustomerInformation.Click += new System.EventHandler(this.BtnChangeCustomerInformation_Click);
            // 
            // dgvCustomerInformation
            // 
            this.dgvCustomerInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCustomerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInformation.Location = new System.Drawing.Point(379, 6);
            this.dgvCustomerInformation.Name = "dgvCustomerInformation";
            this.dgvCustomerInformation.RowHeadersWidth = 51;
            this.dgvCustomerInformation.Size = new System.Drawing.Size(262, 206);
            this.dgvCustomerInformation.TabIndex = 0;
            this.dgvCustomerInformation.SelectionChanged += new System.EventHandler(this.dgvCustomerInformation_SelectionChanged);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.AutoSize = true;
            this.btnSearchCustomer.Location = new System.Drawing.Point(140, 168);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(98, 44);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
            // 
            // btnChangeBook
            // 
            this.btnChangeBook.AutoSize = true;
            this.btnChangeBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeBook.Location = new System.Drawing.Point(127, 409);
            this.btnChangeBook.Name = "btnChangeBook";
            this.btnChangeBook.Size = new System.Drawing.Size(115, 27);
            this.btnChangeBook.TabIndex = 2;
            this.btnChangeBook.Text = "Add/Change Book";
            this.btnChangeBook.UseVisualStyleBackColor = true;
            this.btnChangeBook.Click += new System.EventHandler(this.btnChangeBook_Click);
            // 
            // txtReplaceCustomerPhoneNumber
            // 
            this.txtReplaceCustomerPhoneNumber.Location = new System.Drawing.Point(647, 133);
            this.txtReplaceCustomerPhoneNumber.Multiline = true;
            this.txtReplaceCustomerPhoneNumber.Name = "txtReplaceCustomerPhoneNumber";
            this.txtReplaceCustomerPhoneNumber.Size = new System.Drawing.Size(293, 29);
            this.txtReplaceCustomerPhoneNumber.TabIndex = 10;
            // 
            // txtReplaceCustomerLastName
            // 
            this.txtReplaceCustomerLastName.Location = new System.Drawing.Point(647, 78);
            this.txtReplaceCustomerLastName.Multiline = true;
            this.txtReplaceCustomerLastName.Name = "txtReplaceCustomerLastName";
            this.txtReplaceCustomerLastName.Size = new System.Drawing.Size(293, 29);
            this.txtReplaceCustomerLastName.TabIndex = 9;
            // 
            // txtReplaceCustomerName
            // 
            this.txtReplaceCustomerName.Location = new System.Drawing.Point(647, 21);
            this.txtReplaceCustomerName.Multiline = true;
            this.txtReplaceCustomerName.Name = "txtReplaceCustomerName";
            this.txtReplaceCustomerName.Size = new System.Drawing.Size(293, 29);
            this.txtReplaceCustomerName.TabIndex = 8;
            // 
            // txtReplaceBookISBN
            // 
            this.txtReplaceBookISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookISBN.Location = new System.Drawing.Point(9, 254);
            this.txtReplaceBookISBN.Multiline = true;
            this.txtReplaceBookISBN.Name = "txtReplaceBookISBN";
            this.txtReplaceBookISBN.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookISBN.TabIndex = 11;
            // 
            // txtReplaceBookAuthor
            // 
            this.txtReplaceBookAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookAuthor.Location = new System.Drawing.Point(9, 306);
            this.txtReplaceBookAuthor.Multiline = true;
            this.txtReplaceBookAuthor.Name = "txtReplaceBookAuthor";
            this.txtReplaceBookAuthor.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookAuthor.TabIndex = 12;
            // 
            // txtReplaceBookTitle
            // 
            this.txtReplaceBookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookTitle.Location = new System.Drawing.Point(127, 254);
            this.txtReplaceBookTitle.Multiline = true;
            this.txtReplaceBookTitle.Name = "txtReplaceBookTitle";
            this.txtReplaceBookTitle.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookTitle.TabIndex = 13;
            // 
            // txtReplaceBookYearOfPublication
            // 
            this.txtReplaceBookYearOfPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookYearOfPublication.Location = new System.Drawing.Point(127, 306);
            this.txtReplaceBookYearOfPublication.Multiline = true;
            this.txtReplaceBookYearOfPublication.Name = "txtReplaceBookYearOfPublication";
            this.txtReplaceBookYearOfPublication.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookYearOfPublication.TabIndex = 14;
            // 
            // txtReplaceBookStock
            // 
            this.txtReplaceBookStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookStock.Location = new System.Drawing.Point(127, 358);
            this.txtReplaceBookStock.Multiline = true;
            this.txtReplaceBookStock.Name = "txtReplaceBookStock";
            this.txtReplaceBookStock.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookStock.TabIndex = 15;
            // 
            // txtReplaceBookPublisher
            // 
            this.txtReplaceBookPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookPublisher.Location = new System.Drawing.Point(9, 358);
            this.txtReplaceBookPublisher.Multiline = true;
            this.txtReplaceBookPublisher.Name = "txtReplaceBookPublisher";
            this.txtReplaceBookPublisher.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookPublisher.TabIndex = 16;
            // 
            // txtReplaceBookPrice
            // 
            this.txtReplaceBookPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookPrice.Location = new System.Drawing.Point(10, 409);
            this.txtReplaceBookPrice.Multiline = true;
            this.txtReplaceBookPrice.Name = "txtReplaceBookPrice";
            this.txtReplaceBookPrice.Size = new System.Drawing.Size(116, 27);
            this.txtReplaceBookPrice.TabIndex = 17;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.AutoSize = true;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(836, 168);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(104, 44);
            this.btnRemoveCustomer.TabIndex = 22;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.BtnRemoveCustomer_Click);
            // 
            // cmbSearchCatCustomer
            // 
            this.cmbSearchCatCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCatCustomer.FormattingEnabled = true;
            this.cmbSearchCatCustomer.Items.AddRange(new object[] {
            "customerID",
            "customerFirstName",
            "customerLastName",
            "customerPhoneNumber"});
            this.cmbSearchCatCustomer.Location = new System.Drawing.Point(140, 61);
            this.cmbSearchCatCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSearchCatCustomer.Name = "cmbSearchCatCustomer";
            this.cmbSearchCatCustomer.Size = new System.Drawing.Size(233, 21);
            this.cmbSearchCatCustomer.TabIndex = 29;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(140, 118);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(233, 29);
            this.txtSearchCustomer.TabIndex = 30;
            // 
            // btnResetCustomerSearch
            // 
            this.btnResetCustomerSearch.AutoSize = true;
            this.btnResetCustomerSearch.Location = new System.Drawing.Point(244, 168);
            this.btnResetCustomerSearch.Name = "btnResetCustomerSearch";
            this.btnResetCustomerSearch.Size = new System.Drawing.Size(129, 44);
            this.btnResetCustomerSearch.TabIndex = 31;
            this.btnResetCustomerSearch.Text = "Reset Customer Search";
            this.btnResetCustomerSearch.UseVisualStyleBackColor = true;
            this.btnResetCustomerSearch.Click += new System.EventHandler(this.btnResetCustomerSearch_Click);
            // 
            // txtLabelYearOfPub
            // 
            this.txtLabelYearOfPub.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelYearOfPub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelYearOfPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelYearOfPub.ForeColor = System.Drawing.Color.Black;
            this.txtLabelYearOfPub.Location = new System.Drawing.Point(127, 281);
            this.txtLabelYearOfPub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelYearOfPub.Multiline = true;
            this.txtLabelYearOfPub.Name = "txtLabelYearOfPub";
            this.txtLabelYearOfPub.ReadOnly = true;
            this.txtLabelYearOfPub.Size = new System.Drawing.Size(111, 26);
            this.txtLabelYearOfPub.TabIndex = 34;
            this.txtLabelYearOfPub.Text = "Add/Replace Book Year Of Publication:";
            // 
            // txtLabelTitle
            // 
            this.txtLabelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelTitle.ForeColor = System.Drawing.Color.Black;
            this.txtLabelTitle.Location = new System.Drawing.Point(127, 229);
            this.txtLabelTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelTitle.Multiline = true;
            this.txtLabelTitle.Name = "txtLabelTitle";
            this.txtLabelTitle.ReadOnly = true;
            this.txtLabelTitle.Size = new System.Drawing.Size(111, 26);
            this.txtLabelTitle.TabIndex = 35;
            this.txtLabelTitle.Text = "Add/Replace Book Title:";
            // 
            // txtLabelISBN
            // 
            this.txtLabelISBN.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelISBN.ForeColor = System.Drawing.Color.Black;
            this.txtLabelISBN.Location = new System.Drawing.Point(9, 229);
            this.txtLabelISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelISBN.Multiline = true;
            this.txtLabelISBN.Name = "txtLabelISBN";
            this.txtLabelISBN.ReadOnly = true;
            this.txtLabelISBN.Size = new System.Drawing.Size(111, 26);
            this.txtLabelISBN.TabIndex = 36;
            this.txtLabelISBN.Text = "Add/Replace Book ISBN:";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.txtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtBookAuthor.Location = new System.Drawing.Point(9, 281);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookAuthor.Multiline = true;
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.ReadOnly = true;
            this.txtBookAuthor.Size = new System.Drawing.Size(111, 26);
            this.txtBookAuthor.TabIndex = 37;
            this.txtBookAuthor.Text = "Add/Replace Book Author:";
            // 
            // txtLabelBookPublisher
            // 
            this.txtLabelBookPublisher.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelBookPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelBookPublisher.ForeColor = System.Drawing.Color.Black;
            this.txtLabelBookPublisher.Location = new System.Drawing.Point(9, 333);
            this.txtLabelBookPublisher.Margin = new System.Windows.Forms.Padding(0);
            this.txtLabelBookPublisher.Multiline = true;
            this.txtLabelBookPublisher.Name = "txtLabelBookPublisher";
            this.txtLabelBookPublisher.ReadOnly = true;
            this.txtLabelBookPublisher.Size = new System.Drawing.Size(111, 26);
            this.txtLabelBookPublisher.TabIndex = 38;
            this.txtLabelBookPublisher.Text = "Add/Replace Book Publisher:";
            // 
            // txtLabelBookStock
            // 
            this.txtLabelBookStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelBookStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelBookStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelBookStock.ForeColor = System.Drawing.Color.Black;
            this.txtLabelBookStock.Location = new System.Drawing.Point(127, 333);
            this.txtLabelBookStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelBookStock.Multiline = true;
            this.txtLabelBookStock.Name = "txtLabelBookStock";
            this.txtLabelBookStock.ReadOnly = true;
            this.txtLabelBookStock.Size = new System.Drawing.Size(111, 26);
            this.txtLabelBookStock.TabIndex = 39;
            this.txtLabelBookStock.Text = "Add/Replace Book Stock:";
            // 
            // txtLabelBookPrice
            // 
            this.txtLabelBookPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelBookPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelBookPrice.ForeColor = System.Drawing.Color.Black;
            this.txtLabelBookPrice.Location = new System.Drawing.Point(9, 385);
            this.txtLabelBookPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelBookPrice.Multiline = true;
            this.txtLabelBookPrice.Name = "txtLabelBookPrice";
            this.txtLabelBookPrice.ReadOnly = true;
            this.txtLabelBookPrice.Size = new System.Drawing.Size(111, 26);
            this.txtLabelBookPrice.TabIndex = 40;
            this.txtLabelBookPrice.Text = "Add/Replace Book Price:";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.AutoSize = true;
            this.btnRemoveBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveBook.Location = new System.Drawing.Point(127, 385);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(115, 23);
            this.btnRemoveBook.TabIndex = 41;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // txtLabelAddReplaceCustomerName
            // 
            this.txtLabelAddReplaceCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelAddReplaceCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelAddReplaceCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelAddReplaceCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtLabelAddReplaceCustomerName.Location = new System.Drawing.Point(647, 4);
            this.txtLabelAddReplaceCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelAddReplaceCustomerName.Name = "txtLabelAddReplaceCustomerName";
            this.txtLabelAddReplaceCustomerName.ReadOnly = true;
            this.txtLabelAddReplaceCustomerName.Size = new System.Drawing.Size(160, 12);
            this.txtLabelAddReplaceCustomerName.TabIndex = 42;
            this.txtLabelAddReplaceCustomerName.Text = "Add/Replace Customer Name:";
            // 
            // txtLabelCustomerLastName
            // 
            this.txtLabelCustomerLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelCustomerLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelCustomerLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLabelCustomerLastName.Location = new System.Drawing.Point(647, 61);
            this.txtLabelCustomerLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelCustomerLastName.Name = "txtLabelCustomerLastName";
            this.txtLabelCustomerLastName.ReadOnly = true;
            this.txtLabelCustomerLastName.Size = new System.Drawing.Size(160, 12);
            this.txtLabelCustomerLastName.TabIndex = 43;
            this.txtLabelCustomerLastName.Text = "Add/Replace Customer Last Name:";
            // 
            // txtLabelAddReplaceCustomePhone
            // 
            this.txtLabelAddReplaceCustomePhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelAddReplaceCustomePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelAddReplaceCustomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelAddReplaceCustomePhone.ForeColor = System.Drawing.Color.Black;
            this.txtLabelAddReplaceCustomePhone.Location = new System.Drawing.Point(647, 112);
            this.txtLabelAddReplaceCustomePhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelAddReplaceCustomePhone.Name = "txtLabelAddReplaceCustomePhone";
            this.txtLabelAddReplaceCustomePhone.ReadOnly = true;
            this.txtLabelAddReplaceCustomePhone.Size = new System.Drawing.Size(188, 12);
            this.txtLabelAddReplaceCustomePhone.TabIndex = 44;
            this.txtLabelAddReplaceCustomePhone.Text = "Add/Replace Customer Phone Number:";
            // 
            // txtLabelSearchCustomer
            // 
            this.txtLabelSearchCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelSearchCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtLabelSearchCustomer.Location = new System.Drawing.Point(140, 95);
            this.txtLabelSearchCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelSearchCustomer.Multiline = true;
            this.txtLabelSearchCustomer.Name = "txtLabelSearchCustomer";
            this.txtLabelSearchCustomer.ReadOnly = true;
            this.txtLabelSearchCustomer.Size = new System.Drawing.Size(135, 18);
            this.txtLabelSearchCustomer.TabIndex = 45;
            this.txtLabelSearchCustomer.Text = "Search Customer:";
            // 
            // txtLabelCustomerSearchType
            // 
            this.txtLabelCustomerSearchType.BackColor = System.Drawing.SystemColors.Control;
            this.txtLabelCustomerSearchType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelCustomerSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelCustomerSearchType.ForeColor = System.Drawing.Color.Black;
            this.txtLabelCustomerSearchType.Location = new System.Drawing.Point(140, 39);
            this.txtLabelCustomerSearchType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelCustomerSearchType.Multiline = true;
            this.txtLabelCustomerSearchType.Name = "txtLabelCustomerSearchType";
            this.txtLabelCustomerSearchType.ReadOnly = true;
            this.txtLabelCustomerSearchType.Size = new System.Drawing.Size(150, 18);
            this.txtLabelCustomerSearchType.TabIndex = 46;
            this.txtLabelCustomerSearchType.Text = "Change Customer Search Type";
            // 
            // btnResetBookSearch
            // 
            this.btnResetBookSearch.AutoSize = true;
            this.btnResetBookSearch.Location = new System.Drawing.Point(261, 484);
            this.btnResetBookSearch.Name = "btnResetBookSearch";
            this.btnResetBookSearch.Size = new System.Drawing.Size(112, 36);
            this.btnResetBookSearch.TabIndex = 47;
            this.btnResetBookSearch.Text = "Reset Book Search";
            this.btnResetBookSearch.UseVisualStyleBackColor = true;
            this.btnResetBookSearch.Click += new System.EventHandler(this.btnResetBookSearch_Click);
            // 
            // cmbSearchCatBook
            // 
            this.cmbSearchCatBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCatBook.FormattingEnabled = true;
            this.cmbSearchCatBook.Items.AddRange(new object[] {
            "ISBN",
            "bookTitle",
            "bookAuthor",
            "bookYearOfPublication",
            "bookPublisher",
            "bookStock",
            "bookPrice"});
            this.cmbSearchCatBook.Location = new System.Drawing.Point(87, 446);
            this.cmbSearchCatBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSearchCatBook.Name = "cmbSearchCatBook";
            this.cmbSearchCatBook.Size = new System.Drawing.Size(156, 21);
            this.cmbSearchCatBook.TabIndex = 48;
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(87, 482);
            this.txtSearchBook.Multiline = true;
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(156, 29);
            this.txtSearchBook.TabIndex = 49;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.Black;
            this.textBox13.Location = new System.Drawing.Point(695, 547);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(89, 21);
            this.textBox13.TabIndex = 50;
            this.textBox13.Text = "Books to Sell:";
            // 
            this.btnSellBook.Location = new System.Drawing.Point(647, 608);
            this.btnSellBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellBook.Name = "btnSellBook";
            this.btnSellBook.Size = new System.Drawing.Size(101, 44);
            this.btnSellBook.TabIndex = 52;
            this.btnSellBook.Text = "Sell Book";
            this.btnSellBook.UseVisualStyleBackColor = true;
            this.btnSellBook.Click += new System.EventHandler(this.btnSellBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 662);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.cmbSearchCatBook);
            this.Controls.Add(this.btnResetBookSearch);
            this.Controls.Add(this.txtLabelCustomerSearchType);
            this.Controls.Add(this.txtLabelSearchCustomer);
            this.Controls.Add(this.txtLabelAddReplaceCustomePhone);
            this.Controls.Add(this.txtLabelCustomerLastName);
            this.Controls.Add(this.txtLabelAddReplaceCustomerName);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.txtLabelBookPrice);
            this.Controls.Add(this.txtLabelBookStock);
            this.Controls.Add(this.txtLabelBookPublisher);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.txtLabelISBN);
            this.Controls.Add(this.txtLabelTitle);
            this.Controls.Add(this.txtLabelYearOfPub);
            this.Controls.Add(this.btnResetCustomerSearch);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.cmbSearchCatCustomer);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.txtReplaceBookPrice);
            this.Controls.Add(this.txtReplaceBookPublisher);
            this.Controls.Add(this.txtReplaceBookStock);
            this.Controls.Add(this.txtReplaceBookYearOfPublication);
            this.Controls.Add(this.txtReplaceBookTitle);
            this.Controls.Add(this.txtReplaceBookAuthor);
            this.Controls.Add(this.txtReplaceBookISBN);
            this.Controls.Add(this.txtReplaceCustomerPhoneNumber);
            this.Controls.Add(this.txtReplaceCustomerLastName);
            this.Controls.Add(this.txtReplaceCustomerName);
            this.Controls.Add(this.btnChangeBook);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnChangeCustomerInformation);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.dgvCustomerInformation);
            this.Controls.Add(this.dgvBookList);
            this.Name = "Form1";
            this.Text = "McMillans Book Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnChangeCustomerInformation;
        private System.Windows.Forms.DataGridView dgvCustomerInformation;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnChangeBook;
        private System.Windows.Forms.TextBox txtReplaceCustomerPhoneNumber;
        private System.Windows.Forms.TextBox txtReplaceCustomerLastName;
        private System.Windows.Forms.TextBox txtReplaceCustomerName;
        private System.Windows.Forms.TextBox txtReplaceBookISBN;
        private System.Windows.Forms.TextBox txtReplaceBookAuthor;
        private System.Windows.Forms.TextBox txtReplaceBookTitle;
        private System.Windows.Forms.TextBox txtReplaceBookYearOfPublication;
        private System.Windows.Forms.TextBox txtReplaceBookStock;
        private System.Windows.Forms.TextBox txtReplaceBookPublisher;
        private System.Windows.Forms.TextBox txtReplaceBookPrice;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.ComboBox cmbSearchCatCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnResetCustomerSearch;
        private System.Windows.Forms.TextBox txtLabelYearOfPub;
        private System.Windows.Forms.TextBox txtLabelTitle;
        private System.Windows.Forms.TextBox txtLabelISBN;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtLabelBookPublisher;
        private System.Windows.Forms.TextBox txtLabelBookStock;
        private System.Windows.Forms.TextBox txtLabelBookPrice;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.TextBox txtLabelAddReplaceCustomerName;
        private System.Windows.Forms.TextBox txtLabelCustomerLastName;
        private System.Windows.Forms.TextBox txtLabelAddReplaceCustomePhone;
        private System.Windows.Forms.TextBox txtLabelSearchCustomer;
        private System.Windows.Forms.TextBox txtLabelCustomerSearchType;
        private System.Windows.Forms.Button btnResetBookSearch;
        private System.Windows.Forms.ComboBox cmbSearchCatBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.TextBox txtBookStockCustomerWants;
        private System.Windows.Forms.Button btnSellBook;
    }
}
