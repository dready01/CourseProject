namespace BookByMail
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Каталог = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelkolBook = new System.Windows.Forms.Label();
            this.kolvotextbox = new System.Windows.Forms.TextBox();
            this.adminFormButton = new System.Windows.Forms.Button();
            this.opisaniebox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Корзина = new System.Windows.Forms.TabPage();
            this.DeleteKorzinaButton = new System.Windows.Forms.Button();
            this.OplataButton = new System.Windows.Forms.Button();
            this.RefreshKorzinaButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LoginMainform = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrFormClose = new System.Windows.Forms.Label();
            this.LabelNick = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Каталог.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Корзина.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Каталог);
            this.tabControl1.Controls.Add(this.Корзина);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 434);
            this.tabControl1.TabIndex = 1;
            // 
            // Каталог
            // 
            this.Каталог.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Каталог.Controls.Add(this.dataGridView1);
            this.Каталог.Controls.Add(this.button2);
            this.Каталог.Controls.Add(this.labelkolBook);
            this.Каталог.Controls.Add(this.kolvotextbox);
            this.Каталог.Controls.Add(this.adminFormButton);
            this.Каталог.Controls.Add(this.opisaniebox);
            this.Каталог.Controls.Add(this.listBox1);
            this.Каталог.Controls.Add(this.button1);
            this.Каталог.Location = new System.Drawing.Point(4, 22);
            this.Каталог.Name = "Каталог";
            this.Каталог.Padding = new System.Windows.Forms.Padding(3);
            this.Каталог.Size = new System.Drawing.Size(767, 408);
            this.Каталог.TabIndex = 0;
            this.Каталог.Text = "Каталог";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(423, 59);
            this.dataGridView1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Подробнее о книге";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelkolBook
            // 
            this.labelkolBook.AutoSize = true;
            this.labelkolBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelkolBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelkolBook.Location = new System.Drawing.Point(566, 334);
            this.labelkolBook.Name = "labelkolBook";
            this.labelkolBook.Size = new System.Drawing.Size(84, 16);
            this.labelkolBook.TabIndex = 18;
            this.labelkolBook.Text = "Кол-во книг";
            // 
            // kolvotextbox
            // 
            this.kolvotextbox.Location = new System.Drawing.Point(656, 333);
            this.kolvotextbox.Name = "kolvotextbox";
            this.kolvotextbox.Size = new System.Drawing.Size(100, 20);
            this.kolvotextbox.TabIndex = 17;
            // 
            // adminFormButton
            // 
            this.adminFormButton.Location = new System.Drawing.Point(6, 369);
            this.adminFormButton.Name = "adminFormButton";
            this.adminFormButton.Size = new System.Drawing.Size(125, 33);
            this.adminFormButton.TabIndex = 16;
            this.adminFormButton.Text = "Администрирование";
            this.adminFormButton.UseVisualStyleBackColor = true;
            this.adminFormButton.Visible = false;
            this.adminFormButton.Click += new System.EventHandler(this.adminFormButton_Click);
            // 
            // opisaniebox
            // 
            this.opisaniebox.Location = new System.Drawing.Point(332, 84);
            this.opisaniebox.Multiline = true;
            this.opisaniebox.Name = "opisaniebox";
            this.opisaniebox.Size = new System.Drawing.Size(424, 243);
            this.opisaniebox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(6, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 304);
            this.listBox1.TabIndex = 0;
            // 
            // Корзина
            // 
            this.Корзина.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Корзина.Controls.Add(this.label4);
            this.Корзина.Controls.Add(this.label3);
            this.Корзина.Controls.Add(this.DeleteKorzinaButton);
            this.Корзина.Controls.Add(this.OplataButton);
            this.Корзина.Controls.Add(this.RefreshKorzinaButton);
            this.Корзина.Controls.Add(this.dataGridView2);
            this.Корзина.Location = new System.Drawing.Point(4, 22);
            this.Корзина.Name = "Корзина";
            this.Корзина.Padding = new System.Windows.Forms.Padding(3);
            this.Корзина.Size = new System.Drawing.Size(767, 408);
            this.Корзина.TabIndex = 1;
            this.Корзина.Text = "Корзина";
            // 
            // DeleteKorzinaButton
            // 
            this.DeleteKorzinaButton.Location = new System.Drawing.Point(588, 368);
            this.DeleteKorzinaButton.Name = "DeleteKorzinaButton";
            this.DeleteKorzinaButton.Size = new System.Drawing.Size(87, 34);
            this.DeleteKorzinaButton.TabIndex = 6;
            this.DeleteKorzinaButton.Text = "Удалить из корзины";
            this.DeleteKorzinaButton.UseVisualStyleBackColor = true;
            this.DeleteKorzinaButton.Click += new System.EventHandler(this.DeleteKorzinaButton_Click);
            // 
            // OplataButton
            // 
            this.OplataButton.Location = new System.Drawing.Point(681, 368);
            this.OplataButton.Name = "OplataButton";
            this.OplataButton.Size = new System.Drawing.Size(80, 34);
            this.OplataButton.TabIndex = 5;
            this.OplataButton.Text = "Оплатить";
            this.OplataButton.UseVisualStyleBackColor = true;
            this.OplataButton.Click += new System.EventHandler(this.OplataButton_Click);
            // 
            // RefreshKorzinaButton
            // 
            this.RefreshKorzinaButton.Location = new System.Drawing.Point(502, 368);
            this.RefreshKorzinaButton.Name = "RefreshKorzinaButton";
            this.RefreshKorzinaButton.Size = new System.Drawing.Size(80, 34);
            this.RefreshKorzinaButton.TabIndex = 4;
            this.RefreshKorzinaButton.Text = "Обновить корзину";
            this.RefreshKorzinaButton.UseVisualStyleBackColor = true;
            this.RefreshKorzinaButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(754, 304);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // LoginMainform
            // 
            this.LoginMainform.AutoSize = true;
            this.LoginMainform.Location = new System.Drawing.Point(700, 13);
            this.LoginMainform.Name = "LoginMainform";
            this.LoginMainform.Size = new System.Drawing.Size(35, 13);
            this.LoginMainform.TabIndex = 2;
            this.LoginMainform.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RegistrFormClose);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 27);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(752, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(783, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Х";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // RegistrFormClose
            // 
            this.RegistrFormClose.AutoSize = true;
            this.RegistrFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrFormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrFormClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrFormClose.Location = new System.Drawing.Point(810, 2);
            this.RegistrFormClose.Name = "RegistrFormClose";
            this.RegistrFormClose.Size = new System.Drawing.Size(23, 24);
            this.RegistrFormClose.TabIndex = 0;
            this.RegistrFormClose.Text = "Х";
            // 
            // LabelNick
            // 
            this.LabelNick.AutoSize = true;
            this.LabelNick.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNick.Location = new System.Drawing.Point(54, 29);
            this.LabelNick.Name = "LabelNick";
            this.LabelNick.Size = new System.Drawing.Size(70, 25);
            this.LabelNick.TabIndex = 15;
            this.LabelNick.Text = "label3";
            this.LabelNick.Click += new System.EventHandler(this.LabelNick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookByMail.Properties.Resources.icons8_пользователь_96;
            this.pictureBox1.Location = new System.Drawing.Point(8, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.HistoryButton);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 408);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "История заказов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(606, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Итого:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(675, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(754, 304);
            this.dataGridView3.TabIndex = 1;
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(681, 368);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(80, 34);
            this.HistoryButton.TabIndex = 6;
            this.HistoryButton.Text = "Показать заказы";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelNick);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginMainform);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Каталог.ResumeLayout(false);
            this.Каталог.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Корзина.ResumeLayout(false);
            this.Корзина.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Каталог;
        private System.Windows.Forms.TabPage Корзина;
        private System.Windows.Forms.Label LoginMainform;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RegistrFormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LabelNick;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox opisaniebox;
        private System.Windows.Forms.Button adminFormButton;
        private System.Windows.Forms.Label labelkolBook;
        private System.Windows.Forms.TextBox kolvotextbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteKorzinaButton;
        private System.Windows.Forms.Button OplataButton;
        private System.Windows.Forms.Button RefreshKorzinaButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}