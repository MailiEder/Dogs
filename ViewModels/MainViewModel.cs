using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dogs.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Felder
        private ViewModelBase _currentChildView;

        public ViewModelBase CurrentChildView 
        { 
            get => _currentChildView;
            set 
            { 
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        //Kommando

        public ICommand ShowDogViewCommand { get; }


        public MainViewModel()
        {
            // Initialize Commands
            ShowDogViewCommand = new ViewModelCommand(ExecuteShowDogViewCommand);
        }

        private void ExecuteShowDogViewCommand(object obj)
        {
            CurrentChildView = new DogViewModel();
        }
    }
}
