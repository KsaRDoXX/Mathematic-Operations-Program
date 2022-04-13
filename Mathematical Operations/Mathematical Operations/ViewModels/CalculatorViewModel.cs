using Mathematical_Operations.Core;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mathematical_Operations.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        public string Name { get; set; }

        private readonly ICalculator _calculator;
        public DelegateCommand<object> ButtonPushedCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        private string _expression = "";

        public string Expression
        {
            get { return _expression; }
            set { _expression = value;
                OnPropertyChanged();
            }
        } 

        public CalculatorViewModel(ICalculator calculator)
        {
            Name = "Calculator";

            _calculator = calculator;
            ButtonPushedCommand = new DelegateCommand<object>(ButtonPushed);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Equals, EqualsCanExecute);
        }

        private bool EqualsCanExecute()
        {
            return string.IsNullOrWhiteSpace(Expression) == false;
        }

        private void Equals()
        {
            var value = _calculator.Calculate(Expression);
            Expression = value.ToString();
        }

        private void Clear()
        {
            Expression = null;
            EqualsCommand.RaiseCanExecuteChanged();
        }

        private void ButtonPushed(object obj)
        {
            Expression += obj.ToString();
            EqualsCommand.RaiseCanExecuteChanged();
        }
    }

   

}
