namespace MusicPlayer
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.WMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ShuffleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPlayer
            // 
            this.WMPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.WMPlayer.Enabled = true;
            this.WMPlayer.Location = new System.Drawing.Point(0, 0);
            this.WMPlayer.Name = "WMPlayer";
            this.WMPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer.OcxState")));
            this.WMPlayer.Size = new System.Drawing.Size(784, 543);
            this.WMPlayer.TabIndex = 0;
            // 
            // MusicList
            // 
            this.MusicList.AllowDrop = true;
            this.MusicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MusicList.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 16;
            this.MusicList.Location = new System.Drawing.Point(790, 0);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(298, 543);
            this.MusicList.TabIndex = 2;
            this.MusicList.DragDrop += new System.Windows.Forms.DragEventHandler(this.MusicList_DragDrop);
            this.MusicList.DragEnter += new System.Windows.Forms.DragEventHandler(this.MusicList_DragEnter);
            this.MusicList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(790, 505);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(154, 38);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShuffleButton.FlatAppearance.BorderSize = 0;
            this.ShuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleButton.Location = new System.Drawing.Point(950, 505);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(138, 38);
            this.ShuffleButton.TabIndex = 3;
            this.ShuffleButton.Text = "Shuffle";
            this.ShuffleButton.UseVisualStyleBackColor = false;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1088, 543);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MusicList);
            this.Controls.Add(this.WMPlayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MediaPlayer";
            this.Text = "Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaPlayer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPlayer;
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button ShuffleButton;
    }
}

