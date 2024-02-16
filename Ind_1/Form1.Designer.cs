namespace Ind_1
{
    partial class Form1
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
            label1 = new Label();
            do_it = new Button();
            combo_action = new ComboBox();
            action = new Label();
            key = new Label();
            key_box = new TextBox();
            text = new Label();
            text_box = new ListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            seaShellToolStripMenuItem = new ToolStripMenuItem();
            cursorColorToolStripMenuItem = new ToolStripMenuItem();
            handToolStripMenuItem = new ToolStripMenuItem();
            crossToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            key_box_text = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(403, 49);
            label1.Name = "label1";
            label1.Size = new Size(0, 67);
            label1.TabIndex = 1;
            // 
            // do_it
            // 
            do_it.BackColor = Color.SeaShell;
            do_it.Cursor = Cursors.Hand;
            do_it.FlatStyle = FlatStyle.System;
            do_it.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            do_it.ForeColor = SystemColors.ActiveCaptionText;
            do_it.Location = new Point(28, 263);
            do_it.Name = "do_it";
            do_it.Size = new Size(205, 71);
            do_it.TabIndex = 2;
            do_it.Text = "Do It!";
            do_it.UseMnemonic = false;
            do_it.UseVisualStyleBackColor = false;
            do_it.Click += do_it_Click;
            // 
            // combo_action
            // 
            combo_action.BackColor = Color.SeaShell;
            combo_action.FormattingEnabled = true;
            combo_action.Items.AddRange(new object[] { "Decrypt", "Crypt" });
            combo_action.Location = new Point(28, 71);
            combo_action.Name = "combo_action";
            combo_action.Size = new Size(205, 28);
            combo_action.TabIndex = 3;
            combo_action.SelectedIndexChanged += combo_action_SelectedIndexChanged;
            // 
            // action
            // 
            action.AutoSize = true;
            action.Font = new Font("Segoe UI", 15F);
            action.Location = new Point(28, 33);
            action.Name = "action";
            action.Size = new Size(91, 35);
            action.TabIndex = 4;
            action.Text = "Action:";
            // 
            // key
            // 
            key.AutoSize = true;
            key.Font = new Font("Segoe UI", 15F);
            key.Location = new Point(28, 156);
            key.Name = "key";
            key.Size = new Size(60, 35);
            key.TabIndex = 5;
            key.Text = "Key:";
            // 
            // key_box
            // 
            key_box.BackColor = Color.SeaShell;
            key_box.Location = new Point(28, 204);
            key_box.Name = "key_box";
            key_box.Size = new Size(114, 27);
            key_box.TabIndex = 6;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI", 15F);
            text.Location = new Point(334, 33);
            text.Name = "text";
            text.Size = new Size(63, 35);
            text.TabIndex = 7;
            text.Text = "Text:";
            // 
            // text_box
            // 
            text_box.BackColor = Color.SeaShell;
            text_box.FormattingEnabled = true;
            text_box.Location = new Point(294, 110);
            text_box.Name = "text_box";
            text_box.Size = new Size(459, 224);
            text_box.TabIndex = 8;
            text_box.SelectedIndexChanged += text_box_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backgroundColorToolStripMenuItem, cursorColorToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // backgroundColorToolStripMenuItem
            // 
            backgroundColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greenToolStripMenuItem, seaShellToolStripMenuItem });
            backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            backgroundColorToolStripMenuItem.Size = new Size(211, 26);
            backgroundColorToolStripMenuItem.Text = "Background Color";
            backgroundColorToolStripMenuItem.Click += backgroundColorToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(148, 26);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // seaShellToolStripMenuItem
            // 
            seaShellToolStripMenuItem.Name = "seaShellToolStripMenuItem";
            seaShellToolStripMenuItem.Size = new Size(148, 26);
            seaShellToolStripMenuItem.Text = "SeaShell";
            seaShellToolStripMenuItem.Click += seaShellToolStripMenuItem_Click;
            // 
            // cursorColorToolStripMenuItem
            // 
            cursorColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { handToolStripMenuItem, crossToolStripMenuItem, defaultToolStripMenuItem });
            cursorColorToolStripMenuItem.Name = "cursorColorToolStripMenuItem";
            cursorColorToolStripMenuItem.Size = new Size(211, 26);
            cursorColorToolStripMenuItem.Text = "Cursor Color";
            cursorColorToolStripMenuItem.Click += cursorColorToolStripMenuItem_Click;
            // 
            // handToolStripMenuItem
            // 
            handToolStripMenuItem.Name = "handToolStripMenuItem";
            handToolStripMenuItem.Size = new Size(141, 26);
            handToolStripMenuItem.Text = "Hand";
            handToolStripMenuItem.Click += handToolStripMenuItem_Click;
            // 
            // crossToolStripMenuItem
            // 
            crossToolStripMenuItem.Name = "crossToolStripMenuItem";
            crossToolStripMenuItem.Size = new Size(141, 26);
            crossToolStripMenuItem.Text = "Cross";
            crossToolStripMenuItem.Click += crossToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(141, 26);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // key_box_text
            // 
            key_box_text.Font = new Font("Segoe UI", 13F);
            key_box_text.Location = new Point(294, 71);
            key_box_text.Name = "key_box_text";
            key_box_text.Size = new Size(459, 36);
            key_box_text.TabIndex = 10;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AntiqueWhite;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 357);
            Controls.Add(key_box_text);
            Controls.Add(text_box);
            Controls.Add(text);
            Controls.Add(key_box);
            Controls.Add(key);
            Controls.Add(action);
            Controls.Add(combo_action);
            Controls.Add(do_it);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Caesar`s cypher";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button do_it;
        private ComboBox combo_action;
        private Label action;
        private Label key;
        private TextBox key_box;
        private Label text;
        private ListBox text_box;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem cursorColorToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem seaShellToolStripMenuItem;
        private ToolStripMenuItem handToolStripMenuItem;
        private ToolStripMenuItem crossToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private TextBox key_box_text;
        private SaveFileDialog saveFileDialog1;
    }
}
