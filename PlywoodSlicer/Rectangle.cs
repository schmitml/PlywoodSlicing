namespace PlywoodSlicer
{
    public class Rectangle : IShape
    {
        #region members
        public int Width { get; }
        public int Height { get; }
        #endregion

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area(){
            return Height * Width;
        }
    }
}