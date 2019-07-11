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

        public MediaPlayer()
        {
            InitializeComponent();
        }

        public List<string> Files = new List<string>();
        public List<string> Paths = new List<string>();

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
                Paths.AddRange(openFileDialog.FileNames);

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
                    MusicControl.Del += Delete;
                    MusicPanel.Controls.Add(MusicControl);
                    CountLabel.Text = start.ToString();
                }
            }
        }

        private void Delete(object sender, Music e)
        {
            if (sender is Control control)
            {
                control.Dispose();
                start--;
                Paths.Remove(e.MPath);
                CountLabel.Text = start.ToString();
            }
        }

        public void Play(object sender, Music e)
        {
            WMPlayer.URL = e.MPath;
            ResetLColors();
            if (sender is Control control)
            {
                control.ForeColor = Color.FromArgb(153, 0, 0);
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
            Paths.AddRange(s.Where(a=>Path.GetExtension(a)==".mp3"));

            for (int i = start; i < Paths.Count; i++)
            {
                var newMusic = new Music
                {
                    Title = Path.GetFileNameWithoutExtension(Paths[i]),
                    MPath = Paths[i],
                    Length=GetDuration(Paths[i]).ToString(@"mm\:ss")
                };
                start++;
                var MusicControl = new MusicNameControl(newMusic);
                MusicControl.Selected += OnSelect;
                MusicControl.Playing += Play;
                MusicPanel.Controls.Add(MusicControl);
                CountLabel.Text = start.ToString();
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

    }
}
