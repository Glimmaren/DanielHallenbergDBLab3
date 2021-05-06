
namespace DanielHallenbergDBLab3
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBox_Books = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_titel = new System.Windows.Forms.TextBox();
            this.txtBox_language = new System.Windows.Forms.TextBox();
            this.txtBox_releaseDay = new System.Windows.Forms.TextBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_iSBN = new System.Windows.Forms.TextBox();
            this.cmbBox_authors = new System.Windows.Forms.ComboBox();
            this.cmbBox_publishers = new System.Windows.Forms.ComboBox();
            this.chkBox_editBooks = new System.Windows.Forms.CheckBox();
            this.chkBox_DeleteBook = new System.Windows.Forms.CheckBox();
            this.btn_editBook = new System.Windows.Forms.Button();
            this.btn_deleteBook = new System.Windows.Forms.Button();
            this.txtBox_author = new System.Windows.Forms.TextBox();
            this.txtBox_publisher = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBox_Books
            // 
            this.lstBox_Books.FormattingEnabled = true;
            this.lstBox_Books.ItemHeight = 15;
            this.lstBox_Books.Location = new System.Drawing.Point(12, 12);
            this.lstBox_Books.Name = "lstBox_Books";
            this.lstBox_Books.Size = new System.Drawing.Size(325, 289);
            this.lstBox_Books.TabIndex = 0;
            this.lstBox_Books.SelectedIndexChanged += new System.EventHandler(this.lstBox_Books_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(343, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(343, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Författare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Språk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(343, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Utgivningsatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(343, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bokförlag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(343, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pris:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ISBN:";
            // 
            // txtBox_titel
            // 
            this.txtBox_titel.Enabled = false;
            this.txtBox_titel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_titel.Location = new System.Drawing.Point(484, 12);
            this.txtBox_titel.Name = "txtBox_titel";
            this.txtBox_titel.Size = new System.Drawing.Size(380, 29);
            this.txtBox_titel.TabIndex = 8;
            // 
            // txtBox_language
            // 
            this.txtBox_language.Enabled = false;
            this.txtBox_language.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_language.Location = new System.Drawing.Point(484, 82);
            this.txtBox_language.Name = "txtBox_language";
            this.txtBox_language.Size = new System.Drawing.Size(380, 29);
            this.txtBox_language.TabIndex = 10;
            // 
            // txtBox_releaseDay
            // 
            this.txtBox_releaseDay.Enabled = false;
            this.txtBox_releaseDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_releaseDay.Location = new System.Drawing.Point(484, 117);
            this.txtBox_releaseDay.Name = "txtBox_releaseDay";
            this.txtBox_releaseDay.Size = new System.Drawing.Size(380, 29);
            this.txtBox_releaseDay.TabIndex = 11;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Enabled = false;
            this.txtBox_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Price.Location = new System.Drawing.Point(484, 187);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(380, 29);
            this.txtBox_Price.TabIndex = 13;
            // 
            // txtBox_iSBN
            // 
            this.txtBox_iSBN.Enabled = false;
            this.txtBox_iSBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_iSBN.Location = new System.Drawing.Point(484, 223);
            this.txtBox_iSBN.Name = "txtBox_iSBN";
            this.txtBox_iSBN.Size = new System.Drawing.Size(380, 29);
            this.txtBox_iSBN.TabIndex = 14;
            // 
            // cmbBox_authors
            // 
            this.cmbBox_authors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_authors.FormattingEnabled = true;
            this.cmbBox_authors.Location = new System.Drawing.Point(484, 47);
            this.cmbBox_authors.Name = "cmbBox_authors";
            this.cmbBox_authors.Size = new System.Drawing.Size(380, 29);
            this.cmbBox_authors.TabIndex = 15;
            // 
            // cmbBox_publishers
            // 
            this.cmbBox_publishers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_publishers.FormattingEnabled = true;
            this.cmbBox_publishers.Location = new System.Drawing.Point(484, 152);
            this.cmbBox_publishers.Name = "cmbBox_publishers";
            this.cmbBox_publishers.Size = new System.Drawing.Size(380, 29);
            this.cmbBox_publishers.TabIndex = 16;
            // 
            // chkBox_editBooks
            // 
            this.chkBox_editBooks.AutoSize = true;
            this.chkBox_editBooks.Location = new System.Drawing.Point(684, 276);
            this.chkBox_editBooks.Name = "chkBox_editBooks";
            this.chkBox_editBooks.Size = new System.Drawing.Size(72, 19);
            this.chkBox_editBooks.TabIndex = 17;
            this.chkBox_editBooks.Text = "Redigera";
            this.chkBox_editBooks.UseVisualStyleBackColor = true;
            this.chkBox_editBooks.CheckedChanged += new System.EventHandler(this.cchkBox_editBook_CheckedChanged);
            // 
            // chkBox_DeleteBook
            // 
            this.chkBox_DeleteBook.AutoSize = true;
            this.chkBox_DeleteBook.Location = new System.Drawing.Point(605, 276);
            this.chkBox_DeleteBook.Name = "chkBox_DeleteBook";
            this.chkBox_DeleteBook.Size = new System.Drawing.Size(62, 19);
            this.chkBox_DeleteBook.TabIndex = 18;
            this.chkBox_DeleteBook.Text = "Ta Bort";
            this.chkBox_DeleteBook.UseVisualStyleBackColor = true;
            // 
            // btn_editBook
            // 
            this.btn_editBook.Enabled = false;
            this.btn_editBook.Location = new System.Drawing.Point(484, 267);
            this.btn_editBook.Name = "btn_editBook";
            this.btn_editBook.Size = new System.Drawing.Size(105, 34);
            this.btn_editBook.TabIndex = 19;
            this.btn_editBook.Text = "Redigera";
            this.btn_editBook.UseVisualStyleBackColor = true;
            this.btn_editBook.Click += new System.EventHandler(this.btn_editBook_Click);
            // 
            // btn_deleteBook
            // 
            this.btn_deleteBook.Enabled = false;
            this.btn_deleteBook.Location = new System.Drawing.Point(343, 267);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(105, 34);
            this.btn_deleteBook.TabIndex = 20;
            this.btn_deleteBook.Text = "Ta Bort";
            this.btn_deleteBook.UseVisualStyleBackColor = true;
            // 
            // txtBox_author
            // 
            this.txtBox_author.Enabled = false;
            this.txtBox_author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_author.Location = new System.Drawing.Point(484, 47);
            this.txtBox_author.Name = "txtBox_author";
            this.txtBox_author.Size = new System.Drawing.Size(380, 29);
            this.txtBox_author.TabIndex = 21;
            // 
            // txtBox_publisher
            // 
            this.txtBox_publisher.Enabled = false;
            this.txtBox_publisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_publisher.Location = new System.Drawing.Point(484, 152);
            this.txtBox_publisher.Name = "txtBox_publisher";
            this.txtBox_publisher.Size = new System.Drawing.Size(380, 29);
            this.txtBox_publisher.TabIndex = 22;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 329);
            this.Controls.Add(this.txtBox_publisher);
            this.Controls.Add(this.txtBox_author);
            this.Controls.Add(this.btn_deleteBook);
            this.Controls.Add(this.btn_editBook);
            this.Controls.Add(this.chkBox_DeleteBook);
            this.Controls.Add(this.chkBox_editBooks);
            this.Controls.Add(this.cmbBox_publishers);
            this.Controls.Add(this.cmbBox_authors);
            this.Controls.Add(this.txtBox_iSBN);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.txtBox_releaseDay);
            this.Controls.Add(this.txtBox_language);
            this.Controls.Add(this.txtBox_titel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstBox_Books);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Books;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_titel;
        private System.Windows.Forms.TextBox txtBox_language;
        private System.Windows.Forms.TextBox txtBox_releaseDay;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.TextBox txtBox_iSBN;
        private System.Windows.Forms.ComboBox cmbBox_authors;
        private System.Windows.Forms.ComboBox cmbBox_publishers;
        private System.Windows.Forms.CheckBox chkBox_editBooks;
        private System.Windows.Forms.CheckBox chkBox_DeleteBook;
        private System.Windows.Forms.Button btn_editBook;
        private System.Windows.Forms.Button btn_deleteBook;
        private System.Windows.Forms.TextBox txtBox_author;
        private System.Windows.Forms.TextBox txtBox_publisher;
    }
}