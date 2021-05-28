namespace BookByMail
{
    partial class admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminAddOpisanieTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminAddKolvoTextbox = new System.Windows.Forms.TextBox();
            this.AdminAddPriceTextbox = new System.Windows.Forms.TextBox();
            this.AdminAddAuthorTextbox = new System.Windows.Forms.TextBox();
            this.AdminAddNamebookTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AdminKolvoTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AdminPriceTextbox = new System.Windows.Forms.TextBox();
            this.EdditButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdminIdTexbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AdminDeleteId = new System.Windows.Forms.TextBox();
            this.datastat = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastat)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AdminAddOpisanieTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AdminAddKolvoTextbox);
            this.groupBox1.Controls.Add(this.AdminAddPriceTextbox);
            this.groupBox1.Controls.Add(this.AdminAddAuthorTextbox);
            this.groupBox1.Controls.Add(this.AdminAddNamebookTextbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление книги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Описание";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.AddButton.FlatAppearance.BorderSize = 3;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(10, 361);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(223, 38);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // AdminAddOpisanieTextbox
            // 
            this.AdminAddOpisanieTextbox.Location = new System.Drawing.Point(10, 148);
            this.AdminAddOpisanieTextbox.Multiline = true;
            this.AdminAddOpisanieTextbox.Name = "AdminAddOpisanieTextbox";
            this.AdminAddOpisanieTextbox.Size = new System.Drawing.Size(223, 207);
            this.AdminAddOpisanieTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название книги";
            // 
            // AdminAddKolvoTextbox
            // 
            this.AdminAddKolvoTextbox.Location = new System.Drawing.Point(133, 97);
            this.AdminAddKolvoTextbox.Name = "AdminAddKolvoTextbox";
            this.AdminAddKolvoTextbox.Size = new System.Drawing.Size(100, 22);
            this.AdminAddKolvoTextbox.TabIndex = 3;
            // 
            // AdminAddPriceTextbox
            // 
            this.AdminAddPriceTextbox.Location = new System.Drawing.Point(133, 71);
            this.AdminAddPriceTextbox.Name = "AdminAddPriceTextbox";
            this.AdminAddPriceTextbox.Size = new System.Drawing.Size(100, 22);
            this.AdminAddPriceTextbox.TabIndex = 2;
            // 
            // AdminAddAuthorTextbox
            // 
            this.AdminAddAuthorTextbox.Location = new System.Drawing.Point(133, 45);
            this.AdminAddAuthorTextbox.Name = "AdminAddAuthorTextbox";
            this.AdminAddAuthorTextbox.Size = new System.Drawing.Size(100, 22);
            this.AdminAddAuthorTextbox.TabIndex = 1;
            // 
            // AdminAddNamebookTextbox
            // 
            this.AdminAddNamebookTextbox.Location = new System.Drawing.Point(133, 19);
            this.AdminAddNamebookTextbox.Name = "AdminAddNamebookTextbox";
            this.AdminAddNamebookTextbox.Size = new System.Drawing.Size(100, 22);
            this.AdminAddNamebookTextbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AdminKolvoTextbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.AdminPriceTextbox);
            this.groupBox2.Controls.Add(this.EdditButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AdminIdTexbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(299, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение";
            // 
            // AdminKolvoTextbox
            // 
            this.AdminKolvoTextbox.Location = new System.Drawing.Point(133, 76);
            this.AdminKolvoTextbox.Name = "AdminKolvoTextbox";
            this.AdminKolvoTextbox.Size = new System.Drawing.Size(100, 22);
            this.AdminKolvoTextbox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "id";
            // 
            // AdminPriceTextbox
            // 
            this.AdminPriceTextbox.Location = new System.Drawing.Point(133, 48);
            this.AdminPriceTextbox.Name = "AdminPriceTextbox";
            this.AdminPriceTextbox.Size = new System.Drawing.Size(100, 22);
            this.AdminPriceTextbox.TabIndex = 4;
            // 
            // EdditButton
            // 
            this.EdditButton.BackColor = System.Drawing.Color.White;
            this.EdditButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.EdditButton.FlatAppearance.BorderSize = 3;
            this.EdditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.EdditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdditButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EdditButton.Location = new System.Drawing.Point(10, 115);
            this.EdditButton.Name = "EdditButton";
            this.EdditButton.Size = new System.Drawing.Size(223, 38);
            this.EdditButton.TabIndex = 9;
            this.EdditButton.Text = "Изменить";
            this.EdditButton.UseVisualStyleBackColor = false;
            this.EdditButton.Click += new System.EventHandler(this.EdditButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена";
            // 
            // AdminIdTexbox
            // 
            this.AdminIdTexbox.Location = new System.Drawing.Point(133, 20);
            this.AdminIdTexbox.Name = "AdminIdTexbox";
            this.AdminIdTexbox.Size = new System.Drawing.Size(100, 22);
            this.AdminIdTexbox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(558, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 416);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Каталог";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(493, 389);
            this.dataGridView2.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.DeleteButton.FlatAppearance.BorderSize = 3;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(39, 71);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(172, 38);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.AdminDeleteId);
            this.groupBox4.Controls.Add(this.DeleteButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(299, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удаление";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(36, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "id";
            // 
            // AdminDeleteId
            // 
            this.AdminDeleteId.Location = new System.Drawing.Point(111, 21);
            this.AdminDeleteId.Name = "AdminDeleteId";
            this.AdminDeleteId.Size = new System.Drawing.Size(100, 22);
            this.AdminDeleteId.TabIndex = 11;
            // 
            // datastat
            // 
            this.datastat.AllowUserToAddRows = false;
            this.datastat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastat.Location = new System.Drawing.Point(1117, 34);
            this.datastat.Name = "datastat";
            this.datastat.Size = new System.Drawing.Size(322, 389);
            this.datastat.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reportbutton);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(299, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Отчет о самой популярной книге";
            // 
            // reportbutton
            // 
            this.reportbutton.BackColor = System.Drawing.Color.White;
            this.reportbutton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.reportbutton.FlatAppearance.BorderSize = 3;
            this.reportbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportbutton.Location = new System.Drawing.Point(10, 43);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(223, 38);
            this.reportbutton.TabIndex = 10;
            this.reportbutton.Text = "Сформировать отчет";
            this.reportbutton.UseVisualStyleBackColor = false;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.datastat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastat)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminAddKolvoTextbox;
        private System.Windows.Forms.TextBox AdminAddPriceTextbox;
        private System.Windows.Forms.TextBox AdminAddAuthorTextbox;
        private System.Windows.Forms.TextBox AdminAddNamebookTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EdditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdminAddOpisanieTextbox;
        private System.Windows.Forms.TextBox AdminIdTexbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdminPriceTextbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox AdminKolvoTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AdminDeleteId;
        private System.Windows.Forms.DataGridView datastat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button reportbutton;
    }
}