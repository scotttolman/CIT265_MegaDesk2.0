using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_4_scotttolman
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("quotes.txt");
            List<string> orders = new List<string>();
            while (!reader.EndOfStream)
            {
                orders.Add(reader.ReadLine());
            }

            for (int i = 0; i < orders.Count; ++i)
            {
                quoteList.Items.Add(orders[i]);
            }
        }

        private void viewCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
