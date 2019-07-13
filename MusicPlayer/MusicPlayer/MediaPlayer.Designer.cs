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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.WMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.AddButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.MusicPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.WMPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMPlayer_PlayStateChange);
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
            // MusicPanel
            // 
            this.MusicPanel.AllowDrop = true;
            this.MusicPanel.AutoScroll = true;
            this.MusicPanel.Location = new System.Drawing.Point(790, 0);
            this.MusicPanel.Name = "MusicPanel";
            this.MusicPanel.Size = new System.Drawing.Size(298, 486);
            this.MusicPanel.TabIndex = 4;
            this.MusicPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MusicPanel_DragDrop);
            this.MusicPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MusicPanel_DragEnter);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(790, 489);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(13, 13);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(909, 489);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(0, 13);
            this.DurationLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hours";
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1088, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.MusicPanel);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WMPlayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MediaPlayer";
            this.Text = "Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaPlayer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPlayer;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.FlowLayoutPanel MusicPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label label4;
    }
}

