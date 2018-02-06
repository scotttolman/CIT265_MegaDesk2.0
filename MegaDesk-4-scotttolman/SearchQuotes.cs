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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<material> materialList = Enum.GetValues(typeof(material)).Cast<material>().ToList();
            materialBox.DataSource = materialList;
        }

        private void searchCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quoteList.Items.Clear();
            StreamReader reader = new StreamReader("quotes.txt");
            List<string> orders = new List<string>();
            while (!reader.EndOfStream)
            {
                orders.Add(reader.ReadLine());
            }

            for (int i = 0; i < orders.Count; ++i)
            {
                if (orders[i].Contains(materialBox.Text))
                {
                    quoteList.Items.Add(orders[i]);
                }
            }
        }
    }
}
