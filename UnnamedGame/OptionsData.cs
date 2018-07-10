using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnnamedGame
{
    class OptionsData : INotifyPropertyChanged
    {
        private ObservableCollection<Option> _options;
        private Stack<Func<UnnamedDataContext, ObservableCollection<Option>>> OptionsStack;
        private Func<UnnamedDataContext, ObservableCollection<Option>> CurrentOption;
        private bool _back;

        private UnnamedDataContext ctx;

        public OptionsData(UnnamedDataContext ctx)
        {
            OptionsStack = new Stack<Func<UnnamedDataContext, ObservableCollection<Option>>>();
            this.ctx = ctx;
            SetOptions((context) => MainMenu.Options(context));
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

        public void SetOptions(Func<UnnamedDataContext, ObservableCollection<Option>> opt)
        {
            OptionsStack.Push(CurrentOption);
            CurrentOption = opt;
            Options = opt(ctx);
        }

        public void OptionBack()
        {
            
            if (OptionsStack.Count != 0)
            {
                CurrentOption = OptionsStack.Pop();
                Options = CurrentOption(ctx);
            }
            
        }

    }
}
