namespace CartasianPlane
{
    public abstract class CartesianPlane
    {
        public float x { get; set; }
        public float y { get; set; }
    }
    public class Point : CartesianPlane
    {
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float DistanceTo(Point other)
        {
            return (float)Math.Sqrt((other.x - this.x) * (other.x - this.x) + (other.y - this.y) * (other.y - this.y));
        }
    }
}
