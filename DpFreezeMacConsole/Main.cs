using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace DpFreezeMacConsole
{
    public partial class Main : Form
    {
        // Written by Dale Moore 2/4/14
        // Finished Beta 2/7/14 
        // moore3dj@cmich.edu
        // free to use and modify As you modify add your name under mine.
        //Giving Credit for the work and ideas are important.
        String UName;
        String PWord;
        String DFUName;
        String DFPWord;
        // I thought about giving the user control to set the directory but I want security of the information more.
        // If the user truely wants to modify the home directory then they should be knowledgable enough to change this in coding.
        String Home = @"C:\PROGRA~2\DpFreezeMacConsole";
        //String Home = @"C:\WindowsFormsApplication2";
        //String Home = Application.StartupPath;
                    // this verifies that the unfreeze/freeze command can be ran before enabling the button

        public Main()
        {
            InitializeComponent();

            //checks folders exsistence and creates folder if it doesnt
            if (!Directory.Exists(Home))
            {
                Directory.CreateDirectory(Home);
            }
            //checks files exsistence and creates if needed.
            if (!File.Exists(Home + @"\Machines.txt"))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\Machines.txt", false))
                {
                    file.WriteLine("");
                }
            }

            //where all your machines go
            MacList.Items.AddRange(File.ReadAllLines(Home + @"\Machines.txt"));
            // this creates the deep freeze script
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\UNFreeze.txt", false))
            {
                file.WriteLine("");
            }
            // this creates the batch file that will run the commands to get putty started
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\WriteText.bat", false))
            {
                file.WriteLine("");

            }

        }

        // the logic to make sure the buttons are enabled only when the requirements are met
        private void checkFields()
        {
            if ((FreezeRadio.Checked || UnFreezeRadio.Checked) && MacList.SelectedIndex != -1 && MacUName.Text != "" && MacPW.Text != "")
            {
                FreezeUnfreeze.Enabled = true;
            }
            else
            {
                FreezeUnfreeze.Enabled = false;
            }

            if (MacIP.Text != "")
            {
                AddMac.Enabled = true;
            }
            else 
            {
                AddMac.Enabled = false;
            }

            if (MacList.SelectedIndex != -1)
            {
                RemoveMac.Enabled = true;
            }
            else 
            {
                RemoveMac.Enabled = false;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Help Help = new Help();
            Help.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Hide();
            About About = new About();
            About.Show();
        }

        // following areas calling check fields  is to verify access to certain buttons allowed
        private void UnFreezeRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void FreezeRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void MacList_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void MacUName_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void MacPW_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void DFUser_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void DFPW_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void MacIP_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void MacName_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }
        // this is the code of the button to add macs
        private void AddMac_Click(object sender, EventArgs e)
        {
            string nameIP = MacName.Text + " - " + MacIP.Text;
            MacList.Items.Add(nameIP);
            //listBox2.Items.Add(textBox7.Text);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\Machines.txt", true))
            {

                file.WriteLine(nameIP);
                //file.Close();
            }
            MacList.Items.Clear();
            MacList.Items.AddRange(File.ReadAllLines(Home + @"\Machines.txt"));
            MacIP.Clear();
            MacName.Clear();
        }
        // code of the remove mac button
        private void RemoveMac_Click(object sender, EventArgs e)
        {
            MacList.Items.Remove(MacList.SelectedItem);

            //listBox1.Items.Remove(textBox4.Text);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\Machines.txt", false))
            {
                foreach (object L in MacList.Items)
                {
                    file.WriteLine(L.ToString());

                }
                file.Close();

            }
        }

        private void FreezeUnfreeze_Click(object sender, EventArgs e)
        {
            // the user and password are set here from your input
            UName = MacUName.Text;
            PWord = MacPW.Text;
            DFUName = DFUser.Text;
            DFPWord = DFPW.Text;


            // this loop walks through all the selected machines in the listbox
            foreach (string nameIP in MacList.SelectedItems)
            {
                // Removing preceding computer name from the IP
                string[] Lstrings = nameIP.Split('-');
                string L = Lstrings[1].Trim();
                // this line defaults the DF login to the Mac login if left blank
                if (String.IsNullOrEmpty(DFPW.Text) && String.IsNullOrEmpty(DFUser.Text))
                {
                    DFUName = UName;
                    DFPWord = PWord;
                }
                // this is where the commands needed are formatted and combined
                String Command = Home + @"\putty.exe -ssh ";
                String Command2 = "@" + L + " -pw ";
                String FreezeUnFreeze;
                String RestartCommand = string.Format("echo " + "'" + PWord + "'" + " | sudo -S " + "shutdown -r now ");
                if (UnFreezeRadio.Checked && !FreezeRadio.Checked)
                {
                    FreezeUnFreeze = string.Format(@"/Library/Application\ Support/Faronics/Deep\ Freeze/CLI " + '"' + DFUName + '"' + " " + '"' + DFPWord + '"' + " bootThawedFor " + "6\r\n");
                    System.IO.File.WriteAllText(Home + @"\UNFreeze.txt", FreezeUnFreeze);

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\UNFreeze.txt", true))
                    {
                        file.WriteLine(RestartCommand);
                        file.Close();
                    }


                }

                if (FreezeRadio.Checked && !UnFreezeRadio.Checked)
                {
                    FreezeUnFreeze = string.Format(@"/Library/Application\ Support/Faronics/Deep\ Freeze/CLI " + '"' + UName + '"' + " " + '"' + PWord + '"' + " bootFrozen " + "\r\n");

                    System.IO.File.WriteAllText(Home + @"\UNFreeze.txt", FreezeUnFreeze);

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\UNFreeze.txt", true))
                    {
                        file.WriteLine(RestartCommand);

                    }

                }

                String Command3 = " -m " + Home + @"\UNFreeze.txt";
                String RunCommand = string.Format(Command + UName + Command2 + PWord + Command3);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\WriteText.bat", false))
                {
                    file.WriteLine(RunCommand);

                }
                //System.IO.File.WriteAllText(Home + @"WriteText.bat", RunCommand);
                //Process cmd = System.Diagnostics.Process.Start(Home + @"\WriteText" + i + ".bat");
                //System.Diagnostics.Process.Start(Home + @"\WriteText" + i + ".bat");
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = Home + @"\WriteText.bat";
                //proc.StartInfo.RedirectStandardError = false;
                // proc.StartInfo.RedirectStandardOutput = false;
                // proc.StartInfo.UseShellExecute = false;
                proc.Start();
                proc.WaitForExit();
                //cmd.CloseMainWindow();

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\UNFreeze.txt", false))
                {
                    file.WriteLine("");

                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\WriteText.bat", false))
                {
                    file.WriteLine("");

                }
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MacUName.Text = "";
            MacPW.Text = "";
            MacIP.Text = "";
            DFPW.Text = "";
            DFUser.Text = "";
            MacName.Text = "";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\UNFreeze.txt", false))
            {
                file.WriteLine("");
                file.Close();
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Home + @"\WriteText.bat", false))
            {
                file.WriteLine("");
                file.Close();
            }
            Application.Exit();
        }



    }
}
