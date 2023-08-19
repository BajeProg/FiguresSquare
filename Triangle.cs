namespace FiguresSquare
{
    public class Triangle : Figure
    {
        public int SideA { get; }
        public int SideB { get; }
        public int SideC { get; }

        public bool IsRight => SideC * SideC == SideA * SideA + SideB * SideB;

        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side lengths must be positive.");

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double Square()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
