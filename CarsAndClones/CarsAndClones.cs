using CarsAndClones.DI;
using CarsAndClones.Bll;
using CarsAndClones.Enums;
using CarsAndClones.Settings;

namespace CarsAndClones
{
    public partial class CarsAndClones : Form
    {
        private Configuration configuration;
        private EnumHandler enumHandler;

        private IBuilder builder;
        private ICarFactory carFactory;
        private IPrototype prototype;

        private Bodies[] bodies;
        private Colours[] colours;
        private Engines[] engines;
        private GearBoxes[] gearBoxes;
        private Options[] options;

        public CarsAndClones()
        {
            InitializeComponent();
            configuration = new Configuration();
            enumHandler = new EnumHandler();
            builder = new Builder(configuration);

            carFactory = configuration.Container.GetInstance<ICarFactory>();
            GatherCarParameters();
            ShowParameters();
            ShowAllCars();
        }

        private void ShowAllCars()
        {
            List<ICar> cars = carFactory.GetAllCars().ToList();
            foreach (var car in cars)
            {
                carsList.Items.Add(MakeNewItem(car));
            }
        }

        private void buildCarButton_Click(object sender, EventArgs e)
        {
            bool isReadyForBuild = AreSelectionsRight();
            if (isReadyForBuild)
            {
                ICar car = builder.Build();
                car.Model = carModel.Text;
                carFactory.AddCarToDb(car);
                carsList.Items.Add(MakeNewItem(car));
                ClearSelections();
            }
        }

        private void removeCarButton_Click(object sender, EventArgs e)
        {
            carFactory.RemoveCarFromDb(GetCarFromList());
            carsList.SelectedItems[0].Remove();
        }

        private void cloneCarButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(carModel.Text))
            {
                MessageBox.Show("Введите название модели!", "Ошибка ввода!");
                return;
            }
            else if (carsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите машину для клонирования!", "Ошибка ввода!");
                return;
            }
            ICar carPrototype = GetCarFromList();
            prototype = new Prototype(carPrototype);
            ICar carClone = prototype.Clone();
            if (bodiesBox.SelectedItems.Count == 0) builder.SetBody(carClone.Body);
            else builder.SetBody(bodies[bodiesBox.SelectedIndex]);

            if (coloursBox.SelectedItems.Count == 0) builder.SetColour(carClone.Colour);
            else builder.SetColour(colours[coloursBox.SelectedIndex]);

            if (enginesBox.SelectedItems.Count == 0) builder.SetEngine(carClone.Engine);
            else builder.SetEngine(engines[enginesBox.SelectedIndex]);

            if (gearBoxesBox.SelectedItems.Count == 0) builder.SetGearBox(carClone.GearBox);
            else builder.SetGearBox(gearBoxes[gearBoxesBox.SelectedIndex]);

