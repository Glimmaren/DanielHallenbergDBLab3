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
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();

            lstBox_Authors.DataSource = DataBaseCommand.GetAuthors();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {

        }

        private void chkBox_Redigera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Redigera.Checked)
            {
                txtBox_editFörnamn.ReadOnly = false;
                txtBox_EditEfternamn.ReadOnly = false;
                txtBox_EditFödelsedatum.ReadOnly = false;

                btn_Edit.Enabled = true;
                btn_deleteAuthor.Enabled = true;
            }
            else
            {
                txtBox_editFörnamn.ReadOnly = true;
                txtBox_EditEfternamn.ReadOnly = true;
                txtBox_EditFödelsedatum.ReadOnly = true;

                btn_Edit.Enabled = false;
                btn_deleteAuthor.Enabled = false;
            }
        }

        private void lstBox_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkBox_Redigera.Checked = false;
            var author = lstBox_Authors.SelectedItem as EFDtataAccessLibary.Models.Författare;

            txtBox_ID.Text = author.Id.ToString();
            txtBox_editFörnamn.Text = author.Förnamn;
            txtBox_EditEfternamn.Text = author.Efternamn;
            txtBox_EditFödelsedatum.Text = author.Födelsedatum.ToShortDateString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DateTime dateValue;
            var author = new EFDtataAccessLibary.Models.Författare();
            author.Id = Convert.ToInt32(txtBox_ID.Text);
            author.Förnamn = txtBox_editFörnamn.Text;
            author.Efternamn = txtBox_EditEfternamn.Text;        

            if (DateTime.TryParse(txtBox_AddFödelseDatum.Text, out dateValue))
            {
                author.Födelsedatum = dateValue;

                DataBaseCommand.UpdateAuthor(author);
                lstBox_Authors.DataSource = DataBaseCommand.GetAuthors();
                chkBox_Redigera.Checked = false;
            }
            else
            {
                MessageBox.Show("Felaktigt Datum!, kolla så att du matat in rätt (YYYY-MM-DD)", "FEL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DateTime dateValue;
            var author = new EFDtataAccessLibary.Models.Författare();
            author.Id = 0;
            author.Förnamn = txtBox_AddFörnamn.Text;
            author.Efternamn = txtBox_AddEfternamn.Text;

            if (DateTime.TryParse(txtBox_AddFödelseDatum.Text, out dateValue))
            {
                author.Födelsedatum = dateValue;

                if (DataBaseCommand.AddAuthor(author))
                {
                    lstBox_Authors.DataSource = DataBaseCommand.GetAuthors();
                    txtBox_AddFörnamn.Text = "";
                    txtBox_AddEfternamn.Text = "";
                    txtBox_AddFödelseDatum.Text = "";
                }
                else
                {
                    MessageBox.Show("Författaren finns redan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Felaktigt Datum!, kolla så att du matat in rätt (YYYY-MM-DD)", "FEL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }            
        }
        private void btn_deleteAuthor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort vald författare?", "Varning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseCommand.DeleteAuthor(int.Parse(txtBox_ID.Text));
                lstBox_Authors.DataSource = DataBaseCommand.GetAuthors();
            }
        }
    }
}
