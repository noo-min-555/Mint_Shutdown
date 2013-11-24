namespace Mint_Shutdown
{
    partial class ShutDown
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.เมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดเครองToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รสตารทToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.วธใชToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonshutdown = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.labeltimeleft = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เมนToolStripMenuItem,
            this.วธใชToolStripMenuItem,
            this.เกยวกบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(304, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // เมนToolStripMenuItem
            // 
            this.เมนToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ปดเครองToolStripMenuItem,
            this.รสตารทToolStripMenuItem,
            this.ปดโปรแกรมToolStripMenuItem});
            this.เมนToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem";
            this.เมนToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.เมนToolStripMenuItem.Text = "เมนู";
            // 
            // ปดเครองToolStripMenuItem
            // 
            this.ปดเครองToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.ปดเครองToolStripMenuItem.Name = "ปดเครองToolStripMenuItem";
            this.ปดเครองToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ปดเครองToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.ปดเครองToolStripMenuItem.Text = "ปิดเครื่อง";
            this.ปดเครองToolStripMenuItem.Click += new System.EventHandler(this.ปดเครองToolStripMenuItem_Click);
            // 
            // รสตารทToolStripMenuItem
            // 
            this.รสตารทToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.รสตารทToolStripMenuItem.Name = "รสตารทToolStripMenuItem";
            this.รสตารทToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.รสตารทToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.รสตารทToolStripMenuItem.Text = "รีสตาร์ท";
            this.รสตารทToolStripMenuItem.Click += new System.EventHandler(this.รสตารทToolStripMenuItem_Click);
            // 
            // ปดโปรแกรมToolStripMenuItem
            // 
            this.ปดโปรแกรมToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.ปดโปรแกรมToolStripMenuItem.Name = "ปดโปรแกรมToolStripMenuItem";
            this.ปดโปรแกรมToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ปดโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.ปดโปรแกรมToolStripMenuItem.Text = "ปิดโปรแกรม ";
            this.ปดโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.ปดโปรแกรมToolStripMenuItem_Click);
            // 
            // วธใชToolStripMenuItem
            // 
            this.วธใชToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.วธใชToolStripMenuItem.Name = "วธใชToolStripMenuItem";
            this.วธใชToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.วธใชToolStripMenuItem.Text = "วิธีใช้";
            this.วธใชToolStripMenuItem.Click += new System.EventHandler(this.วธใชToolStripMenuItem_Click);
            // 
            // เกยวกบToolStripMenuItem
            // 
            this.เกยวกบToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.เกยวกบToolStripMenuItem.Name = "เกยวกบToolStripMenuItem";
            this.เกยวกบToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.เกยวกบToolStripMenuItem.Text = "เกี่ยวกับ";
            this.เกยวกบToolStripMenuItem.Click += new System.EventHandler(this.เกยวกบToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "เวลาปัจจุบัน          :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "จะปิดเครื่องใน      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "เลือกเวลา";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Green;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox1.Location = new System.Drawing.Point(13, 177);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.Green;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(125, 180);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(225, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "น.";
            // 
            // buttonshutdown
            // 
            this.buttonshutdown.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonshutdown.Location = new System.Drawing.Point(29, 233);
            this.buttonshutdown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonshutdown.Name = "buttonshutdown";
            this.buttonshutdown.Size = new System.Drawing.Size(136, 28);
            this.buttonshutdown.TabIndex = 7;
            this.buttonshutdown.Text = "ตั้งเวลาปิดเครื่อง";
            this.buttonshutdown.UseVisualStyleBackColor = true;
            this.buttonshutdown.Click += new System.EventHandler(this.buttonshutdown_Click);
            this.buttonshutdown.DragOver += new System.Windows.Forms.DragEventHandler(this.buttonshutdown_DragOver);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "   ";
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.ForeColor = System.Drawing.Color.Coral;
            this.labeltime.Location = new System.Drawing.Point(152, 52);
            this.labeltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(0, 17);
            this.labeltime.TabIndex = 12;
            // 
            // labeltimeleft
            // 
            this.labeltimeleft.AutoSize = true;
            this.labeltimeleft.ForeColor = System.Drawing.Color.DarkViolet;
            this.labeltimeleft.Location = new System.Drawing.Point(152, 102);
            this.labeltimeleft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltimeleft.Name = "labeltimeleft";
            this.labeltimeleft.Size = new System.Drawing.Size(0, 17);
            this.labeltimeleft.TabIndex = 13;
            // 
            // ShutDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(304, 290);
            this.Controls.Add(this.labeltimeleft);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonshutdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShutDown";
            this.Text = "Mint_Shutdown";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.ShutDown_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem เมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดเครองToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รสตารทToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem วธใชToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonshutdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label labeltimeleft;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบToolStripMenuItem;
    }
}

