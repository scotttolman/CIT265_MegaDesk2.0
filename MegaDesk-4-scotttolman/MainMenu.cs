using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_scotttolman
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddQuote newQuote = new AddQuote
            {
                Tag = this
            };
            newQuote.Show(this);
            Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes
            {
                Tag = this
            };
            viewAllQuotes.Show(this);
            Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes
            {
                Tag = this
            };
            searchQuotes.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
