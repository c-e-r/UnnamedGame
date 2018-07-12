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
    public class UnnamedMenu : INotifyPropertyChanged
    {
        private ObservableCollection<Option> _options;


        public UnnamedMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu)
        {
            Ctx = ctx;
            PrevMenu = prevMenu;
        }

        public UnnamedDataContext Ctx { get; set; }
        protected Func<UnnamedMenu> ThisMenu { get; set; }
        protected Func<UnnamedMenu> PrevMenu { get; set; }

        public void Next(UnnamedMenu menu)
        {
            Ctx.PlayerOptions.Menu = menu;
        }

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
    }
}
