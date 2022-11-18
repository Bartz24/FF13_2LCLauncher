namespace FF13_2LCLauncher
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
            this.comboBoxDisplay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVoices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxShadows = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMSAA = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDisplay
            // 
            this.comboBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplay.FormattingEnabled = true;
            this.comboBoxDisplay.Items.AddRange(new object[] {
            "Windowed",
            "Full Screen"});
            this.comboBoxDisplay.Location = new System.Drawing.Point(12, 99);
            this.comboBoxDisplay.Name = "comboBoxDisplay";
            this.comboBoxDisplay.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDisplay.TabIndex = 0;
            this.comboBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisplay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Mode";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolution";
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "1280 x 720",
            "1920 x 1080"});
            this.comboBoxResolution.Location = new System.Drawing.Point(12, 144);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResolution.TabIndex = 2;
            this.comboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolution_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Voices";
            // 
            // comboBoxVoices
            // 
            this.comboBoxVoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoices.FormattingEnabled = true;
            this.comboBoxVoices.Items.AddRange(new object[] {
            "English",
            "Japanese"});
            this.comboBoxVoices.Location = new System.Drawing.Point(12, 191);
            this.comboBoxVoices.Name = "comboBoxVoices";
            this.comboBoxVoices.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVoices.TabIndex = 4;
            this.comboBoxVoices.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoices_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shadow Resolution";
            // 
            // comboBoxShadows
            // 
            this.comboBoxShadows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxShadows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShadows.FormattingEnabled = true;
            this.comboBoxShadows.Items.AddRange(new object[] {
            "512 x 512",
            "1024 x 1024",
            "2048 x 2048",
            "4096 x 4096",
            "8192 x 8192"});
            this.comboBoxShadows.Location = new System.Drawing.Point(12, 238);
            this.comboBoxShadows.Name = "comboBoxShadows";
            this.comboBoxShadows.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShadows.TabIndex = 6;
            this.comboBoxShadows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShadows_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MSAA Anti-Aliasing ";
            // 
            // comboBoxMSAA
            // 
            this.comboBoxMSAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMSAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMSAA.FormattingEnabled = true;
            this.comboBoxMSAA.Items.AddRange(new object[] {
            "x2",
            "x4",
            "x8",
            "x16"});
            this.comboBoxMSAA.Location = new System.Drawing.Point(12, 283);
            this.comboBoxMSAA.Name = "comboBoxMSAA";
            this.comboBoxMSAA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMSAA.TabIndex = 8;
            this.comboBoxMSAA.SelectedIndexChanged += new System.EventHandler(this.comboBoxMSAA_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(366, 293);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(12, 60);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(348, 20);
            this.textBoxPath.TabIndex = 12;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(366, 58);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(116, 23);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "Set Manually";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 328);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMSAA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxShadows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxVoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "FFXIII-2 160f Lucky Coin Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxShadows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMSAA;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonFind;
    }
}

