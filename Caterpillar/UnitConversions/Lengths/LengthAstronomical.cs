
namespace Caterpillar.Lengths
{
    class AstronomicalUnit : Length
    {
        public AstronomicalUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Astronomical;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct Astronomical
    {
        public static readonly Astronomical Empty;

        public static Unit Siriometer { get { return new AstronomicalUnit("Siriometer", "Sm", 149597870000000000.0); } }
        public static Unit Parsec { get { return new AstronomicalUnit("Parsec", "pc", 30856774879000000.0); } }
        public static Unit Spat { get { return new AstronomicalUnit("Spat", "sp", 1000000000000.0); } }
        public static Unit AstronomicalUnit { get { return new AstronomicalUnit("Astronomical Unit", "au", 1149597870690.0); } }
        public static Unit Lightyear { get { return new AstronomicalUnit("Light Year", "ly", 9454254955500000.0); } }
        public static Unit LightDay { get { return new AstronomicalUnit("Light Day", "ld", 25902068371000.0); } }
        public static Unit LightHour { get { return new AstronomicalUnit("Light Hour", "lh", 1079252848800.0); } }
        public static Unit LightMinute { get { return new AstronomicalUnit("Light Minute", "lm", 17987547480.0); } }
        public static Unit LightSecond { get { return new AstronomicalUnit("Light Second", "ls", 299792458.0); } }

    }
}