using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using System.Threading.Tasks;


namespace KSaver
{
    /// <summary>
    /// Structure containing the Keep Awake optional schedule
    /// </summary>
    public struct stSchedule
    {
        public ushort UseScheduleOne;
        public ushort UseScheduleTwo;
        public ushort UseScheduleThree;
        public ushort UseScheduleFour;
        public DateTime ScheduleOneFrom;
        public DateTime ScheduleOneTo;
        public DateTime ScheduleTwoFrom;
        public DateTime ScheduleTwoTo;
        public DateTime ScheduleThreeFrom;
        public DateTime ScheduleThreeTo;
        public DateTime ScheduleFourFrom;
        public DateTime ScheduleFourTo;
        public ushort ActiveSunday;
        public ushort ActiveMonday;
        public ushort ActiveTuesday;
        public ushort ActiveWednesday;
        public ushort ActiveThursday;
        public ushort ActiveFriday;
        public ushort ActiveSaturday;
    }

    /// <summary>
    /// KeepAwakeMainForm
    /// </summary>
    public partial class KeepAwakeMainForm : Form
    {
        /// <summary>
        /// DLL Imports
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "keybd_event", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern void keybd_event(byte vk, byte scan, int flags, int extrainfo);

        /// <summary>
        /// Constants
        /// </summary>
        public const ushort WM_KEYDOWN = 0x0100;
        public const ushort WM_KEYUP = 0x0101;
        public const byte VK_NUMLOCK = 0x90;
        public const byte VK_SCROLL = 0x91;
        public const byte VK_CAPITAL = 0x14;
        public const byte VK_F24 = 0x87;
        public const byte KEYEVENTF_EXTENDEDKEY = 0x1;
        public const byte KEYEVENTF_KEYUP = 0x2;
        public const byte VER_PLATFORM_WIN32_NT = 2;
        public const byte VER_PLATFORM_WIN32_WINDOWS = 1;
        ushort AppFireRate = 1000;
        ushort AppPauseAfterOn = 0;
        ushort AppPauseAfter = 1000;
        ushort AppEnabled = 1;
        ushort AppUseSchedule = 0;
        stSchedule AppSchedule;

