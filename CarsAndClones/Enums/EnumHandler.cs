using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndClones.Enums
{
    public class EnumHandler
    {
        public string ToString(Bodies body) => body switch
        {
            Bodies.sedan => "Седан",
            Bodies.pickup => "Пикап",
            Bodies.stationWagon => "Универсал",
            Bodies.suv => "Внедорожник",
            Bodies.coupe => "Купе",
            Bodies.limousine => "Лимузин",
            Bodies.hatchback => "Хетчбэк",
            Bodies.liftback => "Лифтбэк",
            Bodies.crossover => "Кроссовер",
            Bodies.roadster => "Родстер",
            Bodies.minivan => "Минивэн",
            _ => ""
        };

        public string ToString(Colours colour) => colour switch
        {
            Colours.white => "Белый",
            Colours.black => "Черный",
            Colours.gray => "Серый",
            Colours.golden => "Золотой",
            Colours.silver => "Серебряный",
            Colours.red => "Красный",
            Colours.blue => "Синий",
            Colours.purple => "Фиолетовый",
            Colours.yellow => "Желтый",
            Colours.orange => "Оранжевый",
            Colours.green => "Зеленый",
            Colours.pink => "Розовый",
            _ => ""

        };

        public string ToString(Engines engine) => engine switch
        {
            Engines.gas => "Бензиновый",
            Engines.diesel => "Дизельный",
            Engines.rotary => "Роторный",
            Engines.hybrid => "Гибридный",
            _ => ""
        };

        public string ToString(GearBoxes gearBox) => gearBox switch
        {
            GearBoxes.manual => "Механическая",
            GearBoxes.automatic => "Автоматическая",
            GearBoxes.robotic => "Роботизированная",
            GearBoxes.variable => "Вариативная",
            _ => ""
        };

        public string ToString(Options options) => options switch
        {
            Options.signaling => "Сигнализация",
            Options.conditioner => "Кондиционер",
            Options.powerSteering => "ГРУ",
            Options.powerWindows => "Стеклоподъемники",
            Options.parkingSensors => "Парктроники",
            Options.winterOptions => "Зимние опции",
            Options.esp => "ESP",
            _ => ""
        };

        public Bodies ToBody(string body) => body switch
        {
            "Седан" => Bodies.sedan,
            "Пикап" => Bodies.pickup,
            "Универсал" => Bodies.stationWagon,
            "Внедорожник" => Bodies.suv,
            "Купе" => Bodies.coupe,
            "Лимузин" => Bodies.limousine,
            "Хетчбэк" => Bodies.hatchback,
            "Лифтбэк" => Bodies.liftback,
            "Кроссовер" => Bodies.crossover,
            "Родстер" => Bodies.roadster,
            "Минивэн" => Bodies.minivan,
            _ => 0
        };

        public Colours ToColour(string colour) => colour switch
        {
            "Белый" => Colours.white,
            "Черный" => Colours.black,
            "Серый" => Colours.gray,
            "Золотой" => Colours.golden,
            "Серебряный" => Colours.silver,
            "Красный" => Colours.red,
            "Синий" => Colours.blue,
            "Фиолетовый" => Colours.purple,
            "Желтый" => Colours.yellow,
            "Оранжевый" => Colours.orange,
            "Зеленый" => Colours.green,
            "Розовый" => Colours.pink,
            _ => 0
        };

        public Engines ToEngine(string engine) => engine switch
        {
            "Бензиновый" => Engines.gas,
            "Дизельный" => Engines.diesel,
            "Роторный" => Engines.rotary,
            "Гибридный" => Engines.hybrid,
            _ => 0
        };

        public GearBoxes ToGearBox(string gearBox) => gearBox switch
        {
            "Механическая" => GearBoxes.manual,
            "Автоматическая" => GearBoxes.automatic,
            "Роботизированная" => GearBoxes.robotic,
            "Вариативная" => GearBoxes.variable,
            _ => 0 
        };

        public Options ToOption(string option) => option switch
        {
            "Сигнализация" => Options.signaling,
            "Кондиционер" => Options.conditioner,
            "ГРУ" => Options.powerSteering,
            "Стеклоподъемники" => Options.powerWindows,
            "Парктроники" => Options.parkingSensors,
            "Зимние опции" => Options.winterOptions,
            "ESP" => Options.esp,
            _ => 0
        };
    }
}
