namespace WindowsFormsApplication1
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NameTextTips = new System.Windows.Forms.TextBox();
            this.PhoneTextTips = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.TextBox();
            this.AddressTextTips = new System.Windows.Forms.TextBox();
            this.LoadFileDirectory = new System.Windows.Forms.TextBox();
            this.ReadFile = new System.Windows.Forms.Button();
            this.LoadFilesButton = new System.Windows.Forms.Button();
            this.LoadFilesBox = new System.Windows.Forms.ListBox();
            this.SaveAsText = new System.Windows.Forms.TextBox();
            this.SaveAsLabel = new System.Windows.Forms.TextBox();
            this.SaveAsTextTips = new System.Windows.Forms.TextBox();
            this.LoadFilesDirectoryTips = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(201, 32);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(241, 27);
            this.NameText.TabIndex = 0;
            this.NameText.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // AddressText
            // 
            this.AddressText.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(201, 70);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(384, 27);
            this.AddressText.TabIndex = 1;
            this.AddressText.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.Location = new System.Drawing.Point(201, 111);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(206, 27);
            this.PhoneText.TabIndex = 2;
            this.PhoneText.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubmitButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(201, 192);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(105, 28);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameTextTips
            // 
            this.NameTextTips.BackColor = System.Drawing.SystemColors.Info;
            this.NameTextTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextTips.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextTips.ForeColor = System.Drawing.Color.Black;
            this.NameTextTips.Location = new System.Drawing.Point(448, 38);
            this.NameTextTips.Name = "NameTextTips";
            this.NameTextTips.Size = new System.Drawing.Size(172, 16);
            this.NameTextTips.TabIndex = 10;
            this.NameTextTips.Text = "i.e. Adam Smith";
            this.NameTextTips.TextChanged += new System.EventHandler(this.nameTextTips_TextChanged);
            // 
            // PhoneTextTips
            // 
            this.PhoneTextTips.BackColor = System.Drawing.SystemColors.Info;
            this.PhoneTextTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextTips.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextTips.Location = new System.Drawing.Point(413, 118);
            this.PhoneTextTips.Name = "PhoneTextTips";
            this.PhoneTextTips.Size = new System.Drawing.Size(207, 16);
            this.PhoneTextTips.TabIndex = 12;
            this.PhoneTextTips.Text = "i.e. 9405652000";
            this.PhoneTextTips.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.BackColor = System.Drawing.SystemColors.Info;
            this.AddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(35, 73);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(150, 20);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddressLabel.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.Info;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(35, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(150, 20);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.Info;
            this.PhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(35, 114);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(150, 20);
            this.PhoneLabel.TabIndex = 21;
            this.PhoneLabel.Text = "Phone";
            this.PhoneLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddressTextTips
            // 
            this.AddressTextTips.BackColor = System.Drawing.SystemColors.Info;
            this.AddressTextTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextTips.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextTips.Location = new System.Drawing.Point(591, 76);
            this.AddressTextTips.Name = "AddressTextTips";
            this.AddressTextTips.Size = new System.Drawing.Size(168, 16);
            this.AddressTextTips.TabIndex = 22;
            this.AddressTextTips.Text = "Street City, State, Zip";
            // 
            // LoadFileDirectory
            // 
            this.LoadFileDirectory.BackColor = System.Drawing.SystemColors.Info;
            this.LoadFileDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoadFileDirectory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileDirectory.Location = new System.Drawing.Point(35, 265);
            this.LoadFileDirectory.Name = "LoadFileDirectory";
            this.LoadFileDirectory.Size = new System.Drawing.Size(150, 20);
            this.LoadFileDirectory.TabIndex = 25;
            this.LoadFileDirectory.Text = "Filenames";
            this.LoadFileDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReadFile
            // 
            this.ReadFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadFile.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadFile.Location = new System.Drawing.Point(327, 365);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(105, 28);
            this.ReadFile.TabIndex = 26;
            this.ReadFile.Text = "Read file";
            this.ReadFile.UseVisualStyleBackColor = false;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // LoadFilesButton
            // 
            this.LoadFilesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoadFilesButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFilesButton.Location = new System.Drawing.Point(201, 365);
            this.LoadFilesButton.Name = "LoadFilesButton";
            this.LoadFilesButton.Size = new System.Drawing.Size(105, 28);
            this.LoadFilesButton.TabIndex = 27;
            this.LoadFilesButton.Text = "Load files";
            this.LoadFilesButton.UseVisualStyleBackColor = false;
            this.LoadFilesButton.Click += new System.EventHandler(this.LoadFilesButton_Click);
            // 
            // LoadFilesBox
            // 
            this.LoadFilesBox.AccessibleDescription = "d";
            this.LoadFilesBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFilesBox.FormattingEnabled = true;
            this.LoadFilesBox.ItemHeight = 20;
            this.LoadFilesBox.Location = new System.Drawing.Point(201, 265);
            this.LoadFilesBox.Name = "LoadFilesBox";
            this.LoadFilesBox.Size = new System.Drawing.Size(384, 84);
            this.LoadFilesBox.TabIndex = 28;
            // 
            // SaveAsText
            // 
            this.SaveAsText.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsText.Location = new System.Drawing.Point(201, 150);
            this.SaveAsText.Name = "SaveAsText";
            this.SaveAsText.Size = new System.Drawing.Size(206, 27);
            this.SaveAsText.TabIndex = 29;
            this.SaveAsText.TextChanged += new System.EventHandler(this.SaveAsText_TextChanged);
            // 
            // SaveAsLabel
            // 
            this.SaveAsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.SaveAsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveAsLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsLabel.Location = new System.Drawing.Point(35, 150);
            this.SaveAsLabel.Name = "SaveAsLabel";
            this.SaveAsLabel.Size = new System.Drawing.Size(150, 20);
            this.SaveAsLabel.TabIndex = 30;
            this.SaveAsLabel.Text = "Save As";
            this.SaveAsLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SaveAsTextTips
            // 
            this.SaveAsTextTips.BackColor = System.Drawing.SystemColors.Info;
            this.SaveAsTextTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveAsTextTips.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsTextTips.Location = new System.Drawing.Point(413, 156);
            this.SaveAsTextTips.Name = "SaveAsTextTips";
            this.SaveAsTextTips.Size = new System.Drawing.Size(207, 16);
            this.SaveAsTextTips.TabIndex = 31;
            this.SaveAsTextTips.Text = "i.e. File1";
            // 
            // LoadFilesDirectoryTips
            // 
            this.LoadFilesDirectoryTips.BackColor = System.Drawing.SystemColors.Info;
            this.LoadFilesDirectoryTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoadFilesDirectoryTips.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFilesDirectoryTips.Location = new System.Drawing.Point(591, 269);
            this.LoadFilesDirectoryTips.Name = "LoadFilesDirectoryTips";
            this.LoadFilesDirectoryTips.Size = new System.Drawing.Size(168, 16);
            this.LoadFilesDirectoryTips.TabIndex = 32;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Close.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(654, 365);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(105, 28);
            this.Close.TabIndex = 33;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(857, 425);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LoadFilesDirectoryTips);
            this.Controls.Add(this.SaveAsTextTips);
            this.Controls.Add(this.SaveAsLabel);
            this.Controls.Add(this.SaveAsText);
            this.Controls.Add(this.LoadFilesBox);
            this.Controls.Add(this.LoadFilesButton);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.LoadFileDirectory);
            this.Controls.Add(this.AddressTextTips);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneTextTips);
            this.Controls.Add(this.NameTextTips);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.NameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox NameTextTips;
        private System.Windows.Forms.TextBox PhoneTextTips;
        private System.Windows.Forms.TextBox AddressLabel;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.TextBox PhoneLabel;
        private System.Windows.Forms.TextBox AddressTextTips;
        private System.Windows.Forms.TextBox LoadFileDirectory;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button LoadFilesButton;
        private System.Windows.Forms.ListBox LoadFilesBox;
        private System.Windows.Forms.TextBox SaveAsText;
        private System.Windows.Forms.TextBox SaveAsLabel;
        private System.Windows.Forms.TextBox SaveAsTextTips;
        private System.Windows.Forms.TextBox LoadFilesDirectoryTips;
        private System.Windows.Forms.Button Close;
    }
}

