using CarsAndClones.DI;
using CarsAndClones.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;

namespace CarsAndClones.Data
{
    public class CarEntity : ICar
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public Bodies Body { get; set; }
        public Colours Colour { get; set; }
        public Engines Engine { get; set; }
        public GearBoxes GearBox { get; set; }
        [NotMapped]
        public List<Options> Options { get; set; }
        public string OptionsString { get; set; }

        public CarEntity() { }

        public CarEntity(ICar car)
        {
            Model = car.Model;
            Body = car.Body;
            Colour = car.Colour;
            Engine = car.Engine;
            GearBox = car.GearBox;
            Options = car.Options;
            for (int i = 0; i < car.Options.Count(); i++)
            {
                OptionsString += ((int)car.Options[i]).ToString();
                if (car.Options.Count() > 1 && i + 1 < car.Options.Count()) OptionsString += ", ";
            }
        }
    }
}
