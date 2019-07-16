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
using AxWMPLib;

namespace MusicPlayer
{
    public partial class MusicNameControl : UserControl
    {
        public event EventHandler<Music> Selected;
        public event EventHandler<Music> Playing;


        public MusicNameControl(Music music)
        {
            InitializeComponent();

            Music = music;
            MusicNameLabel.Text = music.Title.Length < 30 ? music.Title : music.Title.Substring(0, 30) + "...";
            LengthLabel.Text = music.Length;
        }


        public Music Music { get; }


        private void MusicNameControl_DoubleClick(object sender, EventArgs e)
        {
            Playing?.Invoke(this, Music);
        }

        private void MusicNameControl_MouseHover(object sender, EventArgs e)
        {
        }

        private void MusicNameControl_MouseClick(object sender, MouseEventArgs e)
        {
            Selected?.Invoke(this, Music);

        }

        private void Mouse_Entered(object sender, EventArgs e)
        {
            toolTip1.Show(Music.Title, this);
        }

        private void Mouse_Left(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }
    }
}
