using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ClockApp.ViewModels
{
    public class ClockViewModel : BaseViewModel
    {

        // DATE

        private string _day;
        public string Day
        {
            get { return _day; }
            set
            {
                _day = value;
                OnPropertyChanged(nameof(Day));
            }
        }

        private string _month;
        public string Month
        {
            get { return _month; }
            set
            {
                _month = value;
                OnPropertyChanged(nameof(Month));
            }
        }

        private string _year;
        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged(nameof(Year));
            }
        }

        // TIME

        private string _hour;
        public string Hour
        {
            get { return _hour; }
            set
            {
                _hour = value;
                OnPropertyChanged(nameof(Hour));
            }
        }

        private string _minute;
        public string Minute
        {
            get { return _minute; }
            set
            {
                _minute = value;
                OnPropertyChanged(nameof(Minute));
            }
        }

        private string _second;
        public string Second
        {
            get { return _second; }
            set
            {
                _second = value;
                OnPropertyChanged(nameof(Second));
            }
        }

        private string _millisecond;
        public string Millisecond
        {
            get { return _millisecond; }
            set
            {
                _millisecond = value;
                OnPropertyChanged(nameof(Millisecond));
            }
        }


        public ClockViewModel()
        {
            DeviceDisplay.KeepScreenOn = true;

            Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                DateTime dateTime = DateTime.Now;

                Hour = dateTime.ToString("HH");
                Minute = dateTime.ToString("mm");
                Second = dateTime.ToString("ss");
                Millisecond = dateTime.ToString("ff");

                Day = dateTime.ToString("dd");
                Month = dateTime.ToString("MM");
                Year = dateTime.ToString("yyyy");

                return true;
            });
        }
    }
}