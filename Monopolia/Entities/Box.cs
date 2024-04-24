using Monopolia.Entities.Abstractions;

namespace Monopolia.Entities;

public class Box : WareHouseElement
{
    public Box(DateTime productionDate, double width, double height, double depth, double weight) : base(width, height, depth)
    {
        ProductionDate = productionDate;
        Weight = weight;
    }
    
    public DateTime ProductionDate { get; set; }
    public DateTime ExpirationDate => ProductionDate.AddDays(100);
    public double Volume =>  Width * Height * Depth;
    public double Weight { get; set; }
}