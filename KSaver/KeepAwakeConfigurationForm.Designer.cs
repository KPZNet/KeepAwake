namespace KSaver
{
    partial class KeepAwakeConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeepAwakeConfigurationForm));
            this.MinutesToFire = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppIsEnabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursToClose = new System.Windows.Forms.NumericUpDown();
            this.PauseAfter = new System.Windows.Forms.CheckBox();
            this.OKConfig = new System.Windows.Forms.Button();
            this.CancelConfig = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScheduleFourOn = new System.Windows.Forms.CheckBox();
            this.ScheduleFourTo = new System.Windows.Forms.DateTimePicker();
            this.ScheduleFourFrom = new System.Windows.Forms.DateTimePicker();
            this.ScheduleThreeOn = new System.Windows.Forms.CheckBox();
            this.ScheduleThreeTo = new System.Windows.Forms.DateTimePicker();
            this.ScheduleThreeFrom = new System.Windows.Forms.DateTimePicker();
            this.ScheduleTwoOn = new System.Windows.Forms.CheckBox();
            this.ScheduleTwoTo = new System.Windows.Forms.DateTimePicker();
            this.ScheduleTwoFrom = new System.Windows.Forms.DateTimePicker();
            this.ScheduleOneOn = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScheduleOneTo = new System.Windows.Forms.DateTimePicker();
            this.ScheduleOneFrom = new System.Windows.Forms.DateTimePicker();
            this.UseSchedule = new System.Windows.Forms.CheckBox();
            this.ApplyConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesToFire)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursToClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MinutesToFire
            // 
            this.MinutesToFire.Location = new System.Drawing.Point(243, 89);
            this.MinutesToFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinutesToFire.Name = "MinutesToFire";
            this.MinutesToFire.Size = new System.Drawing.Size(84, 26);
            this.MinutesToFire.TabIndex = 3;
            this.MinutesToFire.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minutes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AppIsEnabled);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HoursToClose);
            this.groupBox1.Controls.Add(this.PauseAfter);
            this.groupBox1.Controls.Add(this.MinutesToFire);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(451, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KeepAwake Settings";
            // 
            // AppIsEnabled
            // 
            this.AppIsEnabled.AutoSize = true;
            this.AppIsEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppIsEnabled.Location = new System.Drawing.Point(17, 45);
            this.AppIsEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppIsEnabled.Name = "AppIsEnabled";
            this.AppIsEnabled.Size = new System.Drawing.Size(102, 24);
            this.AppIsEnabled.TabIndex = 11;
            this.AppIsEnabled.Text = "Enabled";
            this.AppIsEnabled.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fire Every";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hours";
            // 
            // HoursToClose
            // 
            this.HoursToClose.Location = new System.Drawing.Point(243, 139);
            this.HoursToClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HoursToClose.Name = "HoursToClose";
            this.HoursToClose.Size = new System.Drawing.Size(84, 26);
            this.HoursToClose.TabIndex = 10;
            this.HoursToClose.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PauseAfter
            // 
            this.PauseAfter.AutoSize = true;
            this.PauseAfter.Location = new System.Drawing.Point(17, 136);
            this.PauseAfter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PauseAfter.Name = "PauseAfter";
            this.PauseAfter.Size = new System.Drawing.Size(123, 24);
            this.PauseAfter.TabIndex = 10;
            this.PauseAfter.Text = "Run for Only";
            this.PauseAfter.UseVisualStyleBackColor = true;
            this.PauseAfter.CheckedChanged += new System.EventHandler(this.PauseAfter_CheckedChanged);
            // 
            // OKConfig
            // 
            this.OKConfig.Location = new System.Drawing.Point(503, 19);
            this.OKConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKConfig.Name = "OKConfig";
            this.OKConfig.Size = new System.Drawing.Size(112, 35);
            this.OKConfig.TabIndex = 7;
            this.OKConfig.Text = "OK";
            this.OKConfig.UseVisualStyleBackColor = true;
            this.OKConfig.Click += new System.EventHandler(this.OKConfig_Click);
            // 
            // CancelConfig
            // 
            this.CancelConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelConfig.Location = new System.Drawing.Point(503, 161);
            this.CancelConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelConfig.Name = "CancelConfig";
            this.CancelConfig.Size = new System.Drawing.Size(112, 35);
            this.CancelConfig.TabIndex = 8;
            this.CancelConfig.Text = "Cancel";
            this.CancelConfig.UseVisualStyleBackColor = true;
            this.CancelConfig.Click += new System.EventHandler(this.CancelConfig_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.ScheduleFourOn);
            this.groupBox2.Controls.Add(this.ScheduleFourTo);
            this.groupBox2.Controls.Add(this.ScheduleFourFrom);
            this.groupBox2.Controls.Add(this.ScheduleThreeOn);
            this.groupBox2.Controls.Add(this.ScheduleThreeTo);
            this.groupBox2.Controls.Add(this.ScheduleThreeFrom);
            this.groupBox2.Controls.Add(this.ScheduleTwoOn);
            this.groupBox2.Controls.Add(this.ScheduleTwoTo);
            this.groupBox2.Controls.Add(this.ScheduleTwoFrom);
            this.groupBox2.Controls.Add(this.ScheduleOneOn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ScheduleOneTo);
            this.groupBox2.Controls.Add(this.ScheduleOneFrom);
            this.groupBox2.Controls.Add(this.UseSchedule);
            this.groupBox2.Location = new System.Drawing.Point(18, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(597, 265);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KeepAwake Schedule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeepAwake.Properties.Resources.MSCoffeeImage;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ScheduleFourOn
            // 
            this.ScheduleFourOn.AutoSize = true;
            this.ScheduleFourOn.Location = new System.Drawing.Point(224, 220);
            this.ScheduleFourOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleFourOn.Name = "ScheduleFourOn";
            this.ScheduleFourOn.Size = new System.Drawing.Size(22, 21);
            this.ScheduleFourOn.TabIndex = 25;
            this.ScheduleFourOn.UseVisualStyleBackColor = true;
            // 
            // ScheduleFourTo
            // 
            this.ScheduleFourTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleFourTo.Location = new System.Drawing.Point(426, 214);
            this.ScheduleFourTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleFourTo.Name = "ScheduleFourTo";
            this.ScheduleFourTo.ShowUpDown = true;
            this.ScheduleFourTo.Size = new System.Drawing.Size(160, 26);
            this.ScheduleFourTo.TabIndex = 24;
            // 
            // ScheduleFourFrom
            // 
            this.ScheduleFourFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleFourFrom.Location = new System.Drawing.Point(255, 214);
            this.ScheduleFourFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleFourFrom.Name = "ScheduleFourFrom";
            this.ScheduleFourFrom.ShowUpDown = true;
            this.ScheduleFourFrom.Size = new System.Drawing.Size(160, 26);
            this.ScheduleFourFrom.TabIndex = 23;
            // 
            // ScheduleThreeOn
            // 
            this.ScheduleThreeOn.AutoSize = true;
            this.ScheduleThreeOn.Location = new System.Drawing.Point(224, 180);
            this.ScheduleThreeOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleThreeOn.Name = "ScheduleThreeOn";
            this.ScheduleThreeOn.Size = new System.Drawing.Size(22, 21);
            this.ScheduleThreeOn.TabIndex = 22;
            this.ScheduleThreeOn.UseVisualStyleBackColor = true;
            // 
            // ScheduleThreeTo
            // 
            this.ScheduleThreeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleThreeTo.Location = new System.Drawing.Point(426, 174);
            this.ScheduleThreeTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleThreeTo.Name = "ScheduleThreeTo";
            this.ScheduleThreeTo.ShowUpDown = true;
            this.ScheduleThreeTo.Size = new System.Drawing.Size(160, 26);
            this.ScheduleThreeTo.TabIndex = 21;
            // 
            // ScheduleThreeFrom
            // 
            this.ScheduleThreeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleThreeFrom.Location = new System.Drawing.Point(255, 174);
            this.ScheduleThreeFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleThreeFrom.Name = "ScheduleThreeFrom";
            this.ScheduleThreeFrom.ShowUpDown = true;
            this.ScheduleThreeFrom.Size = new System.Drawing.Size(160, 26);
            this.ScheduleThreeFrom.TabIndex = 20;
            // 
            // ScheduleTwoOn
            // 
            this.ScheduleTwoOn.AutoSize = true;
            this.ScheduleTwoOn.Location = new System.Drawing.Point(224, 140);
            this.ScheduleTwoOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleTwoOn.Name = "ScheduleTwoOn";
            this.ScheduleTwoOn.Size = new System.Drawing.Size(22, 21);
            this.ScheduleTwoOn.TabIndex = 19;
            this.ScheduleTwoOn.UseVisualStyleBackColor = true;
            // 
            // ScheduleTwoTo
            // 
            this.ScheduleTwoTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleTwoTo.Location = new System.Drawing.Point(426, 134);
            this.ScheduleTwoTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleTwoTo.Name = "ScheduleTwoTo";
            this.ScheduleTwoTo.ShowUpDown = true;
            this.ScheduleTwoTo.Size = new System.Drawing.Size(160, 26);
            this.ScheduleTwoTo.TabIndex = 18;
            // 
            // ScheduleTwoFrom
            // 
            this.ScheduleTwoFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleTwoFrom.Location = new System.Drawing.Point(255, 134);
            this.ScheduleTwoFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleTwoFrom.Name = "ScheduleTwoFrom";
            this.ScheduleTwoFrom.ShowUpDown = true;
            this.ScheduleTwoFrom.Size = new System.Drawing.Size(160, 26);
            this.ScheduleTwoFrom.TabIndex = 17;
            // 
            // ScheduleOneOn
            // 
            this.ScheduleOneOn.AutoSize = true;
            this.ScheduleOneOn.Location = new System.Drawing.Point(224, 100);
            this.ScheduleOneOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleOneOn.Name = "ScheduleOneOn";
            this.ScheduleOneOn.Size = new System.Drawing.Size(22, 21);
            this.ScheduleOneOn.TabIndex = 16;
            this.ScheduleOneOn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "From";
            // 
            // ScheduleOneTo
            // 
            this.ScheduleOneTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleOneTo.Location = new System.Drawing.Point(426, 94);
            this.ScheduleOneTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleOneTo.Name = "ScheduleOneTo";
            this.ScheduleOneTo.ShowUpDown = true;
            this.ScheduleOneTo.Size = new System.Drawing.Size(160, 26);
            this.ScheduleOneTo.TabIndex = 13;
            // 
            // ScheduleOneFrom
            // 
            this.ScheduleOneFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ScheduleOneFrom.Location = new System.Drawing.Point(255, 94);
            this.ScheduleOneFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleOneFrom.Name = "ScheduleOneFrom";
            this.ScheduleOneFrom.ShowUpDown = true;
            this.ScheduleOneFrom.Size = new System.Drawing.Size(160, 26);
            this.ScheduleOneFrom.TabIndex = 12;
            // 
            // UseSchedule
            // 
            this.UseSchedule.AutoSize = true;
            this.UseSchedule.Location = new System.Drawing.Point(17, 41);
            this.UseSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseSchedule.Name = "UseSchedule";
            this.UseSchedule.Size = new System.Drawing.Size(135, 24);
            this.UseSchedule.TabIndex = 11;
            this.UseSchedule.Text = "Use Schedule";
            this.UseSchedule.UseVisualStyleBackColor = true;
            // 
            // ApplyConfig
            // 
            this.ApplyConfig.Location = new System.Drawing.Point(503, 58);
            this.ApplyConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplyConfig.Name = "ApplyConfig";
            this.ApplyConfig.Size = new System.Drawing.Size(112, 35);
            this.ApplyConfig.TabIndex = 9;
            this.ApplyConfig.Text = "Apply";
            this.ApplyConfig.UseVisualStyleBackColor = true;
            this.ApplyConfig.Click += new System.EventHandler(this.ApplyConfig_Click);
            // 
            // KeepAwakeConfigurationForm
            // 
            this.AcceptButton = this.OKConfig;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CancelConfig;
            this.ClientSize = new System.Drawing.Size(634, 516);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ApplyConfig);
            this.Controls.Add(this.CancelConfig);
            this.Controls.Add(this.OKConfig);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeepAwakeConfigurationForm";
            this.ShowInTaskbar = false;
            this.Text = "KeepAwake Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.MinutesToFire)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursToClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MinutesToFire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HoursToClose;
        private System.Windows.Forms.Button OKConfig;
        private System.Windows.Forms.Button CancelConfig;
        private System.Windows.Forms.CheckBox PauseAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox UseSchedule;
        private System.Windows.Forms.CheckBox ScheduleFourOn;
        private System.Windows.Forms.DateTimePicker ScheduleFourTo;
        private System.Windows.Forms.DateTimePicker ScheduleFourFrom;
        private System.Windows.Forms.CheckBox ScheduleThreeOn;
        private System.Windows.Forms.DateTimePicker ScheduleThreeTo;
        private System.Windows.Forms.DateTimePicker ScheduleThreeFrom;
        private System.Windows.Forms.CheckBox ScheduleTwoOn;
        private System.Windows.Forms.DateTimePicker ScheduleTwoTo;
        private System.Windows.Forms.DateTimePicker ScheduleTwoFrom;
        private System.Windows.Forms.CheckBox ScheduleOneOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ScheduleOneTo;
        private System.Windows.Forms.DateTimePicker ScheduleOneFrom;
        private System.Windows.Forms.Button ApplyConfig;
        private System.Windows.Forms.CheckBox AppIsEnabled;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}