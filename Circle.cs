namespace FiguresSquare
{
    public class Circle : Figure
    {
        public int Radius { get; }

        public Circle(int radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be non-negative.");

            Radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