        /// <summary>
        /// KeepAwakeMainForm Constructor
        /// </summary>
        public KeepAwakeMainForm()
        {

            InitializeComponent();

            ReadRegistry(ref AppFireRate, ref AppEnabled, ref AppPauseAfterOn, ref AppPauseAfter, ref AppUseSchedule, ref AppSchedule);

            AppSplashTimer.Interval = 3000;
            AppSplashTimer.Enabled = true;

            Initialize();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        void Initialize()
        {
            KeyStrokeTimer.Enabled = false;
            PauseAfterTimer.Enabled = false;

            if (AppEnabled == 0)
            {
                ntStop.Enabled = false;
                ntStart.Enabled = true;
               
            }
            else
            {
                ntStop.Enabled = true;
                ntStart.Enabled = false;
            }

            if (AppEnabled == 1)
            {
                KeyStrokeTimer.Interval = AppFireRate * 60 * 1000;
                KeyStrokeTimer.Enabled = true;

                if (AppPauseAfterOn == 1)
                {
                    PauseAfterTimer.Interval = AppPauseAfter * 60 * 60 * 1000;
                    PauseAfterTimer.Enabled = true;
                }
            }

            WriteRegistry(AppFireRate, AppEnabled, AppPauseAfterOn, AppPauseAfter, AppUseSchedule, AppSchedule);
        }

        /// <summary>
        /// UpdateValues
        /// </summary>       
        public void UpdateValues(ushort fireRate, ushort keepAwakeEnabled, ushort pauseAfterOn, ushort pauseAfter, ushort useSchedule, stSchedule schedule)
        {
            AppFireRate = fireRate;
            AppPauseAfterOn = pauseAfterOn;
            AppPauseAfter = pauseAfter;
            AppEnabled = keepAwakeEnabled;
            AppUseSchedule = useSchedule;
            AppSchedule = schedule;

            Initialize();
        }

        /// <summary>
        /// WriteRegistry
        /// </summary>
        void WriteRegistry(ushort fireRate, ushort appEnabled, ushort pauseAfterOn, ushort pauseAfter, ushort useSchedule, stSchedule schedules)
        {
            Microsoft.Win32.RegistryKey KSaverKey;
            KSaverKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("KeepAwake");
            KSaverKey.SetValue("FireRate", fireRate, RegistryValueKind.DWord);
            KSaverKey.SetValue("AppEnabled", appEnabled, RegistryValueKind.DWord);
            KSaverKey.SetValue("PauseAfterOn", pauseAfterOn, RegistryValueKind.DWord);
            KSaverKey.SetValue("PauseAfter", pauseAfter, RegistryValueKind.DWord);

            KSaverKey.SetValue("UseSchedule", useSchedule, RegistryValueKind.DWord);

            KSaverKey.SetValue("UseScheduleOne", schedules.UseScheduleOne, RegistryValueKind.DWord);
            KSaverKey.SetValue("UseScheduleTwo", schedules.UseScheduleTwo, RegistryValueKind.DWord);
            KSaverKey.SetValue("UseScheduleThree", schedules.UseScheduleThree, RegistryValueKind.DWord);
            KSaverKey.SetValue("UseScheduleFour", schedules.UseScheduleFour, RegistryValueKind.DWord);

            KSaverKey.SetValue("ScheduleOneFrom", schedules.ScheduleOneFrom.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleOneTo", schedules.ScheduleOneTo.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleTwoFrom", schedules.ScheduleTwoFrom.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleTwoTo", schedules.ScheduleTwoTo.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleThreeFrom", schedules.ScheduleThreeFrom.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleThreeTo", schedules.ScheduleThreeTo.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleFourFrom", schedules.ScheduleFourFrom.ToString(), RegistryValueKind.String);
            KSaverKey.SetValue("ScheduleFourTo", schedules.ScheduleFourTo.ToString(), RegistryValueKind.String);

            KSaverKey.SetValue("ActiveSunday", schedules.ActiveSunday, RegistryValueKind.DWord);
            KSaverKey.SetValue("ActiveMonday", schedules.ActiveMonday, RegistryValueKind.DWord);
            KSaverKey.SetValue("ActiveTuesday", schedules.ActiveTuesday, RegistryValueKind.DWord);
            KSaverKey.SetValue("ActiveWednesday", schedules.ActiveWednesday, RegistryValueKind.DWord);
            KSaverKey.SetValue("ActiveThursday", schedules.ActiveThursday, RegistryValueKind.DWord);
            KSaverKey.SetValue("ActiveFriday", schedules.ActiveFriday, RegistryValueKind.DWord);
            KSaverKey.SetValue("ActiveSaturday", schedules.ActiveSaturday, RegistryValueKind.DWord);

            KSaverKey.Close();
        }

        /// <summary>
        /// ReadRegistry
        /// </summary>
        void ReadRegistry(ref ushort fireRate, ref ushort appEnabled, ref ushort pauseAfterOn, ref ushort pauseAfter, ref ushort useSchedule, ref stSchedule schedule)
        {
            ushort defaultFireRate = 3;
            ushort defaultPauseAfter = 2;
            ushort defaultPauseAfterOn = 1;
            ushort defaultAppEnabled = 1;
            ushort defaultUseSchedule = 0;
            ushort defaultDayActive = 1;
            string defaultTimeStringFrom = "8:00:00 AM";
            string defaultTimeStringTo   = "9:00:00 AM";
            string tempString;

            fireRate = defaultFireRate;
            appEnabled = defaultAppEnabled;
            pauseAfterOn = defaultPauseAfterOn;
            pauseAfter = defaultPauseAfter;
 
            useSchedule = defaultUseSchedule;
            schedule.ScheduleOneFrom = DateTime.Parse(defaultTimeStringFrom);
            schedule.ScheduleOneTo = DateTime.Parse(defaultTimeStringTo);
            schedule.ScheduleTwoFrom = DateTime.Parse(defaultTimeStringFrom);
            schedule.ScheduleTwoTo = DateTime.Parse(defaultTimeStringTo);
            schedule.ScheduleThreeFrom = DateTime.Parse(defaultTimeStringFrom);
            schedule.ScheduleThreeTo = DateTime.Parse(defaultTimeStringTo);
            schedule.ScheduleFourFrom = DateTime.Parse(defaultTimeStringFrom);
            schedule.ScheduleFourTo = DateTime.Parse(defaultTimeStringTo);

            schedule.ActiveSunday = defaultDayActive;
            schedule.ActiveMonday = defaultDayActive;
            schedule.ActiveTuesday = defaultDayActive;
            schedule.ActiveWednesday = defaultDayActive;
            schedule.ActiveThursday = defaultDayActive;
            schedule.ActiveFriday = defaultDayActive;
            schedule.ActiveSaturday = defaultDayActive;

            Microsoft.Win32.RegistryKey KSaverKey;
            KSaverKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("KeepAwake");
            if (KSaverKey != null)
            {
                fireRate = (ushort)(int)KSaverKey.GetValue("FireRate", (int)defaultFireRate);
                pauseAfterOn = (ushort)(int)KSaverKey.GetValue("PauseAfterOn", (int)defaultPauseAfterOn);
                pauseAfter = (ushort)(int)KSaverKey.GetValue("PauseAfter", (int)defaultPauseAfter);
                appEnabled = (ushort)(int)KSaverKey.GetValue("AppEnabled", (int)defaultAppEnabled);

                useSchedule = (ushort)(int)KSaverKey.GetValue("UseSchedule", (int)defaultUseSchedule);

                schedule.UseScheduleOne = (ushort)(int)KSaverKey.GetValue("UseScheduleOne", (int)defaultUseSchedule);
                schedule.UseScheduleTwo = (ushort)(int)KSaverKey.GetValue("UseScheduleTwo", (int)defaultUseSchedule);
                schedule.UseScheduleThree = (ushort)(int)KSaverKey.GetValue("UseScheduleThree", (int)defaultUseSchedule);
                schedule.UseScheduleFour = (ushort)(int)KSaverKey.GetValue("UseScheduleFour", (int)defaultUseSchedule);

                tempString = (string)KSaverKey.GetValue("ScheduleOneFrom", (string)defaultTimeStringFrom);
                schedule.ScheduleOneFrom = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleOneTo", (string)defaultTimeStringTo);
                schedule.ScheduleOneTo = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleTwoFrom", (string)defaultTimeStringFrom);
                schedule.ScheduleTwoFrom = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleTwoTo", (string)defaultTimeStringTo);
                schedule.ScheduleTwoTo = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleThreeFrom", (string)defaultTimeStringFrom);
                schedule.ScheduleThreeFrom = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleThreeTo", (string)defaultTimeStringTo);
                schedule.ScheduleThreeTo = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleFourFrom", (string)defaultTimeStringFrom);
                schedule.ScheduleFourFrom = DateTime.Parse(tempString);

                tempString = (string)KSaverKey.GetValue("ScheduleFourTo", (string)defaultTimeStringTo);
                schedule.ScheduleFourTo = DateTime.Parse(tempString);

                schedule.ActiveSunday = (ushort)(int)KSaverKey.GetValue("ActiveSunday", (int)defaultDayActive);
                schedule.ActiveMonday = (ushort)(int)KSaverKey.GetValue("ActiveMonday", (int)defaultDayActive);
                schedule.ActiveTuesday = (ushort)(int)KSaverKey.GetValue("ActiveTuesday", (int)defaultDayActive);
                schedule.ActiveWednesday = (ushort)(int)KSaverKey.GetValue("ActiveWednesday", (int)defaultDayActive);
                schedule.ActiveThursday = (ushort)(int)KSaverKey.GetValue("ActiveThursday", (int)defaultDayActive);
                schedule.ActiveFriday = (ushort)(int)KSaverKey.GetValue("ActiveFriday", (int)defaultDayActive);
                schedule.ActiveSaturday = (ushort)(int)KSaverKey.GetValue("ActiveSaturday", (int)defaultDayActive);

                KSaverKey.Close();
            }
        }

        /// <summary>
        /// NowInBetween
        /// </summary>
        bool NowInBetween(DateTime dtFrom, DateTime dtTo)
        {
            bool bRet = false;

            DateTime dtNow = DateTime.Now;
            TimeSpan tsNow = dtNow.TimeOfDay;
            TimeSpan tsScheduleTo, tsScheduleFrom;

            tsScheduleFrom = dtFrom.TimeOfDay;
            tsScheduleTo = dtTo.TimeOfDay;

            if (tsNow > tsScheduleFrom && tsNow < tsScheduleTo)
            {
                bRet = true;
            }

            return bRet;
        }

        /// <summary>
        /// InSchedule
        /// </summary>
        bool InSchedule()
        {
            bool bRet = false;

            if (AppSchedule.UseScheduleOne == 1)
            {
                if (true == NowInBetween(AppSchedule.ScheduleOneFrom, AppSchedule.ScheduleOneTo))
                {
                    bRet = true;
                }
            }
            if (AppSchedule.UseScheduleTwo == 1)
            {
                if (true == NowInBetween(AppSchedule.ScheduleTwoFrom, AppSchedule.ScheduleTwoTo))
                {
                    bRet = true;
                }
            }
            if (AppSchedule.UseScheduleThree == 1)
            {
                if (true == NowInBetween(AppSchedule.ScheduleThreeFrom, AppSchedule.ScheduleThreeTo))
                {
                    bRet = true;
                }
            }
            if (AppSchedule.UseScheduleFour == 1)
            {
                if (true == NowInBetween(AppSchedule.ScheduleFourFrom, AppSchedule.ScheduleFourTo))
                {
                    bRet = true;
                }
            }

            return bRet;
        }

        /// <summary>
        /// IsDayActive
        /// </summary>
        bool IsDayActive()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return AppSchedule.ActiveSunday == 1;
                case DayOfWeek.Monday:
                    return AppSchedule.ActiveMonday == 1;
                case DayOfWeek.Tuesday:
                    return AppSchedule.ActiveTuesday == 1;
                case DayOfWeek.Wednesday:
                    return AppSchedule.ActiveWednesday == 1;
                case DayOfWeek.Thursday:
                    return AppSchedule.ActiveThursday == 1;
                case DayOfWeek.Friday:
                    return AppSchedule.ActiveFriday == 1;
                case DayOfWeek.Saturday:
                    return AppSchedule.ActiveSaturday == 1;
                default:
                    return true;
            }
        }

