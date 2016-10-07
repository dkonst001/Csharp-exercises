using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Battery
    {
        string _model;
        TimeSpan _idleTime;
        TimeSpan _hoursTalk;
        BatteryType _batteryType;

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public TimeSpan IdleTime
        {
            get
            {
                return _idleTime;
            }

            set
            {
                _idleTime = value;
            }
        }

        public TimeSpan HoursTalk
        {
            get
            {
                return _hoursTalk;
            }

            set
            {
                _hoursTalk = value;
            }
        }

        internal BatteryType BatteryType
        {
            get
            {
                return _batteryType;
            }

            set
            {
                _batteryType = value;
            }
        }

        public Battery(string model, TimeSpan idleTime, TimeSpan hoursTalk)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.HoursTalk = hoursTalk;
            this.BatteryType = BatteryType.Li_Ion;

        }
    }
}
