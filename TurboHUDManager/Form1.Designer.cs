namespace TurboHUDManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.EnabledLabel = new System.Windows.Forms.Label();
            this.NameDisplay = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthorDisplay = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.IdDisplay = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PluginListBox = new System.Windows.Forms.ListBox();
            this.AuthorListBox = new System.Windows.Forms.ListBox();
            this.PathBtn = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.EnabledCheckBox);
            this.panel1.Controls.Add(this.EnabledLabel);
            this.panel1.Controls.Add(this.NameDisplay);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.AuthorDisplay);
            this.panel1.Controls.Add(this.AuthorLabel);
            this.panel1.Controls.Add(this.IdDisplay);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.PluginListBox);
            this.panel1.Controls.Add(this.AuthorListBox);
            this.panel1.Controls.Add(this.PathBtn);
            this.panel1.Controls.Add(this.PathBox);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 370);
            this.panel1.TabIndex = 0;
            // 
            // EnabledCheckBox
            // 
            this.EnabledCheckBox.AutoSize = true;
            this.EnabledCheckBox.CausesValidation = false;
            this.EnabledCheckBox.Enabled = false;
            this.EnabledCheckBox.Location = new System.Drawing.Point(464, 74);
            this.EnabledCheckBox.Name = "EnabledCheckBox";
            this.EnabledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EnabledCheckBox.TabIndex = 11;
            this.EnabledCheckBox.TabStop = false;
            this.EnabledCheckBox.UseVisualStyleBackColor = true;
            this.EnabledCheckBox.Click += new System.EventHandler(this.EnabledCheckBox_Click);
            // 
            // EnabledLabel
            // 
            this.EnabledLabel.AutoSize = true;
            this.EnabledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabledLabel.Location = new System.Drawing.Point(407, 75);
            this.EnabledLabel.Name = "EnabledLabel";
            this.EnabledLabel.Size = new System.Drawing.Size(57, 13);
            this.EnabledLabel.TabIndex = 10;
            this.EnabledLabel.Text = "Enabled:";
            // 
            // NameDisplay
            // 
            this.NameDisplay.AutoSize = true;
            this.NameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameDisplay.Location = new System.Drawing.Point(461, 58);
            this.NameDisplay.Name = "NameDisplay";
            this.NameDisplay.Size = new System.Drawing.Size(27, 13);
            this.NameDisplay.TabIndex = 9;
            this.NameDisplay.Text = "N/A";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(407, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // AuthorDisplay
            // 
            this.AuthorDisplay.AutoSize = true;
            this.AuthorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorDisplay.Location = new System.Drawing.Point(461, 45);
            this.AuthorDisplay.Name = "AuthorDisplay";
            this.AuthorDisplay.Size = new System.Drawing.Size(27, 13);
            this.AuthorDisplay.TabIndex = 7;
            this.AuthorDisplay.Text = "N/A";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(407, 45);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(48, 13);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author:";
            // 
            // IdDisplay
            // 
            this.IdDisplay.AutoSize = true;
            this.IdDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdDisplay.Location = new System.Drawing.Point(461, 32);
            this.IdDisplay.Name = "IdDisplay";
            this.IdDisplay.Size = new System.Drawing.Size(27, 13);
            this.IdDisplay.TabIndex = 5;
            this.IdDisplay.Text = "N/A";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(407, 32);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(28, 13);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "ID: ";
            // 
            // PluginListBox
            // 
            this.PluginListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PluginListBox.FormattingEnabled = true;
            this.PluginListBox.Location = new System.Drawing.Point(157, 33);
            this.PluginListBox.Name = "PluginListBox";
            this.PluginListBox.Size = new System.Drawing.Size(244, 329);
            this.PluginListBox.Sorted = true;
            this.PluginListBox.TabIndex = 3;
            this.PluginListBox.SelectedIndexChanged += new System.EventHandler(this.PluginListBox_SelectedIndexChanged);
            // 
            // AuthorListBox
            // 
            this.AuthorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorListBox.FormattingEnabled = true;
            this.AuthorListBox.Location = new System.Drawing.Point(4, 33);
            this.AuthorListBox.Name = "AuthorListBox";
            this.AuthorListBox.Size = new System.Drawing.Size(147, 329);
            this.AuthorListBox.Sorted = true;
            this.AuthorListBox.TabIndex = 2;
            this.AuthorListBox.SelectedIndexChanged += new System.EventHandler(this.AuthorListBox_SelectedIndexChanged);
            // 
            // PathBtn
            // 
            this.PathBtn.CausesValidation = false;
            this.PathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PathBtn.Location = new System.Drawing.Point(4, 3);
            this.PathBtn.Name = "PathBtn";
            this.PathBtn.Size = new System.Drawing.Size(112, 23);
            this.PathBtn.TabIndex = 1;
            this.PathBtn.Text = "THUD Plugins Path";
            this.PathBtn.UseVisualStyleBackColor = true;
            this.PathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.Location = new System.Drawing.Point(122, 3);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(624, 20);
            this.PathBox.TabIndex = 0;
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            // 
            // PathBrowser
            // 
            this.PathBrowser.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(749, 370);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(765, 400);
            this.Name = "Form1";
            this.Text = "TurboHUD Plugin Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PathBtn;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.FolderBrowserDialog PathBrowser;
        private System.Windows.Forms.CheckBox EnabledCheckBox;
        private System.Windows.Forms.Label EnabledLabel;
        private System.Windows.Forms.Label NameDisplay;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AuthorDisplay;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label IdDisplay;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ListBox PluginListBox;
        private System.Windows.Forms.ListBox AuthorListBox;
    }
}

