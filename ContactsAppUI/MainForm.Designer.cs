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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VkLabel = new System.Windows.Forms.Label();
            this.LeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BottomLeftPanel = new System.Windows.Forms.Panel();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.RightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MenuStrip.SuspendLayout();
            this.LeftTableLayoutPanel.SuspendLayout();
            this.BottomLeftPanel.SuspendLayout();
            this.RightTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.AddButton.Location = new System.Drawing.Point(2, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "a";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.EditButton.Location = new System.Drawing.Point(29, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "e";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(56, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "r";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.FileToolStripMenuItem, this.EditToolStripMenuItem, this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(760, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.AddContactToolStripMenuItem, this.EditContactToolStripMenuItem, this.RemoveContactToolStripMenuItem
            });
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem";
            this.AddContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AddContactToolStripMenuItem.Text = "Add Contact";
            this.AddContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.EditContactToolStripMenuItem.Name = "EditContactToolStripMenuItem";
            this.EditContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.EditContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem
            // 
            this.RemoveContactToolStripMenuItem.Name = "RemoveContactToolStripMenuItem";
            this.RemoveContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RemoveContactToolStripMenuItem.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // contactsListBox
            // 
            this.ContactsListBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.LeftTableLayoutPanel.SetColumnSpan(this.ContactsListBox, 2);
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 15;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 33);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(245, 334);
            this.ContactsListBox.TabIndex = 5;
            this.ContactsListBox.SelectedIndexChanged +=
                new System.EventHandler(this.contactsListBox_SelectedIndexChanged);
            // 
            // findTextBox
            // 
            this.FindTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(45, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(203, 23);
            this.FindTextBox.TabIndex = 4;
            // 
            // findLabel
            // 
            this.FindLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FindLabel.Location = new System.Drawing.Point(6, 4);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(34, 22);
            this.FindLabel.TabIndex = 3;
            this.FindLabel.Text = "Find:";
            this.FindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surnameTextBox
            // 
            this.SurnameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Enabled = false;
            this.SurnameTextBox.Location = new System.Drawing.Point(73, 3);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(416, 23);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.NameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(73, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(416, 23);
            this.NameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLabel.Location = new System.Drawing.Point(2, 36);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 18);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // birthdayLabel
            // 
            this.BirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthdayLabel.Location = new System.Drawing.Point(2, 66);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(66, 18);
            this.BirthdayLabel.TabIndex = 9;
            this.BirthdayLabel.Text = "Birthday:";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // birthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BirthdayDateTimePicker.Enabled = false;
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(72, 63);
            this.BirthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(102, 23);
            this.BirthdayDateTimePicker.TabIndex = 10;
            // 
            // phoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhoneLabel.Location = new System.Drawing.Point(2, 96);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(66, 18);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "Phone:";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.EmailTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Location = new System.Drawing.Point(73, 123);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(416, 23);
            this.EmailTextBox.TabIndex = 13;
            // 
            // vkTextBox
            // 
            this.VkTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.VkTextBox.Enabled = false;
            this.VkTextBox.Location = new System.Drawing.Point(73, 155);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(416, 23);
            this.VkTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmailLabel.Location = new System.Drawing.Point(2, 126);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(66, 18);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "E-mail:";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vkLabel
            // 
            this.VkLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VkLabel.Location = new System.Drawing.Point(2, 157);
            this.VkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(66, 18);
            this.VkLabel.TabIndex = 16;
            this.VkLabel.Text = "vk.com:";
            this.VkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // leftTableLayoutPanel
            // 
            this.LeftTableLayoutPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.LeftTableLayoutPanel.ColumnCount = 2;
            this.LeftTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.13147F));
            this.LeftTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.86853F));
            this.LeftTableLayoutPanel.Controls.Add(this.FindTextBox, 1, 0);
            this.LeftTableLayoutPanel.Controls.Add(this.FindLabel, 0, 0);
            this.LeftTableLayoutPanel.Controls.Add(this.ContactsListBox, 0, 1);
            this.LeftTableLayoutPanel.Controls.Add(this.BottomLeftPanel, 0, 2);
            this.LeftTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.LeftTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftTableLayoutPanel.Name = "LeftTableLayoutPanel";
            this.LeftTableLayoutPanel.RowCount = 3;
            this.LeftTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LeftTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LeftTableLayoutPanel.Size = new System.Drawing.Size(251, 404);
            this.LeftTableLayoutPanel.TabIndex = 17;
            // 
            // bottomLeftPanel
            // 
            this.LeftTableLayoutPanel.SetColumnSpan(this.BottomLeftPanel, 2);
            this.BottomLeftPanel.Controls.Add(this.AddButton);
            this.BottomLeftPanel.Controls.Add(this.EditButton);
            this.BottomLeftPanel.Controls.Add(this.RemoveButton);
            this.BottomLeftPanel.Location = new System.Drawing.Point(3, 377);
            this.BottomLeftPanel.Name = "BottomLeftPanel";
            this.BottomLeftPanel.Size = new System.Drawing.Size(245, 24);
            this.BottomLeftPanel.TabIndex = 6;
            // 
            // surnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SurnameLabel.Location = new System.Drawing.Point(2, 6);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(66, 18);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname:";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightTableLayoutPanel
            // 
            this.RightTableLayoutPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.RightTableLayoutPanel.ColumnCount = 2;
            this.RightTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.RightTableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightTableLayoutPanel.Controls.Add(this.PhoneMaskedTextBox, 1, 3);
            this.RightTableLayoutPanel.Controls.Add(this.NameLabel, 0, 1);
            this.RightTableLayoutPanel.Controls.Add(this.VkTextBox, 1, 5);
            this.RightTableLayoutPanel.Controls.Add(this.VkLabel, 0, 5);
            this.RightTableLayoutPanel.Controls.Add(this.EmailTextBox, 1, 4);
            this.RightTableLayoutPanel.Controls.Add(this.BirthdayLabel, 0, 2);
            this.RightTableLayoutPanel.Controls.Add(this.EmailLabel, 0, 4);
            this.RightTableLayoutPanel.Controls.Add(this.BirthdayDateTimePicker, 1, 2);
            this.RightTableLayoutPanel.Controls.Add(this.PhoneLabel, 0, 3);
            this.RightTableLayoutPanel.Controls.Add(this.NameTextBox, 1, 1);
            this.RightTableLayoutPanel.Controls.Add(this.SurnameTextBox, 1, 0);
            this.RightTableLayoutPanel.Controls.Add(this.SurnameLabel, 0, 0);
            this.RightTableLayoutPanel.Location = new System.Drawing.Point(256, 24);
            this.RightTableLayoutPanel.Name = "RightTableLayoutPanel";
            this.RightTableLayoutPanel.RowCount = 6;
            this.RightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightTableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightTableLayoutPanel.Size = new System.Drawing.Size(492, 183);
            this.RightTableLayoutPanel.TabIndex = 18;
            // 
            // phoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneMaskedTextBox.Enabled = false;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(73, 93);
            this.PhoneMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(416, 23);
            this.PhoneMaskedTextBox.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(760, 428);
            this.Controls.Add(this.RightTableLayoutPanel);
            this.Controls.Add(this.LeftTableLayoutPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(700, 455);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.LeftTableLayoutPanel.ResumeLayout(false);
            this.LeftTableLayoutPanel.PerformLayout();
            this.BottomLeftPanel.ResumeLayout(false);
            this.RightTableLayoutPanel.ResumeLayout(false);
            this.RightTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel LeftTableLayoutPanel;
        private System.Windows.Forms.Panel BottomLeftPanel;
        private System.Windows.Forms.TableLayoutPanel RightTableLayoutPanel;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FindTextBox;
    }
}