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
    public partial class LibraryManagement : Form
    {
        SortedDictionary<string, Items> itemInfo = new SortedDictionary<string, Items>();
        static string[] headings = new string[5];

        Items selectedItem = new Items();

        bool isbn, title, author, year, category;

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
                        Title = info[0],
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
            isbnOKLabel.Visible = false;
            isbnInvalidLabel.Visible = false;
            displayItemsInListBox();
        }

        private void displayItemsInListBox()
        {
            itemListBox.DataSource = new BindingSource(itemInfo, null);
            itemListBox.ValueMember = "Key";

        }

        private void itemListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Validation valid = new Validation();


            if (itemInfo.ContainsKey(itemListBox.SelectedValue.ToString()))
                selectedItem = itemInfo[itemListBox.SelectedValue.ToString()];


            isbn = valid.validateNum(isbnTextBox.Text);
            title = valid.validateString(titleTextBox.Text);
            author = valid.validateString(authorTextBox.Text);
            year = valid.validateNum(yearTextBox.Text);
            category = valid.validateString(categoryTextBox.Text);


            avaLabel.Text = itemListBox.Items.Count.ToString();


            if (isbn && isbnTextBox.Text != " ")
            {
                isbnOKLabel.Visible = true;
                isbnInvalidLabel.Visible = false;

            }
            else if (!isbn && isbnTextBox.Text != " ")
            {
                isbnInvalidLabel.Visible = true;
                isbnOKLabel.Visible = false;
            }


            if (title && titleTextBox.Text != " ")
            {
                titleOKLabel.Visible = true;
                titleInvalidLabel.Visible = false;

            }
            else if (!title && titleTextBox.Text != " ")
            {
                titleOKLabel.Visible = false;
                titleInvalidLabel.Visible = true;
            }

            if (author && authorTextBox.Text != " ")
            {
                authorOKLabel.Visible = true;
                authorInvalidLabel.Visible = false;

            }
            else if (!author && authorTextBox.Text != " ")
            {
                authorOKLabel.Visible = false;
                authorInvalidLabel.Visible = true;
            }


            if (year && yearTextBox.Text != " ")
            {
                yearOKLabel.Visible = true;
                yearInvalidLabel.Visible = false;

            }
            else if (!year && yearTextBox.Text != " ")
            {
                yearOKLabel.Visible = false;
                yearInvalidLabel.Visible = true;
            }

            if (category && categoryTextBox.Text != " ")
            {
                categoryOKLabel.Visible = true;
                categoryInvalidLabel.Visible = false;

            }
            else if (!category && isbnTextBox.Text != " ")
            {
                categoryOKLabel.Visible = false;
                categoryInvalidLabel.Visible = true;
            }


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
            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Items.csv";

            File.AppendAllText(path, Program.newItemName);

            if (Program.newItemName != null)
                itemInfo.Add(Program.newItemName, new Items
                {
                    Title = Program.newItemName,
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
            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Items.csv";


        if (isbn && title && author && year && category)
        {

                List<string> templist = File.ReadAllLines(path).ToList();

                foreach (string list in templist.ToArray())
                {


                    if (list.StartsWith(selectedItem.Title))
                    {


                        int index = templist.FindIndex(x => x.StartsWith(selectedItem.Title));
                        templist.RemoveAt(index);

                        File.WriteAllLines(path, templist);

                        selectedItem.Title = titleTextBox.Text;
                        selectedItem.Isbn = isbnTextBox.Text;
                        selectedItem.Author = authorTextBox.Text;
                        selectedItem.YearPublished = Int32.Parse(yearTextBox.Text);
                        selectedItem.Category = categoryTextBox.Text;


                        string updline = string.Format("{0},{1},{2},{3},{4}", selectedItem.Title, selectedItem.Isbn, selectedItem.Author, selectedItem.YearPublished, selectedItem.Category);

                        File.AppendAllText(path, updline);


                    }
                }

                MessageBox.Show("Saved!");
            }

        else
                MessageBox.Show("Please clear the invalid box");


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

        private void memberReportButton_Click(object sender, EventArgs e)
        {
            UserReport ur = new UserReport();

            

            ur.Show();
        }

        private void rentItemButton_Click(object sender, EventArgs e)
        {
      
            Program.storedItem = string.Format("{0}-{1}", selectedItem.Title, selectedItem.Isbn);

            Form2 f2 = new Form2();
            
            f2.Show();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Items.csv";


            List<string> templist = File.ReadAllLines(path).ToList();

            foreach (string list in templist.ToArray())
            {

                if (list.StartsWith(selectedItem.Title))
                {
                    int index = templist.FindIndex(x => x.StartsWith(selectedItem.Title));
                    templist.RemoveAt(index);

                    File.WriteAllLines(path, templist);

                }
            }

            MessageBox.Show("Deleted!");
        }
    }
}
