namespace DpFreezeMacConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FreezeUnfreeze = new System.Windows.Forms.Button();
            this.RemoveMac = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.AddMac = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UnFreezeRadio = new System.Windows.Forms.RadioButton();
            this.FreezeRadio = new System.Windows.Forms.RadioButton();
            this.MacUName = new System.Windows.Forms.TextBox();
            this.MacPW = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MacIP = new System.Windows.Forms.TextBox();
            this.MacList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DFPW = new System.Windows.Forms.TextBox();
            this.DFUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MacName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FreezeUnfreeze
            // 
            this.FreezeUnfreeze.Enabled = false;
            this.FreezeUnfreeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreezeUnfreeze.Location = new System.Drawing.Point(356, 486);
            this.FreezeUnfreeze.Name = "FreezeUnfreeze";
            this.FreezeUnfreeze.Size = new System.Drawing.Size(75, 45);
            this.FreezeUnfreeze.TabIndex = 8;
            this.FreezeUnfreeze.Text = "Freeze/UnFreeze";
            this.FreezeUnfreeze.UseCompatibleTextRendering = true;
            this.FreezeUnfreeze.UseVisualStyleBackColor = true;
            this.FreezeUnfreeze.Click += new System.EventHandler(this.FreezeUnfreeze_Click);
            // 
            // RemoveMac
            // 
            this.RemoveMac.Enabled = false;
            this.RemoveMac.Location = new System.Drawing.Point(172, 369);
            this.RemoveMac.Name = "RemoveMac";
            this.RemoveMac.Size = new System.Drawing.Size(75, 45);
            this.RemoveMac.TabIndex = 9;
            this.RemoveMac.Text = "Remove Computers";
            this.RemoveMac.UseVisualStyleBackColor = true;
            this.RemoveMac.Click += new System.EventHandler(this.RemoveMac_Click);
            // 
            // About
            // 
            this.About.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(359, 17);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 13;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(440, 17);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 14;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // AddMac
            // 
            this.AddMac.Enabled = false;
            this.AddMac.Location = new System.Drawing.Point(293, 369);
            this.AddMac.Name = "AddMac";
            this.AddMac.Size = new System.Drawing.Size(75, 45);
            this.AddMac.TabIndex = 12;
            this.AddMac.Text = "Add Computers";
            this.AddMac.UseVisualStyleBackColor = true;
            this.AddMac.Click += new System.EventHandler(this.AddMac_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(437, 486);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 45);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Quit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UnFreezeRadio
            // 
            this.UnFreezeRadio.AutoSize = true;
            this.UnFreezeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnFreezeRadio.Location = new System.Drawing.Point(16, 161);
            this.UnFreezeRadio.Name = "UnFreezeRadio";
            this.UnFreezeRadio.Size = new System.Drawing.Size(116, 20);
            this.UnFreezeRadio.TabIndex = 1;
            this.UnFreezeRadio.TabStop = true;
            this.UnFreezeRadio.Text = "Unfreeze Macs";
            this.UnFreezeRadio.UseVisualStyleBackColor = true;
            this.UnFreezeRadio.CheckedChanged += new System.EventHandler(this.UnFreezeRadio_CheckedChanged);
            // 
            // FreezeRadio
            // 
            this.FreezeRadio.AutoSize = true;
            this.FreezeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreezeRadio.Location = new System.Drawing.Point(16, 187);
            this.FreezeRadio.Name = "FreezeRadio";
            this.FreezeRadio.Size = new System.Drawing.Size(104, 20);
            this.FreezeRadio.TabIndex = 2;
            this.FreezeRadio.TabStop = true;
            this.FreezeRadio.Text = "Freeze Macs";
            this.FreezeRadio.UseVisualStyleBackColor = true;
            this.FreezeRadio.CheckedChanged += new System.EventHandler(this.FreezeRadio_CheckedChanged);
            // 
            // MacUName
            // 
            this.MacUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacUName.Location = new System.Drawing.Point(12, 465);
            this.MacUName.Name = "MacUName";
            this.MacUName.Size = new System.Drawing.Size(154, 24);
            this.MacUName.TabIndex = 4;
            this.MacUName.TextChanged += new System.EventHandler(this.MacUName_TextChanged);
            // 
            // MacPW
            // 
            this.MacPW.Location = new System.Drawing.Point(12, 511);
            this.MacPW.Name = "MacPW";
            this.MacPW.PasswordChar = '*';
            this.MacPW.Size = new System.Drawing.Size(154, 20);
            this.MacPW.TabIndex = 5;
            this.MacPW.TextChanged += new System.EventHandler(this.MacPW_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(359, 46);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(153, 107);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Steps. 1. enter the password and User name: 2. Select to freeze or Unfreeze the M" +
                "acs: 3. Select which Macs: 4. Run the commands: 5. check logs and rerun if neede" +
                "d: Quit the program:";
            // 
            // MacIP
            // 
            this.MacIP.Location = new System.Drawing.Point(293, 293);
            this.MacIP.Name = "MacIP";
            this.MacIP.Size = new System.Drawing.Size(154, 20);
            this.MacIP.TabIndex = 10;
            this.MacIP.TextChanged += new System.EventHandler(this.MacIP_TextChanged);
            // 
            // MacList
            // 
            this.MacList.FormattingEnabled = true;
            this.MacList.HorizontalScrollbar = true;
            this.MacList.Location = new System.Drawing.Point(12, 293);
            this.MacList.Name = "MacList";
            this.MacList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.MacList.Size = new System.Drawing.Size(154, 121);
            this.MacList.TabIndex = 3;
            this.MacList.SelectedIndexChanged += new System.EventHandler(this.MacList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mac User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mac Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add A Mac IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mac Computers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "DeepFreeze Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "DeepFreeze User Name";
            // 
            // DFPW
            // 
            this.DFPW.Location = new System.Drawing.Point(187, 511);
            this.DFPW.Name = "DFPW";
            this.DFPW.PasswordChar = '*';
            this.DFPW.Size = new System.Drawing.Size(154, 20);
            this.DFPW.TabIndex = 7;
            this.DFPW.TextChanged += new System.EventHandler(this.DFPW_TextChanged);
            // 
            // DFUser
            // 
            this.DFUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFUser.Location = new System.Drawing.Point(187, 465);
            this.DFUser.Name = "DFUser";
            this.DFUser.Size = new System.Drawing.Size(154, 24);
            this.DFUser.TabIndex = 6;
            this.DFUser.TextChanged += new System.EventHandler(this.DFUser_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Add A Mac Name";
            // 
            // MacName
            // 
            this.MacName.Location = new System.Drawing.Point(293, 343);
            this.MacName.Name = "MacName";
            this.MacName.Size = new System.Drawing.Size(154, 20);
            this.MacName.TabIndex = 11;
            this.MacName.TextChanged += new System.EventHandler(this.MacName_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 548);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MacName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DFPW);
            this.Controls.Add(this.DFUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MacList);
            this.Controls.Add(this.MacIP);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.MacPW);
            this.Controls.Add(this.MacUName);
            this.Controls.Add(this.FreezeRadio);
            this.Controls.Add(this.UnFreezeRadio);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddMac);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.About);
            this.Controls.Add(this.RemoveMac);
            this.Controls.Add(this.FreezeUnfreeze);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FreezeUnfreeze;
        private System.Windows.Forms.Button RemoveMac;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button AddMac;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton UnFreezeRadio;
        private System.Windows.Forms.RadioButton FreezeRadio;
        private System.Windows.Forms.TextBox MacUName;
        private System.Windows.Forms.TextBox MacPW;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox MacIP;
        private System.Windows.Forms.ListBox MacList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DFPW;
        private System.Windows.Forms.TextBox DFUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MacName;
    }
}

