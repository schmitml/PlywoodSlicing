namespace PlywoodSlicer
{
    public interface IShape
    {
        int Width { get; }
        int Height { get; }
        int Area();
    }
}