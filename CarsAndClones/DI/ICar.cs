using CarsAndClones.Enums;

namespace CarsAndClones.DI
{
    public interface ICar
    {
        string Model { get; set; }
        Bodies Body { get; set; }
        Colours Colour { get; set; }
        Engines Engine { get; set; }
        GearBoxes GearBox { get; set; }
        List<Options> Options { get; set; }
    }
}