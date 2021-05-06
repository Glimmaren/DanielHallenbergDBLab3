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

            lstBox_Authors.DataSource = DataBaseCommand.GetFörfattare();
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
            var author = new EFDtataAccessLibary.Models.Författare();
            author.Id = Convert.ToInt32(txtBox_ID.Text);
            author.Förnamn = txtBox_editFörnamn.Text;
            author.Efternamn = txtBox_EditEfternamn.Text;
            author.Födelsedatum = Convert.ToDateTime(txtBox_EditFödelsedatum.Text);

            DataBaseCommand.UpdateAuthor(author);
            lstBox_Authors.DataSource = DataBaseCommand.GetFörfattare();
            chkBox_Redigera.Checked = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //TODO: FIXA INDATA SÅ ATT DET INTE GÅR ATT MATA IN FEL
            var author = new EFDtataAccessLibary.Models.Författare();
            author.Id = 0;
            author.Förnamn = txtBox_AddFörnamn.Text;
            author.Efternamn = txtBox_AddEfternamn.Text;
            author.Födelsedatum = Convert.ToDateTime(txtBox_AddFödelseDatum.Text);

            if (!DataBaseCommand.CreateAuthor(author))
            {
                lstBox_Authors.DataSource = DataBaseCommand.GetFörfattare();
                txtBox_AddFörnamn.Text = "";
                txtBox_AddEfternamn.Text = "";
                txtBox_AddFödelseDatum.Text = "";
            }
            else
            {
                MessageBox.Show("Författaren finns redan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
        private void btn_deleteAuthor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort vald författare?", "Varning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogResult == DialogResult.Yes)
            {
                DataBaseCommand.DeleteAuthor(int.Parse(txtBox_ID.Text));
                lstBox_Authors.DataSource = DataBaseCommand.GetFörfattare();
            }

        }
    }
}
