using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TVPowerControl {
    internal class SharpSerialControl
    {
        private readonly Action<string> _log;
        private readonly object _lock = new object();

        public SharpSerialControl(Action<string> log) {
            _log = log;
        }

        private void Log(string message) {
            _log(message);
        }

        private void SendCommandWithRetry(SerialPort serialPort, string s) {
            Thread.Sleep(100);
            for (int i = 0; i < 3; ++i) {
                Log($"Sending command: {s}");
                serialPort.WriteLine(s);
                var reply = serialPort.ReadLine().Trim();
                Log($"Reply from TV: {reply}");
                if (reply == "OK")
                    break;

                serialPort.WriteLine("");
                Thread.Sleep(100);
                var leftover = serialPort.ReadExisting().Trim();
                if (!string.IsNullOrEmpty(leftover))
                    Log($"Leftover reply: {leftover}");
                Thread.Sleep(1000);
            }
        }

        public void SendPowerCommand(string serialPortName, bool powerOn) {
            if (string.IsNullOrEmpty(serialPortName)) {
                Log("Can't send power command, no serial port selected");
                return;
            }

            Task.Run(() => {
                try {
                    lock (_lock) {
                        using (var serialPort = new SerialPort(serialPortName, 9600, Parity.None, 8, StopBits.One)) {
                            serialPort.NewLine = "\x0d";
                            serialPort.ReadTimeout = 1000;
                            serialPort.WriteTimeout = 1000;
                            serialPort.Open();

                            Log("Sending power saving disable message");
                            SendCommandWithRetry(serialPort, "RSPW0001");

                            Log($"Sending power {(powerOn ? "on" : "off")} message");
                            SendCommandWithRetry(serialPort, $"POWR{(powerOn ? 1 : 0)}   ");
                        }
                    }
                }
                catch (Exception e) {
                    Log($"Error sending power command: {e.Message}");
                }
            });
        }

        public static IEnumerable<string> GetSerialPortNames() {
            return SerialPort.GetPortNames();
        }
    }
}
