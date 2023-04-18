using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KSaver;

namespace KSaver
{
    /// <summary>
    /// KeepAwakeConfigurationform
    /// </summary>
    public partial class KeepAwakeConfigurationForm : Form
    {
        ushort cfgFireRate = 6;
        ushort cfgAppEnabled = 1;
        ushort cfgPauseAfterOn = 0;
        ushort cfgPauseAfter = 7;

        ushort cfgUseSchedule = 0;
        stSchedule cfgSchedule;

        KeepAwakeMainForm cfgParent;

        /// <summary>
        /// KeepAwakeConfigurationForm Constructor
        /// </summary>
        public KeepAwakeConfigurationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            MinutesToFire.Value = cfgFireRate;
            HoursToClose.Value = cfgPauseAfter;

            if (cfgAppEnabled == 0)
            {
                AppIsEnabled.Checked = false;
            }
            else
            {
                AppIsEnabled.Checked = true;
            }

            if (cfgPauseAfterOn == 0)
            {
                PauseAfter.Checked = false;
                HoursToClose.Enabled = false;
            }
            else
            {
                PauseAfter.Checked = true;
                HoursToClose.Enabled = true;
            }

            UseSchedule.Checked = cfgUseSchedule == 1 ? true : false;
            ScheduleOneOn.Checked = cfgSchedule.UseScheduleOne == 1 ? true : false;
            ScheduleTwoOn.Checked = cfgSchedule.UseScheduleTwo == 1 ? true : false; 
            ScheduleThreeOn.Checked = cfgSchedule.UseScheduleThree == 1 ? true : false; 
            ScheduleFourOn.Checked = cfgSchedule.UseScheduleFour == 1 ? true : false;

            ScheduleOneTo.Value = cfgSchedule.ScheduleOneTo;
            ScheduleOneFrom.Value = cfgSchedule.ScheduleOneFrom;
            ScheduleTwoTo.Value = cfgSchedule.ScheduleTwoTo;
            ScheduleTwoFrom.Value = cfgSchedule.ScheduleTwoFrom;
            ScheduleThreeTo.Value = cfgSchedule.ScheduleThreeTo;
            ScheduleThreeFrom.Value = cfgSchedule.ScheduleThreeFrom;
            ScheduleFourTo.Value = cfgSchedule.ScheduleFourTo;
            ScheduleFourFrom.Value = cfgSchedule.ScheduleFourFrom;
        }

        /// <summary>
        /// SetValues
        /// </summary>
        public void SetValues(KeepAwakeMainForm rParent, ushort fireRate, ushort pauseAfterOn, ushort pauseAfter, ushort appEnabled, ushort useSchedule, stSchedule schedule)
        {
            cfgFireRate = fireRate;
            cfgPauseAfterOn = pauseAfterOn;
            cfgPauseAfter = pauseAfter;
            cfgAppEnabled = appEnabled;
            cfgUseSchedule = useSchedule;
            cfgSchedule = schedule;
            cfgParent = rParent;

            Initialize();
        }

        /// <summary>
        /// Apply
        /// </summary>
        private void Apply()
        {
            cfgFireRate = (ushort)MinutesToFire.Value;
            cfgPauseAfter = (ushort)HoursToClose.Value;

            cfgAppEnabled = AppIsEnabled.Checked == true ? (ushort)1 : (ushort)0;
            cfgPauseAfterOn = PauseAfter.Checked == true ? (ushort)1 : (ushort)0;

            cfgUseSchedule = UseSchedule.Checked == true ? (ushort)1 : (ushort)0;

            cfgSchedule.UseScheduleOne = ScheduleOneOn.Checked == true ? (ushort)1 : (ushort)0;
            cfgSchedule.UseScheduleTwo = ScheduleTwoOn.Checked == true ? (ushort)1 : (ushort)0;
            cfgSchedule.UseScheduleThree = ScheduleThreeOn.Checked == true ? (ushort)1 : (ushort)0;
            cfgSchedule.UseScheduleFour = ScheduleFourOn.Checked == true ? (ushort)1 : (ushort)0;

            cfgSchedule.ScheduleOneTo = ScheduleOneTo.Value;
            cfgSchedule.ScheduleOneFrom = ScheduleOneFrom.Value;
            cfgSchedule.ScheduleTwoTo = ScheduleTwoTo.Value;
            cfgSchedule.ScheduleTwoFrom = ScheduleTwoFrom.Value;
            cfgSchedule.ScheduleThreeTo = ScheduleThreeTo.Value;
            cfgSchedule.ScheduleThreeFrom = ScheduleThreeFrom.Value;
            cfgSchedule.ScheduleFourTo = ScheduleFourTo.Value;
            cfgSchedule.ScheduleFourFrom = ScheduleFourFrom.Value;

            cfgParent.UpdateValues(cfgFireRate, cfgAppEnabled, cfgPauseAfterOn, cfgPauseAfter, cfgUseSchedule, cfgSchedule);
        }

        /// <summary>
        /// OKConfiguration_Click
        /// </summary>
        private void OKConfig_Click(object sender, EventArgs e)
        {
            Apply();
            this.Close();
        }

        /// <summary>
        /// ApplyConfig_Click
        /// </summary>
        private void ApplyConfig_Click(object sender, EventArgs e)
        {
            Apply();
        }

        /// <summary>
        /// PauseAfter_CheckedChanged
        /// </summary>
        private void PauseAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (PauseAfter.Checked == true)
            {
                HoursToClose.Enabled = true;
            }
            else
            {
                HoursToClose.Enabled = false;
            }
        }

        /// <summary>
        /// CancelConfig_Click
        /// </summary>
        private void CancelConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
