using System.ComponentModel;

namespace ContactsAppUI
{
    partial class EditForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.vkLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(444, 214);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(349, 214);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.phoneMaskedTextBox, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.vkTextBox, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.vkLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.emailTextBox, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.birthdayLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.emailLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.birthdayDateTimePicker, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.phoneLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.surnameTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.surnameLabel, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(521, 183);
            this.tableLayoutPanel.TabIndex = 19;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(73, 93);
            this.phoneMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(445, 23);
            this.phoneMaskedTextBox.TabIndex = 19;
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
            // vkTextBox
            // 
            this.vkTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.vkTextBox.Location = new System.Drawing.Point(73, 155);
            this.vkTextBox.Name = "vkTextBox";
            this.vkTextBox.Size = new System.Drawing.Size(445, 23);
            this.vkTextBox.TabIndex = 14;
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
            // emailTextBox
            // 
            this.emailTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(73, 123);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(445, 23);
            this.emailTextBox.TabIndex = 13;
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
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            // nameTextBox
            // 
            this.nameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(73, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(445, 23);
            this.nameTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.Location = new System.Drawing.Point(73, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(445, 23);
            this.surnameTextBox.TabIndex = 6;
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
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 250);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.MinimumSize = new System.Drawing.Size(512, 288);
            this.Name = "EditForm";
            this.Text = "Add/Edit Contact";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}