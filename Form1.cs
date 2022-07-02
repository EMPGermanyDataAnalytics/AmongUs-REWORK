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
using System.Threading;
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


        Map map;

        private void Form1_Load(object sender, EventArgs e)
        {
            attatchButton.Location = new Point(23, 55);
            Mem.Init();
            //new Thread(() => { map = new Map(); Application.Run(map); }).Start();
            //new Task(() => { map = new Map(); Application.Run(map); map.Show(); });
            map = new Map();
            map.Show();
            map.Hide();
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

                mapTimer.Interval = 10;
                mapTimer.Start();
            }
        }

        public static bool show_minimap = false;


        private void hackTimer_Tick(object sender, EventArgs e)
        {
            map.playersToRender = PlayerControl.allPlayerControls;

            if (!sortByRole)
            {
                for(int i = 0; i < PlayerControl.allPlayerControls.Count; i++)
                {
                    string lbl = GetPlayerString(PlayerControl.allPlayerControls[i]);
                    Label lab = null;
                    switch (i)
                    {
                        case 0: { lab = p1label; break; }
                        case 1: { lab = p2label; break; }
                        case 2: { lab = p3label; break; }
                        case 3: { lab = p4label; break; }
                        case 4: { lab = p5label; break; }
                        case 5: { lab = p6label; break; }
                        case 6: { lab = p7label; break; }
                        case 7: { lab = p8label; break; }
                        case 8: { lab = p9label; break; }
                        case 9: { lab = p10label; break; }
                        case 10: { lab = p11label; break; }
                        case 11: { lab = p12label; break; }
                        case 12: { lab = p13label; break; }
                        case 13: { lab = p14label; break; }
                        case 14: { lab = p15label; break; }
                        default: { lab = null; break; }
                    }
                    if(lab != null)
                    {
                        lab.Text = lbl;
                    }
                }
            }
            else
            {
                int[] map = new[] { 0, 2, 3, 4, 1, 5 };
                map = map.Reverse().ToArray();
                var sortedList = PlayerControl.allPlayerControls.OrderBy(x => map[(int)(Enum.Parse(typeof(ROLE), x.role))]).ToList();
                for (int i = 0; i < sortedList.Count; i++)
                {
                    string lbl = GetPlayerString(PlayerControl.allPlayerControls[i]);
                    Label lab = null;
                    switch (i)
                    {
                        case 0: { lab = p1label; break; }
                        case 1: { lab = p2label; break; }
                        case 2: { lab = p3label; break; }
                        case 3: { lab = p4label; break; }
                        case 4: { lab = p5label; break; }
                        case 5: { lab = p6label; break; }
                        case 6: { lab = p7label; break; }
                        case 7: { lab = p8label; break; }
                        case 8: { lab = p9label; break; }
                        case 9: { lab = p10label; break; }
                        case 10: { lab = p11label; break; }
                        case 11: { lab = p12label; break; }
                        case 12: { lab = p13label; break; }
                        case 13: { lab = p14label; break; }
                        case 14: { lab = p15label; break; }
                        default: { lab = null; break; }
                    }
                    if (lab != null)
                    {
                        lab.Text = lbl;
                    }
                }
            }

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
            UnlckCsmtcs.ForeColor = Color.Green;
            UnlckCsmtcs.Text = "Unlocked!!";
            UnlckCsmtcs.Enabled = false;
            HatManager.getPets.NOP();
        }

        private void rvertcsmtcs_Click(object sender, EventArgs e)
        {
            HatManager.getPets.Revert();
            HatManager.getHats.Revert();
            HatManager.getSkins.Revert();
            HatManager.getPlates.Revert();
            HatManager.getVisors.Revert();
        }

        private void FrceFreecht_Click(object sender, EventArgs e)
        {
            FrceFreecht.ForeColor = Color.Green;
            FrceFreecht.Text = "Free Chat Locked!!";
            FrceFreecht.Enabled = false;
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
                cb.ForeColor = Color.FromArgb(255, 128, 0);
                cb.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void ghostVisibleCB_CheckedChanged(object sender, EventArgs e)
        {
            //if (ghostVisibleCB.Checked)
            //{
            //    PlayerControl.SeeGhosts.NOP();
            //}
            //else
            // {
            //     PlayerControl.SeeGhosts.Revert();
            // }
            //do_theme(sender);
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
                SaveManager.Level = value - 1;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            show_minimap = checkBox1.Checked;
            do_theme(sender);
        }

        private void mapTimer_Tick(object sender, EventArgs e)
        {
            if (show_minimap)
            {
                map.GET_MAPBOX().Invalidate();
            }
        }


    }
}
