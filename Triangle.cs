namespace FiguresSquare
{
    public class Triangle : Figure
    {
        public bool isRight { get; private set; }
        private int _a, _b, _c;

        private Triangle()
        {
            _a = _b = _c = 0;
            isRight = false;
        }
        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
            isRight = c * c == a * a + b * b;
        }

        public override double Square()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
