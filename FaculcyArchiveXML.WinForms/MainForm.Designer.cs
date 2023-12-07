namespace FaculcyArchiveXML.WinForms
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            saxButton = new RadioButton();
            domButton = new RadioButton();
            linqButton = new RadioButton();
            authorsComboBox = new ComboBox();
            faculcyComboBox = new ComboBox();
            departamentComboBox = new ComboBox();
            convertButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(837, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, clearToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(103, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(359, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(478, 530);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // saxButton
            // 
            saxButton.AutoSize = true;
            saxButton.Location = new Point(285, 27);
            saxButton.Name = "saxButton";
            saxButton.Size = new Size(67, 19);
            saxButton.TabIndex = 2;
            saxButton.TabStop = true;
            saxButton.Text = "SAX API";
            saxButton.UseVisualStyleBackColor = true;
            // 
            // domButton
            // 
            domButton.AutoSize = true;
            domButton.Location = new Point(285, 52);
            domButton.Name = "domButton";
            domButton.Size = new Size(74, 19);
            domButton.TabIndex = 3;
            domButton.TabStop = true;
            domButton.Text = "DOM API";
            domButton.UseVisualStyleBackColor = true;
            // 
            // linqButton
            // 
            linqButton.AutoSize = true;
            linqButton.Location = new Point(285, 77);
            linqButton.Name = "linqButton";
            linqButton.Size = new Size(52, 19);
            linqButton.TabIndex = 4;
            linqButton.TabStop = true;
            linqButton.Text = "LINQ";
            linqButton.UseVisualStyleBackColor = true;
            // 
            // authorsComboBox
            // 
            authorsComboBox.FormattingEnabled = true;
            authorsComboBox.Location = new Point(56, 48);
            authorsComboBox.Name = "authorsComboBox";
            authorsComboBox.Size = new Size(158, 23);
            authorsComboBox.TabIndex = 6;
            authorsComboBox.SelectedIndexChanged += authorsComboBox_SelectedIndexChanged;
            // 
            // faculcyComboBox
            // 
            faculcyComboBox.FormattingEnabled = true;
            faculcyComboBox.Location = new Point(56, 92);
            faculcyComboBox.Name = "faculcyComboBox";
            faculcyComboBox.Size = new Size(158, 23);
            faculcyComboBox.TabIndex = 7;
            faculcyComboBox.SelectedIndexChanged += faculcyComboBox_SelectedIndexChanged;
            // 
            // departamentComboBox
            // 
            departamentComboBox.FormattingEnabled = true;
            departamentComboBox.Location = new Point(56, 137);
            departamentComboBox.Name = "departamentComboBox";
            departamentComboBox.Size = new Size(158, 23);
            departamentComboBox.TabIndex = 8;
            departamentComboBox.SelectedIndexChanged += departamentComboBox_SelectedIndexChanged;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(56, 480);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(214, 57);
            convertButton.TabIndex = 9;
            convertButton.Text = "Convert to HTML";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 74);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 11;
            label2.Text = "Faculcy name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 119);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 12;
            label3.Text = "Departament";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 569);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(convertButton);
            Controls.Add(departamentComboBox);
            Controls.Add(faculcyComboBox);
            Controls.Add(authorsComboBox);
            Controls.Add(linqButton);
            Controls.Add(domButton);
            Controls.Add(saxButton);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private RichTextBox richTextBox1;
        private RadioButton saxButton;
        private RadioButton domButton;
        private RadioButton linqButton;
        private ComboBox authorsComboBox;
        private ComboBox faculcyComboBox;
        private ComboBox departamentComboBox;
        private Button convertButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}