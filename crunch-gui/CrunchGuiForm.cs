using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Crunch_GUI
{
    public partial class CrunchGuiForm : Form
    {
        public CrunchGuiForm()
        {
            InitializeComponent();
        }

        private void maxAtlasOption_CheckedChanged(object sender, EventArgs e)
        {
            maxAtlasComboBox.Enabled = maxAtlasOption.Checked;
        }

        private void paddingOption_CheckedChanged(object sender, EventArgs e)
        {
            paddingInput.Enabled = paddingOption.Checked;
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Image (*.png)|*.png";
            dialog.Title = "Select png image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    sourcesList.Items.Add(dialog.FileName);
                }
            }
            dialog.Dispose();
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                {
                    sourcesList.Items.Add(dialog.SelectedPath);
                }
            }
            dialog.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sourcesList.Items.Count; i++)
            {
                if (sourcesList.Items[i].Selected) sourcesList.Items[i].Remove();
            }
        }

        private void packButton_Click(object sender, EventArgs e)
        {
            Pack(false);
        }

        private void rePackButton_Click(object sender, EventArgs e)
        {
            Pack(true);
        }

        private void Pack(bool force)
        {
            if (!File.Exists(Path.GetFullPath("crunch.exe")))
            {
                ShowError("Crunch not found! Place the \"crunch.exe\" in the same folder as Crunch GUI.");
                return;
            }
            if (outputTextBox.Text == "")
            {
                ShowError("Output not specified!");
                return;
            }
            if (!Path.IsPathRooted(outputTextBox.Text))
            {
                ShowError("Output not valid! (is it path rooted?)");
                return;
            }
            if (sourcesList.Items.Count == 0)
            {
                ShowError("No sources specified!");
                return;
            }

            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = "\"" + outputTextBox.Text + "\"" + GetSources() + GetOptions(force);
            start.FileName = Path.GetFullPath("crunch.exe");
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            int exitCode;

            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }
            if (exitCode != 1)
                ShowInfo("Success !");
            else ShowError(
                "A problem occured with crunch, " +
                "and because the developer of Crunch GUI is lazy, " +
                "he didn't make any log system to his app in order to fix it.\n" +
                "Maybe in a future update? Who know?\n" +
                "But before you start to insult him, make sure that your output or sources path are (still) valid.");
        }

        private string GetOptions(bool force)
        {
            string options = "";
            if (xmlOption.Checked) options += " -x";
            if (binOption.Checked) options += " -b";
            if (jsonOption.Checked) options += " -j";
            if (premultiplyOption.Checked) options += " -p";
            if (trimOption.Checked) options += " -t";
            if (force) options += " -f";
            if (uniqueOption.Checked) options += " -u";
            if (rotateOption.Checked) options += " -r";
            if (paddingOption.Checked) options += " -p" + paddingInput.Value.ToString();
            if (maxAtlasOption.Checked) options += " -s" + maxAtlasComboBox.SelectedItem.ToString();
            return options;
        }

        private string GetSources()
        {
            string sources = " ";

            for (int i = 0; i < sourcesList.Items.Count; i++)
            {
                sources += "\"" + sourcesList.Items[i].Text + "\"";
                if (i + 1 < sourcesList.Items.Count) sources += ",";
            }

            return sources;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (!ShowWarning("This will erase all your current selected options, output and sources and make them to the default values.\n\nContinue?")) return;

            ClearOptions();

            xmlOption.Checked = true;
            premultiplyOption.Checked = true;
            trimOption.Checked = true;
            uniqueOption.Checked = true;
            paddingOption.Checked = true;
            paddingInput.Value = 0;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Image (*.png)|*.png";
            dialog.Title = "Choose output";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(Path.GetDirectoryName(dialog.FileName)))
                {
                    outputTextBox.Text = dialog.FileName;
                }
            }
            dialog.Dispose();
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            string configFilePath = "";

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Config file (*.xml)|*.xml";
            dialog.Title = "Choose output config file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                configFilePath = dialog.FileName;
            }
            else
            {
                dialog.Dispose();
                return;
            }
            dialog.Dispose();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Async = true;
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(configFilePath, settings);
            writer.WriteStartElement("CrunchGuiConfig");

            //output
            writer.WriteElementString("Output", outputTextBox.Text);
            
            //sources
            writer.WriteStartElement("Sources");
            for (int i = 0; i < sourcesList.Items.Count; i++)
            {
                writer.WriteElementString("Source", sourcesList.Items[i].Text);
            }
            writer.WriteEndElement();

            //options
            writer.WriteStartElement("Options");
            writer.WriteElementString("Xml", xmlOption.Checked.ToString());
            writer.WriteElementString("Bin", binOption.Checked.ToString());
            writer.WriteElementString("Json", jsonOption.Checked.ToString());
            writer.WriteElementString("Trim", trimOption.Checked.ToString());
            writer.WriteElementString("Unique", uniqueOption.Checked.ToString());
            writer.WriteElementString("Rotate", rotateOption.Checked.ToString());
            writer.WriteElementString("Padding", paddingOption.Checked.ToString());
            if (paddingOption.Checked) writer.WriteElementString("PaddingValue", paddingInput.Value.ToString());
            writer.WriteElementString("MaxAtlas", (maxAtlasOption.Checked && maxAtlasComboBox.SelectedItem != null).ToString());
            if (maxAtlasOption.Checked && maxAtlasComboBox.SelectedItem != null) writer.WriteElementString("MaxAtlasValue", maxAtlasComboBox.SelectedItem.ToString());
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
            if (!ShowWarning("This will erase all your current selected options, output and sources.\n\nContinue?")) return;

            string configFilePath = "";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Config file (*.xml)|*.xml";
            dialog.Title = "Choose config file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    configFilePath = dialog.FileName;
                }
                else
                {
                    ShowError("The path to the file was incorrect (file not found).");
                }
            }
            else
            {
                dialog.Dispose();
                return;
            }
            dialog.Dispose();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;

            ClearOptions();

            using (XmlReader reader = XmlReader.Create(configFilePath, settings))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement() && reader.NodeType != XmlNodeType.EndElement)
                    {
                        if (!reader.IsEmptyElement)
                        {
                            if (reader.Name == "Output") outputTextBox.Text = reader.ReadElementContentAsString();

                            else if (reader.Name == "Source") sourcesList.Items.Add(reader.ReadElementContentAsString());

                            else if (reader.Name == "Xml") xmlOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "Bin") binOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "Json") jsonOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "Trim") trimOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "Unique") uniqueOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "Rotate") rotateOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "Padding") paddingOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "PaddingValue") paddingInput.Value = reader.ReadElementContentAsInt();
                            else if (reader.Name == "MaxAtlas") maxAtlasOption.Checked = bool.Parse(reader.ReadElementContentAsString());
                            else if (reader.Name == "MaxAtlasValue") maxAtlasComboBox.SelectedItem = reader.ReadElementContentAsString();
                        }
                    }
                }
            }
        }

        private void ClearOptions()
        {
            sourcesList.Items.Clear();
            outputTextBox.Text = "";
            xmlOption.Checked = false;
            binOption.Checked = false;
            jsonOption.Checked = false;
            trimOption.Checked = false;
            uniqueOption.Checked = false;
            paddingOption.Checked = false;
            paddingInput.Value = 0;
            maxAtlasOption.Checked = false;
            maxAtlasComboBox.SelectedItem = null;
            maxAtlasComboBox.Text = "Select a size";
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ShowWarning(string message)
        {
            DialogResult result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createBatButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.GetFullPath("crunch.exe")))
            {
                ShowError("Crunch not found! Place the \"crunch.exe\" in the same folder as Crunch GUI.");
                return;
            }
            if (outputTextBox.Text == "")
            {
                ShowError("Output not specified!");
                return;
            }
            if (!Path.IsPathRooted(outputTextBox.Text))
            {
                ShowError("Output not valid! (is it path rooted?)");
                return;
            }
            if (sourcesList.Items.Count == 0)
            {
                ShowError("No sources specified!");
                return;
            }

            string filePath = "";

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Batch file (*.bat)|*.bat";
            dialog.Title = "Choose output batch file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            else
            {
                dialog.Dispose();
                return;
            }
            dialog.Dispose();

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                AddText(stream, "cd \"" + Path.GetDirectoryName(Path.GetFullPath("crunch.exe")) + "\"\n");
                AddText(stream, "crunch.exe \"" + outputTextBox.Text + "\"" + GetSources() + GetOptions(false));
            }

            static void AddText(FileStream fs, string value)
            {
                byte[] info = new UTF8Encoding(true).GetBytes(value);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
