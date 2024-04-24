using Monopolia.Entities.Abstractions;

namespace Monopolia.Entities;

public class Pallet : WareHouseElement
{
    public Pallet(double width, double height, double depth)
        : base(width, height, depth)
    { }
    
    public List<Box> Boxes { get; set; } = new();

    public DateTime ExpirationDate => Boxes.Min(b => b.ExpirationDate);
    public double Volume => Boxes.Sum(b => b.Volume) + Width * Height * Depth;
    public double Weight => Boxes.Sum(b => b.Weight) + 30;

    public override string ToString()
    {
        return $"pallet ({Id}):\n" +
               $"   width: {Width}" +
               $"   height: {Height}" +
               $"   depth: {Depth}" +
               $"   weight: {Weight}" +
               $"   expirationDate: {ExpirationDate}" +
               $"   volume: {Volume}";
    }
}