using Mathematical_Operations.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mathematical_Operations.ViewModels
{
    public class FunctionsViewModel : ViewModelBase
    {
        public string Name { get; set; }

        private float _a;

        public float A
        {
            get { return _a; }
            set { _a = value;
                OnPropertyChanged();
            }
        }
        private float _b;
        public float B
        {
            get { return _b; }
            set
            {
                _b = value;
                OnPropertyChanged();
            }
        }
        private float _c;
        public float C
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged();
            }
        }

        private float _delta;

        public float Delta
        {
            get { return _delta; }
            set { _delta = value;
                OnPropertyChanged();
            }
        }

        private float x1;

        public float X1
        {
            get { return x1; }
            set { x1 = value;
                OnPropertyChanged();
            }
        }

        private float x2;

        public float X2
        {
            get { return x2; }
            set { x2 = value;
                OnPropertyChanged();
            }
        }

        private float _p;

        public float P
        {
            get { return _p; }
            set { _p = value;
                OnPropertyChanged();
            }
        }

        private float _q;

        public float Q
        {
            get { return _q; }
            set { _q = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateFunctionCommand { get; set; }
        public ICommand SaveFunctionCommand { get; set; }
        public FunctionsViewModel()
        {
            Name = "Functions ";

            A = 0;
            B = 0;
            C = 0;

            SaveFunctionCommand = new SaveFunctionCommand(this);
            CalculateFunctionCommand = new CalculateFunctionCommand(this);
        }
    }
}
