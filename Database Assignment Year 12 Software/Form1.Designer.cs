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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
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
            this.btnSearchBook.Location = new System.Drawing.Point(443, 556);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(150, 44);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(331, 280);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.Size = new System.Drawing.Size(912, 256);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.SelectionChanged += new System.EventHandler(this.dgvBookList_SelectionChanged);
            // 
            // btnChangeCustomerInformation
            // 
            this.btnChangeCustomerInformation.Location = new System.Drawing.Point(984, 207);
            this.btnChangeCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCustomerInformation.Name = "btnChangeCustomerInformation";
            this.btnChangeCustomerInformation.Size = new System.Drawing.Size(129, 54);
            this.btnChangeCustomerInformation.TabIndex = 2;
            this.btnChangeCustomerInformation.Text = "Add/Replace Customer Information";
            this.btnChangeCustomerInformation.UseVisualStyleBackColor = true;
            this.btnChangeCustomerInformation.Click += new System.EventHandler(this.BtnChangeCustomerInformation_Click);
            // 
            // dgvCustomerInformation
            // 
            this.dgvCustomerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInformation.Location = new System.Drawing.Point(627, 7);
            this.dgvCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomerInformation.Name = "dgvCustomerInformation";
            this.dgvCustomerInformation.RowHeadersWidth = 51;
            this.dgvCustomerInformation.Size = new System.Drawing.Size(349, 254);
            this.dgvCustomerInformation.TabIndex = 0;
            this.dgvCustomerInformation.SelectionChanged += new System.EventHandler(this.dgvCustomerInformation_SelectionChanged);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(413, 207);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(103, 54);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
            // 
            // btnChangeBook
            // 
            this.btnChangeBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeBook.Location = new System.Drawing.Point(169, 476);
            this.btnChangeBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeBook.Name = "btnChangeBook";
            this.btnChangeBook.Size = new System.Drawing.Size(154, 30);
            this.btnChangeBook.TabIndex = 2;
            this.btnChangeBook.Text = "Add/Change Book Information";
            this.btnChangeBook.UseVisualStyleBackColor = true;
            this.btnChangeBook.Click += new System.EventHandler(this.btnChangeBook_Click);
            // 
            // txtReplaceCustomerPhoneNumber
            // 
            this.txtReplaceCustomerPhoneNumber.Location = new System.Drawing.Point(985, 166);
            this.txtReplaceCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceCustomerPhoneNumber.Multiline = true;
            this.txtReplaceCustomerPhoneNumber.Name = "txtReplaceCustomerPhoneNumber";
            this.txtReplaceCustomerPhoneNumber.Size = new System.Drawing.Size(258, 35);
            this.txtReplaceCustomerPhoneNumber.TabIndex = 10;
            // 
            // txtReplaceCustomerLastName
            // 
            this.txtReplaceCustomerLastName.Location = new System.Drawing.Point(985, 96);
            this.txtReplaceCustomerLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceCustomerLastName.Multiline = true;
            this.txtReplaceCustomerLastName.Name = "txtReplaceCustomerLastName";
            this.txtReplaceCustomerLastName.Size = new System.Drawing.Size(258, 35);
            this.txtReplaceCustomerLastName.TabIndex = 9;
            // 
            // txtReplaceCustomerName
            // 
            this.txtReplaceCustomerName.Location = new System.Drawing.Point(985, 26);
            this.txtReplaceCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceCustomerName.Multiline = true;
            this.txtReplaceCustomerName.Name = "txtReplaceCustomerName";
            this.txtReplaceCustomerName.Size = new System.Drawing.Size(258, 35);
            this.txtReplaceCustomerName.TabIndex = 8;
            // 
            // txtReplaceBookISBN
            // 
            this.txtReplaceBookISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookISBN.Location = new System.Drawing.Point(12, 312);
            this.txtReplaceBookISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookISBN.Multiline = true;
            this.txtReplaceBookISBN.Name = "txtReplaceBookISBN";
            this.txtReplaceBookISBN.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookISBN.TabIndex = 11;
            // 
            // txtReplaceBookAuthor
            // 
            this.txtReplaceBookAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookAuthor.Location = new System.Drawing.Point(12, 376);
            this.txtReplaceBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookAuthor.Multiline = true;
            this.txtReplaceBookAuthor.Name = "txtReplaceBookAuthor";
            this.txtReplaceBookAuthor.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookAuthor.TabIndex = 12;
            // 
            // txtReplaceBookTitle
            // 
            this.txtReplaceBookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookTitle.Location = new System.Drawing.Point(169, 312);
            this.txtReplaceBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookTitle.Multiline = true;
            this.txtReplaceBookTitle.Name = "txtReplaceBookTitle";
            this.txtReplaceBookTitle.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookTitle.TabIndex = 13;
            // 
            // txtReplaceBookYearOfPublication
            // 
            this.txtReplaceBookYearOfPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookYearOfPublication.Location = new System.Drawing.Point(169, 376);
            this.txtReplaceBookYearOfPublication.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookYearOfPublication.Multiline = true;
            this.txtReplaceBookYearOfPublication.Name = "txtReplaceBookYearOfPublication";
            this.txtReplaceBookYearOfPublication.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookYearOfPublication.TabIndex = 14;
            // 
            // txtReplaceBookStock
            // 
            this.txtReplaceBookStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookStock.Location = new System.Drawing.Point(169, 440);
            this.txtReplaceBookStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookStock.Multiline = true;
            this.txtReplaceBookStock.Name = "txtReplaceBookStock";
            this.txtReplaceBookStock.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookStock.TabIndex = 15;
            // 
            // txtReplaceBookPublisher
            // 
            this.txtReplaceBookPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookPublisher.Location = new System.Drawing.Point(12, 440);
            this.txtReplaceBookPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookPublisher.Multiline = true;
            this.txtReplaceBookPublisher.Name = "txtReplaceBookPublisher";
            this.txtReplaceBookPublisher.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookPublisher.TabIndex = 16;
            // 
            // txtReplaceBookPrice
            // 
            this.txtReplaceBookPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplaceBookPrice.Location = new System.Drawing.Point(14, 503);
            this.txtReplaceBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplaceBookPrice.Multiline = true;
            this.txtReplaceBookPrice.Name = "txtReplaceBookPrice";
            this.txtReplaceBookPrice.Size = new System.Drawing.Size(154, 32);
            this.txtReplaceBookPrice.TabIndex = 17;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(1115, 207);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(129, 54);
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
            this.cmbSearchCatCustomer.Location = new System.Drawing.Point(413, 76);
            this.cmbSearchCatCustomer.Name = "cmbSearchCatCustomer";
            this.cmbSearchCatCustomer.Size = new System.Drawing.Size(206, 24);
            this.cmbSearchCatCustomer.TabIndex = 29;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(413, 146);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(206, 35);
            this.txtSearchCustomer.TabIndex = 30;
            // 
            // btnResetCustomerSearch
            // 
            this.btnResetCustomerSearch.Location = new System.Drawing.Point(516, 207);
            this.btnResetCustomerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetCustomerSearch.Name = "btnResetCustomerSearch";
            this.btnResetCustomerSearch.Size = new System.Drawing.Size(103, 54);
            this.btnResetCustomerSearch.TabIndex = 31;
            this.btnResetCustomerSearch.Text = "Reset Customer Search";
            this.btnResetCustomerSearch.UseVisualStyleBackColor = true;
            this.btnResetCustomerSearch.Click += new System.EventHandler(this.btnResetCustomerSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(169, 346);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 32);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Add/Replace Book Year Of Publication:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(169, 282);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(148, 32);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "Add/Replace Book Title:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(12, 282);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(148, 32);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "Add/Replace Book ISBN:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(12, 346);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(148, 32);
            this.textBox4.TabIndex = 37;
            this.textBox4.Text = "Add/Replace Book Author:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(12, 410);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(148, 32);
            this.textBox5.TabIndex = 38;
            this.textBox5.Text = "Add/Replace Book Publisher:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(169, 410);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(148, 32);
            this.textBox6.TabIndex = 39;
            this.textBox6.Text = "Add/Replace Book Stock:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(12, 474);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(148, 32);
            this.textBox7.TabIndex = 40;
            this.textBox7.Text = "Add/Replace Book Price:";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveBook.Location = new System.Drawing.Point(169, 506);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(154, 30);
            this.btnRemoveBook.TabIndex = 41;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(985, 7);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(213, 15);
            this.textBox8.TabIndex = 42;
            this.textBox8.Text = "Add/Replace Customer Name:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(985, 74);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(213, 15);
            this.textBox9.TabIndex = 43;
            this.textBox9.Text = "Add/Replace Customer Last Name:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(983, 144);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(250, 15);
            this.textBox10.TabIndex = 44;
            this.textBox10.Text = "Add/Replace Customer Phone Number:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(413, 117);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(180, 22);
            this.textBox11.TabIndex = 45;
            this.textBox11.Text = "Search Customer:";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(412, 48);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(200, 22);
            this.textBox12.TabIndex = 46;
            this.textBox12.Text = "Change Customer Search Type";
            // 
            // btnResetBookSearch
            // 
            this.btnResetBookSearch.Location = new System.Drawing.Point(443, 610);
            this.btnResetBookSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetBookSearch.Name = "btnResetBookSearch";
            this.btnResetBookSearch.Size = new System.Drawing.Size(150, 44);
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
            this.cmbSearchCatBook.Location = new System.Drawing.Point(230, 567);
            this.cmbSearchCatBook.Name = "cmbSearchCatBook";
            this.cmbSearchCatBook.Size = new System.Drawing.Size(206, 24);
            this.cmbSearchCatBook.TabIndex = 48;
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(230, 614);
            this.txtSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBook.Multiline = true;
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(206, 35);
            this.txtSearchBook.TabIndex = 49;
            // 
            // txtBookStockCustomerWants
            // 
            this.txtBookStockCustomerWants.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookStockCustomerWants.Location = new System.Drawing.Point(647, 556);
            this.txtBookStockCustomerWants.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookStockCustomerWants.Multiline = true;
            this.txtBookStockCustomerWants.Name = "txtBookStockCustomerWants";
            this.txtBookStockCustomerWants.Size = new System.Drawing.Size(120, 44);
            this.txtBookStockCustomerWants.TabIndex = 51;
            // 
            // btnSellBook
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 662);
            this.Controls.Add(this.btnSellBook);
            this.Controls.Add(this.txtBookStockCustomerWants);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.cmbSearchCatBook);
            this.Controls.Add(this.btnResetBookSearch);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "McMillans Book Store";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button btnResetBookSearch;
        private System.Windows.Forms.ComboBox cmbSearchCatBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.TextBox txtBookStockCustomerWants;
        private System.Windows.Forms.Button btnSellBook;
    }
}

