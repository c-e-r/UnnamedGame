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
    class UnnamedMenu : INotifyPropertyChanged
    {
        private ObservableCollection<Option> _options;

        public ObservableCollection<Option> Options
        {
            get => _options;
            protected set
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
        protected static Action Back(UnnamedDataContext ctx)
        {
            return () => ctx.PlayerOptions.OptionBack();
        }
    }
}
