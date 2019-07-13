
namespace Caterpillar.Areas
{
    class SIUnit : Area
    {
        public SIUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.SI;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct SI
    {
        public static readonly SI Empty;

        public static Unit Yoctometer { get { return new SIUnit("Square Yoctometer", "ym2", 0.000000000000000000000000000000000000000000000001); } }
        public static Unit Zeptometer { get { return new SIUnit("Square Zeptometer", "zm2", 0.000000000000000000000000000000000000000001); } }
        public static Unit Attometer { get { return new SIUnit("Square Attometer", "am2", 0.000000000000000000000000000000000001); } }
        public static Unit Femtometer { get { return new SIUnit("Square Femtometer", "fm2", 0.000000000000000000000000000001); } }
        public static Unit Picometer { get { return new SIUnit("Square Picometer", "pm2", 0.000000000000000000000001); } }
        public static Unit Nanometer { get { return new SIUnit("Square Nanometer", "nm2", 0.000000000000000001); } }
        public static Unit Micrometer { get { return new SIUnit("Square Micrometer", "um2", 0.000000000001); } }
        public static Unit Millimeter { get { return new SIUnit("Square Millimeter", "mm2", 0.000001); } }
        public static Unit Centimeter { get { return new SIUnit("Square Centimeter", "cm2", 0.0001); } }
        public static Unit Decimeter { get { return new SIUnit("Square Decimeter", "dm2", 0.01); } }
        public static Unit Meter { get { return new SIUnit("Square Meter", "m2", 1.0); } }
        public static Unit Dekameter { get { return new SIUnit("Square Dekameter", "dam2", 100.0); } }
        public static Unit Hectometer { get { return new SIUnit("Square Hectometer", "hm2", 10000.0); } }
        public static Unit Kilometer { get { return new SIUnit("Square Kilometer", "km2", 1000000.0); } }
        public static Unit Megameter { get { return new SIUnit("Square Megameter", "Mm2", 1000000000000.0); } }
        public static Unit Gigameter { get { return new SIUnit("Square Gigameter", "Gm2", 1000000000000000000.0); } }
        public static Unit Terameter { get { return new SIUnit("Square Terameter", "Tm2", 1000000000000000000000000.0); } }
        public static Unit Petameter { get { return new SIUnit("Square Petameter", "Pm2", 1000000000000000000000000000000.0); } }
        public static Unit Exameter { get { return new SIUnit("Square Exameter", "Em2", 100000000000000000000000000000000000.0); } }
        public static Unit Zettameter { get { return new SIUnit("Square Zettameter", "Zm2", 1000000000000000000000000000000000000000000.0); } }
        public static Unit Yottameter { get { return new SIUnit("Square Yottameter", "Ym2", 1000000000000000000000000000000000000000000000000.0); } }

    }
}