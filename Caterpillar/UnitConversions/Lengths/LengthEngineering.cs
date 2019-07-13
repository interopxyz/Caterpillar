
namespace Caterpillar.Lengths
{
    class EngineeringUnit : Length
    {
        public EngineeringUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Engineering;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct Engineering
    {
        public static readonly Engineering Empty;

        public static Unit Chain { get { return new EngineeringUnit("Chain", " ", 30.48); } }
        public static Unit Link { get { return new EngineeringUnit("Link", " ", 0.3048); } }

    }
}