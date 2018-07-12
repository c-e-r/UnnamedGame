using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class WorldTime : INotifyPropertyChanged
    {

        public long _time;


        public long Time
        {
            get
            {
                return _time;
            }
            private set
            {
                _time = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Pass(long n)
        {
            for (int i = 0; i < n; i++)
            {
                Time++;
            }

        }
    }
}
