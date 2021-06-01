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
    public partial class Form1 : Form
    {
        SortedDictionary<string, Items> itemInfo = new SortedDictionary<string, Items>();
        static string[] headings = new string[6];

        Items selectedItem = new Items();

        public Form1()
        {
            InitializeComponent();

            var path = @"../../../datafiles/Items.csv";
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (line.StartsWith("Title"))

                    headings = line.Split(',');

                else
                {
                    string[] info = line.Split(',');

                    itemInfo.Add(info[0], new Items
                    {
                        Isbn = info[1],
                        Author = info[2],
                        YearPublished = Int32.Parse(info[3])
                    });

                }
            }
            refreshForm();
        }

        private void refreshForm()
        {
            displayItemsInListBox();
        }

        private void displayItemsInListBox()
        {
            itemListBox.DataSource = new BindingSource(itemInfo, null);
            itemListBox.ValueMember = "key";
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemInfo.ContainsKey(itemListBox.SelectedValue.ToString()))
                selectedItem = itemInfo[itemListBox.SelectedValue.ToString()];


            searchResultLabel.Text = "Search Result(s): " + itemListBox.Items.Count.ToString();


            titleTextBox.Text = selectedItem.Title.ToString();
            IsbnTextBox.Text = selectedItem.Isbn.ToString();
            authorTextBox.Text = selectedItem.Author.ToString();
            yearTextBox.Text = selectedItem.YearPublished.ToString();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            addNewItem ani = new addNewItem();

            ani.FormClosed += new FormClosedEventHandler(addItemFormClosed);

            ani.Show();
        }

        private void addItemFormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.newItemName != null)
                itemInfo.Add(Program.newItemName, new Items
                {
                    Isbn = null,
                    Author = null,
                    YearPublished = 0
                });
            {

            }
        }
    }
}
