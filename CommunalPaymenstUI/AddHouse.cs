using CPLogic.Model;
using System;
using System.Windows.Forms;

namespace CommunalPaymenstUI
{
    public partial class AddHouse : Form
    {
        public House House { get; set; }
        public AddHouse()
        {
            InitializeComponent();
        }

        private void AddHouseButton_Click(object sender, EventArgs e)
        {
            if (AddressTextBox.Text != "")
            {
                House = new House()
                {
                    Address = AddressTextBox.Text,
                    Name = NameTextBox.Text,
                    IsActive = true
                };
            }

            else
            {
                this.DialogResult = 0;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
