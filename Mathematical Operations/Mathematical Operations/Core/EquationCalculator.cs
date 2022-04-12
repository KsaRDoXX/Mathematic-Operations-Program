using Mathematical_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mathematical_Operations.Core
{
    public class EquationCalculator
    {
        public SystemOfEquation Calculate(SystemOfEquation equation)
        {
            double W = equation.A1 * equation.B2 - equation.B1 * equation.A2;
            double Wx = equation.C1 * equation.B2 - equation.B1 * equation.C2;
            double Wy = equation.A1 * equation.C2 - equation.C1 * equation.A2;

            if (W == 0 && Wx == 0 && Wy == 0)
            {
                MessageBox.Show("układ nieoznaczony, posiada nieskończenie wiele rozwiązań. ");
                return equation;
            }
            else if (W != 0)
            {
                equation.X = Wx / W;
                equation.Y = Wy / W;

                return equation;
            }
            else if (W == 0 && (Wx != 0 || Wy != 0))
            {MessageBox.Show("sprzeczny, nie posiada rozwiązań. ");
                return equation;
                
            }
            else return equation;
            


        }
    }
}
