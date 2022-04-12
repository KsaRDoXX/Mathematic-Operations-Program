using Mathematical_Operations.Core;
using Mathematical_Operations.Models;
using Mathematical_Operations.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations.Commands
{
    public class CalculateSystemOfEquationCommand : CommandBase
    {
        EquationCalculator calculator = new EquationCalculator();

        public override bool CanExecute(object parameter)
        {
            //return viewModel.A1
            return true;
        }

        public EquationsViewModel viewModel { get; set; }
        public CalculateSystemOfEquationCommand(EquationsViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            SystemOfEquation equation = new SystemOfEquation(viewModel.A1,viewModel.A2,viewModel.B1,viewModel.B2,viewModel.C1,viewModel.C2);
            equation = calculator.Calculate(equation);

            viewModel.X = equation.X;
            viewModel.Y = equation.Y;
        }
    }
}
