using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Student
{
    public class Call
    {
        DateTime _startCallDate;
        TimeSpan _callDuration;

        public DateTime StartCallDate
        {
            get
            {
                return _startCallDate;
            }

            set
            {
                _startCallDate = value;
            }
        }

        public TimeSpan CallDuration
        {
            get
            {
                return _callDuration;
            }

            set
            {
                _callDuration = value;
            }
        }

        public Call(DateTime startCall, TimeSpan durationCall)
        {
            StartCallDate = startCall;
            CallDuration = durationCall;
        }
    }
}
