using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_scotttolman
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string json)
        {
            InitializeComponent();
                        
            StreamWriter writer = new StreamWriter("quotes.json", true);
            writer.WriteLine(json);
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }
    }
}