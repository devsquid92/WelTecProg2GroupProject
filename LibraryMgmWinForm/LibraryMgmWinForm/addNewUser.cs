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
    public partial class addNewUser : Form
    {
        public addNewUser()
        {
            InitializeComponent();
        }

        private void addNewUser_Load(object sender, EventArgs e)
        {

        }

        private void addNewUserSaveMgmButton_Click(object sender, EventArgs e)
        {
            Program.newUserId = addIdUserMgmTextBox.Text.ToString();
            Program.newUserFName = addFNameUserMgmTextBox.Text;
            Program.newUserLName = addLNameUserMgmTextBox.Text;
            Program.newUserDept = addDeptUserMgmTextBox.Text;
            this.Close();
        }

        private void addNewUserCancelMgmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addIdUserMgmTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
