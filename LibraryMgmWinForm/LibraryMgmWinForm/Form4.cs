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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
    
        }

        private void userInfoSaveButton_Click(object sender, EventArgs e)
        {
            

            Program.editUserInfoId = userInfoIDTextBox.Text;
            Program.editUserInfoFName = userInfoFNameTextBox.Text;
            Program.editUserInfoLName = userInfoLNameTextBox.Text;
            Program.editUserInfoDepartment = userInfoDeparmentTextBox.Text;

            MessageBox.Show("Successfully saved");

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Program.showUserInfoId != null)
            {
                userInfoIDTextBox.Text = Program.showUserInfoId;
                userInfoFNameTextBox.Text = Program.showUserInfoFName;
                userInfoLNameTextBox.Text = Program.showUserInfoLName;
                userInfoDeparmentTextBox.Text = Program.showUserInfoDepartment;

                issuedListBox.DataSource = Program.showIssuedItems;
            }
        }

        private void BorrowedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
         



        }

        private void userInfoFNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
