using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDtataAccessLibary;
using Microsoft.EntityFrameworkCore;

namespace DanielHallenbergDBLab3
{
    public partial class GewertsMainForm : Form
    {

        public GewertsMainForm()
        {

            InitializeComponent();

            cmbBox_ValdButik.DataSource = DataBaseCommand.GetStores();
            cmbBox_ValdButik.DisplayMember = "Namn";
        }

        private void cmbBox_ValdButik_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBox_Lager.DataSource = DataBaseCommand.GetSlado(cmbBox_ValdButik.SelectedIndex + 1);          
        }

        private void btn_ändraSaldo_Click(object sender, EventArgs e)
        {
            var lgSaldo = lstBox_Lager.SelectedItem as tempSaldo;
            try
            {

                if (!DataBaseCommand.UpdateSaldo(Convert.ToInt32(txt_Ammount.Text), lgSaldo.ISBN, cmbBox_ValdButik.SelectedIndex + 1))
                {
                    MessageBox.Show("Saldot är är för lågt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }catch(FormatException a)
            {
                MessageBox.Show("Felaktigt fromat", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txt_Ammount.Text = "";
            lstBox_Lager.DataSource = DataBaseCommand.GetSlado(cmbBox_ValdButik.SelectedIndex + 1);

        }
        private void btn_EtitAuthor_Click(object sender, EventArgs e)
        {
            AuthorsForm aForm = new AuthorsForm();
            aForm.Show();
        }
        private void btn_editBooks_Click(object sender, EventArgs e)
        {
            BooksForm bForm = new BooksForm();
            bForm.Show();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            cmbBox_ValdButik.DataSource = DataBaseCommand.GetStores();
            cmbBox_ValdButik.DisplayMember = "Namn";
        }

        private void lstBox_Lager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
