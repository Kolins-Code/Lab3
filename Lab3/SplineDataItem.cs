namespace Lab3
{
    internal class SplineDataItem
    {
        private double x { get; set; }
        private double y { get; set; }
        private double ySplined { get; set; }

        public SplineDataItem(double x, double y, double ySplined)
        {
            this.x = x;
            this.y = y;
            this.ySplined = ySplined;
        }

        public string ToString(string format)
        {
            return string.Format("x: {0:" + format + "}, y: {1:" + format + "}, y by Spline: {2:" + format + "}", x, y, ySplined);
        }

        public override string ToString()
        {
            return ToString(DataStat.FORMAT);
        }
    }
}
