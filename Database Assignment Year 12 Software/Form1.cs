using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Vigils_book
{
    public partial class Form1 : Form
    {
        //String used to check if a record has been selscted
        string selectedCustomerID = "";
        string selectedBookISBN = "";
       
        
        //Create original size for Ui Elements
        private Rectangle originalFormSize;
        private Rectangle btnSellBookOriginalRectangle;
        private Rectangle btnChangeBookOriginalRectangle;
        private Rectangle btnRemoveBookOriginalRectangle; 
        private Rectangle btnSearchBookOriginalRectangle;
        private Rectangle dgvBookListOriginalRectangle;
        private Rectangle dgvCustomerInformationOriginalRectangle;
        private Rectangle txtBookStockCustomerWantsOriginalRectangle; 
        private Rectangle btnResetBookSearchOriginalRectangle;
        private Rectangle btnChangeCustomerInformationOriginalRectangle;
        private Rectangle btnRemoveCustomerOriginalRectangle;
        private Rectangle txtReplaceCustomerPhoneNumberOriginalRectangle;
        private Rectangle txtLabelAddReplaceCustomePhoneOriginalRectangle;
        private Rectangle txtReplaceCustomerLastNameOriginalRectangle;
        private Rectangle txtLabelCustomerLastNameOriginalRectangle;
        private Rectangle cmbSearchCatBookOriginalRectangle;
        private Rectangle txtSearchBookOriginalRectangle;
        private Rectangle txtReplaceCustomerNameOriginalRectangle;
        private Rectangle txtLabelAddReplaceCustomerNameOriginalRectangle;
        private Rectangle txtReplaceBookPriceOriginalRectangle;
        private Rectangle txtLabelBookPriceOriginalRectangle;
        private Rectangle txtReplaceBookStockOriginalRectangle;
        private Rectangle txtReplaceBookPublisherOriginalRectangle;
        private Rectangle txtLabelBookStockOriginalRectangle;
        private Rectangle txtLabelBookPublisherOriginalRectangle;
        private Rectangle txtReplaceBookYearOfPublicationOriginalRectangle;
        private Rectangle txtReplaceBookAuthorOriginalRectangle;
        private Rectangle txtLabelYearOfPubOriginalRectangle;
        private Rectangle txtBookAuthorOriginalRectangle;
        private Rectangle txtReplaceBookTitleOriginalRectangle;
        private Rectangle txtReplaceBookISBNOriginalRectangle;
        private Rectangle txtLabelISBNOriginalRectangle;
        private Rectangle txtLabelTitleOriginalRectangle;
        private Rectangle btnSearchCustomerOriginalRectangle;
        private Rectangle btnResetCustomerSearchOriginalRectangle;
        private Rectangle txtSearchCustomerOriginalRectangle;
        private Rectangle txtLabelSearchCustomerOriginalRectangle;
        private Rectangle cmbSearchCatCustomerOriginalRectangle;
        private Rectangle txtLabelCustomerSearchTypeOriginalRectangle;


        //Initilises the form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Define original element location and size
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            btnSellBookOriginalRectangle = new Rectangle(btnSellBook.Location.X, btnSellBook.Location.Y, btnSellBook.Width, btnSellBook.Height);
            btnChangeBookOriginalRectangle = new Rectangle(btnChangeBook.Location.X, btnChangeBook.Location.Y, btnChangeBook.Width, btnChangeBook.Height);
            btnRemoveBookOriginalRectangle = new Rectangle(btnRemoveBook.Location.X, btnRemoveBook.Location.Y, btnRemoveBook.Width, btnRemoveBook.Height);
            dgvBookListOriginalRectangle = new Rectangle(dgvBookList.Location.X, dgvBookList.Location.Y, dgvBookList.Width, dgvBookList.Height);
            dgvCustomerInformationOriginalRectangle = new Rectangle(dgvCustomerInformation.Location.X, dgvCustomerInformation.Location.Y, dgvCustomerInformation.Width, dgvCustomerInformation.Height);
            txtBookStockCustomerWantsOriginalRectangle = new Rectangle(txtBookStockCustomerWants.Location.X, txtBookStockCustomerWants.Location.Y, txtBookStockCustomerWants.Width, txtBookStockCustomerWants.Height);
            btnSearchBookOriginalRectangle = new Rectangle(btnSearchBook.Location.X, btnSearchBook.Location.Y, btnSearchBook.Width, btnSearchBook.Height);
            btnResetBookSearchOriginalRectangle = new Rectangle(btnResetBookSearch.Location.X, btnResetBookSearch.Location.Y, btnResetBookSearch.Width, btnResetBookSearch.Height);
            btnChangeCustomerInformationOriginalRectangle = new Rectangle(btnChangeCustomerInformation.Location.X, btnChangeCustomerInformation.Location.Y, btnResetBookSearch.Width, btnChangeCustomerInformation.Height);
            btnRemoveCustomerOriginalRectangle = new Rectangle(btnRemoveCustomer.Location.X, btnRemoveCustomer.Location.Y, btnRemoveCustomer.Width, btnRemoveCustomer.Height);
            txtReplaceCustomerPhoneNumberOriginalRectangle = new Rectangle(txtReplaceCustomerPhoneNumber.Location.X, txtReplaceCustomerPhoneNumber.Location.Y, txtReplaceCustomerPhoneNumber.Width, txtReplaceCustomerPhoneNumber.Height);
            txtLabelAddReplaceCustomePhoneOriginalRectangle = new Rectangle(txtLabelAddReplaceCustomePhone.Location.X, txtLabelAddReplaceCustomePhone.Location.Y, txtLabelAddReplaceCustomePhone.Width, txtLabelAddReplaceCustomePhone.Height);
            txtReplaceCustomerLastNameOriginalRectangle = new Rectangle(txtReplaceCustomerLastName.Location.X, txtReplaceCustomerLastName.Location.Y, txtReplaceCustomerLastName.Width, txtReplaceCustomerLastName.Height);
            txtLabelCustomerLastNameOriginalRectangle = new Rectangle(txtLabelCustomerLastName.Location.X, txtLabelCustomerLastName.Location.Y, txtLabelCustomerLastName.Width, txtLabelCustomerLastName.Height);
            cmbSearchCatBookOriginalRectangle = new Rectangle(cmbSearchCatBook.Location.X, cmbSearchCatBook.Location.Y, cmbSearchCatBook.Width, cmbSearchCatBook.Height);
            txtSearchBookOriginalRectangle = new Rectangle(txtSearchBook.Location.X, txtSearchBook.Location.Y, txtSearchBook.Width, txtSearchBook.Height);
            txtReplaceCustomerNameOriginalRectangle = new Rectangle(txtReplaceCustomerName.Location.X, txtReplaceCustomerName.Location.Y, txtReplaceCustomerName.Width, txtReplaceCustomerName.Height);
            txtLabelAddReplaceCustomerNameOriginalRectangle = new Rectangle(txtLabelAddReplaceCustomerName.Location.X, txtLabelAddReplaceCustomerName.Location.Y, txtLabelAddReplaceCustomerName.Width, txtLabelAddReplaceCustomerName.Height);
            txtReplaceBookPriceOriginalRectangle = new Rectangle(txtReplaceBookPrice.Location.X, txtReplaceBookPrice.Location.Y, txtReplaceBookPrice.Width, txtReplaceBookPrice.Height);
            txtLabelBookPriceOriginalRectangle = new Rectangle(txtLabelBookPrice.Location.X, txtLabelBookPrice.Location.Y, txtLabelBookPrice.Width, txtLabelBookPrice.Height);
            txtReplaceBookStockOriginalRectangle = new Rectangle(txtReplaceBookStock.Location.X, txtReplaceBookStock.Location.Y, txtReplaceBookStock.Width, txtReplaceBookStock.Height);
            txtReplaceBookPublisherOriginalRectangle = new Rectangle(txtReplaceBookPublisher.Location.X, txtReplaceBookPublisher.Location.Y, txtReplaceBookPublisher.Width, txtReplaceBookPublisher.Height);
            txtLabelBookStockOriginalRectangle = new Rectangle(txtLabelBookStock.Location.X, txtLabelBookStock.Location.Y, txtLabelBookStock.Width, txtLabelBookStock.Height);
            txtLabelBookPublisherOriginalRectangle = new Rectangle(txtLabelBookPublisher.Location.X, txtLabelBookPublisher.Location.Y, txtLabelBookPublisher.Width, txtLabelBookPublisher.Height);
            txtReplaceBookYearOfPublicationOriginalRectangle = new Rectangle(txtReplaceBookYearOfPublication.Location.X, txtReplaceBookYearOfPublication.Location.Y, txtReplaceBookYearOfPublication.Width, txtReplaceBookYearOfPublication.Height);
            txtReplaceBookAuthorOriginalRectangle = new Rectangle(txtReplaceBookAuthor.Location.X, txtReplaceBookAuthor.Location.Y, txtReplaceBookAuthor.Width, txtReplaceBookAuthor.Height);
            txtLabelYearOfPubOriginalRectangle = new Rectangle(txtLabelYearOfPub.Location.X, txtLabelYearOfPub.Location.Y, txtLabelYearOfPub.Width, txtLabelYearOfPub.Height);
            txtBookAuthorOriginalRectangle = new Rectangle(txtBookAuthor.Location.X, txtBookAuthor.Location.Y, txtBookAuthor.Width, txtBookAuthor.Height);
            txtReplaceBookTitleOriginalRectangle = new Rectangle(txtReplaceBookTitle.Location.X, txtReplaceBookTitle.Location.Y, txtReplaceBookTitle.Width, txtReplaceBookTitle.Height);
            txtReplaceBookISBNOriginalRectangle = new Rectangle(txtReplaceBookISBN.Location.X, txtReplaceBookISBN.Location.Y, txtReplaceBookISBN.Width, txtReplaceBookISBN.Height);
            txtLabelISBNOriginalRectangle = new Rectangle(txtLabelISBN.Location.X, txtLabelISBN.Location.Y, txtLabelISBN.Width, txtLabelISBN.Height);
            txtLabelTitleOriginalRectangle = new Rectangle(txtLabelTitle.Location.X, txtLabelTitle.Location.Y, txtLabelTitle.Width, txtLabelTitle.Height);
            btnSearchCustomerOriginalRectangle = new Rectangle(btnSearchCustomer.Location.X, btnSearchCustomer.Location.Y, btnSearchCustomer.Width, btnSearchCustomer.Height);
            btnResetCustomerSearchOriginalRectangle = new Rectangle(btnResetCustomerSearch.Location.X, btnResetCustomerSearch.Location.Y, btnResetCustomerSearch.Width, btnResetCustomerSearch.Height);
            txtSearchCustomerOriginalRectangle = new Rectangle(txtSearchCustomer.Location.X, txtSearchCustomer.Location.Y, txtSearchCustomer.Width, txtSearchCustomer.Height);
            txtLabelSearchCustomerOriginalRectangle = new Rectangle(txtLabelSearchCustomer.Location.X, txtLabelSearchCustomer.Location.Y, txtLabelSearchCustomer.Width, txtLabelSearchCustomer.Height);
            cmbSearchCatCustomerOriginalRectangle = new Rectangle(cmbSearchCatCustomer.Location.X, cmbSearchCatCustomer.Location.Y, cmbSearchCatCustomer.Width, cmbSearchCatCustomer.Height);
            txtLabelCustomerSearchTypeOriginalRectangle = new Rectangle(txtLabelCustomerSearchType.Location.X, txtLabelCustomerSearchType.Location.Y, txtLabelCustomerSearchType.Width, txtLabelCustomerSearchType.Height);

            ReadData();

            cmbSearchCatCustomer.SelectedIndex = 0;
            cmbSearchCatBook.SelectedIndex = 0;
        }

        //Updates both data grid views with no search functions
        private void ReadData()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            string commandTextBookList = "Select * From BookList";
            string commandTextCustomerInformation = "Select * From CustomerList";

            var datatableBooks = new DataTable();
            var datatableCustomerInformation = new DataTable();


            SQLiteDataAdapter myDataAdapterBooks = new SQLiteDataAdapter(commandTextBookList, sqlConnection);
            SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);

            //Open the connection to the database
            sqlConnection.Open();
            myDataAdapterBooks.Fill(datatableBooks);
            myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);
            sqlConnection.Close();

            dgvBookList.DataSource = datatableBooks;
            dgvCustomerInformation.DataSource = datatableCustomerInformation;
        }

        //Function that adds the customer information to the customer information text boxes when a record is clicked
        private void dgvCustomerInformation_SelectionChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            if (dgvCustomerInformation.SelectedRows.Count > 0)
            {
                selectedCustomerID = dgvCustomerInformation.SelectedRows[0].Cells[0].Value.ToString();

                string commandTextCustomerInformation = "SELECT * FROM CustomerList WHERE customerID=" + selectedCustomerID;

                var datatableCustomerInformation = new DataTable();
                SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);

                sqlConnection.Open();

                myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);

                txtReplaceCustomerName.Text = datatableCustomerInformation.Rows[0]["customerFirstName"].ToString();
                txtReplaceCustomerLastName.Text = datatableCustomerInformation.Rows[0]["customerLastName"].ToString();
                txtReplaceCustomerPhoneNumber.Text = datatableCustomerInformation.Rows[0]["customerPhoneNumber"].ToString();

                sqlConnection.Close();
            }

        }

        //Function that adds a customer to the database
        private void InsertCustomer()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            SQLiteCommand sqlCommandInsertCustomerInformation = new SQLiteCommand();

            sqlCommandInsertCustomerInformation.Connection = sqlConnection;
            sqlCommandInsertCustomerInformation.CommandType = CommandType.Text;
            sqlCommandInsertCustomerInformation.CommandText = "INSERT into CustomerList (customerFirstName, customerLastName, customerPhoneNumber) values(@customerFirstName, @customerLastName, @customerPhoneNumber)";
            sqlCommandInsertCustomerInformation.Parameters.AddWithValue("@customerFirstName", txtReplaceCustomerName.Text);
            sqlCommandInsertCustomerInformation.Parameters.AddWithValue("@customerLastName", txtReplaceCustomerLastName.Text);
            sqlCommandInsertCustomerInformation.Parameters.AddWithValue("@customerPhoneNumber", txtReplaceCustomerPhoneNumber.Text);


            sqlConnection.Open();
            sqlCommandInsertCustomerInformation.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your Data is saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);



            string commandTextCustomerInformation = "Select * From CustomerList";
            var datatableCustomerInformation = new DataTable();
            SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);
            sqlConnection.Open();
            myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);
            sqlConnection.Close();
            dgvCustomerInformation.DataSource = datatableCustomerInformation;
        }

        //Function that updates the record of the customer that is selected
        private void UpdateCustomerRecord()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            SQLiteCommand sqlCommandChangeCustomerInformation = new SQLiteCommand();

            sqlCommandChangeCustomerInformation.Connection = sqlConnection;
            sqlCommandChangeCustomerInformation.CommandType = CommandType.Text;
            sqlCommandChangeCustomerInformation.CommandText = "UPDATE CustomerList SET customerFirstName=@customerFirstName, customerLastName=@customerLastName, customerPhoneNumber=@customerPhoneNumber WHERE customerID=@customerID";

            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@customerFirstName", txtReplaceCustomerName.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@customerLastName", txtReplaceCustomerLastName.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@customerPhoneNumber", txtReplaceCustomerPhoneNumber.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@customerID", selectedCustomerID);

            sqlConnection.Open();
            sqlCommandChangeCustomerInformation.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your Customer data is updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string commandTextCustomerInformation = "Select * From CustomerList";
            var datatableCustomerInformation = new DataTable();
            SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);
            sqlConnection.Open();
            myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);
            sqlConnection.Close();
            dgvCustomerInformation.DataSource = datatableCustomerInformation;

        }

        //Button that checks if the entered customer details is updating an existing record or adding a new one
        private void BtnChangeCustomerInformation_Click(object sender, EventArgs e)
        {
            if (dgvCustomerInformation.SelectedRows.Count > 0)
            {
                selectedCustomerID = dgvCustomerInformation.SelectedRows[0].Cells[0].Value.ToString();
                UpdateCustomerRecord();
            }
            else
            {
                InsertCustomer();
            }
        }

        //Button that removes the selected customer from the database
        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this customer?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = bookList.db";


                SQLiteCommand sqlCommandDeleteCustomer = new SQLiteCommand();


                sqlCommandDeleteCustomer.Connection = sqlConnection;
                sqlCommandDeleteCustomer.CommandType = CommandType.Text;
                sqlCommandDeleteCustomer.CommandText = "DELETE FROM CustomerList WHERE customerID=@customerID";
                sqlCommandDeleteCustomer.Parameters.AddWithValue("@customerID", selectedCustomerID);

                sqlConnection.Open();
                sqlCommandDeleteCustomer.ExecuteNonQuery();
                sqlConnection.Close();


                string commandTextCustomerInformation = "Select * From CustomerList";
                var datatableCustomerInformation = new DataTable();
                SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);
                sqlConnection.Open();
                myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);
                sqlConnection.Close();
                dgvCustomerInformation.DataSource = datatableCustomerInformation;

            }
        }

        //Button that searches the customer database based on the provided query
        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            string commandTextSearchCustomer = "Select * FROM CustomerList WHERE " + cmbSearchCatCustomer.Text + " LIKE'%" + txtSearchCustomer.Text + "%'";



            var datatable = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandTextSearchCustomer, sqlConnection);

            sqlConnection.Open();
            myDataAdapter.Fill(datatable);
            sqlConnection.Close();

            dgvCustomerInformation.DataSource = datatable;

            if (dgvCustomerInformation.Rows.Count <= 1)
            {
                MessageBox.Show("There are no customers with this information.");
            }
        }

        //Button that resets the customer searching query
        private void btnResetCustomerSearch_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            string commandTextCustomerInformation = "Select * From CustomerList";

            var datatableCustomerInformation = new DataTable();

            SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);

            sqlConnection.Open();
            myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);

            dgvCustomerInformation.DataSource = datatableCustomerInformation;

            cmbSearchCatCustomer.SelectedIndex = 0;
            txtSearchCustomer.Text = "";
        }

        //Function that adds the book information to the book information text boxes when a record is clicked
        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            if (dgvBookList.SelectedRows.Count > 0)
            {
                selectedBookISBN = dgvBookList.SelectedRows[0].Cells[0].Value.ToString();

                string commandTextBookList = "SELECT * FROM BookList WHERE ISBN=" + selectedBookISBN;

                var datatableBookList = new DataTable();
                SQLiteDataAdapter myDataAdapterBookList = new SQLiteDataAdapter(commandTextBookList, sqlConnection);

                sqlConnection.Open();

                myDataAdapterBookList.Fill(datatableBookList);

                txtReplaceBookISBN.Text = datatableBookList.Rows[0]["ISBN"].ToString();
                txtReplaceBookTitle.Text = datatableBookList.Rows[0]["bookTitle"].ToString();
                txtReplaceBookAuthor.Text = datatableBookList.Rows[0]["bookAuthor"].ToString();
                txtReplaceBookYearOfPublication.Text = datatableBookList.Rows[0]["bookYearOfPublication"].ToString();
                txtReplaceBookPublisher.Text = datatableBookList.Rows[0]["bookPublisher"].ToString();
                txtReplaceBookStock.Text = datatableBookList.Rows[0]["bookStock"].ToString();
                txtReplaceBookPrice.Text = datatableBookList.Rows[0]["bookPrice"].ToString();

                sqlConnection.Close();
            }
        }

        //Function that updates the record of the book that is selected
        private void UpdateBookRecord()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            SQLiteCommand sqlCommandChangeCustomerInformation = new SQLiteCommand();

            sqlCommandChangeCustomerInformation.Connection = sqlConnection;
            sqlCommandChangeCustomerInformation.CommandType = CommandType.Text;
            sqlCommandChangeCustomerInformation.CommandText = "UPDATE BookList SET ISBN=@ISBN, bookTitle=@bookTitle, bookAuthor=@bookAuthor, bookYearOfPublication=@bookYearOfPublication, bookPublisher=@bookPublisher, bookStock=@bookStock, bookPrice=@bookPrice WHERE ISBN=@ISBN";
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@ISBN", txtReplaceBookISBN.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookTitle", txtReplaceBookTitle.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookAuthor", txtReplaceBookAuthor.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookYearOfPublication", txtReplaceBookYearOfPublication.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookPublisher", txtReplaceBookPublisher.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookStock", txtReplaceBookStock.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookPrice", txtReplaceBookPrice.Text);


            sqlConnection.Open();
            sqlCommandChangeCustomerInformation.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your Book data is updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string commandTextBookList = "Select * From BookList";
            var datatableBooks = new DataTable();
            SQLiteDataAdapter myDataAdapterBooks = new SQLiteDataAdapter(commandTextBookList, sqlConnection);
            sqlConnection.Open();
            myDataAdapterBooks.Fill(datatableBooks);
            dgvBookList.DataSource = datatableBooks;
        }

        //Button that checks if the entered book is updating an existing book or adding a new one
        private void btnChangeBook_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                selectedBookISBN = dgvBookList.SelectedRows[0].Cells[0].Value.ToString();
                UpdateBookRecord();
            }
            else
            {
                InsertBook();
            }
        }

        //Function that adds a book to the database
        private void InsertBook()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            SQLiteCommand sqlCommandInsertBookInformation = new SQLiteCommand();

            sqlCommandInsertBookInformation.Connection = sqlConnection;
            sqlCommandInsertBookInformation.CommandType = CommandType.Text;
            sqlCommandInsertBookInformation.CommandText = "INSERT into BookList (ISBN, bookTitle, bookAuthor, bookYearOfPublication, bookPublisher, bookStock, bookPrice) values(@ISBN, @bookTitle, @bookAuthor, @bookYearOfPublication, @bookPublisher, @bookStock, @bookPrice)";
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@ISBN", txtReplaceBookISBN.Text);
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@bookTitle", txtReplaceBookTitle.Text);
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@bookAuthor", txtReplaceBookAuthor.Text);
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@bookYearOfPublication", txtReplaceBookYearOfPublication.Text);
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@bookPublisher", txtReplaceBookPublisher.Text);
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@bookStock", txtReplaceBookStock.Text);
            sqlCommandInsertBookInformation.Parameters.AddWithValue("@bookPrice", txtReplaceBookPrice.Text);


            sqlConnection.Open();
            sqlCommandInsertBookInformation.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your Data is saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string commandTextBookList = "Select * From BookList";
            var datatableBooks = new DataTable();
            SQLiteDataAdapter myDataAdapterBooks = new SQLiteDataAdapter(commandTextBookList, sqlConnection);
            sqlConnection.Open();
            myDataAdapterBooks.Fill(datatableBooks);
            dgvBookList.DataSource = datatableBooks;
        }

        //Button that removes the selected book from the database
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this book from the database?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = bookList.db";


                SQLiteCommand sqlCommandDeleteCustomer = new SQLiteCommand();


                sqlCommandDeleteCustomer.Connection = sqlConnection;
                sqlCommandDeleteCustomer.CommandType = CommandType.Text;
                sqlCommandDeleteCustomer.CommandText = "DELETE FROM BookList WHERE ISBN=@ISBN";
                sqlCommandDeleteCustomer.Parameters.AddWithValue("@ISBN", selectedBookISBN);

                sqlConnection.Open();
                sqlCommandDeleteCustomer.ExecuteNonQuery();
                sqlConnection.Close();


                string commandTextBookList = "Select * From BookList";
                var datatableBooks = new DataTable();
                SQLiteDataAdapter myDataAdapterBooks = new SQLiteDataAdapter(commandTextBookList, sqlConnection);
                sqlConnection.Open();
                myDataAdapterBooks.Fill(datatableBooks);
                dgvBookList.DataSource = datatableBooks;
            }
        }

        //Button that searches the book database based on the provided query
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            string commandTextSearchBook = "Select * FROM BookList WHERE " + cmbSearchCatBook.Text + " LIKE'%" + txtSearchBook.Text + "%'";


            var datatable = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandTextSearchBook, sqlConnection);

            sqlConnection.Open();
            myDataAdapter.Fill(datatable);
            sqlConnection.Close();

            dgvBookList.DataSource = datatable;

            if (dgvBookList.Rows.Count <= 1)
            {
                MessageBox.Show("There are no books with this information.");
                txtSearchBook.Clear();
            }
        }

        //Button that resets the book searching query
        private void btnResetBookSearch_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            string commandTextBookInformation = "Select * From BookList";

            var datatableBookInformation = new DataTable();

            SQLiteDataAdapter myDataAdapterBookInformation = new SQLiteDataAdapter(commandTextBookInformation, sqlConnection);

            sqlConnection.Open();
            myDataAdapterBookInformation.Fill(datatableBookInformation);

            dgvBookList.DataSource = datatableBookInformation;

            cmbSearchCatBook.SelectedIndex = 0;
            txtSearchBook.Text = "";

        }

        //Button that sells the book to the customer
        private void btnSellBook_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            int wantedStock;
            int totalStock;
            string finalStock;
            double totalCost;
            
            StreamWriter sw = new StreamWriter("PastSales.txt", true);

            totalStock = Convert.ToInt32(txtReplaceBookStock.Text);
            if (txtBookStockCustomerWants.Text == "")
            {
                MessageBox.Show("Please enter the quantity of books being sold.");
            }
            else
            {
                wantedStock = Convert.ToInt32(txtBookStockCustomerWants.Text);
                if (txtReplaceCustomerName.Text != "")
                {

                    if (totalStock >= wantedStock)
                    {

                        string bookCost = txtReplaceBookPrice.Text;
                        bookCost = bookCost.Substring(1);
                        Convert.ToDouble(bookCost);

                        totalCost = Convert.ToDouble(wantedStock) * Convert.ToDouble(bookCost);
                        totalStock -= wantedStock;
                        finalStock = Convert.ToString(totalStock);
                        txtReplaceBookStock.Text = finalStock;


                        string customerName = Convert.ToString(txtReplaceCustomerName.Text);
                        string customerLastName = Convert.ToString(txtReplaceCustomerLastName.Text);
                        string bookTitle = Convert.ToString(txtReplaceBookTitle.Text);


                        int totalCostTwoDecimal = totalCost.ToString().Split('.').Count() > 1 ? totalCost.ToString().Split('.').ToList().ElementAt(1).Length : 0;

                        if (totalCostTwoDecimal == 0)
                        {
                            MessageBox.Show(customerName + " " + customerLastName + " wants to buy " + wantedStock + " copies of the book " + bookTitle + ". The final price is $" + totalCost + ".00");

                        }
                        else if (totalCostTwoDecimal == 1)
                        {
                            MessageBox.Show(customerName + " " + customerLastName + " wants to buy " + wantedStock + " copies of the book " + bookTitle + ". The final price is $" + totalCost + "0");

                        }
                        else if (totalCostTwoDecimal == 2)
                        {
                            MessageBox.Show(customerName + " " + customerLastName + " wants to buy " + wantedStock + " copies of the book " + bookTitle + ". The final price is $" + totalCost);
                        }
                        






                        txtBookStockCustomerWants.Text = "";


                      

                        
                        sw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd ") + "-  " + customerName + " " + customerLastName + " wants to buy " + wantedStock + " copies of the book " + bookTitle + ". The final price is $" + totalCost);
                        sw.Close();

                        UpdateBookRecord();

                        if (dgvCustomerInformation.SelectedRows.Count > 0)
                        {
                            selectedCustomerID = dgvCustomerInformation.SelectedRows[0].Cells[0].Value.ToString();
                            UpdateCustomerRecord();
                        }
                        else
                        {
                            UpdateCustomerRecord();
                        }


                        ReadData();
                    }
                    else
                    {
                        MessageBox.Show("There are not enough of this book to buy.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer.");
                }
            }
        }

        //Math for the resize location
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        //Calls for resizing
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(btnSellBookOriginalRectangle, btnSellBook);
            resizeControl(btnChangeBookOriginalRectangle, btnChangeBook);
            resizeControl(btnRemoveBookOriginalRectangle, btnRemoveBook);
            resizeControl(dgvBookListOriginalRectangle, dgvBookList);
            resizeControl(dgvCustomerInformationOriginalRectangle, dgvCustomerInformation);
            resizeControl(txtBookStockCustomerWantsOriginalRectangle, txtBookStockCustomerWants); 
            resizeControl(btnSearchBookOriginalRectangle, btnSearchBook);
            resizeControl(btnResetBookSearchOriginalRectangle, btnResetBookSearch);
            resizeControl(btnChangeCustomerInformationOriginalRectangle, btnChangeCustomerInformation);
            resizeControl(btnRemoveCustomerOriginalRectangle, btnRemoveCustomer);
            resizeControl(txtReplaceCustomerPhoneNumberOriginalRectangle, txtReplaceCustomerPhoneNumber);
            resizeControl(txtLabelAddReplaceCustomePhoneOriginalRectangle, txtLabelAddReplaceCustomePhone);
            resizeControl(txtReplaceCustomerLastNameOriginalRectangle, txtReplaceCustomerLastName);
            resizeControl(txtLabelCustomerLastNameOriginalRectangle, txtLabelCustomerLastName);
            resizeControl(cmbSearchCatBookOriginalRectangle, cmbSearchCatBook);
            resizeControl(txtSearchBookOriginalRectangle, txtSearchBook);
            resizeControl(txtReplaceCustomerNameOriginalRectangle, txtReplaceCustomerName);
            resizeControl(txtLabelAddReplaceCustomerNameOriginalRectangle, txtLabelAddReplaceCustomerName);
            resizeControl(txtReplaceBookPriceOriginalRectangle, txtReplaceBookPrice);
            resizeControl(txtLabelBookPriceOriginalRectangle, txtLabelBookPrice);
            resizeControl(txtReplaceBookStockOriginalRectangle, txtReplaceBookStock);
            resizeControl(txtReplaceBookPublisherOriginalRectangle, txtReplaceBookPublisher);
            resizeControl(txtLabelBookStockOriginalRectangle, txtLabelBookStock);
            resizeControl(txtLabelBookPublisherOriginalRectangle, txtLabelBookPublisher);
            resizeControl(txtReplaceBookYearOfPublicationOriginalRectangle, txtReplaceBookYearOfPublication);
            resizeControl(txtReplaceBookAuthorOriginalRectangle, txtReplaceBookAuthor);
            resizeControl(txtLabelYearOfPubOriginalRectangle, txtLabelYearOfPub);
            resizeControl(txtBookAuthorOriginalRectangle, txtBookAuthor);
            resizeControl(txtReplaceBookTitleOriginalRectangle, txtReplaceBookTitle);
            resizeControl(txtReplaceBookISBNOriginalRectangle, txtReplaceBookISBN);
            resizeControl(txtLabelISBNOriginalRectangle, txtLabelISBN);
            resizeControl(txtLabelTitleOriginalRectangle, txtLabelTitle);
            resizeControl(btnSearchCustomerOriginalRectangle, btnSearchCustomer);
            resizeControl(btnResetCustomerSearchOriginalRectangle, btnResetCustomerSearch);
            resizeControl(txtSearchCustomerOriginalRectangle, txtSearchCustomer);
            resizeControl(txtLabelSearchCustomerOriginalRectangle, txtLabelSearchCustomer);
            resizeControl(cmbSearchCatCustomerOriginalRectangle, cmbSearchCatCustomer);
            resizeControl(txtLabelCustomerSearchTypeOriginalRectangle, txtLabelCustomerSearchType);






        }

        //Disallows user to unput anything not allowed into the book price text box
        private void txtReplaceBookPrice_TextChanged(object sender, EventArgs e)
        {
            
            char[] letters = {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '`', '~', '!', '@', '#', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '"', ';', ':', '/', '?', '>', '<', ',', '[', ']', '{', '}'};
            char[] dollar = { '$' };

            bool priceContainsLetter = false; 
            priceContainsLetter = txtReplaceBookPrice.Text.IndexOfAny(letters) >= 0;

            
            if (priceContainsLetter == true)
            {
                MessageBox.Show("Please enter price in form $0.00");
                txtReplaceBookPrice.Text = ("");
                
                priceContainsLetter = false;
            }
        }
    }
}