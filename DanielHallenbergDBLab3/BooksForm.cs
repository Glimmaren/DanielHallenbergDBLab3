using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielHallenbergDBLab3
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
         
            cmbBox_authors.DataSource = DataBaseCommand.GetFörfattare();
            cmbBox_publishers.DataSource = DataBaseCommand.GetPublishers();
            cmbBox_publishers.DisplayMember = "Namn";
            lstBox_Books.DataSource = DataBaseCommand.GetBooksWAuthor();
            lstBox_Books.DisplayMember = "Title";
        }

        private void lstBox_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bookWAuthor = lstBox_Books.SelectedItem as TempBook;

            txtBox_titel.Text = bookWAuthor.Title;
            txtBox_author.Text = bookWAuthor.AuthorName;
            txtBox_language.Text = bookWAuthor.Language;
            txtBox_releaseDay.Text = bookWAuthor.ReleaseDay.ToShortDateString();
            txtBox_publisher.Text = bookWAuthor.Publisher.Namn;
            txtBox_Price.Text = Convert.ToString(Math.Round(bookWAuthor.Price));
            txtBox_iSBN.Text = bookWAuthor.ISBN.ToString();

            cmbBox_authors.SelectedIndex = bookWAuthor.AuthorID -1;
            cmbBox_publishers.SelectedIndex = SetPublisherComboBox(bookWAuthor.Publisher); //Här har jag lärt mig att ALLTID använda numreriskt ID som PK, ALLTID!!!!

            chkBox_editBooks.Checked = false;          
        }

        private void btn_editBook_Click(object sender, EventArgs e)
        {
            var bookWAuthor = lstBox_Books.SelectedItem as TempBook;

            bookWAuthor.Title = txtBox_titel.Text;
            bookWAuthor.AuthorName = txtBox_author.Text;
            bookWAuthor.Language = txtBox_language.Text;
            bookWAuthor.ReleaseDay = Convert.ToDateTime(txtBox_releaseDay.Text);
            bookWAuthor.Publisher = cmbBox_publishers.SelectedItem as EFDtataAccessLibary.Models.Bokförlag;
            bookWAuthor.Price = Convert.ToDecimal(txtBox_Price.Text);
            bookWAuthor.ISBN = long.Parse(txtBox_iSBN.Text);
            bookWAuthor.AuthorID = cmbBox_authors.SelectedIndex;

            DataBaseCommand.UpdateBook(bookWAuthor);

            chkBox_editBooks.Checked = false;
        }
        private void cchkBox_editBook_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_editBooks.Checked)
            {
                EnableFields();
                btn_editBook.Enabled = true;
            }
            else
            {
                DisableFields();
                btn_editBook.Enabled = false;
            }
        }
        private void EnableFields()
        {
            txtBox_author.Hide();
            txtBox_publisher.Hide();
            txtBox_titel.Enabled = true;
            txtBox_language.Enabled = true;
            txtBox_releaseDay.Enabled = true;
            txtBox_Price.Enabled = true;
            txtBox_iSBN.Enabled = true;
        }
        private void DisableFields()
        {
            txtBox_author.Show();
            txtBox_publisher.Show();
            txtBox_titel.Enabled = false;
            txtBox_language.Enabled = false;
            txtBox_releaseDay.Enabled = false;
            txtBox_Price.Enabled = false;
            txtBox_iSBN.Enabled = false;
        }
        private int SetPublisherComboBox(EFDtataAccessLibary.Models.Bokförlag publischer)
        {
            List<EFDtataAccessLibary.Models.Bokförlag> publishers = DataBaseCommand.GetPublishers();

            int index = 0;
            for (int i = 0; i < publishers.Count; i++)
            {
                if(publishers[i].Namn.Equals(publischer.Namn))
                {
                    break;
                }
                else
                {
                    index += 1;
                }
            }
            return index;
        }//Fick göra en abrovinsch här för att få fram en int som skall ändra index:arn i comboboxarna.

        
    }
}
