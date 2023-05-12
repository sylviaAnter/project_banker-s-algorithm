
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.resourcesnumber = new System.Windows.Forms.Label();
            this.numberofprcess = new System.Windows.Forms.Label();
            this.numberofresources = new System.Windows.Forms.TextBox();
            this.numberofprocess = new System.Windows.Forms.TextBox();
            this.enterresource = new System.Windows.Forms.Button();
            this.enterprocess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewtotal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewava = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewcurrent = new System.Windows.Forms.DataGridView();
            this.entercurrentdata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewmax = new System.Windows.Forms.DataGridView();
            this.entermaxdata = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewremaining = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxreqnumber = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxresource = new System.Windows.Forms.TextBox();
            this.textBoxprocess = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewremaining)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcesnumber
            // 
            this.resourcesnumber.AutoSize = true;
            this.resourcesnumber.BackColor = System.Drawing.Color.White;
            this.resourcesnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcesnumber.ForeColor = System.Drawing.Color.Black;
            this.resourcesnumber.Location = new System.Drawing.Point(6, 10);
            this.resourcesnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resourcesnumber.Name = "resourcesnumber";
            this.resourcesnumber.Size = new System.Drawing.Size(256, 25);
            this.resourcesnumber.TabIndex = 0;
            this.resourcesnumber.Text = "Enter Number Of Resources";
            // 
            // numberofprcess
            // 
            this.numberofprcess.AutoSize = true;
            this.numberofprcess.BackColor = System.Drawing.Color.White;
            this.numberofprcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofprcess.ForeColor = System.Drawing.Color.Black;
            this.numberofprcess.Location = new System.Drawing.Point(7, 61);
            this.numberofprcess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberofprcess.Name = "numberofprcess";
            this.numberofprcess.Size = new System.Drawing.Size(255, 25);
            this.numberofprcess.TabIndex = 1;
            this.numberofprcess.Text = "Enter Number Of Processes";
            // 
            // numberofresources
            // 
            this.numberofresources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberofresources.Location = new System.Drawing.Point(309, 17);
            this.numberofresources.Margin = new System.Windows.Forms.Padding(2);
            this.numberofresources.Multiline = true;
            this.numberofresources.Name = "numberofresources";
            this.numberofresources.Size = new System.Drawing.Size(101, 24);
            this.numberofresources.TabIndex = 2;
            this.numberofresources.Text = "0";
            this.numberofresources.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberofprocess
            // 
            this.numberofprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberofprocess.Location = new System.Drawing.Point(309, 66);
            this.numberofprocess.Margin = new System.Windows.Forms.Padding(2);
            this.numberofprocess.Multiline = true;
            this.numberofprocess.Name = "numberofprocess";
            this.numberofprocess.Size = new System.Drawing.Size(101, 24);
            this.numberofprocess.TabIndex = 3;
            this.numberofprocess.Text = "0";
            this.numberofprocess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterresource
            // 
            this.enterresource.BackColor = System.Drawing.Color.Navy;
            this.enterresource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterresource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterresource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterresource.Location = new System.Drawing.Point(448, 13);
            this.enterresource.Margin = new System.Windows.Forms.Padding(2);
            this.enterresource.Name = "enterresource";
            this.enterresource.Size = new System.Drawing.Size(138, 40);
            this.enterresource.TabIndex = 4;
            this.enterresource.Text = "Enter";
            this.enterresource.UseVisualStyleBackColor = false;
            this.enterresource.Click += new System.EventHandler(this.enterresource_Click);
            // 
            // enterprocess
            // 
            this.enterprocess.BackColor = System.Drawing.Color.Navy;
            this.enterprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterprocess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterprocess.Location = new System.Drawing.Point(449, 65);
            this.enterprocess.Margin = new System.Windows.Forms.Padding(2);
            this.enterprocess.Name = "enterprocess";
            this.enterprocess.Size = new System.Drawing.Size(136, 39);
            this.enterprocess.TabIndex = 5;
            this.enterprocess.Text = "Enter";
            this.enterprocess.UseVisualStyleBackColor = false;
            this.enterprocess.Click += new System.EventHandler(this.enterprocess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter total number of resources";
            // 
            // dataGridViewtotal
            // 
            this.dataGridViewtotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewtotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewtotal.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewtotal.GridColor = System.Drawing.Color.Black;
            this.dataGridViewtotal.Location = new System.Drawing.Point(6, 170);
            this.dataGridViewtotal.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewtotal.Name = "dataGridViewtotal";
            this.dataGridViewtotal.RowHeadersWidth = 51;
            this.dataGridViewtotal.RowTemplate.Height = 24;
            this.dataGridViewtotal.Size = new System.Drawing.Size(355, 99);
            this.dataGridViewtotal.TabIndex = 7;
            this.dataGridViewtotal.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridViewtotal_AllowUserToAddRowsChanged);
            this.dataGridViewtotal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtotal_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Available number of resources";
            // 
            // dataGridViewava
            // 
            this.dataGridViewava.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewava.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewava.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewava.GridColor = System.Drawing.Color.Black;
            this.dataGridViewava.Location = new System.Drawing.Point(14, 302);
            this.dataGridViewava.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewava.Name = "dataGridViewava";
            this.dataGridViewava.RowHeadersWidth = 51;
            this.dataGridViewava.RowTemplate.Height = 24;
            this.dataGridViewava.Size = new System.Drawing.Size(355, 82);
            this.dataGridViewava.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Enter Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Processes (currently allocated resources)";
            // 
            // dataGridViewcurrent
            // 
            this.dataGridViewcurrent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcurrent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewcurrent.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewcurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewcurrent.GridColor = System.Drawing.Color.Black;
            this.dataGridViewcurrent.Location = new System.Drawing.Point(13, 433);
            this.dataGridViewcurrent.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewcurrent.Name = "dataGridViewcurrent";
            this.dataGridViewcurrent.RowHeadersWidth = 51;
            this.dataGridViewcurrent.RowTemplate.Height = 24;
            this.dataGridViewcurrent.Size = new System.Drawing.Size(355, 110);
            this.dataGridViewcurrent.TabIndex = 14;
            // 
            // entercurrentdata
            // 
            this.entercurrentdata.BackColor = System.Drawing.Color.Navy;
            this.entercurrentdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entercurrentdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entercurrentdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entercurrentdata.Location = new System.Drawing.Point(384, 470);
            this.entercurrentdata.Margin = new System.Windows.Forms.Padding(2);
            this.entercurrentdata.Name = "entercurrentdata";
            this.entercurrentdata.Size = new System.Drawing.Size(202, 38);
            this.entercurrentdata.TabIndex = 15;
            this.entercurrentdata.Text = "Enter Data";
            this.entercurrentdata.UseVisualStyleBackColor = false;
            this.entercurrentdata.Click += new System.EventHandler(this.entercurrentdata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 552);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Processes (maximum resources)";
            // 
            // dataGridViewmax
            // 
            this.dataGridViewmax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewmax.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewmax.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewmax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewmax.GridColor = System.Drawing.Color.Black;
            this.dataGridViewmax.Location = new System.Drawing.Point(12, 598);
            this.dataGridViewmax.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewmax.Name = "dataGridViewmax";
            this.dataGridViewmax.RowHeadersWidth = 51;
            this.dataGridViewmax.RowTemplate.Height = 24;
            this.dataGridViewmax.Size = new System.Drawing.Size(350, 122);
            this.dataGridViewmax.TabIndex = 17;
            // 
            // entermaxdata
            // 
            this.entermaxdata.BackColor = System.Drawing.Color.Navy;
            this.entermaxdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entermaxdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entermaxdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entermaxdata.Location = new System.Drawing.Point(384, 650);
            this.entermaxdata.Margin = new System.Windows.Forms.Padding(2);
            this.entermaxdata.Name = "entermaxdata";
            this.entermaxdata.Size = new System.Drawing.Size(202, 38);
            this.entermaxdata.TabIndex = 18;
            this.entermaxdata.Text = "Enter Data";
            this.entermaxdata.UseVisualStyleBackColor = false;
            this.entermaxdata.Click += new System.EventHandler(this.entermaxdata_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(698, 507);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(471, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "would you know it is safe or not safe ?";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(747, 255);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 45);
            this.button3.TabIndex = 20;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewremaining
            // 
            this.dataGridViewremaining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewremaining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewremaining.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewremaining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewremaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewremaining.GridColor = System.Drawing.Color.Black;
            this.dataGridViewremaining.Location = new System.Drawing.Point(705, 315);
            this.dataGridViewremaining.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewremaining.Name = "dataGridViewremaining";
            this.dataGridViewremaining.RowHeadersWidth = 51;
            this.dataGridViewremaining.RowTemplate.Height = 24;
            this.dataGridViewremaining.Size = new System.Drawing.Size(355, 151);
            this.dataGridViewremaining.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(679, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = " Request Some Resources";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(680, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Select a process";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(680, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Select a Resource";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(680, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Number of requested Resources";
            // 
            // textBoxreqnumber
            // 
            this.textBoxreqnumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxreqnumber.Location = new System.Drawing.Point(1071, 150);
            this.textBoxreqnumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxreqnumber.Multiline = true;
            this.textBoxreqnumber.Name = "textBoxreqnumber";
            this.textBoxreqnumber.Size = new System.Drawing.Size(83, 24);
            this.textBoxreqnumber.TabIndex = 29;
            this.textBoxreqnumber.Text = "0";
            this.textBoxreqnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1213, 95);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 48);
            this.button5.TabIndex = 30;
            this.button5.Text = "Apply";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxresource
            // 
            this.textBoxresource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxresource.Location = new System.Drawing.Point(994, 106);
            this.textBoxresource.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxresource.Multiline = true;
            this.textBoxresource.Name = "textBoxresource";
            this.textBoxresource.Size = new System.Drawing.Size(160, 24);
            this.textBoxresource.TabIndex = 33;
            this.textBoxresource.Text = "0";
            this.textBoxresource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxprocess
            // 
            this.textBoxprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxprocess.Location = new System.Drawing.Point(994, 75);
            this.textBoxprocess.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxprocess.Multiline = true;
            this.textBoxprocess.Name = "textBoxprocess";
            this.textBoxprocess.Size = new System.Drawing.Size(160, 24);
            this.textBoxprocess.TabIndex = 34;
            this.textBoxprocess.Text = "0";
            this.textBoxprocess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Navy;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(747, 572);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(285, 45);
            this.button8.TabIndex = 36;
            this.button8.Text = "YES";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(679, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(360, 31);
            this.label10.TabIndex = 37;
            this.label10.Text = "show output needed matrix ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(608, 744);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(847, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "https://www.youtube.com/watch?v=enewMch9vaM&list=PLb6C49tXQ0xB_iJK3J_p2gU73ct64B0" +
    "on&index=5&t=1341s";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(616, 719);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "for more information click down";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1412, 773);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBoxprocess);
            this.Controls.Add(this.textBoxresource);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxreqnumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewremaining);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.entermaxdata);
            this.Controls.Add(this.dataGridViewmax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entercurrentdata);
            this.Controls.Add(this.dataGridViewcurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterprocess);
            this.Controls.Add(this.enterresource);
            this.Controls.Add(this.numberofprocess);
            this.Controls.Add(this.numberofresources);
            this.Controls.Add(this.numberofprcess);
            this.Controls.Add(this.resourcesnumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banker\'s Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewremaining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resourcesnumber;
        private System.Windows.Forms.Label numberofprcess;
        private System.Windows.Forms.TextBox numberofresources;
        private System.Windows.Forms.TextBox numberofprocess;
        private System.Windows.Forms.Button enterresource;
        private System.Windows.Forms.Button enterprocess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewava;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewcurrent;
        private System.Windows.Forms.Button entercurrentdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewmax;
        private System.Windows.Forms.Button entermaxdata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewremaining;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxreqnumber;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxresource;
        private System.Windows.Forms.TextBox textBoxprocess;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

