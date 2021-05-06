
namespace DanielHallenbergDBLab3
{
    partial class AuthorsForm
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
            this.lstBox_Authors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_editFörnamn = new System.Windows.Forms.TextBox();
            this.txtBox_EditEfternamn = new System.Windows.Forms.TextBox();
            this.txtBox_EditFödelsedatum = new System.Windows.Forms.TextBox();
            this.chkBox_Redigera = new System.Windows.Forms.CheckBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtBox_AddFödelseDatum = new System.Windows.Forms.TextBox();
            this.txtBox_AddEfternamn = new System.Windows.Forms.TextBox();
            this.txtBox_AddFörnamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_deleteAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_Authors
            // 
            this.lstBox_Authors.FormattingEnabled = true;
            this.lstBox_Authors.ItemHeight = 15;
            this.lstBox_Authors.Location = new System.Drawing.Point(12, 12);
            this.lstBox_Authors.Name = "lstBox_Authors";
            this.lstBox_Authors.Size = new System.Drawing.Size(230, 409);
            this.lstBox_Authors.TabIndex = 0;
            this.lstBox_Authors.SelectedIndexChanged += new System.EventHandler(this.lstBox_Authors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Förnamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(248, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Efternamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(248, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Födelsedatum:";
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_ID.Location = new System.Drawing.Point(400, 9);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(34, 29);
            this.txtBox_ID.TabIndex = 5;
            // 
            // txtBox_editFörnamn
            // 
            this.txtBox_editFörnamn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_editFörnamn.Location = new System.Drawing.Point(400, 44);
            this.txtBox_editFörnamn.Name = "txtBox_editFörnamn";
            this.txtBox_editFörnamn.ReadOnly = true;
            this.txtBox_editFörnamn.Size = new System.Drawing.Size(201, 29);
            this.txtBox_editFörnamn.TabIndex = 6;
            // 
            // txtBox_EditEfternamn
            // 
            this.txtBox_EditEfternamn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_EditEfternamn.Location = new System.Drawing.Point(400, 79);
            this.txtBox_EditEfternamn.Name = "txtBox_EditEfternamn";
            this.txtBox_EditEfternamn.ReadOnly = true;
            this.txtBox_EditEfternamn.Size = new System.Drawing.Size(201, 29);
            this.txtBox_EditEfternamn.TabIndex = 7;
            // 
            // txtBox_EditFödelsedatum
            // 
            this.txtBox_EditFödelsedatum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_EditFödelsedatum.Location = new System.Drawing.Point(400, 117);
            this.txtBox_EditFödelsedatum.Name = "txtBox_EditFödelsedatum";
            this.txtBox_EditFödelsedatum.ReadOnly = true;
            this.txtBox_EditFödelsedatum.Size = new System.Drawing.Size(201, 29);
            this.txtBox_EditFödelsedatum.TabIndex = 8;
            // 
            // chkBox_Redigera
            // 
            this.chkBox_Redigera.AutoSize = true;
            this.chkBox_Redigera.Location = new System.Drawing.Point(529, 9);
            this.chkBox_Redigera.Name = "chkBox_Redigera";
            this.chkBox_Redigera.Size = new System.Drawing.Size(72, 19);
            this.chkBox_Redigera.TabIndex = 9;
            this.chkBox_Redigera.Text = "Redigera";
            this.chkBox_Redigera.UseVisualStyleBackColor = true;
            this.chkBox_Redigera.CheckedChanged += new System.EventHandler(this.chkBox_Redigera_CheckedChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(400, 161);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(201, 36);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Redigera Författare";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(248, 385);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(353, 36);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Lägg Till Författare";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBox_AddFödelseDatum
            // 
            this.txtBox_AddFödelseDatum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_AddFödelseDatum.Location = new System.Drawing.Point(400, 341);
            this.txtBox_AddFödelseDatum.Name = "txtBox_AddFödelseDatum";
            this.txtBox_AddFödelseDatum.Size = new System.Drawing.Size(201, 29);
            this.txtBox_AddFödelseDatum.TabIndex = 16;
            this.txtBox_AddFödelseDatum.Text = "yyyy-mm-dd";
            // 
            // txtBox_AddEfternamn
            // 
            this.txtBox_AddEfternamn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_AddEfternamn.Location = new System.Drawing.Point(400, 303);
            this.txtBox_AddEfternamn.Name = "txtBox_AddEfternamn";
            this.txtBox_AddEfternamn.Size = new System.Drawing.Size(201, 29);
            this.txtBox_AddEfternamn.TabIndex = 15;
            // 
            // txtBox_AddFörnamn
            // 
            this.txtBox_AddFörnamn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_AddFörnamn.Location = new System.Drawing.Point(400, 265);
            this.txtBox_AddFörnamn.Name = "txtBox_AddFörnamn";
            this.txtBox_AddFörnamn.Size = new System.Drawing.Size(201, 29);
            this.txtBox_AddFörnamn.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(248, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Födelsedatum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(248, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Efternamn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(248, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Förnamn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(248, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lägg till författare:";
            // 
            // btn_deleteAuthor
            // 
            this.btn_deleteAuthor.Enabled = false;
            this.btn_deleteAuthor.Location = new System.Drawing.Point(248, 161);
            this.btn_deleteAuthor.Name = "btn_deleteAuthor";
            this.btn_deleteAuthor.Size = new System.Drawing.Size(146, 36);
            this.btn_deleteAuthor.TabIndex = 19;
            this.btn_deleteAuthor.Text = "Ta Bort Författare";
            this.btn_deleteAuthor.UseVisualStyleBackColor = true;
            this.btn_deleteAuthor.Click += new System.EventHandler(this.btn_deleteAuthor_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 433);
            this.Controls.Add(this.btn_deleteAuthor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_AddFödelseDatum);
            this.Controls.Add(this.txtBox_AddEfternamn);
            this.Controls.Add(this.txtBox_AddFörnamn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.chkBox_Redigera);
            this.Controls.Add(this.txtBox_EditFödelsedatum);
            this.Controls.Add(this.txtBox_EditEfternamn);
            this.Controls.Add(this.txtBox_editFörnamn);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox_Authors);
            this.Name = "AuthorsForm";
            this.Text = "Redigera/Lägtill/Tabort Författare";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Authors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.TextBox txtBox_editFörnamn;
        private System.Windows.Forms.TextBox txtBox_EditEfternamn;
        private System.Windows.Forms.TextBox txtBox_EditFödelsedatum;
        private System.Windows.Forms.CheckBox chkBox_Redigera;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBox_AddFödelseDatum;
        private System.Windows.Forms.TextBox txtBox_AddEfternamn;
        private System.Windows.Forms.TextBox txtBox_AddFörnamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_deleteAuthor;
    }
}