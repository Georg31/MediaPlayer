using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.MusicList.DragDrop += new
           System.Windows.Forms.DragEventHandler(this.MusicList_DragDrop);
            this.MusicList.DragEnter += new
                       System.Windows.Forms.DragEventHandler(this.MusicList_DragEnter);
        }

        public List<string> Files = new List<string>();
        public List<string> Path = new List<string>();

        private void Add_Click(object sender, EventArgs e)
        {
            start = FileAdd(start);
        }
        
        private int FileAdd(int start)
        {
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Files.AddRange(openFileDialog.SafeFileNames);
                Path.AddRange(openFileDialog.FileNames);
                
                    for (int i = start; i < Files.Count; i++)
                    {
                        MusicList.Items.Add(Files[i]);
                        start++;
                    }

            }
            return start;
        }


        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WMPlayer.URL = Path[MusicList.SelectedIndex];
        }

        private void MediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            WMPlayer.Dispose();
        }

        private void MusicList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MusicList_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                MusicList.Items.Add(s[i]);
        }
    }
}
