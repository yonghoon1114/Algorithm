namespace Grid
{
    public abstract class CartesianPlane
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class Point : CartesianPlane
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
    }
}
