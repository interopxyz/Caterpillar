
namespace Caterpillar.Energies
{
    class SIUnit : Energy
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

namespace Caterpillar.Energies.SI
{
    public struct Joules
    {
        public static readonly Joules Empty;

        public static Unit Yoctojoule { get { return new SIUnit("Yoctojoule", "yJ", 0.000000000000000000000001); } }
        public static Unit Zeptojoule { get { return new SIUnit("Zeptojoule", "zJ", 0.000000000000000000001); } }
        public static Unit Attojoule { get { return new SIUnit("Attojoule", "aJ", 0.000000000000000001); } }
        public static Unit Femtojoule { get { return new SIUnit("Femtojoule", "fJ", 0.000000000000001); } }
        public static Unit Picojoule { get { return new SIUnit("Picojoule", "pJ", 0.000000000001); } }
        public static Unit Nanojoule { get { return new SIUnit("Nanojoule", "nJ", 0.000000001); } }
        public static Unit Microjoule { get { return new SIUnit("Microjoule", "uJ", 0.000001); } }
        public static Unit Millijoule { get { return new SIUnit("Millijoule", "mJ", 0.001); } }
        public static Unit Centijoule { get { return new SIUnit("Centijoule", "cJ", 0.01); } }
        public static Unit Decijoule { get { return new SIUnit("Decijoule", "dJ", 0.1); } }
        public static Unit Joule { get { return new SIUnit("Joule", "J", 1.0); } }
        public static Unit Decajoule { get { return new SIUnit("Decajoule", "daJ", 10.0); } }
        public static Unit Hectojoule { get { return new SIUnit("Hectojoule", "hJ", 100.0); } }
        public static Unit Kilojoule { get { return new SIUnit("Kilojoule", "kJ", 1000.0); } }
        public static Unit Megajoule { get { return new SIUnit("Megajoule", "MJ", 1000000.0); } }
        public static Unit Gigajoule { get { return new SIUnit("Gigajoule", "GJ", 1000000000.0); } }
        public static Unit Terajoule { get { return new SIUnit("Terajoule", "TJ", 1000000000000.0); } }
        public static Unit Petajoule { get { return new SIUnit("Petajoule", "PJ", 1000000000000000.0); } }
        public static Unit Exajoule { get { return new SIUnit("Exajoule", "EJ", 1000000000000000000.0); } }
        public static Unit Zettajoule { get { return new SIUnit("Zettajoule", "ZJ", 1000000000000000000000.0); } }
        public static Unit Yottajoule { get { return new SIUnit("Yottajoule", "YJ", 1000000000000000000000000.0); } }

    }
}

namespace Caterpillar.Energies.SI
{
    public struct WattHours
    {
        public static readonly WattHours Empty;

        public static Unit YoctowattHour { get { return new SIUnit("Yoctowatt Hour", "", 0.0000000000000000000036); } }
        public static Unit ZeptowattHour { get { return new SIUnit("Zeptowatt Hour", "", 0.0000000000000000036); } }
        public static Unit AttowattHour { get { return new SIUnit("Attowatt Hour", "", 0.0000000000000036); } }
        public static Unit FemtowattHour { get { return new SIUnit("Femtowatt Hour", "", 0.0000000000036); } }
        public static Unit PicowattHour { get { return new SIUnit("Picowatt Hour", "", 0.0000000036); } }
        public static Unit NanowattHour { get { return new SIUnit("Nanowatt Hour", "", 0.0000036); } }
        public static Unit MicrowattHour { get { return new SIUnit("Microwatt Hour", "", 0.0036); } }
        public static Unit MilliwattHour { get { return new SIUnit("Milliwatt Hour", "", 3.6); } }
        public static Unit CentiwattHour { get { return new SIUnit("Centiwatt Hour", "", 36.0); } }
        public static Unit DeciwattHour { get { return new SIUnit("Deciwatt Hour", "", 360.0); } }
        public static Unit WattHour { get { return new SIUnit("Watt Hour", "", 3600.0); } }
        public static Unit DecawattHour { get { return new SIUnit("Decawatt Hour", "", 36000.0); } }
        public static Unit HectowattHour { get { return new SIUnit("Hectowatt Hour", "", 360000.0); } }
        public static Unit KilowattHour { get { return new SIUnit("Kilowatt Hour", "", 3600000.0); } }
        public static Unit MegawattHour { get { return new SIUnit("Megawatt Hour", "", 3600000000.0); } }
        public static Unit GigawattHour { get { return new SIUnit("Gigawatt Hour", "", 3600000000000.0); } }
        public static Unit TerawattHour { get { return new SIUnit("Terawatt Hour", "", 3600000000000000.0); } }
        public static Unit PetawattHour { get { return new SIUnit("Petawatt Hour", "", 3600000000000000000.0); } }
        public static Unit ExawattHour { get { return new SIUnit("Exawatt Hour", "", 3600000000000000000000.0); } }
        public static Unit ZettawattHour { get { return new SIUnit("Zettawatt Hour", "", 3600000000000000000000000.0); } }
        public static Unit YottawattHour { get { return new SIUnit("Yottawatt Hour", "", 3600000000000000000000000000.0); } }

    }
}