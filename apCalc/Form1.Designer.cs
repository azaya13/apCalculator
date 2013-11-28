namespace apCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_skills = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.box_totalAP = new System.Windows.Forms.TextBox();
            this.label_totalAP = new System.Windows.Forms.Label();
            this.label_totalCombat = new System.Windows.Forms.Label();
            this.box_totalCombat = new System.Windows.Forms.TextBox();
            this.box_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_otherAp = new System.Windows.Forms.Label();
            this.toolTip_brionac = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheAPCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedBox_brionac = new System.Windows.Forms.MaskedTextBox();
            this.tab_skills.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_skills
            // 
            this.tab_skills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_skills.Controls.Add(this.tabPage1);
            this.tab_skills.Controls.Add(this.tabPage2);
            this.tab_skills.Location = new System.Drawing.Point(249, 156);
            this.tab_skills.Name = "tab_skills";
            this.tab_skills.SelectedIndex = 0;
            this.tab_skills.Size = new System.Drawing.Size(595, 537);
            this.tab_skills.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Combat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 512);
            this.button1.TabIndex = 0;
            this.button1.Text = "This is the Combat page";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // box_totalAP
            // 
            this.box_totalAP.Location = new System.Drawing.Point(117, 669);
            this.box_totalAP.Name = "box_totalAP";
            this.box_totalAP.ReadOnly = true;
            this.box_totalAP.Size = new System.Drawing.Size(112, 20);
            this.box_totalAP.TabIndex = 5;
            this.box_totalAP.Text = "0";
            // 
            // label_totalAP
            // 
            this.label_totalAP.AutoSize = true;
            this.label_totalAP.Location = new System.Drawing.Point(21, 676);
            this.label_totalAP.Name = "label_totalAP";
            this.label_totalAP.Size = new System.Drawing.Size(80, 13);
            this.label_totalAP.TabIndex = 6;
            this.label_totalAP.Text = "Total AP spent:";
            // 
            // label_totalCombat
            // 
            this.label_totalCombat.AutoSize = true;
            this.label_totalCombat.Location = new System.Drawing.Point(28, 257);
            this.label_totalCombat.Name = "label_totalCombat";
            this.label_totalCombat.Size = new System.Drawing.Size(73, 13);
            this.label_totalCombat.TabIndex = 8;
            this.label_totalCombat.Text = "Total Combat:";
            // 
            // box_totalCombat
            // 
            this.box_totalCombat.Location = new System.Drawing.Point(117, 253);
            this.box_totalCombat.Name = "box_totalCombat";
            this.box_totalCombat.ReadOnly = true;
            this.box_totalCombat.Size = new System.Drawing.Size(112, 20);
            this.box_totalCombat.TabIndex = 7;
            this.box_totalCombat.Text = "0";
            // 
            // box_1
            // 
            this.box_1.Location = new System.Drawing.Point(117, 295);
            this.box_1.Name = "box_1";
            this.box_1.ReadOnly = true;
            this.box_1.Size = new System.Drawing.Size(112, 20);
            this.box_1.TabIndex = 9;
            this.box_1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label_otherAp
            // 
            this.label_otherAp.AutoSize = true;
            this.label_otherAp.Location = new System.Drawing.Point(22, 599);
            this.label_otherAp.Name = "label_otherAp";
            this.label_otherAp.Size = new System.Drawing.Size(80, 13);
            this.label_otherAp.TabIndex = 12;
            this.label_otherAp.Text = "Brionac repairs:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSaveToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadSaveToolStripMenuItem
            // 
            this.loadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.loadSaveToolStripMenuItem.Name = "loadSaveToolStripMenuItem";
            this.loadSaveToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.loadSaveToolStripMenuItem.Text = "Load/Save";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutTheAPCalculatorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.helpToolStripMenuItem.Text = "Help!";
            // 
            // aboutTheAPCalculatorToolStripMenuItem
            // 
            this.aboutTheAPCalculatorToolStripMenuItem.Name = "aboutTheAPCalculatorToolStripMenuItem";
            this.aboutTheAPCalculatorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutTheAPCalculatorToolStripMenuItem.Text = "About the AP Calculator";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Character name:";
            // 
            // maskedBox_brionac
            // 
            this.maskedBox_brionac.BeepOnError = true;
            this.maskedBox_brionac.Location = new System.Drawing.Point(117, 596);
            this.maskedBox_brionac.Name = "maskedBox_brionac";
            this.maskedBox_brionac.Size = new System.Drawing.Size(112, 20);
            this.maskedBox_brionac.TabIndex = 15;
            this.maskedBox_brionac.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 714);
            this.Controls.Add(this.maskedBox_brionac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_otherAp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_1);
            this.Controls.Add(this.label_totalCombat);
            this.Controls.Add(this.box_totalCombat);
            this.Controls.Add(this.label_totalAP);
            this.Controls.Add(this.box_totalAP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tab_skills);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AP Calculator";
            this.tab_skills.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_skills;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox box_totalAP;
        private System.Windows.Forms.Label label_totalAP;
        private System.Windows.Forms.Label label_totalCombat;
        private System.Windows.Forms.TextBox box_totalCombat;
        private System.Windows.Forms.TextBox box_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_otherAp;
        private System.Windows.Forms.ToolTip toolTip_brionac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheAPCalculatorToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedBox_brionac;
    }
}

