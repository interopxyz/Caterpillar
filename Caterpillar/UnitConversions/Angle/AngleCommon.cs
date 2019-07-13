
namespace Caterpillar.Angles
{
    class CommonUnit : Angle
    {
        public CommonUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.None;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Angles
{
    public struct Common
    {
        public static readonly Common Empty;

        public static Unit Degree { get { return new CommonUnit("Degree", "°", 0.0174532925199433); } }
        public static Unit Radian { get { return new CommonUnit("Radian", "rad", 1); } }
        public static Unit Gradian { get { return new CommonUnit("Gradian", "g", 0.015707963267949); } }
        public static Unit Unitized { get { return new CommonUnit("Unitized", "u", 6.28318530717959); } }
        public static Unit Point { get { return new CommonUnit("Point", "--", 0.19634954084936); } }
        public static Unit Mil { get { return new CommonUnit("Mil", "--", 0.00098174770424681); } }

    }
}