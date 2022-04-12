using Mathematical_Operations.Core;
using Mathematical_Operations.ViewModels;

namespace Mathematical_Operations.Commands
{
    public class CalculateFunctionCommand : CommandBase
    {
        public FunctionsViewModel viewModel { get; set; }

        public override bool CanExecute(object parameter)
        {
            if (string.IsNullOrEmpty(viewModel.A.ToString()) && viewModel.A != 0)
            {
                if (string.IsNullOrEmpty(viewModel.B.ToString()) && viewModel.B != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public override void Execute(object parameter)
        {
            if (viewModel.A != 0)
            {
                viewModel.Delta = FunctionsMath.CalcDelta(viewModel.A, viewModel.B, viewModel.C);

                viewModel.P = FunctionsMath.CalcP(viewModel.B, viewModel.A);
                viewModel.Q = FunctionsMath.CalcQ(viewModel.Delta, viewModel.A);

            }
            else
            {
                viewModel.Delta = float.NaN;
                // non quadratic function
            }

            viewModel.X1 = FunctionsMath.CalcX1(viewModel.A, viewModel.B, viewModel.C, viewModel.Delta);
            viewModel.X2 = FunctionsMath.CalcX2(viewModel.A, viewModel.B, viewModel.C, viewModel.Delta);

        }
        public CalculateFunctionCommand(FunctionsViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}
