using Mathematical_Operations.Core;
using Mathematical_Operations.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mathematical_Operations.Views
{
    /// <summary>
    /// Logika interakcji dla klasy CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : UserControl
    {
        private ExpressionCalculator expressionCalculator = new ExpressionCalculator();
        public CalculatorView()
        {
            InitializeComponent();
            this.DataContext = new CalculatorViewModel(expressionCalculator);

        }
    }
}