            if (optionsBox.SelectedItems.Count == 0) builder.SetOptions(carClone.Options);
            else
            {
                List<Options> optionsList = new List<Options>();
                foreach (var item in optionsBox.SelectedItems)
                {
                    int index = optionsBox.Items.IndexOf(item);
                    optionsList.Add(options[index]);
                }
                builder.SetOptions(optionsList);
            }
            carClone = builder.Build();
            carClone.Model = carModel.Text;
            carFactory.AddCarToDb(carClone);
            carsList.Items.Add(MakeNewItem(carClone));
            ClearSelections();
        }

        private void ShowParameters()
        {
            for (int i = 0; i < bodies.Count(); i++)
            {
                bodiesBox.Items.Add(enumHandler.ToString(bodies[i]));
            }

            for (int i = 0; i < colours.Count(); i++)
            {
                coloursBox.Items.Add(enumHandler.ToString(colours[i]));
            }

            for (int i = 0; i < engines.Count(); i++)
            {
                enginesBox.Items.Add(enumHandler.ToString(engines[i]));
            }

            for (int i = 0; i < gearBoxes.Count(); i++)
            {
                gearBoxesBox.Items.Add(enumHandler.ToString(gearBoxes[i]));
            }

            for (int i = 0; i < options.Count(); i++)
            {
                optionsBox.Items.Add(enumHandler.ToString(options[i]));
            }
        }

        private void bodiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bodiesBox.SelectedItem != null) builder.SetBody(bodies[bodiesBox.SelectedIndex]);

        }

        private void coloursBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(coloursBox.SelectedItem != null) builder.SetColour(colours[coloursBox.SelectedIndex]);
        }

        private void enginesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(enginesBox.SelectedItem != null) builder.SetEngine(engines[enginesBox.SelectedIndex]);
        }

        private void gearBoxesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gearBoxesBox.SelectedItem != null) builder.SetGearBox(gearBoxes[gearBoxesBox.SelectedIndex]);
        }

        private void optionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optionsBox.SelectedItems.Count == 0) return;
            List<Options> optionsList = new List<Options>();
            foreach (var item in optionsBox.SelectedItems)
            {
                int index = optionsBox.Items.IndexOf(item);
                optionsList.Add(options[index]);
            }
            builder.SetOptions(optionsList);
        }

        private ListViewItem MakeNewItem(ICar car)
        {
            ListViewItem listViewItem = new ListViewItem(car.Model);
            listViewItem.SubItems.Add(enumHandler.ToString(car.Body));
            listViewItem.SubItems.Add(enumHandler.ToString(car.Colour));
            listViewItem.SubItems.Add(enumHandler.ToString(car.Engine));
            listViewItem.SubItems.Add(enumHandler.ToString(car.GearBox));
            string options = "";
            for (int i = 0; i < car.Options.Count(); i++)
            {
                options += enumHandler.ToString(car.Options[i]);
                if (car.Options.Count() > 1 && i + 1 < car.Options.Count()) options += ", ";
            }
            if (options != "") listViewItem.SubItems.Add(options);
            else
            {

            }
            return listViewItem;
        }

        private void GatherCarParameters()
        {
            bodies = (Bodies[])Enum.GetValues(typeof(Bodies));
            colours = (Colours[])Enum.GetValues(typeof(Colours));
            engines = (Engines[])Enum.GetValues(typeof(Engines));
            gearBoxes = (GearBoxes[])Enum.GetValues(typeof(GearBoxes));
            options = (Options[])Enum.GetValues(typeof(Options));
        }

        private ICar GetCarFromList()
        {
            ICar car = configuration.Container.GetInstance<ICar>();
            car.Model = carsList.SelectedItems[0].Text;
            car.Body = enumHandler.ToBody(carsList.SelectedItems[0].SubItems[1].Text);
            car.Colour = enumHandler.ToColour(carsList.SelectedItems[0].SubItems[2].Text);
            car.Engine = enumHandler.ToEngine(carsList.SelectedItems[0].SubItems[3].Text);
            car.GearBox = enumHandler.ToGearBox(carsList.SelectedItems[0].SubItems[4].Text);
            car.Options = new List<Options>();
            string[] options = carsList.SelectedItems[0].SubItems[5].Text.Split(", ");
            foreach (var item in options)
            {
                car.Options.Add(enumHandler.ToOption(item));
            }
            return car;
        }

        private void ClearSelections()
        {
            bodiesBox.ClearSelected();
            coloursBox.ClearSelected();
            enginesBox.ClearSelected();
            gearBoxesBox.ClearSelected();
            optionsBox.ClearSelected();
            foreach (ListViewItem item in carsList.Items)
            {
                item.Selected = false;
            }
        }

        private bool AreSelectionsRight()
        {
            if (String.IsNullOrEmpty(carModel.Text))
            {
                MessageBox.Show("Введите название модели!", "Ошибка ввода!");
                return false;
            }
            else if (bodiesBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите кузов!", "Ошибка ввода!");
                return false;
            }
            else if (coloursBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите цвет машины!", "Ошибка ввода!");
                return false;
            }
            else if (enginesBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите двигатель!", "Ошибка ввода!");
                return false;
            }
            else if (gearBoxesBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите коробку переключения передач!", "Ошибка ввода!");
                return false;
            }
            else if (optionsBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну доп. опцию!", "Ошибка ввода!");
                return false;
            }
            else return true;
        }
    }
}