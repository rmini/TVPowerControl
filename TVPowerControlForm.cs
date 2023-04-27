using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TVPowerControl.Properties;


namespace TVPowerControl {
    public partial class TVPowerControlForm: Form {
        private static class NativeMethods {
            [DllImport(@"User32", SetLastError = true, EntryPoint = "RegisterPowerSettingNotification", CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr RegisterPowerSettingNotification(
                IntPtr hRecipient, 
                ref Guid PowerSettingGuid,
                Int32 Flags);
        }

        private static Guid GUID_MONITOR_POWER_ON = new Guid("{02731015-4510-4526-99e6-e5a17ebd1aea}");
        private const int WM_POWERBROADCAST = 0x0218;
        private const int DEVICE_NOTIFY_WINDOW_HANDLE = 0x00000000;
        const int PBT_POWERSETTINGCHANGE = 0x8013; // DPPE

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        internal struct POWERBROADCAST_SETTING_MPO {
            public Guid PowerSetting;
            public uint DataLength;
            public uint Data;
        }

        private string serialPortName;
        private readonly SharpSerialControl _sharpSerialControl;

        protected override void WndProc(ref Message m) {
            if (m.Msg == WM_POWERBROADCAST && (int)m.WParam == PBT_POWERSETTINGCHANGE) {
                var ps = (POWERBROADCAST_SETTING_MPO)Marshal.PtrToStructure(m.LParam, typeof(POWERBROADCAST_SETTING_MPO));
                if (ps.PowerSetting != GUID_MONITOR_POWER_ON) 
                    return;
                MonitorStateChanged(ps.Data != 0);
            }
            base.WndProc(ref m);
        }

        private void SendPowerCommand(bool powerOn) {
            if (true) {
                _sharpSerialControl.SendPowerCommand(serialPortName, powerOn);
            }
        }

        public TVPowerControlForm() {
            _sharpSerialControl = new SharpSerialControl(Log);
            InitializeComponent();
        }

        private void Log(string s) {
            listBoxMessages.Items.Add($"{DateTime.Now}: {s}");
            listBoxMessages.SelectedIndex = listBoxMessages.Items.Count - 1;
        }

        private void MonitorStateChanged(bool powerOn) {
            Log($"Got monitor power message: {(powerOn ? "On" : "Off")}");
            if (checkBoxEnablePowerOn.Checked && powerOn) {
                SendPowerCommand(true);
            }
            if (checkBoxEnablePowerOff.Checked && !powerOn) {
                SendPowerCommand(false);
            }
        }

        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e) {
            serialPortName = comboBoxComPort.SelectedItem.ToString();
            Settings.Default.ComPort = serialPortName;
            Settings.Default.Save();
        }

        private void comboBoxComPort_DropDown(object sender, EventArgs e) {
            UpdateComPortComboBox();
        }

        private void UpdateComPortComboBox() {
            bool foundPort = false;
            comboBoxComPort.Items.Clear();
            foreach (var p in SharpSerialControl.GetSerialPortNames()) {
                comboBoxComPort.Items.Add(p);
                if (p == serialPortName) {
                    comboBoxComPort.SelectedIndex = comboBoxComPort.Items.Count - 1;
                    foundPort = true;
                }
            }
            if (!foundPort) {
                comboBoxComPort.SelectedIndex = -1;
            }
        }

        private void buttonPowerOn_Click(object sender, EventArgs e) {
            SendPowerCommand(true);
        }

        private void buttonPowerOff_Click(object sender, EventArgs e) {
            SendPowerCommand(false);
        }

        private void TVPowerControlForm_Load(object sender, EventArgs e) {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            NativeMethods.RegisterPowerSettingNotification(Handle,
                ref GUID_MONITOR_POWER_ON,
                DEVICE_NOTIFY_WINDOW_HANDLE);
            serialPortName = Settings.Default.ComPort;
            Hide();
            UpdateComPortComboBox();
            checkBoxEnablePowerOn.Checked = Settings.Default.PowerOnWake;
            checkBoxEnablePowerOff.Checked = Settings.Default.PowerOffSleep;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TVPowerControlForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
                WindowState = FormWindowState.Normal;
            }
        }
        
        private void toolStripMenuItemExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void checkBoxEnablePowerOn_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.PowerOnWake = checkBoxEnablePowerOn.Checked;
            Settings.Default.Save();
        }

        private void checkBoxEnablePowerOff_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.PowerOffSleep = checkBoxEnablePowerOff.Checked;
            Settings.Default.Save();
        }
    }
}
