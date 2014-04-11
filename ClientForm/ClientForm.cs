using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameTextBox.Text + ", (" + emailTextBox.Text + "): " + phoneTextBox.Text,
                "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
