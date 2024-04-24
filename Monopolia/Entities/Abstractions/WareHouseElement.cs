namespace Monopolia.Entities.Abstractions;

public abstract class WareHouseElement
{
    protected WareHouseElement(double width, double height, double depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }
    public int Id { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    
}