using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_JosueBenjaminCenturion
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            StartProgram(); 
        }

        public void StartProgram()
        {
            Desk myDesk = new Desk(100, 100, 1, ""); 
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddNewQuoteForm newQuote = new AddNewQuoteForm();
            newQuote.Tag  = this;
            newQuote.Show();
            Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this; 
            viewQuotes.Show();
            Hide(); 
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes(); 
            searchQuotes.Tag = this;
            searchQuotes.Show();
            Hide();
        }
    }
}
