using System.Runtime.InteropServices;

namespace Lab3
{
    public class MainClass
    {
        private static void arrayGenerate(double x, ref double y1, ref double y2)
        {
            y1 = x * x;
            y2 = 1;
        }

        static void Main(string[] args)
        {

            double[] x = new double[5];
            x[0] = 10;
            for (int i = 1; i < x.Length; i++)
            {
                x[i] = x[i - 1] + 1;
            }

            V1DataArray array = new V1DataArray("array1", DateTime.Now, x, arrayGenerate);

            SplineData method = new SplineData(array, 3, 1000);
            method.calculate();
            System.Console.WriteLine(method.ToLongString(DataStat.FORMAT));

            string filename = "info.txt";
            System.Console.WriteLine("Also information was written to " + filename);
            method.Save(filename, DataStat.FORMAT);
        }

        
        static void testSpline(double[] x)
        {
            int m = 3;
            const int N = 5;
            double[] interval = {10, 14};
            double[] result = new double[N ];
            double[] y = { 11, 12, 13 };

            spline(result, m, interval, y, N, x);

            foreach (double i in result)
            {
                Console.WriteLine(i);
            }
        }
        [DllImport("\\..\\..\\..\\..\\x64\\Debug\\SplineCalculation.dll",
        CallingConvention = CallingConvention.Cdecl)]
        public static extern void spline(double[] splineY, int n, double[] interval, double[] y, int initialN, double[] initialX);
    }
}