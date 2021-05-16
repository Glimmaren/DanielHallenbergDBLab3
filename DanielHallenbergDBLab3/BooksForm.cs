using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielHallenbergDBLab3
{
    public partial class BooksForm : Form
    {
        public int MultiAutors = 0;

        public BooksForm()
        {
            InitializeComponent();

            cmbBox_authors1.DataSource = DataBaseCommand.GetAuthors();
            cmbBox_authors2.DataSource = DataBaseCommand.GetAuthors();
            cmbBox_authors3.DataSource = DataBaseCommand.GetAuthors();
            cmbBox_publishers.DataSource = DataBaseCommand.GetPublishers();
            cmbBox_publishers.DisplayMember = "Namn";
            lstBox_Books.DataSource = DataBaseCommand.GetBooksWAuthor();
            lstBox_Books.DisplayMember = "Title";
            
        }

        private void lstBox_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDetails();
        }

        private void btn_editBook_Click(object sender, EventArgs e)
        {
            int defaultComboBoxIndex = cmbBox_authors1.Items.Count - 1;
            if (MultiAutors > 1)
            {
                if (cmbBox_authors1.SelectedIndex != cmbBox_authors2.SelectedIndex && cmbBox_authors2.SelectedIndex != cmbBox_authors3.SelectedIndex && cmbBox_authors1.SelectedIndex != cmbBox_authors3.SelectedIndex ||
                    chkBox_multiauthors.Checked == false || cmbBox_authors2.SelectedIndex == defaultComboBoxIndex && cmbBox_authors3.SelectedIndex == defaultComboBoxIndex)
                {
                    DataBaseCommand.UpdateBook(RefreshTempBook());

                    lstBox_Books.DataSource = DataBaseCommand.GetBooksWAuthor();
                    lstBox_Books.DisplayMember = "Title";

                    chkBox_editBook.Checked = false;
                }
                else
                {
                   MessageBox.Show("En eller fler likadana författare!", "Varning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DataBaseCommand.UpdateBook(RefreshTempBook());

                lstBox_Books.DataSource = DataBaseCommand.GetBooksWAuthor();
                lstBox_Books.DisplayMember = "Title";

                chkBox_editBook.Checked = false;
            }
        }
        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort vald boken?\n Boken kommer försvinna helt ur sortimentet\n i alla butiker!", "Varning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseCommand.DeleteBook(RefreshTempBook());

                lstBox_Books.DataSource = DataBaseCommand.GetBooksWAuthor();
                lstBox_Books.DisplayMember = "Title";
            }
            
            chkBox_DeleteBook.Checked = false;
        }
        private void btn_addBook_Click(object sender, EventArgs e)
        {
            if (DataBaseCommand.AddBook(RefreshTempBook()))
            {
                RefreshDetails();

                DisableFields();

                chkBox_addBook.Checked = false;

                lstBox_Books.DataSource = DataBaseCommand.GetBooksWAuthor();
                lstBox_Books.DisplayMember = "Title";
            }           
        }

        private void chkBox_editBook_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_editBook.Checked)
            {
                EnableFields();
                btn_editBook.Enabled = true;
                chkBox_multiauthors.Enabled = true;

                chkBox_DeleteBook.Checked = false;
                chkBox_addBook.Checked = false;
            }
            else
            {
                DisableFields();
                btn_editBook.Enabled = false;

                if (MultiAutors < 2)
                {
                    chkBox_multiauthors.Checked = false;
                }

                RefreshDetails();
            }
        }
        private void chkBox_DeleteBook_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_DeleteBook.Checked)
            {               
                btn_deleteBook.Enabled = true;

                chkBox_editBook.Checked = false;
                chkBox_addBook.Checked = false;

            }
            else
            {
                btn_deleteBook.Enabled = false;
            }
        }
        private void chkBox_multiauthors_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_editBook.Checked && !chkBox_multiauthors.Checked)
            {
                txtBox_author2.Show();
                txtBox_author2.Text = "";
                txtBox_author3.Show();
                txtBox_author3.Text = "";
                cmbBox_authors2.SelectedIndex = cmbBox_authors3.Items.Count - 1;
                cmbBox_authors3.SelectedIndex = cmbBox_authors3.Items.Count - 1;

            }
            if (chkBox_editBook.Checked && chkBox_multiauthors.Checked || chkBox_addBook.Checked && chkBox_multiauthors.Checked)
            {
                txtBox_author2.Hide();
                txtBox_author3.Hide();

            }else if (!chkBox_multiauthors.Checked)
            {
                txtBox_author2.Text = "";
                txtBox_author3.Text = "";
            }

            MultiAutors = 2;
        }
        private void chkBox_addBook_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_addBook.Checked)
            {
                EnableFields();
                txtBox_titel.Text = "";
                txtBox_language.Text = "";
                txtBox_releaseDay.Text = "YYYY-MM-DD";
                txtBox_Price.Text = "";
                txtBox_iSBN.Text = "13-Digits";

                cmbBox_authors1.SelectedIndex = cmbBox_authors1.Items.Count - 1;
                cmbBox_publishers.SelectedIndex = cmbBox_publishers.Items.Count - 1;

                btn_addBook.Enabled = true;

                chkBox_DeleteBook.Checked = false;
                chkBox_editBook.Checked = false;
            }
            else
            {
                DisableFields();
                RefreshDetails();
            }
        }


        private void EnableFields()
        {
            txtBox_author1.Hide();
            txtBox_publisher.Hide();
            txtBox_titel.Enabled = true;
            txtBox_language.Enabled = true;
            txtBox_releaseDay.Enabled = true;
            txtBox_Price.Enabled = true;
            txtBox_iSBN.Enabled = true;
            chkBox_multiauthors.Enabled = true;

            if (chkBox_multiauthors.Checked)
            {
                txtBox_author2.Hide();
                txtBox_author3.Hide();
            }
        }
        private void DisableFields()
        {
            txtBox_author1.Show();
            txtBox_author2.Show();
            txtBox_author3.Show();
            txtBox_publisher.Show();
            txtBox_titel.Enabled = false;
            txtBox_language.Enabled = false;
            txtBox_releaseDay.Enabled = false;
            txtBox_Price.Enabled = false;
            txtBox_iSBN.Enabled = false;
            chkBox_multiauthors.Enabled = false;
            btn_addBook.Enabled = false;
        }
        private int SetPublisherComboBox(EFDtataAccessLibary.Models.Bokförlag publischer)
        {
            List<EFDtataAccessLibary.Models.Bokförlag> publishers = DataBaseCommand.GetPublishers();

            int index = 0;
            for (int i = 0; i < publishers.Count; i++)
            {
                if (publishers[i].Namn.Equals(publischer.Namn))
                {
                    break;
                }
                else
                {
                    index += 1;
                }
            }
            return index;
        }//Här har jag lärt mig att ALLTID använda numreriskt ID som PK, ALLTID!!!!, Fick göra en abrovinsch här för att få fram en int som skall ändra index:arn i comboboxarna.
        private void RefreshDetails()
        {
            var bookWAuthor = lstBox_Books.SelectedItem as TempBook;

            txtBox_titel.Text = bookWAuthor.Title;         
            txtBox_language.Text = bookWAuthor.Language;
            txtBox_releaseDay.Text = bookWAuthor.ReleaseDay.ToShortDateString();
            txtBox_publisher.Text = bookWAuthor.Publisher.Namn;
            txtBox_Price.Text = Convert.ToString(Math.Round(bookWAuthor.Price));
            txtBox_iSBN.Text = bookWAuthor.ISBN.ToString();
          
            cmbBox_publishers.SelectedIndex = SetPublisherComboBox(bookWAuthor.Publisher);

            chkBox_multiauthors.Checked = false;

            //Logiken för att fylla comboboxar och textboxar med författare!
            if (bookWAuthor.Authors.Count != 0)
            {
                if (bookWAuthor.Authors[0] != null)
                {
                    txtBox_author1.Text = bookWAuthor.Authors[0].Förnamn + " " + bookWAuthor.Authors[0].Efternamn;

                    cmbBox_authors1.SelectedIndex = GetAuthorsComboBoxIndex(bookWAuthor.Authors[0]);
                }
                else
                {
                    txtBox_author1.Text = "";
                    cmbBox_authors1.SelectedIndex = cmbBox_authors1.Items.Count - 1;
                }

                if (bookWAuthor.Authors.Count > 1)
                {
                    if (bookWAuthor.Authors[1] != null)
                    {
                        txtBox_author2.Text = bookWAuthor.Authors[1].Förnamn + " " + bookWAuthor.Authors[1].Efternamn;
                        cmbBox_authors2.SelectedIndex = GetAuthorsComboBoxIndex(bookWAuthor.Authors[1]);
                        cmbBox_authors3.SelectedIndex = cmbBox_authors3.Items.Count - 1;
                        MultiAutors = 2;
                    }
                    else
                    {
                        txtBox_author2.Text = "";
                        cmbBox_authors2.SelectedIndex = cmbBox_authors2.Items.Count - 1;
                        cmbBox_authors3.SelectedIndex = cmbBox_authors3.Items.Count - 1;
                    }

                    if (bookWAuthor.Authors.Count > 2)
                    {
                        if (bookWAuthor.Authors[2] != null)
                        {
                            txtBox_author3.Text = bookWAuthor.Authors[2].Förnamn + " " + bookWAuthor.Authors[2].Efternamn;
                            cmbBox_authors3.SelectedIndex = GetAuthorsComboBoxIndex(bookWAuthor.Authors[2]);
                            MultiAutors = 3;
                        }
                        else
                        {
                            txtBox_author3.Text = "";
                            cmbBox_authors2.SelectedIndex = cmbBox_authors2.Items.Count - 1;
                            cmbBox_authors3.SelectedIndex = cmbBox_authors3.Items.Count - 1;
                        }
                    }

                    chkBox_multiauthors.Checked = true;
                }
                else
                {
                    cmbBox_authors2.SelectedIndex = cmbBox_authors3.Items.Count - 1;
                    cmbBox_authors3.SelectedIndex = cmbBox_authors3.Items.Count - 1;
                    MultiAutors = 1;
                }
                if (bookWAuthor.Authors == null)
                {
                    if (bookWAuthor.Authors[0] != null)
                    {
                        txtBox_author1.Text = bookWAuthor.Authors[0].Förnamn + " " + bookWAuthor.Authors[0].Efternamn;

                        cmbBox_authors1.SelectedIndex = GetAuthorsComboBoxIndex(bookWAuthor.Authors[0]);
                    }
                    else
                    {
                        txtBox_author1.Text = "";
                        cmbBox_authors1.SelectedIndex = cmbBox_authors1.Items.Count - 1;
                    }
                }
            }
            else
            {
                txtBox_author1.Text = "";
                txtBox_author2.Text = "";
                txtBox_author3.Text = "";

                cmbBox_authors1.SelectedIndex = cmbBox_authors1.Items.Count - 1;
                cmbBox_authors2.SelectedIndex = cmbBox_authors2.Items.Count - 1;
                cmbBox_authors3.SelectedIndex = cmbBox_authors3.Items.Count - 1;
            }

            chkBox_editBook.Checked = false;
        }
        private TempBook RefreshTempBook()
        {
            var bookWAuthor = lstBox_Books.SelectedItem as TempBook;
            DateTime dateValue;


            bookWAuthor.Title = txtBox_titel.Text;
            bookWAuthor.Language = txtBox_language.Text;

            if (DateTime.TryParse(txtBox_releaseDay.Text, out dateValue))
            {
                bookWAuthor.ReleaseDay = dateValue;
            }
            else 
            {
                MessageBox.Show("Felaktigt Datum!, kolla så att du matat in rätt (YYYY-MM-DD)", "FEL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bookWAuthor.Publisher = cmbBox_publishers.SelectedItem as EFDtataAccessLibary.Models.Bokförlag;

            if (txtBox_Price.Text.All(char.IsDigit))
            {
                try
                {
                    bookWAuthor.Price = Convert.ToDecimal(txtBox_Price.Text);

                }
                catch (FormatException e)
                {
                    MessageBox.Show("Felaktigt Pris!, Måste vara enbart siffror! På Gewrets anväder vi bara hela kronor!!", "FEL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("Felaktigt Pris!, Måste vara enbart siffror! På Gewrets anväder vi bara hela kronor!!", "FEL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if(txtBox_iSBN.Text.Length == 13 && txtBox_iSBN.Text.All(char.IsDigit))
            {
                bookWAuthor.ISBN = long.Parse(txtBox_iSBN.Text); 
            }
            else
            {
                MessageBox.Show("Felaktigt ISBN, Måste vara 13 nummer!", "FEL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            bookWAuthor.NewAuthors.Clear();
            bookWAuthor.NewAuthors.Add(cmbBox_authors1.SelectedItem as EFDtataAccessLibary.Models.Författare);
          
            if (cmbBox_authors2.SelectedIndex >= 0 && cmbBox_authors2.SelectedIndex != cmbBox_authors2.Items.Count -1)
            {
                bookWAuthor.NewAuthors.Add(cmbBox_authors2.SelectedItem as EFDtataAccessLibary.Models.Författare);

                if (cmbBox_authors3.SelectedIndex >= 0 && cmbBox_authors3.SelectedIndex != cmbBox_authors3.Items.Count - 1)
                {
                    bookWAuthor.NewAuthors.Add(cmbBox_authors3.SelectedItem as EFDtataAccessLibary.Models.Författare);
                }
            }

            return bookWAuthor;

        }//Updaterar TempBook som skall skickas tillbaka till DataBaseCommand
        //Väl medveten om att jag borde gjort annorlunda här och skicka seperata object istället för att bygga en ny class med alla info!
        //Det har jag lärt mig nu att göra nästa gång

        private int GetAuthorsComboBoxIndex(EFDtataAccessLibary.Models.Författare author)
        {
            var authors = DataBaseCommand.GetAuthors();

            for (int i = 0; i < authors.Count; i++)
            {
                if(authors[i].Id == author.Id) { return i; }               
            }

            return cmbBox_authors1.Items.Count - 1;
        }

    }
}
