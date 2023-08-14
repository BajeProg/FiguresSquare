namespace FiguresSquare
{
    public class Circle : Figure
    {
        private int _radius;

        private Circle() => _radius = 0;
        public Circle(int radius) => _radius = radius;

        public override double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
