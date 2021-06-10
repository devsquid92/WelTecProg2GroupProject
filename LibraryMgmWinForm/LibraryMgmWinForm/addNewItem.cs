using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMgmWinForm
{
    public partial class addNewItem : Form
    {
        public addNewItem()
        {
            InitializeComponent();
        }

        private void addNewItemOkBtn_Click(object sender, EventArgs e)
        {
            Program.newItemName = addNewItemTextBox.Text;
            this.Close();
        }

        private void addNewItemCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewItemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