        /// <summary>
        /// Fire
        /// </summary>
        void Fire(byte vkey, byte scancode)
        {
            bool bFire = false;
            if (AppUseSchedule == 1)
            {
                if (IsDayActive() && InSchedule())
                {
                    bFire = true;
                }
            }
            else
            {
                bFire = true;
            }

            if (bFire)
            {
                keybd_event(vkey, scancode, KEYEVENTF_EXTENDEDKEY | 0, 0);
                keybd_event(vkey, scancode, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
            FlashTrayIcon();
        }

        /// <summary>
        /// KeyStrokeTimer_Tick
        /// </summary>
        private void KeyStrokeTimer_Tick(object sender, EventArgs e)
        {
            Fire(VK_F24, 0);
        }

        /// <summary>
        /// PauseAfterTimer_Tick
        /// </summary>
        private void PauseAfterTimer_Tick(object sender, EventArgs e)
        {
            AppEnabled = 0;
            Initialize();
        }

        /// <summary>
        /// AppSplashTimer_Tick
        /// </summary>
        private void AppSplashTimer_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            AppSplashTimer.Enabled = false;
        }

        /// <summary>
        /// ntExit_Click
        /// </summary>
        private void ntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ntConfigure_Click
        /// </summary>
        private void ntConfigure_Click(object sender, EventArgs e)
        {
            KeepAwakeConfigurationForm Frm = new KeepAwakeConfigurationForm();
            Frm.SetValues(this, AppFireRate, AppPauseAfterOn, AppPauseAfter, AppEnabled, AppUseSchedule, AppSchedule);
            Frm.ShowDialog();
        }

        /// <summary>
        /// ntAbout_Click
        /// </summary>
        private void ntAbout_Click(object sender, EventArgs e)
        {
            KeepAwakeAbout Frm = new KeepAwakeAbout();
            Frm.ShowDialog();
        }

        private void ntStop_Click(object sender, EventArgs e)
        {
            AppEnabled = 0;
            Initialize();
        }

        private void ntStart_Click(object sender, EventArgs e)
        {
            AppEnabled = 1;
            Initialize();
        }

        private void KTrayNotifier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FlashTrayIcon();
        }

