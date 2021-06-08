namespace FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClashPanel = new System.Windows.Forms.Panel();
            this.SuggestBTN = new System.Windows.Forms.Button();
            this.CongoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimeTableClashGrid = new System.Windows.Forms.DataGridView();
            this.ClashCheckPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckClashBTN = new System.Windows.Forms.Button();
            this.BatchCB3 = new System.Windows.Forms.ComboBox();
            this.BatchCB2 = new System.Windows.Forms.ComboBox();
            this.BatchCB1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SectionCB3 = new System.Windows.Forms.ComboBox();
            this.SectionCB2 = new System.Windows.Forms.ComboBox();
            this.SectionCB1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Course3_CB = new System.Windows.Forms.ComboBox();
            this.Course2_CB = new System.Windows.Forms.ComboBox();
            this.Course1_CB = new System.Windows.Forms.ComboBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTableClashGrid)).BeginInit();
            this.ClashCheckPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClashPanel
            // 
            this.ClashPanel.BackColor = System.Drawing.Color.Maroon;
            this.ClashPanel.Controls.Add(this.SuggestBTN);
            this.ClashPanel.Controls.Add(this.CongoLabel);
            this.ClashPanel.Controls.Add(this.button1);
            this.ClashPanel.Controls.Add(this.TimeTableClashGrid);
            this.ClashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClashPanel.Location = new System.Drawing.Point(0, 0);
            this.ClashPanel.Name = "ClashPanel";
            this.ClashPanel.Size = new System.Drawing.Size(903, 342);
            this.ClashPanel.TabIndex = 7;
            this.ClashPanel.Visible = false;
            // 
            // SuggestBTN
            // 
            this.SuggestBTN.BackColor = System.Drawing.Color.Linen;
            this.SuggestBTN.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestBTN.Location = new System.Drawing.Point(670, 222);
            this.SuggestBTN.Name = "SuggestBTN";
            this.SuggestBTN.Size = new System.Drawing.Size(116, 29);
            this.SuggestBTN.TabIndex = 3;
            this.SuggestBTN.Text = "Suggestions>>";
            this.SuggestBTN.UseVisualStyleBackColor = false;
            this.SuggestBTN.Visible = false;
            this.SuggestBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // CongoLabel
            // 
            this.CongoLabel.AutoSize = true;
            this.CongoLabel.BackColor = System.Drawing.Color.Maroon;
            this.CongoLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongoLabel.ForeColor = System.Drawing.Color.Yellow;
            this.CongoLabel.Location = new System.Drawing.Point(31, 222);
            this.CongoLabel.Name = "CongoLabel";
            this.CongoLabel.Size = new System.Drawing.Size(0, 79);
            this.CongoLabel.TabIndex = 2;
            this.CongoLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeTableClashGrid
            // 
            this.TimeTableClashGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TimeTableClashGrid.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.TimeTableClashGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTableClashGrid.GridColor = System.Drawing.SystemColors.GrayText;
            this.TimeTableClashGrid.Location = new System.Drawing.Point(14, 58);
            this.TimeTableClashGrid.Name = "TimeTableClashGrid";
            this.TimeTableClashGrid.Size = new System.Drawing.Size(812, 150);
            this.TimeTableClashGrid.TabIndex = 0;
            this.TimeTableClashGrid.Visible = false;
            // 
            // ClashCheckPanel
            // 
            this.ClashCheckPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClashCheckPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClashCheckPanel.BackgroundImage")));
            this.ClashCheckPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClashCheckPanel.Controls.Add(this.label9);
            this.ClashCheckPanel.Controls.Add(this.CheckClashBTN);
            this.ClashCheckPanel.Controls.Add(this.BatchCB3);
            this.ClashCheckPanel.Controls.Add(this.BatchCB2);
            this.ClashCheckPanel.Controls.Add(this.BatchCB1);
            this.ClashCheckPanel.Controls.Add(this.label13);
            this.ClashCheckPanel.Controls.Add(this.label12);
            this.ClashCheckPanel.Controls.Add(this.label11);
            this.ClashCheckPanel.Controls.Add(this.SectionCB3);
            this.ClashCheckPanel.Controls.Add(this.SectionCB2);
            this.ClashCheckPanel.Controls.Add(this.SectionCB1);
            this.ClashCheckPanel.Controls.Add(this.label8);
            this.ClashCheckPanel.Controls.Add(this.label7);
            this.ClashCheckPanel.Controls.Add(this.label6);
            this.ClashCheckPanel.Controls.Add(this.label5);
            this.ClashCheckPanel.Controls.Add(this.label4);
            this.ClashCheckPanel.Controls.Add(this.label3);
            this.ClashCheckPanel.Controls.Add(this.Course3_CB);
            this.ClashCheckPanel.Controls.Add(this.Course2_CB);
            this.ClashCheckPanel.Controls.Add(this.Course1_CB);
            this.ClashCheckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClashCheckPanel.Location = new System.Drawing.Point(0, 0);
            this.ClashCheckPanel.Name = "ClashCheckPanel";
            this.ClashCheckPanel.Size = new System.Drawing.Size(903, 342);
            this.ClashCheckPanel.TabIndex = 6;
            this.ClashCheckPanel.Visible = false;
            this.ClashCheckPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ClashCheckPanel_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Location = new System.Drawing.Point(236, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(419, 54);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select Courses";
            // 
            // CheckClashBTN
            // 
            this.CheckClashBTN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckClashBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckClashBTN.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckClashBTN.Location = new System.Drawing.Point(360, 266);
            this.CheckClashBTN.Name = "CheckClashBTN";
            this.CheckClashBTN.Size = new System.Drawing.Size(118, 37);
            this.CheckClashBTN.TabIndex = 23;
            this.CheckClashBTN.Text = "Proceed";
            this.CheckClashBTN.UseVisualStyleBackColor = false;
            this.CheckClashBTN.Click += new System.EventHandler(this.CheckClashBTN_Click);
            // 
            // BatchCB3
            // 
            this.BatchCB3.BackColor = System.Drawing.SystemColors.Control;
            this.BatchCB3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.BatchCB3.FormattingEnabled = true;
            this.BatchCB3.Location = new System.Drawing.Point(483, 210);
            this.BatchCB3.Name = "BatchCB3";
            this.BatchCB3.Size = new System.Drawing.Size(67, 26);
            this.BatchCB3.TabIndex = 22;
            this.BatchCB3.SelectedIndexChanged += new System.EventHandler(this.BatchCB3_SelectedIndexChanged);
            // 
            // BatchCB2
            // 
            this.BatchCB2.BackColor = System.Drawing.SystemColors.Control;
            this.BatchCB2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.BatchCB2.FormattingEnabled = true;
            this.BatchCB2.Location = new System.Drawing.Point(483, 149);
            this.BatchCB2.Name = "BatchCB2";
            this.BatchCB2.Size = new System.Drawing.Size(67, 26);
            this.BatchCB2.TabIndex = 21;
            this.BatchCB2.SelectedIndexChanged += new System.EventHandler(this.BatchCB2_SelectedIndexChanged);
            // 
            // BatchCB1
            // 
            this.BatchCB1.BackColor = System.Drawing.SystemColors.Control;
            this.BatchCB1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.BatchCB1.FormattingEnabled = true;
            this.BatchCB1.Location = new System.Drawing.Point(483, 97);
            this.BatchCB1.Name = "BatchCB1";
            this.BatchCB1.Size = new System.Drawing.Size(67, 26);
            this.BatchCB1.TabIndex = 20;
            this.BatchCB1.SelectedIndexChanged += new System.EventHandler(this.BatchCB1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(654, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Section:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(654, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Section:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(654, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Section:";
            // 
            // SectionCB3
            // 
            this.SectionCB3.BackColor = System.Drawing.SystemColors.Control;
            this.SectionCB3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.SectionCB3.FormattingEnabled = true;
            this.SectionCB3.Location = new System.Drawing.Point(740, 207);
            this.SectionCB3.Name = "SectionCB3";
            this.SectionCB3.Size = new System.Drawing.Size(67, 26);
            this.SectionCB3.TabIndex = 14;
            // 
            // SectionCB2
            // 
            this.SectionCB2.BackColor = System.Drawing.SystemColors.Control;
            this.SectionCB2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.SectionCB2.FormattingEnabled = true;
            this.SectionCB2.Location = new System.Drawing.Point(740, 149);
            this.SectionCB2.Name = "SectionCB2";
            this.SectionCB2.Size = new System.Drawing.Size(67, 26);
            this.SectionCB2.TabIndex = 13;
            // 
            // SectionCB1
            // 
            this.SectionCB1.BackColor = System.Drawing.SystemColors.Control;
            this.SectionCB1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.SectionCB1.FormattingEnabled = true;
            this.SectionCB1.Location = new System.Drawing.Point(737, 95);
            this.SectionCB1.Name = "SectionCB1";
            this.SectionCB1.Size = new System.Drawing.Size(67, 26);
            this.SectionCB1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(378, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Batch:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(378, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Batch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(378, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Batch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(26, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Course 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course 1:";
            // 
            // Course3_CB
            // 
            this.Course3_CB.BackColor = System.Drawing.SystemColors.Control;
            this.Course3_CB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.Course3_CB.FormattingEnabled = true;
            this.Course3_CB.Location = new System.Drawing.Point(112, 211);
            this.Course3_CB.Name = "Course3_CB";
            this.Course3_CB.Size = new System.Drawing.Size(163, 26);
            this.Course3_CB.TabIndex = 2;
            this.Course3_CB.SelectedIndexChanged += new System.EventHandler(this.Course3_CB_SelectedIndexChanged);
            // 
            // Course2_CB
            // 
            this.Course2_CB.BackColor = System.Drawing.SystemColors.Control;
            this.Course2_CB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic);
            this.Course2_CB.FormattingEnabled = true;
            this.Course2_CB.Location = new System.Drawing.Point(112, 154);
            this.Course2_CB.Name = "Course2_CB";
            this.Course2_CB.Size = new System.Drawing.Size(163, 26);
            this.Course2_CB.TabIndex = 1;
            this.Course2_CB.SelectedIndexChanged += new System.EventHandler(this.Course2_CB_SelectedIndexChanged);
            // 
            // Course1_CB
            // 
            this.Course1_CB.BackColor = System.Drawing.SystemColors.Control;
            this.Course1_CB.DropDownWidth = 163;
            this.Course1_CB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course1_CB.FormattingEnabled = true;
            this.Course1_CB.ItemHeight = 18;
            this.Course1_CB.Location = new System.Drawing.Point(112, 95);
            this.Course1_CB.Name = "Course1_CB";
            this.Course1_CB.Size = new System.Drawing.Size(163, 26);
            this.Course1_CB.TabIndex = 0;
            this.Course1_CB.SelectedIndexChanged += new System.EventHandler(this.Course1_CB_SelectedIndexChanged);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginPanel.Controls.Add(this.label10);
            this.LoginPanel.Controls.Add(this.LoginBTN);
            this.LoginPanel.Controls.Add(this.PasswordTB);
            this.LoginPanel.Controls.Add(this.UsernameTB);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(903, 342);
            this.LoginPanel.TabIndex = 5;
            this.LoginPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Harrington", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(240, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(580, 94);
            this.label10.TabIndex = 5;
            this.label10.Text = "Clash Identifier";
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBTN.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.Location = new System.Drawing.Point(383, 266);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(134, 37);
            this.LoginBTN.TabIndex = 4;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic);
            this.PasswordTB.ForeColor = System.Drawing.Color.Black;
            this.PasswordTB.Location = new System.Drawing.Point(383, 207);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(146, 29);
            this.PasswordTB.TabIndex = 3;
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.SystemColors.Window;
            this.UsernameTB.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.ForeColor = System.Drawing.Color.Black;
            this.UsernameTB.Location = new System.Drawing.Point(383, 151);
            this.UsernameTB.MaxLength = 8;
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(146, 29);
            this.UsernameTB.TabIndex = 2;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(255, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll No.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(903, 342);
            this.Controls.Add(this.ClashPanel);
            this.Controls.Add(this.ClashCheckPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.Text = "Time Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClashPanel.ResumeLayout(false);
            this.ClashPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTableClashGrid)).EndInit();
            this.ClashCheckPanel.ResumeLayout(false);
            this.ClashCheckPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel ClashCheckPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Course3_CB;
        private System.Windows.Forms.ComboBox Course2_CB;
        private System.Windows.Forms.ComboBox Course1_CB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SectionCB3;
        private System.Windows.Forms.ComboBox SectionCB2;
        private System.Windows.Forms.ComboBox SectionCB1;
        private System.Windows.Forms.ComboBox BatchCB3;
        private System.Windows.Forms.ComboBox BatchCB2;
        private System.Windows.Forms.ComboBox BatchCB1;
        private System.Windows.Forms.Button CheckClashBTN;
        private System.Windows.Forms.Panel ClashPanel;
        private System.Windows.Forms.DataGridView TimeTableClashGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CongoLabel;
        private System.Windows.Forms.Button SuggestBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

    }
}

