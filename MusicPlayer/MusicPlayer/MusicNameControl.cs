using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer.Models;

namespace MusicPlayer
{
    public partial class MusicNameControl : UserControl
    {
        public event EventHandler<Music> Selected;
        public event EventHandler<Music> Playing;
        public event EventHandler<Music> Del;


        public MusicNameControl(Music music)
        {
            InitializeComponent();
            Music = music;
            MusicNameLabel.Text = music.Title.Length < 30 ? music.Title : music.Title.Substring(0, 30)+"...";
            LengthLabel.Text = music.Length;
        }
        public Music Music { get; }


        private void MusicNameControl_DoubleClick(object sender, EventArgs e)
        {
            Playing?.Invoke(this, Music);
        }

        private void MusicNameControl_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show(Music.Title,this);
        }

        private void MusicNameControl_MouseClick(object sender, MouseEventArgs e)
        {
            Selected?.Invoke(this, Music);

        }

        private void MusicNameControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playing?.Invoke(this, Music);
        }

        private void RemoveFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Del.Invoke(this, Music);
        }
    }
}
