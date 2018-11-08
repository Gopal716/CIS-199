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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook
    {
        // Backing Fields
        private string _title; // Title String
        private string _author; // Author String
        private string _publisher; // Publisher String
        private int _copyrightYear; // Copyright Year Number
        private string _callNumber; // Call Number String
        private bool _checkedOut; // Checkout Status

        // pre-condition: Pass valid values from TextBoxes to the parameters
        // postcondition: The values from parameters must be passed to backing fields.
        public LibraryBook(string Title, string Author, string Publisher, int CopyrightYear, string CallNumber)
        {
            _title = Title;
            _author = Author;
            _publisher = Publisher;
            _copyrightYear = CopyrightYear;
            _callNumber = CallNumber;
        }
        // Precondition:  None
        // Postcondition: The title is returned
        public string Title
        {
            get
            {
               return _title;
            }
            set
            {
                _title = value;
            }
        }
        // Precondition:  None
        // Postcondition: The author is returned
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        // Precondition:  None
        // Postcondition: The publisher is returned
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }
        // Precondition:  None
        // Postcondition: The copyright year is returned
        public int CopyrightYear
        {
            get
            {
                return _copyrightYear;
            }
            set
            {
                // Precondition: input must be > 0
                // Postcondition: The copyright year is returned
                if (value > 0)
                    _copyrightYear = value;
                else
                    _copyrightYear = 2016;
            }
        }
        // Precondition:  None
        // Postcondition: The call number is returned
        public string CallNumber
        {
            get
            {
                return _callNumber;
            }
            set
            {
                _callNumber = value;
            }
        }

        // sets checkout value to true
        public void CheckOut()
        {
            _checkedOut = true;

        }
        // sets checkout value to false
        public void ReturnToShelf()
        {
            _checkedOut = false;

        }
        // returns status for checkout
        public bool IsCheckedOut()
        {
            bool status;
            status = _checkedOut;           
            return status;
        }

        // returns string in the below format for Details
        public override string ToString()
        {        
            return String.Format("Title: {0}{6}Author: {1}{6}" + "Publisher: {2}{6}Copyright: {3}{6}Call Number: {4}{6}" + 
                "CheckedOut Status: {5}{6}", Title, Author, Publisher, CopyrightYear, CallNumber, IsCheckedOut(),
                System.Environment.NewLine);            
        }
    }
}
