
namespace Caterpillar.Volumes
{
    class SIUnit : Volume
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

namespace Caterpillar.Volumes.SI
{
    public struct Meters
    {
        public static readonly Meters Empty;

        public static Unit Yoctometer { get { return new SIUnit("Cubic Yoctometer", "ym3", 0.000000000000000000000000000000000000000000000000000000000000000000001); } }
        public static Unit Zeptometer { get { return new SIUnit("Cubic Zeptometer", "zm3", 0.000000000000000000000000000000000000000000000000000000000001); } }
        public static Unit Attometer { get { return new SIUnit("Cubic Attometer", "am3", 0.000000000000000000000000000000000000000000000000001); } }
        public static Unit Femtometer { get { return new SIUnit("Cubic Femtometer", "fm3", 0.000000000000000000000000000000000000000001); } }
        public static Unit Picometer { get { return new SIUnit("Cubic Picometer", "pm3", 0.000000000000000000000000000000001); } }
        public static Unit Nanometer { get { return new SIUnit("Cubic Nanometer", "nm3", 0.000000000000000000000001); } }
        public static Unit Micrometer { get { return new SIUnit("Cubic Micrometer", "um3", 0.000000000000001); } }
        public static Unit Millimeter { get { return new SIUnit("Cubic Millimeter", "mm3", 0.000001); } }
        public static Unit Centimeter { get { return new SIUnit("Cubic Centimeter", "cm3", 0.001); } }
        public static Unit Decimeter { get { return new SIUnit("Cubic Decimeter", "dm3", 1.0); } }
        public static Unit Meter { get { return new SIUnit("Cubic Meter", "m3", 1000.0); } }
        public static Unit Dekameter { get { return new SIUnit("Cubic Dekameter", "dam3", 1000000.0); } }
        public static Unit Hectometer { get { return new SIUnit("Cubic Hectometer", "hm3", 1000000000.0); } }
        public static Unit Kilometer { get { return new SIUnit("Cubic Kilometer", "km3", 1000000000000.0); } }
        public static Unit Megameter { get { return new SIUnit("Cubic Megameter", "Mm3", 1000000000000000000000.0); } }
        public static Unit Gigameter { get { return new SIUnit("Cubic Gigameter", "Gm3", 1000000000000000000000000000000.0); } }
        public static Unit Terameter { get { return new SIUnit("Cubic Terameter", "Tm3", 1000000000000000000000000000000000000000.0); } }
        public static Unit Petameter { get { return new SIUnit("Cubic Petameter", "Pm3", 1000000000000000000000000000000000000000000000000.0); } }
        public static Unit Exameter { get { return new SIUnit("Cubic Exameter", "Em3", 1000000000000000000000000000000000000000000000000000000000.0); } }
        public static Unit Zettameter { get { return new SIUnit("Cubic Zettameter", "Zm3", 1000000000000000000000000000000000000000000000000000000000000000000.0); } }
        public static Unit Yottameter { get { return new SIUnit("Cubic Yottameter", "Ym3", 1000000000000000000000000000000000000000000000000000000000000000000000000000.0); } }

    }
}
namespace Caterpillar.Volumes.SI
{
    public struct Liters
    {
        public static readonly Liters Empty;

        public static Unit Yoctoliter { get { return new SIUnit("Yoctoliter", "--", 0.000000000000000000000001); } }
        public static Unit Zeptoliter { get { return new SIUnit("Zeptoliter", "--", 0.000000000000000000001); } }
        public static Unit Attoliter { get { return new SIUnit("Attoliter", "--", 0.000000000000000001); } }
        public static Unit Femtoliter { get { return new SIUnit("Femtoliter", "--", 0.000000000000001); } }
        public static Unit Picoliter { get { return new SIUnit("Picoliter", "--", 0.000000000001); } }
        public static Unit Nanoliter { get { return new SIUnit("Nanoliter", "--", 0.000000001); } }
        public static Unit Microliter { get { return new SIUnit("Microliter", "--", 0.000001); } }
        public static Unit Milliliter { get { return new SIUnit("Milliliter", "ml", 0.001); } }
        public static Unit Centiliter { get { return new SIUnit("Centiliter", "cl", 0.01); } }
        public static Unit Deciliter { get { return new SIUnit("Deciliter", "dl", 0.1); } }
        public static Unit Liter { get { return new SIUnit("Liter", "l", 1.0); } }
        public static Unit Decaliter { get { return new SIUnit("Decaliter", "dal", 10.0); } }
        public static Unit Hectoliter { get { return new SIUnit("Hectoliter", "hl", 100.0); } }
        public static Unit Kiloliter { get { return new SIUnit("Kiloliter", "kl", 1000.0); } }
        public static Unit Megaliter { get { return new SIUnit("Megaliter", "--", 1000000.0); } }
        public static Unit Gigaliter { get { return new SIUnit("Gigaliter", "--", 1000000000.0); } }
        public static Unit Teraliter { get { return new SIUnit("Teraliter", "--", 1000000000000.0); } }
        public static Unit Petaliter { get { return new SIUnit("Petaliter", "--", 1000000000000000.0); } }
        public static Unit Exaliter { get { return new SIUnit("Exaliter", "--", 1000000000000000000.0); } }
        public static Unit Zettaliter { get { return new SIUnit("Zettaliter", "--", 1000000000000000000000.0); } }
        public static Unit Yottaliter { get { return new SIUnit("Yottaliter", "--", 1000000000000000000000000.0); } }

    }
}