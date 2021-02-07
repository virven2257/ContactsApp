using System.ComponentModel;
using System.Windows.Forms;

namespace ContactsAppUI
{
    partial class AboutForm
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
            this.contactsAppLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.rightsLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.emailTextLabel = new System.Windows.Forms.Label();
            this.githubTextLabel = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // contactsAppLabel
            // 
            this.contactsAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.contactsAppLabel.Location = new System.Drawing.Point(12, 9);
            this.contactsAppLabel.Name = "contactsAppLabel";
            this.contactsAppLabel.Size = new System.Drawing.Size(206, 45);
            this.contactsAppLabel.TabIndex = 0;
            this.contactsAppLabel.Text = "ContactsApp";
            this.contactsAppLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.versionLabel.Location = new System.Drawing.Point(21, 54);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(112, 22);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "v. " + Application.ProductVersion;
            // 
            // rightsLabel
            // 
            this.rightsLabel.Location = new System.Drawing.Point(12, 207);
            this.rightsLabel.Name = "rightsLabel";
            this.rightsLabel.Size = new System.Drawing.Size(153, 26);
            this.rightsLabel.TabIndex = 2;
            this.rightsLabel.Text = "2021 Sabanova Kristina Ц";
            // 
            // authorLabel
            // 
            this.authorLabel.Location = new System.Drawing.Point(12, 97);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(221, 25);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author: Sabanova Kristina";
            // 
            // emailTextLabel
            // 
            this.emailTextLabel.Location = new System.Drawing.Point(12, 141);
            this.emailTextLabel.Name = "emailTextLabel";
            this.emailTextLabel.Size = new System.Drawing.Size(121, 20);
            this.emailTextLabel.TabIndex = 4;
            this.emailTextLabel.Text = "E-mail for feedback:";
            // 
            // githubTextLabel
            // 
            this.githubTextLabel.Location = new System.Drawing.Point(12, 162);
            this.githubTextLabel.Name = "githubTextLabel";
            this.githubTextLabel.Size = new System.Drawing.Size(51, 20);
            this.githubTextLabel.TabIndex = 5;
            this.githubTextLabel.Text = "GitHub:";
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.Location = new System.Drawing.Point(124, 141);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(141, 19);
            this.emailLinkLabel.TabIndex = 6;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "linkLabel1";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.Location = new System.Drawing.Point(58, 162);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(136, 18);
            this.githubLinkLabel.TabIndex = 7;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "linkLabel2";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 242);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.emailLinkLabel);
            this.Controls.Add(this.githubTextLabel);
            this.Controls.Add(this.emailTextLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.rightsLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.contactsAppLabel);
            this.MaximumSize = new System.Drawing.Size(411, 280);
            this.MinimumSize = new System.Drawing.Size(411, 280);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.Label githubTextLabel;
        private System.Windows.Forms.Label emailTextLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label rightsLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label contactsAppLabel;
    }
}