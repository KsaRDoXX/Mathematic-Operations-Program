using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations.Core
{
    public class ExpressionCalculator : ICalculator
    {
        public double Calculate(string expresstion)
        {     
                var dataTable = new DataTable();
                var value = dataTable.Compute(expresstion, string.Empty);

                return Convert.ToDouble(value);
        }
    }
}
