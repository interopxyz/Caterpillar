
namespace Caterpillar.Volumes
{
    class JPUnit : Volume
    {
        public JPUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.JP;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Volumes
{
    public struct JP
    {
        public static readonly JP Empty;

        public static Unit Koku { get { return new JPUnit("Koku", "--", 0.1803906836965); } }
        public static Unit To { get { return new JPUnit("To", "--", 0.01803906836965); } }
        public static Unit Sho { get { return new JPUnit("Sho", "--", 0.001803906836965); } }
        public static Unit Go { get { return new JPUnit("Go", "--", 0.0001803906836965); } }
        public static Unit Shaku { get { return new JPUnit("Shaku", "--", 0.00001803906836965); } }
        public static Unit Sai { get { return new JPUnit("Sai", "--", 0.000001803906836965); } }

    }

}