using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations.Models
{
    public class SystemOfEquation
    {
        private double _a1;
        public double A1
        {
            get { return _a1; }
            set
            {
                _a1 = value;
                //  OnPropertyChanged();
            }
        }


        private double _a2;
        public double A2
        {
            get { return _a2; }
            set
            {
                _a2 = value;
                //  OnPropertyChanged();
            }
        }


        private double _b1;
        public double B1
        {
            get { return _b1; }
            set
            {
                _b1 = value;
                //  OnPropertyChanged();
            }
        }


        private double _b2;
        public double B2
        {
            get { return _b2; }
            set
            {
                _b2 = value;
                // OnPropertyChanged();
            }
        }


        private double _c1;
        public double C1
        {
            get { return _c1; }
            set
            {
                _c1 = value;
                //   OnPropertyChanged();
            }
        }


        private double _c2;
        public double C2
        {
            get { return _c2; }
            set
            {
                _c2 = value;
                // OnPropertyChanged();
            }
        }


        private double _x;
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                //  OnPropertyChanged();
            }
        }

        private double _y;
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                //   OnPropertyChanged();
            }
        }

        

        public SystemOfEquation(double a1, double a2, double b1, double b2, double c1, double c2)
        {
            A1 = a1;
            A2 = a2;
            B1 = b1;
            B2 = b2;
            C1 = c1;
            C2 = c2;
        }

       
    }
}
