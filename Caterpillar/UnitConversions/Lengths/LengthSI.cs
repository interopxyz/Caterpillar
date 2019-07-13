
namespace Caterpillar.Lengths
{
    class SIUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct SI
    {
        public static readonly SI Empty;

        public static Unit Yoctometer { get { return new SIUnit("Yoctometer", "ym", 0.000000000000000000000001); } }
        public static Unit Zeptometer { get { return new SIUnit("Zeptometer", "zm", 0.000000000000000000001); } }
        public static Unit Attometer { get { return new SIUnit("Attometer", "am", 0.000000000000000001); } }
        public static Unit Femtometer { get { return new SIUnit("Femtometer", "fm", 0.000000000000001); } }
        public static Unit Picometer { get { return new SIUnit("Picometer", "pm", 0.000000000001); } }
        public static Unit Nanometer { get { return new SIUnit("Nanometer", "nm", 0.000000001); } }
        public static Unit Micrometer { get { return new SIUnit("Micrometer", "um", 0.000001); } }
        public static Unit Millimeter { get { return new SIUnit("Millimeter", "mm", 0.001); } }
        public static Unit Centimeter { get { return new SIUnit("Centimeter", "cm", 0.01); } }
        public static Unit Decimeter { get { return new SIUnit("Decimeter", "dm", 0.1); } }
        public static Unit Meter { get { return new SIUnit("Meter", "m", 1.0); } }
        public static Unit Dekameter { get { return new SIUnit("Dekameter", "dam", 10.0); } }
        public static Unit Hectometer { get { return new SIUnit("Hectometer", "hm", 100.0); } }
        public static Unit Kilometer { get { return new SIUnit("Kilometer", "km", 1000.0); } }
        public static Unit Megameter { get { return new SIUnit("Megameter", "Mm", 1000000.0); } }
        public static Unit Gigameter { get { return new SIUnit("Gigameter", "Gm", 1000000000.0); } }
        public static Unit Terameter { get { return new SIUnit("Terameter", "Tm", 1000000000000.0); } }
        public static Unit Petameter { get { return new SIUnit("Petameter", "Pm", 1000000000000000.0); } }
        public static Unit Exameter { get { return new SIUnit("Exameter", "Em", 1000000000000000000.0); } }
        public static Unit Zettameter { get { return new SIUnit("Zettameter", "Zm", 1000000000000000000000.0); } }
        public static Unit Yottameter { get { return new SIUnit("Yottameter", "Ym", 1000000000000000000000000.0); } }

    }
}