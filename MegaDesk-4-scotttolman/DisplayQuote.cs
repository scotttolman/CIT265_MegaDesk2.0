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
        public DisplayQuote(Desk desk, DeskQuote deskQuote)
        {
            InitializeComponent();

            quoteName.Text = deskQuote.getFirst() + deskQuote.getLast();
            width.Text = desk.getWidth().ToString();
            depth.Text = desk.getDepth().ToString();
            surface.Text = desk.getSurface().ToString();
            drawers.Text = desk.getDrawers().ToString();
            int rush = deskQuote.getRush();
            if (rush == 0)
            {
                rushLabel.Text = "No Rush";
            }
            else
            {
                rushLabel.Text = rush.ToString() + " days";
            }
            cost.Text = deskQuote.calcTotalCost().ToString();

            StreamWriter writer = new StreamWriter("quotes.txt", true);
            writer.WriteLine(quoteName.Text + ',' +  DateTime.Today + ',' + width.Text + ',' +  depth.Text + ',' +  surface.Text + ',' +  drawers.Text + ',' +  rushLabel.Text + ',' +  cost.Text);
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
