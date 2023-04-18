namespace KSaver
{
    partial class KeepAwakeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeepAwakeMainForm));
            this.KeyStrokeTimer = new System.Windows.Forms.Timer(this.components);
            this.KTrayNotifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.KTrayNotifierMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ntConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.ntStop = new System.Windows.Forms.ToolStripMenuItem();
            this.ntStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ntAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ntExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.AppSplashTimer = new System.Windows.Forms.Timer(this.components);
            this.PauseAfterTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KTrayNotifierMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyStrokeTimer
            // 
            this.KeyStrokeTimer.Interval = 5000;
            this.KeyStrokeTimer.Tick += new System.EventHandler(this.KeyStrokeTimer_Tick);
            // 
            // KTrayNotifier
            // 
            this.KTrayNotifier.ContextMenuStrip = this.KTrayNotifierMenu;
            this.KTrayNotifier.Icon = ((System.Drawing.Icon)(resources.GetObject("KTrayNotifier.Icon")));
            this.KTrayNotifier.Text = "Keep Awake!";
            this.KTrayNotifier.Visible = true;
            this.KTrayNotifier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.KTrayNotifier_MouseDoubleClick);
            // 
            // KTrayNotifierMenu
            // 
            this.KTrayNotifierMenu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTrayNotifierMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.KTrayNotifierMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ntConfigure,
            this.ntStop,
            this.ntStart,
            this.ntAbout,
            this.ntExit});
            this.KTrayNotifierMenu.Name = "KTrayNotifierMenu";
            this.KTrayNotifierMenu.ShowImageMargin = false;
            this.KTrayNotifierMenu.Size = new System.Drawing.Size(160, 164);
            // 
            // ntConfigure
            // 
            this.ntConfigure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ntConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntConfigure.Name = "ntConfigure";
            this.ntConfigure.Size = new System.Drawing.Size(159, 32);
            this.ntConfigure.Text = "Configure...";
            this.ntConfigure.ToolTipText = "Configure KeepAwake Application Settings";
            this.ntConfigure.Click += new System.EventHandler(this.ntConfigure_Click);
            // 
            // ntStop
            // 
            this.ntStop.BackColor = System.Drawing.SystemColors.Control;
            this.ntStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntStop.Name = "ntStop";
            this.ntStop.Size = new System.Drawing.Size(159, 32);
            this.ntStop.Text = "Stop";
            this.ntStop.Click += new System.EventHandler(this.ntStop_Click);
            // 
            // ntStart
            // 
            this.ntStart.BackColor = System.Drawing.SystemColors.Control;
            this.ntStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntStart.Name = "ntStart";
            this.ntStart.Size = new System.Drawing.Size(159, 32);
            this.ntStart.Text = "Start";
            this.ntStart.Click += new System.EventHandler(this.ntStart_Click);
            // 
            // ntAbout
            // 
            this.ntAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ntAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntAbout.Name = "ntAbout";
            this.ntAbout.Size = new System.Drawing.Size(159, 32);
            this.ntAbout.Text = "About...";
            this.ntAbout.Click += new System.EventHandler(this.ntAbout_Click);
            // 
            // ntExit
            // 
            this.ntExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntExit.Name = "ntExit";
            this.ntExit.Size = new System.Drawing.Size(159, 32);
            this.ntExit.Text = "Exit";
            this.ntExit.ToolTipText = "Exit the KeepAwake Application";
            this.ntExit.Click += new System.EventHandler(this.ntExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // AppSplashTimer
            // 
            this.AppSplashTimer.Enabled = true;
            this.AppSplashTimer.Interval = 4000;
            this.AppSplashTimer.Tick += new System.EventHandler(this.AppSplashTimer_Tick);
            // 
            // PauseAfterTimer
            // 
            this.PauseAfterTimer.Interval = 5000;
            this.PauseAfterTimer.Tick += new System.EventHandler(this.PauseAfterTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "KeepAwake!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeepAwake.Properties.Resources.MSCoffeeImage;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // KeepAwakeMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 266);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeepAwakeMainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeepAwake!";
            this.KTrayNotifierMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer KeyStrokeTimer;
        private System.Windows.Forms.NotifyIcon KTrayNotifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer AppSplashTimer;
        private System.Windows.Forms.ContextMenuStrip KTrayNotifierMenu;
        private System.Windows.Forms.ToolStripMenuItem ntExit;
        private System.Windows.Forms.ToolStripMenuItem ntConfigure;
        private System.Windows.Forms.Timer PauseAfterTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ntAbout;
        private System.Windows.Forms.ToolStripMenuItem ntStop;
        private System.Windows.Forms.ToolStripMenuItem ntStart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

