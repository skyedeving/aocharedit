namespace Attorney_Online_Character_Editor
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
            this.iniFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.preanimationTimeValueBox = new System.Windows.Forms.NumericUpDown();
            this.preanimationsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.blipSelectList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.positionSelectList = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.preanimationTimer = new System.Windows.Forms.Timer(this.components);
            this.emotionsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.emotionSettingTextBox = new System.Windows.Forms.TextBox();
            this.sfxTextBox = new System.Windows.Forms.TextBox();
            this.sfxTimeValueBox = new System.Windows.Forms.NumericUpDown();
            this.spriteBox = new System.Windows.Forms.PictureBox();
            this.takeThatButton = new System.Windows.Forms.Button();
            this.objectionButton = new System.Windows.Forms.Button();
            this.holdItButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.emotionsButtonOff = new System.Windows.Forms.Button();
            this.emotionsButtonOn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sfxTimer = new System.Windows.Forms.Timer(this.components);
            this.emotionTimer = new System.Windows.Forms.Timer(this.components);
            this.blipTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.preanimationTimeValueBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfxTimeValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iniFileDialog
            // 
            this.iniFileDialog.Filter = "Ini Files|*.ini";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time Units (not msec)";
            // 
            // preanimationTimeValueBox
            // 
            this.preanimationTimeValueBox.Location = new System.Drawing.Point(130, 22);
            this.preanimationTimeValueBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.preanimationTimeValueBox.Name = "preanimationTimeValueBox";
            this.preanimationTimeValueBox.ReadOnly = true;
            this.preanimationTimeValueBox.Size = new System.Drawing.Size(200, 20);
            this.preanimationTimeValueBox.TabIndex = 1;
            this.preanimationTimeValueBox.ValueChanged += new System.EventHandler(this.preanimationTimeValueBox_ValueChanged);
            // 
            // preanimationsListBox
            // 
            this.preanimationsListBox.FormattingEnabled = true;
            this.preanimationsListBox.Location = new System.Drawing.Point(6, 6);
            this.preanimationsListBox.Name = "preanimationsListBox";
            this.preanimationsListBox.Size = new System.Drawing.Size(115, 186);
            this.preanimationsListBox.TabIndex = 0;
            this.preanimationsListBox.SelectedIndexChanged += new System.EventHandler(this.preanimationsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // blipSelectList
            // 
            this.blipSelectList.DisplayMember = "3";
            this.blipSelectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blipSelectList.FormattingEnabled = true;
            this.blipSelectList.Items.AddRange(new object[] {
            "male",
            "female",
            "layton",
            "zelda"});
            this.blipSelectList.Location = new System.Drawing.Point(9, 58);
            this.blipSelectList.Name = "blipSelectList";
            this.blipSelectList.Size = new System.Drawing.Size(100, 21);
            this.blipSelectList.TabIndex = 7;
            this.blipSelectList.SelectedIndexChanged += new System.EventHandler(this.blipSelectList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Position";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(118, 19);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 5;
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.clientNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BlipSFX";
            // 
            // positionSelectList
            // 
            this.positionSelectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionSelectList.Items.AddRange(new object[] {
            "def",
            "pro",
            "jud",
            "wit",
            "hld",
            "hlp"});
            this.positionSelectList.Location = new System.Drawing.Point(118, 58);
            this.positionSelectList.Name = "positionSelectList";
            this.positionSelectList.Size = new System.Drawing.Size(100, 21);
            this.positionSelectList.TabIndex = 9;
            this.positionSelectList.SelectedIndexChanged += new System.EventHandler(this.positionSelectList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ini";
            this.saveFileDialog1.Filter = "ini Files|*.ini";
            // 
            // preanimationTimer
            // 
            this.preanimationTimer.Tick += new System.EventHandler(this.preanimationTimer_Tick);
            // 
            // emotionsListBox
            // 
            this.emotionsListBox.FormattingEnabled = true;
            this.emotionsListBox.Location = new System.Drawing.Point(6, 6);
            this.emotionsListBox.Name = "emotionsListBox";
            this.emotionsListBox.Size = new System.Drawing.Size(51, 186);
            this.emotionsListBox.TabIndex = 0;
            this.emotionsListBox.SelectedIndexChanged += new System.EventHandler(this.emotionsListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "On";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Off";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Comment#Idle/Preanimation#Talking#Mode#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "SFX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "SFX Time Units (not msec)";
            // 
            // emotionSettingTextBox
            // 
            this.emotionSettingTextBox.Location = new System.Drawing.Point(63, 90);
            this.emotionSettingTextBox.Name = "emotionSettingTextBox";
            this.emotionSettingTextBox.Size = new System.Drawing.Size(259, 20);
            this.emotionSettingTextBox.TabIndex = 8;
            this.emotionSettingTextBox.TextChanged += new System.EventHandler(this.emotionSettingTextBox_TextChanged);
            // 
            // sfxTextBox
            // 
            this.sfxTextBox.Location = new System.Drawing.Point(63, 129);
            this.sfxTextBox.Name = "sfxTextBox";
            this.sfxTextBox.Size = new System.Drawing.Size(259, 20);
            this.sfxTextBox.TabIndex = 9;
            this.sfxTextBox.TextChanged += new System.EventHandler(this.sfxTextBox_TextChanged);
            // 
            // sfxTimeValueBox
            // 
            this.sfxTimeValueBox.Location = new System.Drawing.Point(63, 168);
            this.sfxTimeValueBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sfxTimeValueBox.Name = "sfxTimeValueBox";
            this.sfxTimeValueBox.Size = new System.Drawing.Size(259, 20);
            this.sfxTimeValueBox.TabIndex = 10;
            this.sfxTimeValueBox.ValueChanged += new System.EventHandler(this.sfxTimeValueBox_ValueChanged);
            // 
            // spriteBox
            // 
            this.spriteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spriteBox.Location = new System.Drawing.Point(12, 27);
            this.spriteBox.Name = "spriteBox";
            this.spriteBox.Size = new System.Drawing.Size(256, 192);
            this.spriteBox.TabIndex = 18;
            this.spriteBox.TabStop = false;
            // 
            // takeThatButton
            // 
            this.takeThatButton.BackColor = System.Drawing.Color.Transparent;
            this.takeThatButton.FlatAppearance.BorderSize = 0;
            this.takeThatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.takeThatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeThatButton.Image = global::Attorney_Online_Character_Editor.Properties.Resources.takeThatButtonOff;
            this.takeThatButton.Location = new System.Drawing.Point(184, 225);
            this.takeThatButton.Name = "takeThatButton";
            this.takeThatButton.Size = new System.Drawing.Size(75, 23);
            this.takeThatButton.TabIndex = 12;
            this.takeThatButton.UseVisualStyleBackColor = false;
            this.takeThatButton.Click += new System.EventHandler(this.takeThatButton_Click);
            this.takeThatButton.MouseEnter += new System.EventHandler(this.takeThatButton_MouseEnter);
            this.takeThatButton.MouseLeave += new System.EventHandler(this.takeThatButton_MouseLeave);
            // 
            // objectionButton
            // 
            this.objectionButton.BackColor = System.Drawing.Color.Transparent;
            this.objectionButton.FlatAppearance.BorderSize = 0;
            this.objectionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.objectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.objectionButton.Image = ((System.Drawing.Image)(resources.GetObject("objectionButton.Image")));
            this.objectionButton.Location = new System.Drawing.Point(103, 225);
            this.objectionButton.Name = "objectionButton";
            this.objectionButton.Size = new System.Drawing.Size(75, 23);
            this.objectionButton.TabIndex = 11;
            this.objectionButton.UseVisualStyleBackColor = false;
            this.objectionButton.Click += new System.EventHandler(this.objectionButton_Click);
            this.objectionButton.MouseEnter += new System.EventHandler(this.objectionButton_MouseEnter);
            this.objectionButton.MouseLeave += new System.EventHandler(this.objectionButton_MouseLeave);
            // 
            // holdItButton
            // 
            this.holdItButton.BackColor = System.Drawing.Color.Transparent;
            this.holdItButton.FlatAppearance.BorderSize = 0;
            this.holdItButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.holdItButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holdItButton.Image = global::Attorney_Online_Character_Editor.Properties.Resources.holdItButtonOff;
            this.holdItButton.Location = new System.Drawing.Point(22, 225);
            this.holdItButton.Name = "holdItButton";
            this.holdItButton.Size = new System.Drawing.Size(75, 23);
            this.holdItButton.TabIndex = 10;
            this.holdItButton.UseVisualStyleBackColor = false;
            this.holdItButton.Click += new System.EventHandler(this.holdItButton_Click);
            this.holdItButton.MouseEnter += new System.EventHandler(this.holdItButton_MouseEnter);
            this.holdItButton.MouseLeave += new System.EventHandler(this.holdItButton_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(274, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 222);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.emotionsButtonOff);
            this.tabPage1.Controls.Add(this.emotionsButtonOn);
            this.tabPage1.Controls.Add(this.emotionsListBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.sfxTimeValueBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.emotionSettingTextBox);
            this.tabPage1.Controls.Add(this.sfxTextBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emotions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // emotionsButtonOff
            // 
            this.emotionsButtonOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emotionsButtonOff.Location = new System.Drawing.Point(201, 22);
            this.emotionsButtonOff.Name = "emotionsButtonOff";
            this.emotionsButtonOff.Size = new System.Drawing.Size(40, 40);
            this.emotionsButtonOff.TabIndex = 12;
            this.emotionsButtonOff.UseVisualStyleBackColor = true;
            this.emotionsButtonOff.Click += new System.EventHandler(this.emotionsButtonOff_Click);
            // 
            // emotionsButtonOn
            // 
            this.emotionsButtonOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emotionsButtonOn.Location = new System.Drawing.Point(155, 22);
            this.emotionsButtonOn.Name = "emotionsButtonOn";
            this.emotionsButtonOn.Size = new System.Drawing.Size(40, 40);
            this.emotionsButtonOn.TabIndex = 11;
            this.emotionsButtonOn.UseVisualStyleBackColor = true;
            this.emotionsButtonOn.Click += new System.EventHandler(this.emotionsButtonOn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.preanimationsListBox);
            this.tabPage2.Controls.Add(this.preanimationTimeValueBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preanimations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.positionSelectList);
            this.tabPage3.Controls.Add(this.nameTextBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.blipSelectList);
            this.tabPage3.Controls.Add(this.clientNameTextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(331, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sfxTimer
            // 
            this.sfxTimer.Tick += new System.EventHandler(this.sfxTimer_Tick);
            // 
            // emotionTimer
            // 
            this.emotionTimer.Tick += new System.EventHandler(this.emotionTimer_Tick);
            // 
            // blipTimer
            // 
            this.blipTimer.Tick += new System.EventHandler(this.blipTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.spriteBox);
            this.Controls.Add(this.takeThatButton);
            this.Controls.Add(this.objectionButton);
            this.Controls.Add(this.holdItButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Attorney Online Character Editor";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.preanimationTimeValueBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfxTimeValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog iniFileDialog;
        private System.Windows.Forms.Button holdItButton;
        private System.Windows.Forms.Button takeThatButton;
        private System.Windows.Forms.Button objectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox blipSelectList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox positionSelectList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox preanimationsListBox;
        private System.Windows.Forms.PictureBox spriteBox;
        private System.Windows.Forms.Timer preanimationTimer;
        private System.Windows.Forms.NumericUpDown preanimationTimeValueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox emotionsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emotionSettingTextBox;
        private System.Windows.Forms.TextBox sfxTextBox;
        private System.Windows.Forms.NumericUpDown sfxTimeValueBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Timer sfxTimer;
        private System.Windows.Forms.Button emotionsButtonOff;
        private System.Windows.Forms.Button emotionsButtonOn;
        private System.Windows.Forms.Timer emotionTimer;
        private System.Windows.Forms.Timer blipTimer;
    }
}

