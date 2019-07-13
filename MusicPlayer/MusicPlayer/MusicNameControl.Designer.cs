namespace MusicPlayer
{
    partial class MusicNameControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MusicNameLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // MusicNameLabel
            // 
            this.MusicNameLabel.AutoSize = true;
            this.MusicNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.MusicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicNameLabel.Location = new System.Drawing.Point(3, 0);
            this.MusicNameLabel.Name = "MusicNameLabel";
            this.MusicNameLabel.Size = new System.Drawing.Size(0, 15);
            this.MusicNameLabel.TabIndex = 1;
            this.MusicNameLabel.DoubleClick += new System.EventHandler(this.MusicNameControl_DoubleClick);
            this.MusicNameLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicNameControl_MouseClick);
            this.MusicNameLabel.MouseHover += new System.EventHandler(this.MusicNameControl_MouseHover);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(236, 4);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(0, 13);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.DoubleClick += new System.EventHandler(this.MusicNameControl_DoubleClick);
            this.LengthLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicNameControl_MouseClick);
            this.LengthLabel.MouseHover += new System.EventHandler(this.MusicNameControl_MouseHover);
            // 
            // MusicNameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.MusicNameLabel);
            this.Name = "MusicNameControl";
            this.Size = new System.Drawing.Size(275, 18);
            this.DoubleClick += new System.EventHandler(this.MusicNameControl_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicNameControl_MouseClick);
            this.MouseHover += new System.EventHandler(this.MusicNameControl_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MusicNameLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
