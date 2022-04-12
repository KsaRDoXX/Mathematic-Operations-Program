using Mathematical_Operations.ViewModels;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows;

namespace Mathematical_Operations.Commands
{
    public class SaveFunctionCommand : CommandBase
    {
        public FunctionsViewModel viewModel { get; set; }
        public SaveFunctionCommand(FunctionsViewModel viewModel)
        {
            this.viewModel = viewModel;

            this.viewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return (viewModel.A != 0 || viewModel.B != 0);
        }

        void Save(string path, string line)
        {

            if (!File.Exists(path))
            {
                string lineStart = "Functions :" + Environment.NewLine;
                File.WriteAllText(path, lineStart);
            }
            if (File.Exists(path))
            {
                File.AppendAllText(path, line);
            }
        }

        public override void Execute(object parameter)
        {

            string line;
            line = " Linia numer 1 ";

            string path = @"ResultsLog.txt";

            if (viewModel.A == 0)
            {
                line = viewModel.B.ToString() + " X + (" + viewModel.C + " ) = 0 " + Environment.NewLine; ;
                Save(path, line);

                line = "X1 = " + viewModel.X1.ToString() + Environment.NewLine;
                Save(path, line);

            }
            else if (viewModel.A != 0)
            {
                line = viewModel.A.ToString() + " X^2 + (" + viewModel.B + " ) + ( " + viewModel.C + " ) = 0" + Environment.NewLine;
                Save(path, line);

                if (viewModel.Delta != float.NaN)
                {
                    line = "Delta = " + viewModel.Delta.ToString() + Environment.NewLine;
                    Save(path, line);
                }

                if (viewModel.Delta > 0)
                {
                    line = "X1 = " + viewModel.X1.ToString() + Environment.NewLine;
                    Save(path, line);

                    line = "X2 = " + viewModel.X2.ToString() + Environment.NewLine;
                    Save(path, line);
                }
                else
                {
                    line = "Delta < 0" + Environment.NewLine;
                    Save(path, line);
                }

                if (viewModel.P != float.NaN)
                {
                    line = "P = " + viewModel.P.ToString() + Environment.NewLine;
                    Save(path, line);
                }

                if (viewModel.Q != float.NaN)
                {
                    line = "Q = " + viewModel.Q.ToString() + Environment.NewLine;
                    Save(path, line);
                }

                line = Environment.NewLine + " --------- " + Environment.NewLine;
                Save(path, line);

                MessageBox.Show("Function has been saved to file ");
            }
        }
        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecuteChanged();
        }
    }
}
