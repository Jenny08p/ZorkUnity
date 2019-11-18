using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zork_Builder
{
    public partial class AddRoom : Form
    {
        public string RoomName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public AddRoom()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            addButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}

