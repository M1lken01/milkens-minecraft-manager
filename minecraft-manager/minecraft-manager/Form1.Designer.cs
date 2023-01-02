namespace minecraft_manager
{
    partial class Main
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMods = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMods = new System.Windows.Forms.Panel();
            this.listMods = new System.Windows.Forms.CheckedListBox();
            this.labelModsSubtitle = new System.Windows.Forms.Label();
            this.btnBrowseMinecraftFolder = new System.Windows.Forms.Button();
            this.labelForMinecraftLocation = new System.Windows.Forms.Label();
            this.inputMinecraftLocation = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelLeft.SuspendLayout();
            this.panelMods.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnMods);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 621);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.Location = new System.Drawing.Point(0, 548);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(220, 70);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnMods
            // 
            this.btnMods.FlatAppearance.BorderSize = 0;
            this.btnMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMods.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMods.Location = new System.Drawing.Point(0, 79);
            this.btnMods.Name = "btnMods";
            this.btnMods.Size = new System.Drawing.Size(220, 70);
            this.btnMods.TabIndex = 2;
            this.btnMods.Text = "Mods";
            this.btnMods.UseVisualStyleBackColor = true;
            this.btnMods.Click += new System.EventHandler(this.btnMods_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 70);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(241, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Milken\'s Minecraft Manager";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(242, 79);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(361, 23);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Minecraft mod and plugin manager by M1lk3n01.";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersion.Location = new System.Drawing.Point(1022, 589);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(150, 23);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Version: v1.0.0alpha";
            // 
            // panelMods
            // 
            this.panelMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panelMods.Controls.Add(this.listMods);
            this.panelMods.Controls.Add(this.labelModsSubtitle);
            this.panelMods.Controls.Add(this.btnBrowseMinecraftFolder);
            this.panelMods.Controls.Add(this.labelForMinecraftLocation);
            this.panelMods.Controls.Add(this.inputMinecraftLocation);
            this.panelMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMods.Location = new System.Drawing.Point(220, 0);
            this.panelMods.Name = "panelMods";
            this.panelMods.Size = new System.Drawing.Size(964, 621);
            this.panelMods.TabIndex = 4;
            this.panelMods.Visible = false;
            // 
            // listMods
            // 
            this.listMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMods.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listMods.FormattingEnabled = true;
            this.listMods.Location = new System.Drawing.Point(26, 120);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(926, 465);
            this.listMods.TabIndex = 6;
            this.listMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listMods_ItemCheck);
            // 
            // labelModsSubtitle
            // 
            this.labelModsSubtitle.AutoSize = true;
            this.labelModsSubtitle.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModsSubtitle.Location = new System.Drawing.Point(22, 79);
            this.labelModsSubtitle.Name = "labelModsSubtitle";
            this.labelModsSubtitle.Size = new System.Drawing.Size(53, 23);
            this.labelModsSubtitle.TabIndex = 5;
            this.labelModsSubtitle.Text = "Mods:";
            // 
            // btnBrowseMinecraftFolder
            // 
            this.btnBrowseMinecraftFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBrowseMinecraftFolder.FlatAppearance.BorderSize = 0;
            this.btnBrowseMinecraftFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseMinecraftFolder.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowseMinecraftFolder.Location = new System.Drawing.Point(826, 27);
            this.btnBrowseMinecraftFolder.Name = "btnBrowseMinecraftFolder";
            this.btnBrowseMinecraftFolder.Size = new System.Drawing.Size(126, 29);
            this.btnBrowseMinecraftFolder.TabIndex = 2;
            this.btnBrowseMinecraftFolder.Text = "Browse";
            this.btnBrowseMinecraftFolder.UseVisualStyleBackColor = false;
            this.btnBrowseMinecraftFolder.Click += new System.EventHandler(this.btnBrowseMinecraftFolder_Click);
            // 
            // labelForMinecraftLocation
            // 
            this.labelForMinecraftLocation.AutoSize = true;
            this.labelForMinecraftLocation.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelForMinecraftLocation.Location = new System.Drawing.Point(21, 27);
            this.labelForMinecraftLocation.Name = "labelForMinecraftLocation";
            this.labelForMinecraftLocation.Size = new System.Drawing.Size(167, 29);
            this.labelForMinecraftLocation.TabIndex = 1;
            this.labelForMinecraftLocation.Text = "Minecraft Folder";
            // 
            // inputMinecraftLocation
            // 
            this.inputMinecraftLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.inputMinecraftLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputMinecraftLocation.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputMinecraftLocation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inputMinecraftLocation.Location = new System.Drawing.Point(194, 27);
            this.inputMinecraftLocation.Name = "inputMinecraftLocation";
            this.inputMinecraftLocation.Size = new System.Drawing.Size(626, 29);
            this.inputMinecraftLocation.TabIndex = 0;
            this.inputMinecraftLocation.Text = "C:\\Users\\User\\AppData\\Roaming\\.minecraft";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.panelMods);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Main";
            this.Text = "Milken\'s Minecraft Manager";
            this.panelLeft.ResumeLayout(false);
            this.panelMods.ResumeLayout(false);
            this.panelMods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMods;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Panel panelMods;
        private System.Windows.Forms.TextBox inputMinecraftLocation;
        private System.Windows.Forms.Label labelForMinecraftLocation;
        private System.Windows.Forms.Button btnBrowseMinecraftFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelModsSubtitle;
        private System.Windows.Forms.CheckedListBox listMods;
    }
}

