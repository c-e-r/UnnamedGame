using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class OptionsData : INotifyPropertyChanged
    {
        private ObservableCollection<Option> _options;

        public OptionsData()
        {
            Options = MainMenu.Options(new Action<ObservableCollection<Option>>((opt) => Options = opt), null);
        }

        public ObservableCollection<Option> Options
        {
            get => _options;
            private set
            {
                if (value != _options)
                {
                    _options = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void SetOptions(ObservableCollection<Option> opt)
        {
            Options = opt;
        }
    }


}
