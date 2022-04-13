using Mathematical_Operations.Core;
using System.Collections.ObjectModel;

namespace Mathematical_Operations.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _operationsViewModel;
        public ViewModelBase OperationsViewModel
        {
            get { return _operationsViewModel; }
            set
            {
                _operationsViewModel = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ViewModelBase> _list;
        public ObservableCollection<ViewModelBase> List
        {
            get { return _list; }
            set
            {
                _list = value;
                OnPropertyChanged();
            }
        }

        private ExpressionCalculator expressionCalculator = new ExpressionCalculator();
        public MainViewModel()
        {
            List = new ObservableCollection<ViewModelBase>();

            List.Add(new CalculatorViewModel(expressionCalculator));
            List.Add(new EquationsViewModel());
            List.Add(new FunctionsViewModel());
        }
    }
}
