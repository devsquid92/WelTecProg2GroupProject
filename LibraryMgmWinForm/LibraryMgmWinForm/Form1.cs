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
    public partial class LibraryManagement : Form
    {
        SortedDictionary<string, Items> itemInfo = new SortedDictionary<string, Items>();
        static string[] headings = new string[5];

        Items selectedItem = new Items();

        public LibraryManagement()
        {
            InitializeComponent();

            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Items.csv"; 
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
                        YearPublished = Int32.Parse(info[3]),
                        Category = info[4]
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

            

            itemListBox.ValueMember = "Key";

        }

        private void itemListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (itemInfo.ContainsKey(itemListBox.SelectedValue.ToString()))
                selectedItem = itemInfo[itemListBox.SelectedValue.ToString()];


            avaLabel.Text = itemListBox.Items.Count.ToString();



            isbnTextBox.Text = selectedItem.Isbn;
            titleTextBox.Text = selectedItem.Title;
            authorTextBox.Text = selectedItem.Author;
            yearTextBox.Text = selectedItem.YearPublished.ToString();
            categoryTextBox.Text = selectedItem.Category;
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
                    YearPublished = 0,
                    Category = null
                });

            Program.newItemName = null;
            displayItemsInListBox();
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            
            selectedItem.Isbn = isbnTextBox.Text;
            selectedItem.Author = authorTextBox.Text;
            selectedItem.YearPublished = Int32.Parse(yearTextBox.Text);
            selectedItem.Category = categoryTextBox.Text;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text != "")
            {
                if(searchBox.Text.Length == 1)
                {
                    searchBox.Text = searchBox.Text.ToString().ToUpper();
                    searchBox.Select(searchBox.Text.Length, 0);
                }


                var filtered = itemInfo.
                    Where(i => i.Key.Contains(searchBox.Text)).ToDictionary(i => i.Key, i => i.Value);

                if(filtered.Count > 0)
                {
                    itemListBox.DataSource = new BindingSource(filtered, null);
                    itemListBox.ValueMember = "Key";


                    noSearchResultLabel.Visible = false;

                    searchResultLabel.Visible = true;

                    if (filtered.Count == 1) 
                        searchResultLabel.Text = "Search Result(s): " + filtered.Count;

                    else
                        searchResultLabel.Text = "Search Result(s): " + filtered.Count;
                }
                else
                {
                    noSearchResultLabel.Visible = true;

                    searchResultLabel.Visible = false;
                }
            }

            else
            {
                displayItemsInListBox();
                searchResultLabel.Visible = noSearchResultLabel.Visible = false;
            }
        }
    }
}
