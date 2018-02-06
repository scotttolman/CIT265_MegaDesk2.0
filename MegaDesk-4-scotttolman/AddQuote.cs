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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            List<material> materialList = Enum.GetValues(typeof(material)).Cast<material>().ToList();
            materialBox.DataSource = materialList;
        }

        private void ShowMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            if (widthBox.Text.Length == 0)
                return;
            try
            {
                float.TryParse(widthBox.Text, out float width);
                if (width < 24 || width > 96)
                    widthError.Visible = true;                
            } catch (Exception)
            {
                widthError.Visible = true;
            }
        }

        private void depthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsDigit(e.KeyChar))
            {
                depthError.Visible = true;
            }
            else
            {
                depthError.Visible = false;
            }
        }

        private void ShowQuote_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk(float.Parse(widthBox.Text), float.Parse(depthBox.Text), int.Parse(drawerBox.Text),
                (material)materialBox.SelectedItem);

            DeskQuote quote = new DeskQuote(firstNameBox.Text, lastNameBox.Text, desk);

            if ((string)rushBox.SelectedItem != "No Rush")
            {
                int rushVal;
                string rush = (string)rushBox.SelectedItem;
                int.TryParse(rush, out rushVal);
                quote.addRush(rushVal);
            }

            
            DisplayQuote displayQuote = new DisplayQuote(desk, quote)
            {
                Tag = this
            };
            displayQuote.Show(this);
            Hide();
        }
    }
}
