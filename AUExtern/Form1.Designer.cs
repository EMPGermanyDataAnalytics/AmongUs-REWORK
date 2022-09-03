namespace AUExtern
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UnlckCsmtcs = new System.Windows.Forms.Button();
            this.FrceFreecht = new System.Windows.Forms.Button();
            this.playerlistlabel = new System.Windows.Forms.Label();
            this.hackTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LevelTB = new MetroFramework.Controls.MetroTextBox();
            this.moji1 = new System.Windows.Forms.Button();
            this.moji2 = new System.Windows.Forms.Button();
            this.moji3 = new System.Windows.Forms.Button();
            this.ghostVisibleCB = new System.Windows.Forms.CheckBox();
            this.setnameButton = new System.Windows.Forms.Button();
            this.setnametextbox = new MetroFramework.Controls.MetroTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.Fullbright = new System.Windows.Forms.CheckBox();
            this.Noclip = new System.Windows.Forms.CheckBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.showrole = new System.Windows.Forms.CheckBox();
            this.showdead = new System.Windows.Forms.CheckBox();
            this.showlevel = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sortButton = new System.Windows.Forms.CheckBox();
            this.attatchButton = new System.Windows.Forms.Button();
            this.proclabel = new System.Windows.Forms.Label();
            this.topmostbox = new System.Windows.Forms.CheckBox();
            this.nameLengthLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnlckCsmtcs
            // 
            this.UnlckCsmtcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnlckCsmtcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnlckCsmtcs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UnlckCsmtcs.Location = new System.Drawing.Point(468, 63);
            this.UnlckCsmtcs.Name = "UnlckCsmtcs";
            this.UnlckCsmtcs.Size = new System.Drawing.Size(152, 53);
            this.UnlckCsmtcs.TabIndex = 0;
            this.UnlckCsmtcs.Text = "!!Unlock All Cosmetics!!";
            this.UnlckCsmtcs.UseVisualStyleBackColor = false;
            this.UnlckCsmtcs.Click += new System.EventHandler(this.UnlckCsmtcs_Click);
            // 
            // FrceFreecht
            // 
            this.FrceFreecht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FrceFreecht.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FrceFreecht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FrceFreecht.Location = new System.Drawing.Point(321, 63);
            this.FrceFreecht.Name = "FrceFreecht";
            this.FrceFreecht.Size = new System.Drawing.Size(141, 54);
            this.FrceFreecht.TabIndex = 2;
            this.FrceFreecht.Text = "!!Force Freechat!!";
            this.FrceFreecht.UseVisualStyleBackColor = false;
            this.FrceFreecht.Click += new System.EventHandler(this.FrceFreecht_Click);
            // 
            // playerlistlabel
            // 
            this.playerlistlabel.AutoSize = true;
            this.playerlistlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerlistlabel.ForeColor = System.Drawing.Color.Cyan;
            this.playerlistlabel.Location = new System.Drawing.Point(3, 3);
            this.playerlistlabel.Name = "playerlistlabel";
            this.playerlistlabel.Size = new System.Drawing.Size(15, 13);
            this.playerlistlabel.TabIndex = 3;
            this.playerlistlabel.Text = "~";
            // 
            // hackTimer
            // 
            this.hackTimer.Tick += new System.EventHandler(this.hackTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LevelTB);
            this.panel1.Controls.Add(this.moji1);
            this.panel1.Controls.Add(this.moji2);
            this.panel1.Controls.Add(this.moji3);
            this.panel1.Controls.Add(this.ghostVisibleCB);
            this.panel1.Controls.Add(this.setnameButton);
            this.panel1.Controls.Add(this.setnametextbox);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.speedLabel);
            this.panel1.Controls.Add(this.metroTrackBar1);
            this.panel1.Controls.Add(this.Fullbright);
            this.panel1.Controls.Add(this.Noclip);
            this.panel1.Controls.Add(this.usernamelabel);
            this.panel1.Location = new System.Drawing.Point(321, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 208);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(185, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 22);
            this.button1.TabIndex = 22;
            this.button1.Text = "Set Level";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelTB
            // 
            this.LevelTB.Location = new System.Drawing.Point(184, 133);
            this.LevelTB.MaxLength = 10;
            this.LevelTB.Multiline = true;
            this.LevelTB.Name = "LevelTB";
            this.LevelTB.PromptText = "Level";
            this.LevelTB.Size = new System.Drawing.Size(111, 23);
            this.LevelTB.TabIndex = 21;
            this.LevelTB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LevelTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LevelTB_KeyPress);
            // 
            // moji1
            // 
            this.moji1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moji1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moji1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moji1.Location = new System.Drawing.Point(185, 28);
            this.moji1.Name = "moji1";
            this.moji1.Size = new System.Drawing.Size(28, 22);
            this.moji1.TabIndex = 20;
            this.moji1.Text = "😁";
            this.moji1.UseVisualStyleBackColor = false;
            this.moji1.Click += new System.EventHandler(this.moji1_Click);
            // 
            // moji2
            // 
            this.moji2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moji2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moji2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moji2.Location = new System.Drawing.Point(221, 28);
            this.moji2.Name = "moji2";
            this.moji2.Size = new System.Drawing.Size(39, 22);
            this.moji2.TabIndex = 19;
            this.moji2.Text = "😎";
            this.moji2.UseVisualStyleBackColor = false;
            this.moji2.Click += new System.EventHandler(this.moji2_Click);
            // 
            // moji3
            // 
            this.moji3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moji3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moji3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moji3.Location = new System.Drawing.Point(266, 28);
            this.moji3.Name = "moji3";
            this.moji3.Size = new System.Drawing.Size(29, 22);
            this.moji3.TabIndex = 18;
            this.moji3.Text = "😂";
            this.moji3.UseVisualStyleBackColor = false;
            this.moji3.Click += new System.EventHandler(this.moji3_Click);
            // 
            // ghostVisibleCB
            // 
            this.ghostVisibleCB.Appearance = System.Windows.Forms.Appearance.Button;
            this.ghostVisibleCB.AutoSize = true;
            this.ghostVisibleCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ghostVisibleCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ghostVisibleCB.Location = new System.Drawing.Point(185, 110);
            this.ghostVisibleCB.Name = "ghostVisibleCB";
            this.ghostVisibleCB.Size = new System.Drawing.Size(110, 23);
            this.ghostVisibleCB.TabIndex = 14;
            this.ghostVisibleCB.Text = "Ghosts Stay Visible ";
            this.ghostVisibleCB.UseVisualStyleBackColor = true;
            this.ghostVisibleCB.CheckedChanged += new System.EventHandler(this.ghostVisibleCB_CheckedChanged);
            // 
            // setnameButton
            // 
            this.setnameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setnameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setnameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setnameButton.Location = new System.Drawing.Point(185, 54);
            this.setnameButton.Name = "setnameButton";
            this.setnameButton.Size = new System.Drawing.Size(110, 22);
            this.setnameButton.TabIndex = 13;
            this.setnameButton.Text = "Set Nickname";
            this.setnameButton.UseVisualStyleBackColor = false;
            this.setnameButton.Click += new System.EventHandler(this.setnameButton_Click);
            // 
            // setnametextbox
            // 
            this.setnametextbox.Location = new System.Drawing.Point(185, 3);
            this.setnametextbox.MaxLength = 10;
            this.setnametextbox.Multiline = true;
            this.setnametextbox.Name = "setnametextbox";
            this.setnametextbox.Size = new System.Drawing.Size(110, 23);
            this.setnametextbox.TabIndex = 11;
            this.setnametextbox.Text = "Username";
            this.setnametextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setnametextbox.TextChanged += new System.EventHandler(this.setnametextbox_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resetButton.Location = new System.Drawing.Point(240, 180);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(54, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.Cyan;
            this.speedLabel.Location = new System.Drawing.Point(3, 164);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(98, 13);
            this.speedLabel.TabIndex = 11;
            this.speedLabel.Text = "Player Speed: ~";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroTrackBar1.Location = new System.Drawing.Point(6, 180);
            this.metroTrackBar1.Minimum = 1;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(228, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTrackBar1.TabIndex = 10;
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // Fullbright
            // 
            this.Fullbright.Appearance = System.Windows.Forms.Appearance.Button;
            this.Fullbright.AutoSize = true;
            this.Fullbright.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fullbright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Fullbright.Location = new System.Drawing.Point(185, 81);
            this.Fullbright.Name = "Fullbright";
            this.Fullbright.Size = new System.Drawing.Size(59, 23);
            this.Fullbright.TabIndex = 10;
            this.Fullbright.Text = "Fullbright";
            this.Fullbright.UseVisualStyleBackColor = true;
            this.Fullbright.CheckedChanged += new System.EventHandler(this.Fullbright_CheckedChanged);
            // 
            // Noclip
            // 
            this.Noclip.Appearance = System.Windows.Forms.Appearance.Button;
            this.Noclip.AutoSize = true;
            this.Noclip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Noclip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Noclip.Location = new System.Drawing.Point(247, 81);
            this.Noclip.Name = "Noclip";
            this.Noclip.Size = new System.Drawing.Size(48, 23);
            this.Noclip.TabIndex = 9;
            this.Noclip.Text = "NoClip";
            this.Noclip.UseVisualStyleBackColor = true;
            this.Noclip.CheckedChanged += new System.EventHandler(this.Noclip_CheckedChanged);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Cyan;
            this.usernamelabel.Location = new System.Drawing.Point(3, 6);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(17, 16);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "~";
            // 
            // showrole
            // 
            this.showrole.Appearance = System.Windows.Forms.Appearance.Button;
            this.showrole.AutoSize = true;
            this.showrole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showrole.Location = new System.Drawing.Point(201, 240);
            this.showrole.Name = "showrole";
            this.showrole.Size = new System.Drawing.Size(39, 23);
            this.showrole.TabIndex = 6;
            this.showrole.Text = "Role";
            this.showrole.UseVisualStyleBackColor = true;
            this.showrole.CheckedChanged += new System.EventHandler(this.showrole_CheckedChanged);
            // 
            // showdead
            // 
            this.showdead.Appearance = System.Windows.Forms.Appearance.Button;
            this.showdead.AutoSize = true;
            this.showdead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showdead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showdead.Location = new System.Drawing.Point(244, 240);
            this.showdead.Name = "showdead";
            this.showdead.Size = new System.Drawing.Size(43, 23);
            this.showdead.TabIndex = 8;
            this.showdead.Text = "Dead";
            this.showdead.UseVisualStyleBackColor = true;
            this.showdead.CheckedChanged += new System.EventHandler(this.showdead_CheckedChanged_1);
            // 
            // showlevel
            // 
            this.showlevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.showlevel.AutoSize = true;
            this.showlevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showlevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showlevel.Location = new System.Drawing.Point(122, 240);
            this.showlevel.Name = "showlevel";
            this.showlevel.Size = new System.Drawing.Size(31, 23);
            this.showlevel.TabIndex = 9;
            this.showlevel.Text = "Lvl";
            this.showlevel.UseVisualStyleBackColor = true;
            this.showlevel.CheckedChanged += new System.EventHandler(this.showlevel_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sortButton);
            this.panel2.Controls.Add(this.playerlistlabel);
            this.panel2.Controls.Add(this.showlevel);
            this.panel2.Controls.Add(this.showdead);
            this.panel2.Controls.Add(this.showrole);
            this.panel2.Location = new System.Drawing.Point(23, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 268);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // sortButton
            // 
            this.sortButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.sortButton.AutoSize = true;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sortButton.Location = new System.Drawing.Point(159, 240);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(36, 23);
            this.sortButton.TabIndex = 10;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.CheckedChanged += new System.EventHandler(this.sortButton_CheckedChanged);
            // 
            // attatchButton
            // 
            this.attatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attatchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.attatchButton.Location = new System.Drawing.Point(797, 61);
            this.attatchButton.Name = "attatchButton";
            this.attatchButton.Size = new System.Drawing.Size(598, 268);
            this.attatchButton.TabIndex = 12;
            this.attatchButton.Text = "Click To Enable Cheats";
            this.attatchButton.UseVisualStyleBackColor = false;
            this.attatchButton.Click += new System.EventHandler(this.attatchButton_Click);
            // 
            // proclabel
            // 
            this.proclabel.AutoSize = true;
            this.proclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proclabel.ForeColor = System.Drawing.Color.Cyan;
            this.proclabel.Location = new System.Drawing.Point(21, 334);
            this.proclabel.Name = "proclabel";
            this.proclabel.Size = new System.Drawing.Size(0, 13);
            this.proclabel.TabIndex = 13;
            // 
            // topmostbox
            // 
            this.topmostbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.topmostbox.AutoSize = true;
            this.topmostbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topmostbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.topmostbox.Location = new System.Drawing.Point(535, 334);
            this.topmostbox.Name = "topmostbox";
            this.topmostbox.Size = new System.Drawing.Size(85, 23);
            this.topmostbox.TabIndex = 11;
            this.topmostbox.Text = "Top Most [Off]";
            this.topmostbox.UseVisualStyleBackColor = true;
            this.topmostbox.CheckedChanged += new System.EventHandler(this.topmostbox_CheckedChanged);
            // 
            // nameLengthLabel
            // 
            this.nameLengthLabel.AutoSize = true;
            this.nameLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLengthLabel.ForeColor = System.Drawing.Color.Cyan;
            this.nameLengthLabel.Location = new System.Drawing.Point(620, 132);
            this.nameLengthLabel.Name = "nameLengthLabel";
            this.nameLengthLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLengthLabel.TabIndex = 14;
            this.nameLengthLabel.Text = "8/10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 369);
            this.Controls.Add(this.nameLengthLabel);
            this.Controls.Add(this.topmostbox);
            this.Controls.Add(this.proclabel);
            this.Controls.Add(this.attatchButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FrceFreecht);
            this.Controls.Add(this.UnlckCsmtcs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "AmongUs External  by: Glatrix 2022";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnlckCsmtcs;
        private System.Windows.Forms.Button FrceFreecht;
        private System.Windows.Forms.Label playerlistlabel;
        private System.Windows.Forms.Timer hackTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showrole;
        private System.Windows.Forms.CheckBox showdead;
        private System.Windows.Forms.CheckBox showlevel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.CheckBox Fullbright;
        private System.Windows.Forms.CheckBox Noclip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button attatchButton;
        private System.Windows.Forms.Label proclabel;
        private System.Windows.Forms.CheckBox topmostbox;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.CheckBox sortButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button setnameButton;
        private MetroFramework.Controls.MetroTextBox setnametextbox;
        private System.Windows.Forms.CheckBox ghostVisibleCB;
        private System.Windows.Forms.Button moji1;
        private System.Windows.Forms.Button moji2;
        private System.Windows.Forms.Button moji3;
        private System.Windows.Forms.Label nameLengthLabel;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox LevelTB;
    }
}

