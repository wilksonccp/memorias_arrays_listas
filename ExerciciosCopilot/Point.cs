namespace ExerciciosCopilot;


struct Point
{
    public double X;
    public double Y;

    public double CalculateDistance(Point other)
    {
        double dx = X - other.X;
        double dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    public override string ToString()
    {
        return $"({X} , {Y})";
    }
}
