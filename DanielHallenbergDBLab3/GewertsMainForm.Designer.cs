
namespace DanielHallenbergDBLab3
{
    partial class GewertsMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBox_ValdButik = new System.Windows.Forms.ComboBox();
            this.lstBox_Lager = new System.Windows.Forms.ListBox();
            this.btn_ändraSaldo = new System.Windows.Forms.Button();
            this.txt_Ammount = new System.Windows.Forms.TextBox();
            this.btn_EtitAuthor = new System.Windows.Forms.Button();
            this.btn_editBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox_ValdButik
            // 
            this.cmbBox_ValdButik.FormattingEnabled = true;
            this.cmbBox_ValdButik.Location = new System.Drawing.Point(12, 46);
            this.cmbBox_ValdButik.Name = "cmbBox_ValdButik";
            this.cmbBox_ValdButik.Size = new System.Drawing.Size(342, 23);
            this.cmbBox_ValdButik.TabIndex = 0;
            this.cmbBox_ValdButik.SelectedIndexChanged += new System.EventHandler(this.cmbBox_ValdButik_SelectedIndexChanged);
            // 
            // lstBox_Lager
            // 
            this.lstBox_Lager.FormattingEnabled = true;
            this.lstBox_Lager.ItemHeight = 15;
            this.lstBox_Lager.Location = new System.Drawing.Point(12, 102);
            this.lstBox_Lager.Name = "lstBox_Lager";
            this.lstBox_Lager.Size = new System.Drawing.Size(342, 364);
            this.lstBox_Lager.TabIndex = 1;
            // 
            // btn_ändraSaldo
            // 
            this.btn_ändraSaldo.Location = new System.Drawing.Point(360, 141);
            this.btn_ändraSaldo.Name = "btn_ändraSaldo";
            this.btn_ändraSaldo.Size = new System.Drawing.Size(155, 47);
            this.btn_ändraSaldo.TabIndex = 2;
            this.btn_ändraSaldo.Text = "Justera Saldo";
            this.btn_ändraSaldo.UseVisualStyleBackColor = true;
            this.btn_ändraSaldo.Click += new System.EventHandler(this.btn_ändraSaldo_Click);
            // 
            // txt_Ammount
            // 
            this.txt_Ammount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ammount.Location = new System.Drawing.Point(360, 102);
            this.txt_Ammount.Name = "txt_Ammount";
            this.txt_Ammount.Size = new System.Drawing.Size(155, 33);
            this.txt_Ammount.TabIndex = 3;
            this.txt_Ammount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_EtitAuthor
            // 
            this.btn_EtitAuthor.Location = new System.Drawing.Point(360, 250);
            this.btn_EtitAuthor.Name = "btn_EtitAuthor";
            this.btn_EtitAuthor.Size = new System.Drawing.Size(155, 47);
            this.btn_EtitAuthor.TabIndex = 4;
            this.btn_EtitAuthor.Text = "Redigera författare";
            this.btn_EtitAuthor.UseVisualStyleBackColor = true;
            this.btn_EtitAuthor.Click += new System.EventHandler(this.btn_EtitAuthor_Click);
            // 
            // btn_editBooks
            // 
            this.btn_editBooks.Location = new System.Drawing.Point(360, 303);
            this.btn_editBooks.Name = "btn_editBooks";
            this.btn_editBooks.Size = new System.Drawing.Size(155, 47);
            this.btn_editBooks.TabIndex = 5;
            this.btn_editBooks.Text = "Redigera Böcker";
            this.btn_editBooks.UseVisualStyleBackColor = true;
            this.btn_editBooks.Click += new System.EventHandler(this.btn_editBooks_Click);
            // 
            // GewertsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 651);
            this.Controls.Add(this.btn_editBooks);
            this.Controls.Add(this.btn_EtitAuthor);
            this.Controls.Add(this.txt_Ammount);
            this.Controls.Add(this.btn_ändraSaldo);
            this.Controls.Add(this.lstBox_Lager);
            this.Controls.Add(this.cmbBox_ValdButik);
            this.Name = "GewertsMainForm";
            this.Text = "Gewerts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_ValdButik;
        private System.Windows.Forms.ListBox lstBox_Lager;
        private System.Windows.Forms.Button btn_ändraSaldo;
        private System.Windows.Forms.TextBox txt_Ammount;
        private System.Windows.Forms.Button btn_EtitAuthor;
        private System.Windows.Forms.Button btn_editBooks;
    }
}

