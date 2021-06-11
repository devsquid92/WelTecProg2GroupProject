using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LibraryMgmWinForm
{
    public partial class UserReport : Form
    {
        SortedDictionary<string, Users> userInfo = new SortedDictionary<string, Users>();
        static string[] headings = new string[5];

        Users selectedUser = new Users();

        public UserReport()
        {
            InitializeComponent();



            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (line.StartsWith("ID"))
                    headings = line.Split(',');

                else
                {
                    string[] info = line.Split(',');


                   
                    userInfo.Add(string.Format("{0} , {1}", info[0], info[1]), new Users
                    {
                        Id = Int32.Parse(info[0]),
                        LastName = info[1],
                        FirstName = info[2],
                        Department = info[3],
                        issItems = info[4]

                    });

                }
            }

            refreshForm();
        }

        private void refreshForm()
        {
            displayUserInUserListBox();
        }

        private void displayUserInUserListBox()
        {

            userMgmtListBox.DataSource = new BindingSource(userInfo, null);
            userMgmtListBox.ValueMember = "Key";

        }


        private void userMgmtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
     

            if (userInfo.ContainsKey(userMgmtListBox.SelectedValue.ToString()))
                selectedUser = userInfo[userMgmtListBox.SelectedValue.ToString()];


            Program.showIssuedItems = selectedUser.IssueItems;

            Program.showUserInfoId = selectedUser.Id.ToString();
            Program.showUserInfoFName = selectedUser.FirstName;
            Program.showUserInfoLName = selectedUser.LastName;
            Program.showUserInfoDepartment = selectedUser.Department;





        }

        private void addNewUserMgmButton_Click(object sender, EventArgs e)
        {
            addNewUser anu = new addNewUser();

            anu.FormClosed += new FormClosedEventHandler(addNewUserFormClosed);

            this.Close();
            anu.Show();
            
        }

        void addNewUserFormClosed(object sender, FormClosedEventArgs e)
        {
            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";
            
            if (Program.newUserId != null)
            {
                string[] nextline = new string[]
                     {
                        string.Format("{0},{1},{2},{3},{4}", Program.newUserId, Program.newUserLName,
                        Program.newUserFName, Program.newUserDept, Program.newUserIssItems)
                     };

                File.AppendAllLines(path, nextline);
            }

            Program.newUserId = null;
            
        }

        private void userRepViewButton_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.FormClosed += new FormClosedEventHandler(viewUserInfoFormClosed);


            f4.Show();
            this.Close();


        }

        void viewUserInfoFormClosed(object sender, FormClosedEventArgs e)
        {
            var temppath = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";
            List<string> templist = File.ReadAllLines(temppath).ToList();


            foreach (string tl in templist.ToArray())
            {


                if (Program.editUserInfoId != null && Program.editUserInfoLName != null &&
                   Program.editUserInfoFName != null && Program.editUserInfoDepartment != null)

                {
                    int index = templist.FindIndex(x => x.StartsWith(selectedUser.Id.ToString()));
                    templist.RemoveAt(index);

                        StringBuilder stb = new StringBuilder();
                        foreach (var item in selectedUser.IssueItems)
                        {
                            stb.Append(item).Append(';');

                            string update = string.Format("{0},{1},{2},{3},{4}", Program.editUserInfoId, Program.editUserInfoLName,
                                   Program.editUserInfoFName, Program.editUserInfoDepartment, "[" + stb.ToString().TrimStart(';') + "]");

                            templist.Add(update);
                        }

                }
            }

            Program.editUserInfoId = null;



        File.WriteAllLines(temppath, templist);
        }

        private void searchUserMgmTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchUserMgmTextBox.Text != "")
            {
                if (searchUserMgmTextBox.Text.Length == 1)
                {
                    searchUserMgmTextBox.Text = searchUserMgmTextBox.Text.ToString().ToUpper();
                    searchUserMgmTextBox.Select(searchUserMgmTextBox.Text.Length, 0);
                }


                var filtered = userInfo.
                    Where(i => i.Key.Contains(searchUserMgmTextBox.Text)).ToDictionary(i => i.Key, i => i.Value);

                if (filtered.Count > 0)
                {
                    userMgmtListBox.DataSource = new BindingSource(filtered, null);
                    userMgmtListBox.ValueMember = "Key";


                    noResultLabel.Visible = false;

                    searchResultLabel.Visible = true;

                    if (filtered.Count == 1)
                        searchResultLabel.Text = "Search Result(s): " + filtered.Count;

                    else
                        searchResultLabel.Text = "Search Result(s): " + filtered.Count;
                }
                else
                {
                    noResultLabel.Visible = true;

                    searchResultLabel.Visible = false;
                }
            }

            else
            {
                displayUserInUserListBox();
                searchResultLabel.Visible = noResultLabel.Visible = false;
            }
        }
    }
}
