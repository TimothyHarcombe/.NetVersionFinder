using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace DotNetVersionFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oldVersion_Click(object sender, EventArgs e)
        {
            richTextBoxName.Clear();
            richTextBoxSP.Clear();
            richTextBoxVersion.Clear();

            using (RegistryKey ndpKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                RegKey(ndpKey);
            }
        }

        private void newVersion_Click(object sender, EventArgs e)
        {
            richTextBoxName.Clear();
            richTextBoxSP.Clear();
            richTextBoxVersion.Clear();

            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                RegKey(ndpKey); 
            }
        }

        public void RegKey(RegistryKey ndpKey)
        {
            foreach (string versionKeyName in ndpKey.GetSubKeyNames())
            {
                if (versionKeyName.StartsWith("v"))
                {
                    RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                    string name = (string)versionKey.GetValue("Version", "");
                    string sp = versionKey.GetValue("SP", "").ToString();
                    string install = versionKey.GetValue("Install", "").ToString();
                    if (install == "")
                    {
                        richTextBoxVersion.AppendText(versionKeyName + Environment.NewLine + Environment.NewLine);
                        richTextBoxSP.AppendText(sp + Environment.NewLine);
                    }
                    else
                    {
                        if (sp != "" && install == "1")
                        {
                            richTextBoxVersion.AppendText(versionKeyName + Environment.NewLine);
                            richTextBoxName.AppendText(name + Environment.NewLine);
                            richTextBoxSP.AppendText(sp + Environment.NewLine);
                        }
                    }
                    if (name != "")
                    {
                        continue;
                    }
                    foreach (string subKeyName in versionKey.GetSubKeyNames())
                    {
                        RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                        name = (string)subKey.GetValue("Version", "");
                        if (name != "")
                        {
                            sp = subKey.GetValue("SP", "").ToString();
                        }
                        install = subKey.GetValue("Install", "").ToString();
                        if (install == "")
                        {
                            richTextBoxVersion.AppendText(versionKeyName + Environment.NewLine);
                            richTextBoxName.AppendText(name + Environment.NewLine);
                        }
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                richTextBoxName.AppendText(subKeyName + " ===> " + name + Environment.NewLine);
                                richTextBoxSP.AppendText(sp + Environment.NewLine);
                            }
                            else if (install == "1")
                            {
                                richTextBoxName.AppendText(subKeyName + " ===> " + name + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }
    }
}
