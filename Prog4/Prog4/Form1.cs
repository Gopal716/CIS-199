/* Grading ID: B5989
   Program 4
   Due Date: 12/06/2016
   Course Section: CIS-199-75
   Description: This program lets the user add books in a library book list. The user can check
                Details (check out status, author, et.c.) about a book in the list. The user can 
                also check out a book or return a book, the details update as a user does this.
   */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class prog4Form : Form       
    {
      
        public prog4Form()
        {
            InitializeComponent();
        }

        int copyrightInput; // variable to check if copyright Year is int

        List<LibraryBook> bookList = new List<LibraryBook>(); // bookList receives properties/elements from LibraryBook class

        // Precondition: valid data must be entered in all textboxes (int value for copyright Year)
        // Postcondition: Book added successfully, or approriate error message
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxtBox.Text))
            {
                MessageBox.Show("Please, Enter a Title.");
            }
            else if (string.IsNullOrEmpty(authorTxtBox.Text))
            {
                MessageBox.Show("Please, Enter an Author.");
            }
            else if (string.IsNullOrEmpty(publisherTxtBox.Text))
            {
                MessageBox.Show("Please, Enter a Publisher.");
            }
            else if (string.IsNullOrEmpty(copyrightTxtBox.Text))
            {
                MessageBox.Show("Please, Enter Copyright Year.");
            }
            else if (!int.TryParse(copyrightTxtBox.Text, out copyrightInput)) // tests if not int
            {
                MessageBox.Show("Invalid Copyright Year!");
            }
            else if (string.IsNullOrEmpty(callNumTxtBox.Text))
            {
                MessageBox.Show("Please, Enter Call Number.");
            }

            // book gets added to booklist
            else
            {

                LibraryBook newBook = new LibraryBook(titleTxtBox.Text, authorTxtBox.Text, publisherTxtBox.Text, copyrightInput , callNumTxtBox.Text);
                bookList.Add(newBook); // adds new book to booklist
                bookListBox.Items.Clear(); // clears booklistBox
               foreach (var book in bookList)
                {
                    bookListBox.Items.Add(book.Title); // all books to date are displayed in listbox
                }

                MessageBox.Show(titleTxtBox.Text + " has been added to Library!"); // message if book is added

                // all textboxes are cleared after new book is added
                titleTxtBox.Clear();
                authorTxtBox.Clear();
                publisherTxtBox.Clear();
                copyrightTxtBox.Clear();
                callNumTxtBox.Clear();
                               
                }
        }

        // Precondition: booklistBox must have books, a book must be selected
        // Postcondition: details about book is displayed in messagebox
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int bookListCount = bookList.Count(); // counts books in booklist

            // booklist count must be over 0 for a book to be in list
            if (bookListCount > 0)
            {

                int Index = bookListBox.SelectedIndex; // index value of selected book
                
                // index must be > -1 in order for a book to be selected
                if (Index > -1)
                {
                    LibraryBook currentItem = bookList[Index];
                    MessageBox.Show(currentItem.ToString()); // displays details of the book
                }
                else
                {
                    MessageBox.Show("Select Book"); // error message to select book if not selected
                }
            }
            else
            {
                MessageBox.Show("No Books Available!"); // error message if no books in list

            }

        }
        // Precondition: booklistBox must have books, a book must be selected
        // Postcondition: checkout status turns to true
        private void checkOutBtn_Click(object sender, EventArgs e)
        {

            int bookListCount = bookList.Count(); // counts books in booklist
            // booklist count must be over 0 for a book to be in list
            if (bookListCount > 0)
            {
                int Index = bookListBox.SelectedIndex; // index value of selected book
                // index must be > -1 in order for a book to be selected
                if (Index > -1)
                {
                    bookList[Index].CheckOut(); // turns checkout status to true for selected book       

                    MessageBox.Show(bookList[Index].Title + " has been checked out."); // message if checkout success
                }
                else
                {
                    MessageBox.Show("select a book"); // message if no selection
                }
            }
            else
            {
                MessageBox.Show("No books available"); // message if no book in list
            }
        }
        // Precondition: booklistBox must have books, a book must be selected
        // Postcondition: checkout status turns to false
        private void returnBtn_Click(object sender, EventArgs e)
        {
            int bookListCount = bookList.Count(); // counts books in booklist
            
            // booklist count must be over 0 for a book to be in list
            if (bookListCount > 0)
            {
                int Index = bookListBox.SelectedIndex; // index value of selected book
                // index must be > -1 in order for a book to be selected
                if (Index > -1)
                {
                    bookList[Index].ReturnToShelf(); // turns checkout status to false for selected book
                   
                    MessageBox.Show(bookList[Index].Title + " has been returned."); // message if book return is success.
                }
                else
                {
                    MessageBox.Show("select a book"); // message if no selection
                }
            }
            else
            {
                MessageBox.Show("No books available"); // message if no books in list
            }
        }
       
    }
}
