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
            this.СontactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.RightsLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.GithubTextLabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // СontactsAppLabel
            // 
            this.СontactsAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.СontactsAppLabel.Location = new System.Drawing.Point(12, 9);
            this.СontactsAppLabel.Name = "СontactsAppLabel";
            this.СontactsAppLabel.Size = new System.Drawing.Size(206, 45);
            this.СontactsAppLabel.TabIndex = 0;
            this.СontactsAppLabel.Text = "ContactsApp";
            this.СontactsAppLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.VersionLabel.Location = new System.Drawing.Point(21, 54);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(112, 22);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 2019.3.4.0";
            // 
            // RightsLabel
            // 
            this.RightsLabel.Location = new System.Drawing.Point(12, 207);
            this.RightsLabel.Name = "RightsLabel";
            this.RightsLabel.Size = new System.Drawing.Size(153, 27);
            this.RightsLabel.TabIndex = 2;
            this.RightsLabel.Text = "2021 Sabanova Kristina Ц";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Location = new System.Drawing.Point(12, 97);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(220, 25);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author: Sabanova Kristina";
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.Location = new System.Drawing.Point(12, 141);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(121, 20);
            this.EmailTextLabel.TabIndex = 4;
            this.EmailTextLabel.Text = "E-mail for feedback:";
            // 
            // GithubTextLabel
            // 
            this.GithubTextLabel.Location = new System.Drawing.Point(12, 162);
            this.GithubTextLabel.Name = "GithubTextLabel";
            this.GithubTextLabel.Size = new System.Drawing.Size(51, 20);
            this.GithubTextLabel.TabIndex = 5;
            this.GithubTextLabel.Text = "GitHub:";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.Location = new System.Drawing.Point(124, 141);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(141, 18);
            this.EmailLinkLabel.TabIndex = 6;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "linkLabel1";
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
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.GithubTextLabel);
            this.Controls.Add(this.EmailTextLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.RightsLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.СontactsAppLabel);
            this.MaximumSize = new System.Drawing.Size(411, 280);
            this.MinimumSize = new System.Drawing.Size(411, 280);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.Label GithubTextLabel;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label RightsLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label СontactsAppLabel;
    }
}