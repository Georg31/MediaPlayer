using AxWMPLib;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using MusicPlayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MediaPlayer : Form
    {
        int start = 0;
        TimeSpan sum = TimeSpan.Zero;

        public MediaPlayer()
        {
            InitializeComponent();
        }

        public List<string> Paths = new List<string>();
        public List<string> SamePaths = new List<string>();

        private void Add_Click(object sender, EventArgs e)
        {
            MusicAdd();
        }

        private void MusicAdd()
        {
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SamePaths.AddRange(openFileDialog.FileNames);
                Paths = SamePaths.Distinct().ToList();
                var pl = WMPlayer.currentPlaylist;
                for (int i = start; i < Paths.Count; i++)
                {
                    var mediaItem = WMPlayer.newMedia(Paths[i]);
                    pl.appendItem(mediaItem);

                }


                for (int i = start; i < Paths.Count; i++)
                {
                    var newMusic = new Music
                    {
                        Title = Path.GetFileNameWithoutExtension(Paths[i]),
                        MPath = Paths[i],
                        Length = GetDuration(Paths[i]).ToString(@"mm\:ss"),
                    };
                    start++;
                    var MusicControl = new MusicNameControl(newMusic);
                    MusicControl.Selected += OnSelect;
                    MusicControl.Playing += Play;
                    MusicPanel.Controls.Add(MusicControl);
                    CountLabel.Text = start.ToString();
                    TimeSpan time = GetDuration(Paths[i]);
                    sum += time;
                    DurationLabel.Text = sum.ToString(@"hh\:mm\:ss");


                }
            }
        }



        public void Play(object sender, Music e)
        {
            for (int i = 0; i < WMPlayer.currentPlaylist.count; i++)
            {
                if (WMPlayer.currentPlaylist.Item[i].sourceURL == e.MPath)
                {
                    WMPlayer.Ctlcontrols.playItem(WMPlayer.currentPlaylist.Item[i]);
                }
            }
        }

        private void ResetLColors()
        {
            foreach (Control control in MusicPanel.Controls)
            {
                control.ForeColor = Color.Black;
            }
        }

        private void OnSelect(object sender, Music e)
        {
            ResetColors();
            if (sender is Control control)
            {
                control.BackColor = Color.FromArgb(104, 159, 247);
            }
        }

        private void ResetColors()
        {
            foreach (Control control in MusicPanel.Controls)
            {
                control.BackColor = Color.FromArgb(192, 255, 255);
            }
        }

        private void MediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            WMPlayer.Dispose();
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            WMPlayer.URL = Paths[rnd.Next(0, Paths.Count)];

        }

        private void MusicPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MusicPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            SamePaths.AddRange(s.Where(a => Path.GetExtension(a) == ".mp3"));
            Paths = SamePaths.Distinct().ToList();
            var pl = WMPlayer.currentPlaylist;
            for (int i = start; i < Paths.Count; i++)
            {
                var mediaItem = WMPlayer.newMedia(Paths[i]);
                pl.appendItem(mediaItem);
            }

            for (int i = start; i < Paths.Count; i++)
            {
                var newMusic = new Music
                {
                    Title = Path.GetFileNameWithoutExtension(Paths[i]),
                    MPath = Paths[i],
                    Length = GetDuration(Paths[i]).ToString(@"mm\:ss")
                };
                start++;
                var MusicControl = new MusicNameControl(newMusic);
                MusicControl.Selected += OnSelect;
                MusicControl.Playing += Play;
                MusicPanel.Controls.Add(MusicControl);
                CountLabel.Text = start.ToString();
                TimeSpan time = GetDuration(Paths[i]);
                sum += time;
                DurationLabel.Text = sum.ToString(@"hh\:mm\:ss");
            }
        }
        private static TimeSpan GetDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                ulong t = 0;
                IShellProperty prop = shell.Properties.System.Media.Duration;
                if (prop.ValueAsObject != null)
                {
                    t = (ulong)prop.ValueAsObject;
                }
                return TimeSpan.FromTicks((long)t);
            }
        }

        private void WMPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {


            if (WMPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int i;
                for (i = 0; i < WMPlayer.currentPlaylist.count - 1; i++)
                {
                    if (WMPlayer.currentMedia.isIdentical[WMPlayer.currentPlaylist.Item[i]])
                    {

                        break;
                    }
                }
                ResetLColors();
                MusicPanel.Controls[i].ForeColor = Color.FromArgb(153, 0, 0);
            }
        }

    }
}
