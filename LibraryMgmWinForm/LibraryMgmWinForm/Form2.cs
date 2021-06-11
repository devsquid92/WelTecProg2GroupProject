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
    public partial class Form2 : Form
    {
        SortedDictionary<string, Users> userInfo = new SortedDictionary<string, Users>();
        static string[] headings = new string[5];

        Users selectedUser = new Users();

        public Form2()
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

            userListBox.DataSource = new BindingSource(userInfo, null);
            userListBox.ValueMember = "Key";
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userInfo.ContainsKey(userListBox.SelectedValue.ToString()))
                selectedUser = userInfo[userListBox.SelectedValue.ToString()];



            if (userInfo.ContainsKey(userListBox.SelectedValue.ToString()))
                userInfo[userListBox.SelectedValue.ToString()] = selectedUser;

  




    }

        private void confirmRentButton_Click(object sender, EventArgs e)
        {
            selectedUser.IssueItems.Add(Program.storedItem + "-" + selectedUser.GetDueDate());
            


            var temppath = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";
            List<string> templist = File.ReadAllLines(temppath).ToList();



            foreach (string tl in templist.ToArray())
            {


                if (Program.storedItem != null)
                {
             
                    int index = templist.FindIndex(x => x.StartsWith(selectedUser.Id.ToString()));
                    templist.RemoveAt(index);



                    if (selectedUser.IssueItems.Count > 0)
                    {
                        StringBuilder stb = new StringBuilder();
                        foreach (var item in selectedUser.IssueItems)
                        {
                            stb.Append(item).Append(';');
                        }



                        string update = string.Format("{0},{1},{2},{3},{4}", selectedUser.Id.ToString(), selectedUser.LastName,
                        selectedUser.FirstName, selectedUser.Department, "[" + stb.ToString().TrimStart(';') + "]");


                        templist.Add(update);   // must do: update issued list
                    }


                }


               
            }

            File.WriteAllLines(temppath, templist);

            this.Close();
        }



    }
}
