using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace AUExtern
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            attatchButton.Location = new Point(22,62);
            Mem.Init();
        }



        private void attatchButton_Click(object sender, EventArgs e)
        {
            if(!Mem.m.OpenProcess("Among Us"))
            {
                MessageBox.Show("Please Open 'Among Us' First", "~~~~", MessageBoxButtons.OK);
            }
            else
            {
                attatchButton.Visible = false;
                hackTimer.Start();
            }
        }

        private void hackTimer_Tick(object sender, EventArgs e)
        {
            string lbl = "";
            if (!sortByRole)
            {
                foreach (PlayerControl p in PlayerControl.allPlayerControls)
                {
                    lbl += GetPlayerString(p) + "\n";
                }
            }
            else
            {
                int[] map = new[] { 0, 2, 3, 4, 1, 5 };
                map = map.Reverse().ToArray();
                var sortedList = PlayerControl.allPlayerControls.OrderBy(x => map[(int)(Enum.Parse(typeof(ROLE), x.role))]).ToList();
                foreach (PlayerControl p in sortedList)
                {
                    lbl += GetPlayerString(p) + "\n";
                }
            }


            playerlistlabel.Text = lbl;
            allplayersstring = lbl;
            panel2.Refresh();

            usernamelabel.Text = "[" + PlayerControl.localPlayer.nickname + "]\n[Role: " + PlayerControl.localPlayer.role + "]\n[Dead: " + PlayerControl.localPlayer.IsDead.ToString() + "]\n[Level: " +
            PlayerControl.localPlayer.Level + "]\n[Host: " + PlayerControl.localPlayer.Host.ToString() + "]";


            if (Noclip.Checked && PlayerControl.localPlayer.nickname != null)
            {
                PlayerControl.localPlayer.ToggleNoclip(true);
            }
            if (Fullbright.Checked)
            {
                PlayerControl.localPlayer.LightHits = 0;
                PlayerControl.localPlayer.LightRadius = 40;
            }

            if (Mem.m.theProc == null || Mem.m.theProc.HasExited)
            {
                attatchButton.Visible = true;
                proclabel.Text = "Among Us Closed. Please Re-Enable Cheats";
            }
            else
            {
                proclabel.Text = "Proc ID: " + Mem.m.theProc.Id.ToString() + " Process Health: " + (Mem.m.theProc.Responding ? "Good" : "Not Responding");

            }

            if (PlayerControl.localPlayer.nickname != "")
            {
                speedLabel.Text = "Player Speed: " + PlayerControl.localPlayer.Speed.ToString();
                metroTrackBar1.Value = int.Parse(Math.Floor(PlayerControl.localPlayer.Speed).ToString());
            }


        }

        public static string allplayersstring = "";



        private void UnlckCsmtcs_Click(object sender, EventArgs e)
        {
            //HatManager.getPets.NOP();
            //HatManager.getHats.NOP();
            //HatManager.getSkins.NOP();
            //HatManager.getPlates.NOP();
            //HatManager.getVisors.NOP();
            HatManager.getCosmetics.NOP();
        }

        private void rvertcsmtcs_Click(object sender, EventArgs e)
        {
            //HatManager.getPets.Revert();
            //HatManager.getHats.Revert();
            //HatManager.getSkins.Revert();
            //HatManager.getPlates.Revert();
            //HatManager.getVisors.Revert();
            HatManager.getCosmetics.Revert();
        }

        private void FrceFreecht_Click(object sender, EventArgs e)
        {
            SaveManager.Get_ChatModeType.NOP();
        }


        public bool _showdead = false;
        public bool _showrole = false;
        public bool _showlevel = false;

        public string GetPlayerString(PlayerControl p)
        {
            string str = p.nickname;

            if (_showdead)
            {
                str += " Dead: " + p.IsDead.ToString();
            }
            if (_showrole)
            {
                str += " Role: " + p.role;
            }
            if (_showlevel)
            {
                str += " Level: " + p.Level;
            }
            return str;
        }



        private void showrole_CheckedChanged(object sender, EventArgs e)
        {
            _showrole = showrole.Checked;
            do_theme(sender);
        }

        private void showlevel_CheckedChanged(object sender, EventArgs e)
        {
            _showlevel = showlevel.Checked;
            do_theme(sender);
        }


        private void Noclip_CheckedChanged(object sender, EventArgs e)
        {
            PlayerControl.localPlayer.ToggleNoclip(Noclip.Checked);
            do_theme(sender);
        }

        private void topmostbox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostbox.Checked;
            topmostbox.Text = "Top Most [" + (topmostbox.Checked ? "On" : "Off") + "]";
            do_theme(sender);
        }

        //Speed Trackbar
        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PlayerControl.localPlayer.Speed = float.Parse(e.NewValue.ToString());
            speedLabel.Text = "Player Speed: " + PlayerControl.localPlayer.Speed.ToString();
        }

        public bool sortByRole = false;
        private void sortButton_CheckedChanged(object sender, EventArgs e)
        {
            sortByRole = sortButton.Checked;
            do_theme(sender);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            PlayerControl.localPlayer.ResetSpeed();
        }

        private void showdead_CheckedChanged_1(object sender, EventArgs e)
        {
            _showdead = showdead.Checked;
            do_theme(sender);
        }

        private void Fullbright_CheckedChanged(object sender, EventArgs e)
        {
            PlayerControl.localPlayer.ToggleFB(Fullbright.Checked);
            do_theme(sender);
        }

        private void setnameButton_Click(object sender, EventArgs e)
        {
            PlayerControl.localPlayer.nickname = setnametextbox.Text;
        } 



        public void do_theme(object sender)
        {
            CheckBox cb = (CheckBox)sender;
            if (((CheckBox)sender).Checked)
            {
                cb.ForeColor = Color.White;
                cb.BackColor = Color.Green;
            }
            else
            {
                cb.ForeColor = Color.FromArgb(0, 192, 192);
                cb.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void ghostVisibleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ghostVisibleCB.Checked)
            {
                PlayerControl.SeeGhosts.NOP();
            }
            else
            {
                PlayerControl.SeeGhosts.Revert();
            }
            do_theme(sender);
        }

        private void seeGhostChatCB_CheckedChanged(object sender, EventArgs e)
        {
            //Mem.m.WriteBytes(PlayerControl.SeeGhostChat.address,(((CheckBox)sender).Checked ? new byte[] {0x90,0x90,0x90,0x90,0x90} : new byte[] {0xE8,0x23,0x87,0x00,0x00}));
            //do_theme(sender);
        }

        private void moji1_Click(object sender, EventArgs e)
        {
            if (setnametextbox.MaxLength > setnametextbox.Text.Length)
            {
                setnametextbox.Text += ((Button)sender).Text;
            }
        }

        private void moji2_Click(object sender, EventArgs e)
        {
            if(setnametextbox.MaxLength > setnametextbox.Text.Length)
            {
                setnametextbox.Text += ((Button)sender).Text;
            }
        }

        private void moji3_Click(object sender, EventArgs e)
        {
            if (setnametextbox.MaxLength > setnametextbox.Text.Length)
            {
                setnametextbox.Text += ((Button)sender).Text;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString(allplayersstring,Font,Brushes.Blue,5,5);
        }

        private void setnametextbox_TextChanged(object sender, EventArgs e)
        {
            nameLengthLabel.Text = setnametextbox.Text.Length.ToString() + "/10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 0;
            if(int.TryParse(LevelTB.Text, out value))
            {
                PlayerControl.localPlayer.Level = value;
                SaveManager.Level = value ;
            }
            else
            {
                LevelTB.Text = "";
                MessageBox.Show("Only Use Numbers Please","Invalid Number",MessageBoxButtons.OK);
            }
        }

        private void LevelTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
