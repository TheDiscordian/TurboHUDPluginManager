using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboHUDManager
{
    public partial class Form1 : Form
    {
        const string skeleton = @"// This file is managed by TurboHUD Plugin Manager, it is used as a database, DO NOT MODIFY.
using Turbo.Plugins.Default;

namespace Turbo.Plugins.User
{{

	public class PluginManagerPlugin : BasePlugin, ICustomizer
	{{

		public PluginManagerPlugin()
		{{
			Enabled = true;
		}}

		public override void Load(IController hud)
		{{
			base.Load(hud);
		}}

		public void Customize()
		{{{0}
		}}
	}}
}}";

        public void SaveChanges()
        {
            string toggleLines = "";
            string lastAuthor = "";
            for (var i = 0; i < Plugins.Count; i++)
            {
                if (lastAuthor != Plugins[i].author)
                {
                    toggleLines = toggleLines + String.Format("\n\t\t\t//{0}", Plugins[i].author);
                    lastAuthor = Plugins[i].author;
                }
                if (Plugins[i].author != "Default")
                    toggleLines = toggleLines + String.Format("\n\t\t\tHud.TogglePlugin<{0}>({1});", Plugins[i].id, Plugins[i].enabled.ToString().ToLower());
                else
                    toggleLines = toggleLines + String.Format("\n\t\t\tHud.TogglePlugin<{0}>({1});", Plugins[i].name, Plugins[i].enabled.ToString().ToLower());
            }
            System.Diagnostics.Debug.WriteLine(toggleLines);
            System.IO.File.WriteAllText(PathBox.Text + @"\User\PluginManagerPlugin.cs", String.Format(skeleton, toggleLines));
        }

        public void LoadChanges()
        {
            if (!File.Exists(PathBox.Text + @"\User\PluginManagerPlugin.cs"))
                return;
            var lines = File.ReadLines(PathBox.Text + @"\User\PluginManagerPlugin.cs", Encoding.UTF8).ToArray();
            string author = "";
            for (var i = 22; i < lines.Length-5; i++)
            {
                if (lines[i].IndexOf("//") > -1)
                    author = lines[i].Substring(lines[i].IndexOf("//") + 1);

                int index = lines[i].IndexOf("Hud.TogglePlugin<"); // Check if this line is a toggle line.
                
                if (index > -1)
                {
                    int pIndex = -1;
                    if (author == "Default")
                        pIndex = IndexPlugin(lines[i].Substring(index + 17, lines[i].IndexOf(">") - index - 17));
                    else
                        pIndex = IndexPluginID(lines[i].Substring(index + 17, lines[i].IndexOf(">") - index - 17));

                    if (pIndex == -1)
                    {
                        continue;
                    }
                    bool pEnabled = lines[i].Substring(lines[i].IndexOf('(') + 1, 4) == "true";
                    Plugins[pIndex].enabled = pEnabled;
                }
            }
        }

        // Object representing a plugin.
        public class PluginObj
        {
            public string name, id, author, path;
            public bool enabled;

            public PluginObj(string pId, string pName, string pAuthor, bool pEnabled, string pPath)
            {
                name = pName;
                id = pId;
                author = pAuthor;
                enabled = pEnabled;
                path = pPath;
            }
        }

        public List<PluginObj> Plugins; // List of all known plugins

        public List<int> AuthorPlugins(string author)
        {
            var Out = new List<int>();
            bool foundAuthor = false;

            for (var i = 0; i < Plugins.Count; i++)
            {
                if (Plugins[i].author == author)
                {
                    if (!foundAuthor)
                        foundAuthor = true;
                    Out.Add(i);
                    System.Diagnostics.Debug.WriteLine(author + " plugin id " + i.ToString());
                } else if (foundAuthor)
                {
                    break;
                }
            }

            return Out;
        }

        public int IndexPlugin(string name)
        {
            for (var i = 0; i < Plugins.Count; i++)
                if (Plugins[i].name == name)
                    return i;

            return -1;
        }

        public int IndexPluginID(string id)
        {
            for (var i = 0; i < Plugins.Count; i++)
                if (Plugins[i].id == id)
                    return i;

            return -1;
        }

        public void LoadAuthor(string author)
        {
            var pluginList = AuthorPlugins(author);
            EnabledCheckBox.Enabled = false;
            PluginListBox.Items.Clear();
            if (pluginList.Count == 0)
                return;

            for (var i = 0; i < pluginList.Count; i++)
            {
                //if (Plugins[pluginList[i]].enabled)
                    PluginListBox.Items.Add(Plugins[pluginList[i]].name);
                //else
                //    PluginListBox.Items.Add("!" + Plugins[pluginList[i]].name);
            }
            EnabledCheckBox.Enabled = true;
            PluginListBox.SelectedIndex = 0;
        }

        public void LoadPlugin(string name)
        {
            int index = IndexPlugin(name);
            IdDisplay.Text = Plugins[index].id;
            AuthorDisplay.Text = Plugins[index].author;
            NameDisplay.Text = Plugins[index].name;
            EnabledCheckBox.Checked = Plugins[index].enabled;
        }

        // Refreshes the list of plugins
        public void RefreshPlugins()
        {

            string path = PathBox.Text;
            string lastAuthor = "";

            // Exit if we're not looking at a plugin directory.
            if (!Directory.Exists(path) || path.Split('\\').Last().ToLower() != "plugins")
            {
                return;
            }
            Plugins = new List<PluginObj>(); // Clear plugin list.
            AuthorListBox.Items.Clear();
            PluginListBox.Items.Clear();
            Properties.Settings.Default.THUDPath = path; // Prepare to change default path.

            foreach (string file in Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories))
            {
                var info = file.Substring(path.Length, file.Length - path.Length - 3).Split('\\'); // [author, ... path info ..., plugin name]
                // Skip if first entry is blank.
                int skip = 0;
                if (info[0].Length == 0)
                {
                    skip = 1;
                }
                
                if (info[skip] != "User") // Only check plugins not in "User" directory.
                {
                    bool enabled = false;
                    bool notPlugin = true;

                    // Search until Enabled line is found, and set enabled variable accordingly.
                    foreach (string line in File.ReadLines(file, Encoding.UTF8))
                    {
                        // Skip if file doesn't use "BasePlugin" (not a plugin)
                        if (line.IndexOf("class") > -1)
                        {
                            if (line.IndexOf("BasePlugin") == -1)
                                break;
                            System.Diagnostics.Debug.WriteLine(info.Last() + " -> " + line.Trim().Split(' ')[2]);
                            info[info.Length - 1] = line.Trim().Split(' ')[2];
                        }

                        int index = line.IndexOf("Enabled = "); // Check if this line is an "Enabled" line.

                        // If line is found, set notPlugin to false (indicating we've found a plugin), and set enabled depending on setting in file.
                        if (index > -1)
                        {
                            notPlugin = false;
                            if (line.Substring(index+10, 4) == "true")
                            {
                                enabled = true;
                            } else
                            {
                                enabled = false;
                            }
                            break;
                        }
                    }
                    if (notPlugin) // Skip if file isn't a plugin
                    {
                        continue;
                    }
                    if (info[skip] != lastAuthor)
                    {
                        AuthorListBox.Items.Add(info[skip]);
                        lastAuthor = info[skip];
                    }

                    Plugins.Add(new PluginObj(String.Join(".", info.Skip(skip).ToArray()), info.Last(), info[skip], enabled, path)); // Add plugin to list.
                    System.Diagnostics.Debug.WriteLine(Plugins.Last().author + ": " + Plugins.Last().id + " (Enabled: " + Plugins.Last().enabled.ToString() + ")"); // Dump some debugging info.
                }
            }

            LoadChanges();

            Properties.Settings.Default.Save(); // Save new default path.

            AuthorListBox.SelectedIndex = 0;
            if (AuthorListBox.Items.Count > 0)
                LoadAuthor(AuthorListBox.Items[0].ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PathBox.Text = Properties.Settings.Default.THUDPath;
            PathBrowser.SelectedPath = PathBox.Text;
            //RefreshPlugins();
        }

        private void PathBtn_Click(object sender, EventArgs e)
        {
            var result = PathBrowser.ShowDialog(); // Show plugin directory selection dialogue.
            if (result == System.Windows.Forms.DialogResult.OK) // If user pressed "OK", update plugin lists.
            {
                PathBox.Text = PathBrowser.SelectedPath; // Update displayed path text.
                //RefreshPlugins();
            }
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            PathBrowser.SelectedPath = PathBox.Text;
            RefreshPlugins();
        }

        private void AuthorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAuthor(AuthorListBox.Items[AuthorListBox.SelectedIndex].ToString());
        }

        private void PluginListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlugin(PluginListBox.Items[PluginListBox.SelectedIndex].ToString());
        }

        private void EnabledCheckBox_Click(object sender, EventArgs e)
        {
            Plugins[IndexPlugin(PluginListBox.Items[PluginListBox.SelectedIndex].ToString())].enabled = EnabledCheckBox.Checked;
            SaveChanges();
            PluginListBox.Focus();
        }
    }
}
