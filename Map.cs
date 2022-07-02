using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace AUExtern
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            this.mapBox.MouseDown += new MouseEventHandler(this.frmTTMain_MouseDown);
        }

        public PictureBox GET_MAPBOX()
        {
            return this.mapBox;
        }

        public List<PlayerControl> playersToRender;

        public static bool SHOWFRM = false;

        private void Map_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //API functions to move the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public void frmTTMain_MouseDown(object sender, MouseEventArgs e)
        {
            //If the left mouse is pressed, release form for movement
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        float zoom = 70;
        private void mapBox_Paint(object sender, PaintEventArgs e)
        {
            mapBox.SizeMode = PictureBoxSizeMode.CenterImage;
            Bitmap m = AUExtern.Properties.Resources.skeld;
            this.Width = m.Width;
            this.Height = m.Height;

            e.Graphics.DrawImage(m,(mapBox.Width / 2) - (m.Width / 2), (mapBox.Height / 2) - ((m.Height / 2)-5), m.Width,m.Height);

            if (playersToRender != null && playersToRender.Count > 0)
            {
                foreach (var a in playersToRender)
                {
                    var vec = Vec2ToOverlayPos(a.position);

                    float w = 5;
                    float h = 5;

                    Brush brush;
                    switch (a.RawRole)
                    {
                        case ROLE.Crewmate: { brush = Brushes.Lime; break; }
                        case ROLE.Engineer: { brush = Brushes.Orange; break; }
                        case ROLE.Guardian_Angel: { brush = Brushes.Yellow; break; }
                        case ROLE.Imposter: { brush = Brushes.Red; break; }
                        case ROLE.Scientist: { brush = Brushes.Cyan; break; }
                        case ROLE.Shapeshifter: { brush = Brushes.Violet; break; }
                        default: { brush = Brushes.White; break; }
                    }
                    e.Graphics.FillRectangle(brush, vec.x - (w / 2), vec.y + (h / 2), w, h);
                    e.Graphics.DrawString(a.nickname + ((a.IsDead) ? "(Dead)":""),Font,Brushes.White, vec.x - (w / 2), vec.y + (h / 2));
                }
            }
        }


        public float map_size = 10f;
        public Vector2 Vec2ToOverlayPos(Vector2 pos)
        {
            var overlayX = (mapBox.Width / 2) + pos.x * (zoom / 10);
            var overlayY = (mapBox.Height / 2) - pos.y * (zoom / 10);
            return new Vector2(overlayX - (5 / 2), overlayY - (5 / 2));
        }

        public Vector2 OverlayPosToVec2(Vector2 overlayPos)
        {
            var worldX = (overlayPos.x - (mapBox.Width / 2)) / (zoom / 10);
            var worldY = (overlayPos.y + (mapBox.Height / 2)) / (zoom / 10);
            return new Vector2(worldX + (5 / 2), worldY + (5 / 2));
        }

        private void mapBox_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = Form1.show_minimap;
        }

        private void mapBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

    }
}
