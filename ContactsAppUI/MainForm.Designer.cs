using System.ComponentModel;

namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.vkLabel = new System.Windows.Forms.Label();
            this.leftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.rightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MenuStrip.SuspendLayout();
            this.leftTableLayoutPanel.SuspendLayout();
            this.bottomLeftPanel.SuspendLayout();
            this.rightTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "a";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(29, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(23, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "e";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(56, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(23, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "r";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.fileToolStripMenuItem, this.editToolStripMenuItem, this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(760, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.addContactToolStripMenuItem, this.editContactToolStripMenuItem, this.removeContactToolStripMenuItem
            });
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // contactsListBox
            // 
            this.contactsListBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.leftTableLayoutPanel.SetColumnSpan(this.contactsListBox, 2);
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.ItemHeight = 15;
            this.contactsListBox.Location = new System.Drawing.Point(3, 33);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.ScrollAlwaysVisible = true;
            this.contactsListBox.Size = new System.Drawing.Size(245, 334);
            this.contactsListBox.TabIndex = 5;
            this.contactsListBox.SelectedIndexChanged +=
                new System.EventHandler(this.contactsListBox_SelectedIndexChanged);
            // 
            // findTextBox
            // 
            this.findTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.findTextBox.Location = new System.Drawing.Point(45, 3);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(203, 23);
            this.findTextBox.TabIndex = 4;
            // 
            // findLabel
            // 
            this.findLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.findLabel.Location = new System.Drawing.Point(6, 4);
            this.findLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(34, 22);
            this.findLabel.TabIndex = 3;
            this.findLabel.Text = "Find:";
            this.findLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.Enabled = false;
            this.surnameTextBox.Location = new System.Drawing.Point(73, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(416, 23);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(73, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(416, 23);
            this.nameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.Location = new System.Drawing.Point(2, 36);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 18);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.birthdayLabel.Location = new System.Drawing.Point(2, 66);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(66, 18);
            this.birthdayLabel.TabIndex = 9;
            this.birthdayLabel.Text = "Birthday:";
            this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(72, 63);
            this.birthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(102, 23);
            this.birthdayDateTimePicker.TabIndex = 10;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneLabel.Location = new System.Drawing.Point(2, 96);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 18);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Phone:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(73, 123);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(416, 23);
            this.emailTextBox.TabIndex = 13;
            // 
            // vkTextBox
            // 
            this.vkTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.vkTextBox.Enabled = false;
            this.vkTextBox.Location = new System.Drawing.Point(73, 155);
            this.vkTextBox.Name = "vkTextBox";
            this.vkTextBox.Size = new System.Drawing.Size(416, 23);
            this.vkTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailLabel.Location = new System.Drawing.Point(2, 126);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 18);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "E-mail:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vkLabel
            // 
            this.vkLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vkLabel.Location = new System.Drawing.Point(2, 157);
            this.vkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vkLabel.Name = "vkLabel";
            this.vkLabel.Size = new System.Drawing.Size(66, 18);
            this.vkLabel.TabIndex = 16;
            this.vkLabel.Text = "vk.com:";
            this.vkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // leftTableLayoutPanel
            // 
            this.leftTableLayoutPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.leftTableLayoutPanel.ColumnCount = 2;
            this.leftTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.13147F));
            this.leftTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.86853F));
            this.leftTableLayoutPanel.Controls.Add(this.findTextBox, 1, 0);
            this.leftTableLayoutPanel.Controls.Add(this.findLabel, 0, 0);
            this.leftTableLayoutPanel.Controls.Add(this.contactsListBox, 0, 1);
            this.leftTableLayoutPanel.Controls.Add(this.bottomLeftPanel, 0, 2);
            this.leftTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.leftTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftTableLayoutPanel.Name = "leftTableLayoutPanel";
            this.leftTableLayoutPanel.RowCount = 3;
            this.leftTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftTableLayoutPanel.Size = new System.Drawing.Size(251, 404);
            this.leftTableLayoutPanel.TabIndex = 17;
            // 
            // bottomLeftPanel
            // 
            this.leftTableLayoutPanel.SetColumnSpan(this.bottomLeftPanel, 2);
            this.bottomLeftPanel.Controls.Add(this.addButton);
            this.bottomLeftPanel.Controls.Add(this.editButton);
            this.bottomLeftPanel.Controls.Add(this.removeButton);
            this.bottomLeftPanel.Location = new System.Drawing.Point(3, 377);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(245, 24);
            this.bottomLeftPanel.TabIndex = 6;
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surnameLabel.Location = new System.Drawing.Point(2, 6);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(66, 18);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Surname:";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightTableLayoutPanel
            // 
            this.rightTableLayoutPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.rightTableLayoutPanel.ColumnCount = 2;
            this.rightTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.rightTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightTableLayoutPanel.Controls.Add(this.phoneMaskedTextBox, 1, 3);
            this.rightTableLayoutPanel.Controls.Add(this.nameLabel, 0, 1);
            this.rightTableLayoutPanel.Controls.Add(this.vkTextBox, 1, 5);
            this.rightTableLayoutPanel.Controls.Add(this.vkLabel, 0, 5);
            this.rightTableLayoutPanel.Controls.Add(this.emailTextBox, 1, 4);
            this.rightTableLayoutPanel.Controls.Add(this.birthdayLabel, 0, 2);
            this.rightTableLayoutPanel.Controls.Add(this.emailLabel, 0, 4);
            this.rightTableLayoutPanel.Controls.Add(this.birthdayDateTimePicker, 1, 2);
            this.rightTableLayoutPanel.Controls.Add(this.phoneLabel, 0, 3);
            this.rightTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.rightTableLayoutPanel.Controls.Add(this.surnameTextBox, 1, 0);
            this.rightTableLayoutPanel.Controls.Add(this.surnameLabel, 0, 0);
            this.rightTableLayoutPanel.Location = new System.Drawing.Point(256, 24);
            this.rightTableLayoutPanel.Name = "rightTableLayoutPanel";
            this.rightTableLayoutPanel.RowCount = 6;
            this.rightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightTableLayoutPanel.Size = new System.Drawing.Size(492, 183);
            this.rightTableLayoutPanel.TabIndex = 18;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.phoneMaskedTextBox.Enabled = false;
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(73, 93);
            this.phoneMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(416, 23);
            this.phoneMaskedTextBox.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(760, 428);
            this.Controls.Add(this.rightTableLayoutPanel);
            this.Controls.Add(this.leftTableLayoutPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(700, 455);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.leftTableLayoutPanel.ResumeLayout(false);
            this.leftTableLayoutPanel.PerformLayout();
            this.bottomLeftPanel.ResumeLayout(false);
            this.rightTableLayoutPanel.ResumeLayout(false);
            this.rightTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel leftTableLayoutPanel;
        private System.Windows.Forms.Panel bottomLeftPanel;
        private System.Windows.Forms.TableLayoutPanel rightTableLayoutPanel;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox findTextBox;
    }
}