﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Vigils_book
{
    public partial class Form1 : Form
    {
        string selectedCustomerID = "";
        string selectedBookISBN = "";
        string selectedCustomerBookISBN = "";




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();

            cmbSearchCatCustomer.SelectedIndex = 0;
            cmbSearchCatBook.SelectedIndex = 0;
        }

        private void ReadData()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            string commandTextBookList = "Select * From BookList";
            string commandTextCustomerInformation = "Select * From CustomerList";
            string commandTextCustomerBooks = "Select * From CustomerBooks";

            var datatableBooks = new DataTable();
            var datatableCustomerInformation = new DataTable();
            var datatableCustomerBooks = new DataTable();

            
            SQLiteDataAdapter myDataAdapterBooks = new SQLiteDataAdapter(commandTextBookList, sqlConnection);
            SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);
            SQLiteDataAdapter myDataAdapterCustomerBooks = new SQLiteDataAdapter(commandTextCustomerBooks, sqlConnection);

            //Open the connection to the database
            sqlConnection.Open();

            myDataAdapterBooks.Fill(datatableBooks);
            myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);
            myDataAdapterCustomerBooks.Fill(datatableCustomerBooks);
            sqlConnection.Close();
            
            dgvBookList.DataSource = datatableBooks;
            dgvCustomerInformation.DataSource = datatableCustomerInformation;
            dgvCustomerBooks.DataSource = datatableCustomerBooks;
        }



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

        private void UpdateBookRecord()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";

            SQLiteCommand sqlCommandChangeCustomerInformation = new SQLiteCommand();

            sqlCommandChangeCustomerInformation.Connection = sqlConnection;
            sqlCommandChangeCustomerInformation.CommandType = CommandType.Text;
            sqlCommandChangeCustomerInformation.CommandText = "UPDATE BookList SET bookTitle=@bookTitle, bookAuthor=@bookAuthor, bookYearOfPublication=@bookYearOfPublication, bookPublisher=@bookPublisher, bookStock=@bookStock, bookPrice=@bookPrice WHERE ISBN=@ISBN";
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookTitle", txtReplaceBookTitle.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookAuthor", txtReplaceBookAuthor.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookYearOfPublication", txtReplaceBookYearOfPublication.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookPublisher", txtReplaceBookPublisher.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookStock", txtReplaceBookStock.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@bookPrice", txtReplaceBookPrice.Text);
            sqlCommandChangeCustomerInformation.Parameters.AddWithValue("@ISBN", selectedBookISBN);

            sqlConnection.Open();
            sqlCommandChangeCustomerInformation.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your Customer data is updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string commandTextBookList = "Select * From BookList";
            var datatableBooks = new DataTable();
            SQLiteDataAdapter myDataAdapterBooks = new SQLiteDataAdapter(commandTextBookList, sqlConnection);
            sqlConnection.Open();
            myDataAdapterBooks.Fill(datatableBooks);
            dgvBookList.DataSource = datatableBooks;
        }

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

        private void btnSearch_Click(object sender, EventArgs e)
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
            }
        }

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

        private void btnAddCustomerBook_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnectionBookList = new SQLiteConnection();
            SQLiteConnection sqlConnectionCustomerBooksList = new SQLiteConnection();
            SQLiteCommand sqlCommandInsertCustomerBookInformation = new SQLiteCommand();

            sqlConnectionBookList.ConnectionString = "DataSource = bookList.db";
            sqlConnectionCustomerBooksList.ConnectionString = "DataSource = bookList.db";


            sqlCommandInsertCustomerBookInformation.Connection = sqlConnectionCustomerBooksList;
            sqlCommandInsertCustomerBookInformation.CommandType = CommandType.Text;
            sqlCommandInsertCustomerBookInformation.CommandText = "INSERT into CustomerBooks (ISBN, bookTitle, bookAuthor, bookYearOfPublication, bookPublisher, bookStockWanted, bookPrice) values(@ISBN, @bookTitle, @bookAuthor, @bookYearOfPublication, @bookPublisher, @bookStockWanted, @bookPrice)";
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@ISBN", txtReplaceBookISBN.Text);
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@bookTitle", txtReplaceBookTitle.Text);
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@bookAuthor", txtReplaceBookAuthor.Text);
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@bookYearOfPublication", txtReplaceBookYearOfPublication.Text);
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@bookPublisher", txtReplaceBookPublisher.Text);
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@bookStockWanted", txtCustomerStockWanted.Text);
            sqlCommandInsertCustomerBookInformation.Parameters.AddWithValue("@bookPrice", txtReplaceBookPrice.Text);

            int wantedStock;
            int totalStock;
            string finalStock;
            int.TryParse(txtReplaceBookStock.Text, out totalStock);

            if (int.TryParse(txtCustomerStockWanted.Text, out wantedStock))
            {
                if (wantedStock < totalStock)
                {
                    sqlConnectionCustomerBooksList.Open();
                    sqlCommandInsertCustomerBookInformation.ExecuteNonQuery();
                    sqlConnectionCustomerBooksList.Close();

                    totalStock -= wantedStock;
                    finalStock = Convert.ToString(totalStock);


                    txtReplaceBookStock.Text = finalStock;
                    UpdateBookRecord();


                    string commandTextBookList = "Select * From BookList";
                    string commandTextCustomerBooks = "Select * From CustomerBooks";
                    var datatableBookList = new DataTable();
                    var datatableCustomerBooks = new DataTable();
                    SQLiteDataAdapter myDataAdapterBookList = new SQLiteDataAdapter(commandTextBookList, sqlConnectionBookList);
                    SQLiteDataAdapter myDataAdapterCustomerBooks = new SQLiteDataAdapter(commandTextCustomerBooks, sqlConnectionCustomerBooksList);
                    myDataAdapterBookList.Fill(datatableBookList);
                    myDataAdapterCustomerBooks.Fill(datatableCustomerBooks);
                    dgvBookList.DataSource = datatableBookList;
                    dgvCustomerBooks.DataSource = datatableCustomerBooks;
                }
                else
                {
                    MessageBox.Show("There are not enough of this book.");
                }
            }
            else
            {
                MessageBox.Show("Book amount not valid.");
            }
        }

        private void btnRemoveCustomerBook_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Are you sure you want to remove this book?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                { /*
                    int currentStock = Convert.ToInt32(txtReplaceBookStock.Text);
                    int customerStockToReturn = Convert.ToInt32(txtCustomerStockWanted.Text);

                    int finalStock = currentStock + customerStockToReturn;

                    txtReplaceBookStock.Text = Convert.ToString(finalStock);
                    */


                    /*
                    SQLiteConnection sqlConnection = new SQLiteConnection();
                    sqlConnection.ConnectionString = "DataSource = bookList.db";

                    SQLiteCommand sqlCommandAddBooksBackToBookList = new SQLiteCommand();
                    SQLiteCommand sqlCommandRemoveBookFromCustomer = new SQLiteCommand();


                    UpdateBookRecord();


                    sqlCommandRemoveBookFromCustomer.Connection = sqlConnection;
                    sqlCommandRemoveBookFromCustomer.CommandType = CommandType.Text;
                    sqlCommandRemoveBookFromCustomer.CommandText = "DELETE FROM CustomerBooks WHERE ISBN=@ISBN";
                    sqlCommandRemoveBookFromCustomer.Parameters.AddWithValue("@ISBN", selectedCustomerBookISBN);


                    sqlConnection.Open();
                    sqlCommandAddBooksBackToBookList.ExecuteNonQuery();
                    sqlConnection.Close();


                    ReadData();
                    */
                }


                int currentStock = Convert.ToInt32(txtReplaceBookStock.Text);
                int customerStockToReturn = Convert.ToInt32(txtCustomerStockWanted.Text);

                int totalStock = currentStock + customerStockToReturn;

                txtReplaceBookStock.Text = totalStock.ToString();



            }







        }

        private void btnSellBooks_Click(object sender, EventArgs e)
        {
            {
                /*
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = bookList.db";


                string commandTextCustomerInformation = "Select * From CustomerList";
                string commandTextCustomerBooks = "Select * From CustomerBooks";
                string commandTextPastSales = "Select * From PastSales";




                var datatableCustomerInformation = new DataTable();
                var datatableCustomerBooks = new DataTable();
                var datatablePastSales = new DataTable();

                SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);
                SQLiteDataAdapter myDataAdapterCustomerBooks = new SQLiteDataAdapter(commandTextCustomerBooks, sqlConnection);
                SQLiteDataAdapter myDataAdapterPastSales = new SQLiteDataAdapter(commandTextPastSales, sqlConnection);

                myDataAdapterCustomerInformation.Fill(datatableCustomerInformation);
                myDataAdapterCustomerBooks.Fill(datatableCustomerBooks);
                myDataAdapterPastSales.Fill(datatablePastSales);

                dgvCustomerInformation.DataSource = datatableCustomerInformation;
                dgvCustomerBooks.DataSource = datatableCustomerBooks;
                */
            }

            { 
            /*
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            selectedCustomerID = dgvCustomerInformation.SelectedRows[0].Cells[0].Value.ToString();

            string commandTextCustomerInformation = "SELECT * FROM CustomerList WHERE customerID=" + selectedCustomerID;
            string commandTextCustomerBooks = "SELECT * FROM CustomerBooks WHERE ISBN=@ISBN";

            var datatableCustomerBooks = new DataTable();
            var datatableCustomerInformation = new DataTable();

            SQLiteDataAdapter myDataAdapterCustomerInformation = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);
            SQLiteDataAdapter myDataAdapterCustomerBooks = new SQLiteDataAdapter(commandTextCustomerInformation, sqlConnection);

            sqlConnection.Open();

            myDataAdapterCustomerInformation.Fill(datatableCustomerBooks);

            string customerFirstName = datatableCustomerInformation.Rows[0]["customerFirstName"].ToString();
            string customerLasName = datatableCustomerInformation.Rows[0]["customerLastName"].ToString();
            string bookTitle = datatableCustomerInformation.Rows[0][""].ToString();

            sqlConnection.Close();
            */
        }


        

            var textFileForSoldBooks = new StringBuilder();

            for(int i = 0;  i < dgvCustomerBooks.Rows.Count - 1; i++)
            {
                string line = "";
                for (int j = 0; j < dgvCustomerBooks.Columns.Count; j++)
                {
                    line += dgvCustomerBooks.Rows[i].Cells[j].Value.ToString() + "\t" + "|";
                }
                textFileForSoldBooks.AppendLine(line);
            }

            string fileName = @"soldBookList";
            System.IO.File.WriteAllText(fileName, textFileForSoldBooks.ToString());

        }

        private void dgvCustomerBooks_SelectionChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = bookList.db";


            if (dgvCustomerBooks.SelectedRows.Count > 0)
            {
                selectedCustomerBookISBN = dgvCustomerBooks.SelectedRows[0].Cells[0].Value.ToString();

                string commandTextCustomerBooks = "SELECT * FROM CustomerBooks WHERE ISBN=" + selectedCustomerBookISBN;

                var datatableCustomerBooks = new DataTable();
                SQLiteDataAdapter myDataAdapterBookList = new SQLiteDataAdapter(commandTextCustomerBooks, sqlConnection);

                sqlConnection.Open();

                myDataAdapterBookList.Fill(datatableCustomerBooks);

                txtCustomerStockWanted.Text = datatableCustomerBooks.Rows[0]["bookStockWanted"].ToString();

                sqlConnection.Close();
            }



        }

    }
}
