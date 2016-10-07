using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class GSM
    {
        //static string nokiaN95 = "nokiaN95";

        string _model;
        string _manufacturer;
        decimal _price;
        string _owner;
        List<Call> _callHistory;
        GSM _nextGSM;

        Battery _phoneBattery;
        Screen _phoneScreen;

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

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                _manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Owner
        {
            get
            {
                return _owner;
            }

            set
            {
                _owner = value;
            }
        }

        public GSM NextGSM
        {
            get
            {
                return _nextGSM;
            }

            set
            {
                _nextGSM = value;
            }
        }

        private Battery PhoneBattery
        {
            get
            {
                return _phoneBattery;
            }

            set
            {
                _phoneBattery = value;
            }
        }

        private Screen PhoneScreen
        {
            get
            {
                return _phoneScreen;
            }

            set
            {
                _phoneScreen = value;
            }
        }

        private List<Call> CallHistory
        {
            get
            {
                return _callHistory;
            }

            set
            {
                _callHistory = value;
            }
        }

        public GSM(string model,
            string manufacturer, decimal price, string owner,
            Battery phoneBattery, Screen phoneScreen)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.PhoneBattery = phoneBattery;
            this.PhoneScreen = phoneScreen;
            this.CallHistory = new List<Call>();

        }
        public override string ToString()
        {
            return string.Format("Owner: {0}, Model: {1} Manufacturer: {2} Price: {3} ", Owner, Model, Manufacturer, Price);
        }
        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }
        public void RemoveCall(Call call)
        {
            CallHistory.Remove(call);
        }
        public void RemoveAllCalls()
        {
            CallHistory.RemoveRange(0, CallHistory.Count - 1);
        }
        public decimal TotalAmount(decimal price)
        {
            TimeSpan callsSum = new TimeSpan();

            foreach (Call call in CallHistory)
            {

                callsSum += call.CallDuration;
            }
            return price * callsSum.Minutes;
        }

    }
}
