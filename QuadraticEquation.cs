using System;

namespace Complex
{
    class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException()
        {
        }

        public NotRealRootsException(string message) : base(message)
        {

        }
    }

    class QuadraticEquation
    {
        private double m_a;
        private double m_b;
        private double m_c;

        public QuadraticEquation()
        {
            m_a = 0;
            m_b = 0;
            m_c = 0;
        }

        public QuadraticEquation(double a, double b, double c)
        {
            m_a = a;
            m_b = b;
            m_c = c;
        }

        public double A
        {
            get
            {
                return m_a;
            }
            set
            {
                m_a = value;
            }
        }
        public double B
        {
            get
            {
                return m_b;
            }
            set
            {
                m_b = value;
            }
        }

        public double C
        {
            get
            {
                return m_c;
            }
            set
            {
                m_c = value;
            }
        }

        public double Y(double x)
        {
            return (A * x * x) + (B * x) + C;
        }

        public double Discriminant
        {
            get
            {
                return (B * B) - (4 * A * C);
            }
        }

        public double[] Roots
        {
            get
            {
                if (Discriminant < 0)
                {
                    throw new NotRealRootsException($"{Discriminant}");
                }
                //var firstRoot = -B + System.Math.Sqrt(Discriminant)/2 / A;
                //var secondRoot = -B - System.Math.Sqrt(Discriminant) / 2 / A;
                //var roots = new double[] { firstRoot, secondRoot };
                return new double[] { -B + System.Math.Sqrt(Discriminant) / 2 / A , -B - System.Math.Sqrt(Discriminant) / 2 / A };
            }
        }

    }
}
