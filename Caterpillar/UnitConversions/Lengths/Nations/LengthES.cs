
namespace Caterpillar.Lengths
{
    class ESUnit : Length
    {
        public ESUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.ES;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct ES
    {
        public static readonly ES Empty;

        public static Unit Legua { get { return new ESUnit("Legua", " ", 6680.02672010688); } }
        public static Unit Milla { get { return new ESUnit("Milla", " ", 1391.98218262806); } }
        public static Unit Estadio { get { return new ESUnit("Estadio", " ", 174.000800403682); } }
        public static Unit Cana { get { return new ESUnit("Cana", " ", 2.0); } }
        public static Unit Braza { get { return new ESUnit("Braza", " ", 1.66999998664); } }
        public static Unit Paso { get { return new ESUnit("Paso", " ", 1.39316707277487); } }
        public static Unit Vara { get { return new ESUnit("Vara", " ", 0.835869989784833); } }
        public static Unit Pie { get { return new ESUnit("Pie", " ", 0.278600003777816); } }
        public static Unit Palmo { get { return new ESUnit("Palmo", " ", 0.2); } }
        public static Unit Pulgada { get { return new ESUnit("Pulgada", " ", 0.0236499999984627); } }
        public static Unit Linea { get { return new ESUnit("Linea", " ", 0.00193495400004348); } }
        public static Unit Punto { get { return new ESUnit("Punto", " ", 0.000161246100000281); } }

    }
}