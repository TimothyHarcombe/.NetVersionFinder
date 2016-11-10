using Microsoft.Win32;
using System;

namespace DotNetFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int ver;
            Console.WriteLine("Please select the version of .Net Framework between 1 till 4 installed on your workstation, for example ===> 4:");
            ver = int.Parse(Console.ReadLine());

            switch (ver)
            {
                case 1:
                case 2:
                case 3:
                    using (RegistryKey ndpKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
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
                                    Console.WriteLine();
                                    Console.WriteLine(versionKeyName + "  ===>  " + name + "  ===>  SP" + sp);                                    
                                }
                                else
                                {
                                    if (sp != "" && install == "1")
                                    {
                                        Console.WriteLine(versionKeyName + "  ===>  " + name + "  ===>  SP" + sp);
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
                                        Console.WriteLine(versionKeyName + "  ===>  " + name);
                                    }
                                    else
                                    {
                                        if (sp != "" && install == "1")
                                        {                                            
                                            Console.WriteLine(subKeyName + "  ===>  " + name + "  ===>  SP" + sp);
                                        }
                                        else if (install == "1")
                                        {
                                            Console.WriteLine(subKeyName + "  ===>  " + name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
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
                                    Console.WriteLine();
                                    Console.WriteLine(versionKeyName + "  ===>  " + name + "  ===>  SP" + sp);
                                }
                                else
                                {
                                    if (sp != "" && install == "1")
                                    {
                                        Console.WriteLine(versionKeyName + "  ===>  " + name + "  ===>  SP" + sp);
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
                                        Console.WriteLine(versionKeyName + "  ===>  " + name);
                                    }
                                    else
                                    {
                                        if (sp != "" && install == "1")
                                        {
                                            Console.WriteLine(subKeyName + "  ===>  " + name + "  ===>  SP" + sp);
                                        }
                                        else if (install == "1")
                                        {
                                            Console.WriteLine(subKeyName + "  ===>  " + name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                default:
                    return;
            }

            Console.Read();
        }
    }
}