        private void FlashTrayIcon()
        {
            Task.Run(() =>
            {
                NotifyIcon trayIcon = KTrayNotifier; // Assuming KTrayNotifier is a NotifyIcon
                Icon originalIcon = trayIcon.Icon;
                Icon invertedIcon = SetIconToBlack(originalIcon);
                for (int i = 0; i < 2; i++)
                {
                    trayIcon.Icon = invertedIcon;
                    Thread.Sleep(100);
                    trayIcon.Icon = originalIcon;
                    Thread.Sleep(100);
                }
            });
        }
        /// <summary>

        private Icon InvertIconColors(Icon originalIcon)
        {
            Bitmap originalBitmap = originalIcon.ToBitmap();
            Bitmap invertedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int x = 0; x < originalBitmap.Width; x++)
            {
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(originalColor.A, 255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    invertedBitmap.SetPixel(x, y, invertedColor);
                }
            }

            return Icon.FromHandle(invertedBitmap.GetHicon());
        }

        /// <summary>
        /// Sets the icon to a completely black color.
        /// </summary>
        private Icon SetIconToBlack(Icon originalIcon)
        {
            Bitmap originalBitmap = originalIcon.ToBitmap();
            Bitmap blackBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            using (Graphics g = Graphics.FromImage(blackBitmap))
            {
                g.Clear(Color.Black);
            }

            return Icon.FromHandle(blackBitmap.GetHicon());
        }

    }
}
