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

namespace LibraryMgmWinForm
{
    public partial class Form4 : Form
    {

        string itemToRemove = null;

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


            if (issuedListBox.SelectedIndex >= 0)
            {
                itemToRemove = issuedListBox.Items[issuedListBox.SelectedIndex].ToString();
            }

        }

        private void userInfoFNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userInfoRecieveItemButton_Click(object sender, EventArgs e)
        {
            var temppath = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";
            List<string> templist = File.ReadAllLines(temppath).ToList();

            this.issuedListBox.DataSource = null;

            foreach(string tl in templist.ToArray())
            {

                if (itemToRemove != "")
                {
                    int index = templist.FindIndex(x => x.StartsWith(Program.showUserInfoId));
                    templist.RemoveAt(index);

                    int index2 = Program.showIssuedItems.FindIndex(x => x.StartsWith(itemToRemove));

                    index2 = 1 - index2;


                    for (int i = issuedListBox.Items.Count - 1; i >= 0; --i)
                    {
                        if (issuedListBox.Items[i].ToString().Contains(itemToRemove))
                        {
                            issuedListBox.Items.RemoveAt(i);
                        }
                    }

                    itemToRemove = "";

                    StringBuilder stb = new StringBuilder();
                    foreach (var item in Program.showIssuedItems.ToArray())
                    {

                        Program.showIssuedItems.RemoveAt(index2);

                    }

                    string update = string.Format("{0},{1},{2},{3},{4}", Program.showUserInfoId, Program.showUserInfoLName,
                    Program.showUserInfoFName, Program.showUserInfoDepartment, "[" + stb.ToString().TrimStart(';') + "]");

                    templist.Add(update);

                }
            }
            File.WriteAllLines(temppath, templist);
        }
    }
}
