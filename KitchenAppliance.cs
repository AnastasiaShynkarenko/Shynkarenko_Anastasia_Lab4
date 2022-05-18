using System;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class KitchenAppliance : IConditionDevice, IPlace
    {
        private double weight;
        private bool condition;
        private string place = "Кухня";

        public double Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }

        public KitchenAppliance() { }
        public KitchenAppliance(double weight) { this.weight = weight; }

        public void TurnOn()
        { condition = true; }
        public void TurnOff()
        { condition = false; }
        public void ReplaceTo(string s)
        { place = s; }

        public string GetInfo()
        {
            Console.WriteLine($"Знаходиться у: {place}");
            if (condition == true)
                return "Пристрiй увiмкнено";
            else
                return "Пристрiй вимкнено";
        }
    }
}

