using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace minecraft_manager
{
    public partial class Main : Form
    {
        string managerModsFolderName = "~jars";
        string managerModsFolder;
        string[] managerMods;
        string minecraftModsFolder;
        string[] minecraftMods;

        public Main()
        {
            InitializeComponent();
            minecraftModsFolder = inputMinecraftLocation.Text + "\\modsDummy"; //replace with actual mods folder name `\\mods`
            managerModsFolder = Path.Combine(minecraftModsFolder, managerModsFolderName);
            if (!Directory.Exists(minecraftModsFolder))
                Directory.CreateDirectory(minecraftModsFolder);
            if (!Directory.Exists(managerModsFolder))
                Directory.CreateDirectory(managerModsFolder);
            minecraftMods = Directory.GetFiles(minecraftModsFolder);
            managerMods = Directory.GetFiles(managerModsFolder);
            foreach (string mod in minecraftMods)
            {
                listMods.Items.Add(Path.GetFileName(mod), true);
            }
            foreach (string mod in managerMods)
            {
                listMods.Items.Add(Path.GetFileName(mod), false);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMods.Visible = false;
        }

        public void setPanel(Panel panelSelected)
        {
            panelMods.Visible = false;
            panelSelected.Visible = true;
        }

        private void btnBrowseMinecraftFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputMinecraftLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnMods_Click(object sender, EventArgs e)
        {
            setPanel(panelMods);
        }

        private void listMods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string fileName = listMods.Items[e.Index].ToString();
            string sourceFile = Path.Combine(managerModsFolder, fileName);
            string destinationFile = Path.Combine(minecraftModsFolder, fileName);
            if (e.NewValue == CheckState.Unchecked)
            {
                sourceFile = Path.Combine(minecraftModsFolder, fileName);
                destinationFile = Path.Combine(managerModsFolder, fileName);
            }
            if (File.Exists(sourceFile))
                File.Move(sourceFile, destinationFile);
        }
    }
}
